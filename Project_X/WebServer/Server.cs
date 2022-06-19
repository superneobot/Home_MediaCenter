﻿using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using File = System.IO.File;

namespace LocalServer
{
    public class WebServer
    {
        public bool running = false; //Запущено ли?

        private int timeout = 8; // Лиммт времени на приём данных.
        private Encoding charEncoder = Encoding.UTF8; // Кодировка
        private Socket serverSocket; // Наш сокет
        private string contentPath; // Корневая папка для контента
        public string requestCommand = "";
        public bool ready = false;
        public string file;

        // Поодерживаемый контент нашим сервером
        // Вы можете добавить больше
        private Dictionary<string, string> extensions = new Dictionary<string, string>()
{ 
    //{ "extension", "content type" }
    { "htm", "text/html" },
    { "html", "text/html" },
    { "xml", "text/xml" },
    { "txt", "text/plain" },
    { "css", "text/css" },
    { "png", "image/png" },
    { "gif", "image/gif" },
    { "jpg", "image/jpg" },
    { "jpeg", "image/jpeg" },
    { "zip", "application/zip" },
    { "mkv", "video/mp4" },
    { "mp4", "video/mp4" },
    { "avi", "video/mp4" },
    { "?=", "text/plain" },
    { "js", "text/javascript" },
    { "json", "text/json" }
};

        public bool start(IPAddress ipAddress, int port, int maxNOfCon, string contentPath)
        {
            if (running) return false; // Если уже запущено, то выходим

            try
            {
                // tcp/ip сокет (ipv4)
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(ipAddress, port));
                serverSocket.Listen(maxNOfCon);
                serverSocket.ReceiveTimeout = timeout;
                serverSocket.SendTimeout = timeout;
                //serverSocket.EnableBroadcast = true;
                //serverSocket.MulticastLoopback = true;
                serverSocket.SendBufferSize = 65000;
                running = true;
                this.contentPath = contentPath;
            }
            catch { return false; }

            // Наш поток ждет новые подключения и создает новые потоки.
            Thread requestListenerT = new Thread(() =>
            {
                while (running)
                {
                    Socket clientSocket;
                    try
                    {
                        clientSocket = serverSocket.Accept();
                        // Создаем новый поток для нового клиента и продолжаем слушать сокет.
                        Thread requestHandler = new Thread(() =>
                        {
                            clientSocket.ReceiveTimeout = timeout;
                            clientSocket.SendTimeout = timeout;
                            try { handleTheRequest(clientSocket); }
                            catch
                            {
                                try { clientSocket.Close(); } catch { }
                            }
                        });
                        requestHandler.Start();
                    }
                    catch { }
                }
            });
            requestListenerT.Start();

            return true;
        }

        public void stop()
        {
            if (running)
            {
                running = false;
                try { serverSocket.Close(); }
                catch { }
                serverSocket = null;
            }
        }

        public string SendKino()
        {
            return file;
        }

        private void handleTheRequest(Socket clientSocket)
        {
            byte[] buffer = new byte[1024]; // 10 kb, just in case
            int receivedBCount = clientSocket.Receive(buffer); // Получаем запрос
            string strReceived = charEncoder.GetString(buffer, 0, receivedBCount);

            //var command = clientSocket.Receive(buffer, 0, SocketFlags.OutOfBand);

            // Парсим запрос
            string httpMethod = strReceived.Substring(0, strReceived.IndexOf(" "));

            int start = strReceived.IndexOf(httpMethod) + httpMethod.Length + 1;
            int length = strReceived.LastIndexOf("HTTP") - start - 1;
            string requestedUrl = strReceived.Substring(start, length);

            if (requestedUrl.Contains("watch"))
            {
                requestCommand = requestedUrl;
                ready = true;
            }

            //requestCommand = strReceived;

            string requestedFile;
            if (httpMethod.Equals("GET") || httpMethod.Equals("POST"))
                requestedFile = requestedUrl.Split('?')[0];

            else // Вы можете реализовать другие методы
            {
                notImplemented(clientSocket);
                return;
            }

            requestedFile = requestedFile.Replace("/", "\\").Replace("\\..", ""); // Not to go back
            start = requestedFile.LastIndexOf('.') + 1;

            if (start > 0)
            {

                length = requestedFile.Length - start;
                string extension = requestedFile.Substring(start, length);
                //string command = requestedFile;
                if (extensions.ContainsKey(extension)) // Мы поддерживаем это расширение?
                    if (File.Exists(contentPath + requestedFile)) // Если да
                                                                  // ТО отсылаем запрашиваемы контент:
                        sendOkResponse(clientSocket, File.ReadAllBytes(contentPath + requestedFile), extensions[extension]);

                    else
                        notFound(clientSocket); // Мы не поддерживаем данный контент.

            }
            else
            {
                // Если файл не указан, пробуем послать index.html
                // Вы можете добавить больше(например "default.html")
                if (requestedFile.Substring(length - 1, 1) != "\\")
                    requestedFile += "\\";
                if (File.Exists(contentPath + requestedFile + "index.htm"))
                    sendOkResponse(clientSocket, File.ReadAllBytes(contentPath + requestedFile + "\\index.htm"), "text/html");
                else if (File.Exists(contentPath + requestedFile + "index.html"))
                    sendOkResponse(clientSocket, File.ReadAllBytes(contentPath + requestedFile + "\\index.html"), "text/html");
                else
                    notFound(clientSocket);
            }
        }

        private void notImplemented(Socket clientSocket)
        {

            sendResponse(clientSocket, "<html><head><meta http-equiv =\"Content-Type\" content=\"text/html;charset=utf-8\"></head><body><h2>HOMELAN Web Server</ h2 >< div > 501 - Method Not Implemented </ div ></ body ></ html > ",
                "501 Not Implemented", "text/html");

        }

        private void notFound(Socket clientSocket)
        {

            sendResponse(clientSocket, "<html><head><meta http - equiv =\"Content-Type\" content=\"text/html;charset = utf - 8\"></head><body><h2>HOMELAN Web Server </ h2 >< div > 404 - Not Found </ div ></ body ></ html > ",
                "404 Not Found", "text/html");
        }

        private void sendOkResponse(Socket clientSocket, byte[] bContent, string contentType)
        {

            sendResponse(clientSocket, bContent, "200 OK", contentType);
            ready = false;
            //requestCommand = null;
        }

        // For strings
        private void sendResponse(Socket clientSocket, string strContent, string responseCode,
                                  string contentType)
        {
            byte[] bContent = charEncoder.GetBytes(strContent);
            sendResponse(clientSocket, bContent, responseCode, contentType);
            //ready = false;
            //requestCommand = null;
        }

        // For byte arrays
        private void sendResponse(Socket clientSocket, byte[] bContent, string responseCode,
                                  string contentType)
        {
            try
            {
                byte[] bHeader = charEncoder.GetBytes(
                                    "HTTP/1.1 " + responseCode + "\r\n"
                                  + "Server: HOMELAN Web Server\r\n"
                                  + "Content-Length: " + bContent.Length.ToString() + "\r\n"
                                  + "Connection: close\r\n"
                                  + "Content-Type: " + contentType + "\r\n\r\n");
                clientSocket.Send(bHeader);
                clientSocket.Send(bContent);
                clientSocket.EnableBroadcast = true;
                clientSocket.Close();
                //ready = false;
                //requestCommand = null;
            }
            catch { }
        }
    }
}
