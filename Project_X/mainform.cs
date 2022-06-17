using LocalServer;
using Project_X.Additional;
using Project_X.MediaCenter;
using Project_X.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Project_X
{
    public partial class mainform : Form
    {
        Status serv_status = new Status();
        WebServer local_web_server;
        public IPAddress ipAddress;
        IniFile manager = new IniFile(AppContext.BaseDirectory + "settings.ini");
        byte[] address { get; set; }
        public int port;
        public int max_connection;
        public string content_path;
        public bool run = false;
        public bool autostart = false;
        public int current_film_index;
        public string current_film_poster_location;

        public List<Movie> movies;
        public mainform()
        {

            InitializeComponent();
            #region Параметры сервера
            //
            local_web_server = new WebServer();
            address = new byte[4];
            address[0] = (byte)ip1.Value;
            address[1] = (byte)ip2.Value;
            address[2] = (byte)ip3.Value;
            address[3] = (byte)ip4.Value;
            ipAddress = new IPAddress(address);
            port = (int)server_port.Value;
            max_connection = 10;
            content_path = "";
            //
            #endregion

            #region MediaCenter
            movies = new List<Movie>();


            #endregion
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            content_path = manager.Read("ContentPath", "Server");
            server_path.Text = content_path;
            Text = $"HomeServer [{serv_status}]";
            autostart = bool.Parse(manager.Read("Autostart", "Server"));
            server_exec_param.Checked = autostart ? true : false;

            if (autostart)
            {
                StartServer();
            }
        }

        private void mainform_table_TabIndexChanged(object sender, EventArgs e)
        {
            if (mainform_table.TabIndex == 1)
                this.Width = 200;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void StartServer()
        {
            if (content_path != string.Empty)
            {
                if (run)
                {
                    local_web_server.stop();
                    start_btn.Text = "Start";
                    server_status_tip.Text = "Сервер остановлен";
                    ip1.Enabled = true;
                    ip2.Enabled = true;
                    ip3.Enabled = true;
                    ip4.Enabled = true;
                    server_port.Enabled = true;
                    server_path.Enabled = true;
                    select_btn.Enabled = true;
                    run = false;
                    serv_status = Status.Idle;
                    Text = $"HomeServer [{serv_status}]";
                }
                else
                {
                    local_web_server.start(ipAddress, port, max_connection, content_path);
                    start_btn.Text = "Stop";
                    server_status_tip.Text = $"Сервер запущен по адресу - {ipAddress}";
                    ip1.Enabled = false;
                    ip2.Enabled = false;
                    ip3.Enabled = false;
                    ip4.Enabled = false;
                    server_port.Enabled = false;
                    server_path.Enabled = false;
                    select_btn.Enabled = false;
                    run = true;
                    serv_status = Status.Run;
                    Text = $"HomeServer [{serv_status}]";
                }
            }
            else
            {
                //ошибка если не выбран content_path
                MessageBox.Show("ERROR");
            }
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Выбор папки для размещения локального веб сервера";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    content_path = fbd.SelectedPath;
                    //тут будет сохранение пути в ини файл
                    manager.Write("ContentPath", content_path, "Server");
                    server_path.Text = content_path;
                }
            }
        }

        public void Selected_ip_address(object sender, EventArgs e)
        {
            manager.Write("IP", $"{ipAddress}", "Server");
            manager.Write("Port", $"{port}", "Server");
        }

        private void open_server_path_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (run)
            {
                string url = ipAddress.ToString();
                Process.Start($"http://{url}", "");
            }
            else
            {
                if (content_path != string.Empty)
                {
                    string path = content_path;
                    Process.Start(path);
                }
                else
                {
                    //ошибка если не выбран content_path
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void server_exec_param_CheckedChanged(object sender, EventArgs e)
        {
            manager.Write($"Autostart", $"{server_exec_param.Checked}", "Server");
        }

        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            local_web_server.stop();
            Application.Exit();
        }

        private void add_films_Click(object sender, EventArgs e)
        {
            movies.Clear();
            film_list.Items.Clear();
            using (OpenFileDialog opfile = new OpenFileDialog())
            {
                opfile.Title = "Open media files and add to list";
                opfile.Multiselect = true;
                opfile.Filter = "All acepted files *.mkv, *.mp4, *.avi|*.mkv;*.mp4;*.avi|Matroska Video File *.mkv | *.mkv|Файлы MPEG-4 *.mp4 | *.mp4|Video for Windows *.avi | *.avi";
                if (opfile.ShowDialog() == DialogResult.OK)
                {
                    var files = opfile.FileNames;
                    foreach (var item in files)
                    {
                        movies.Add(new Movie(Path.GetFileNameWithoutExtension(item), Path.GetFullPath(item), null));
                    }

                    foreach (var item in movies)
                    {
                        film_list.Items.Add(item.Title);
                    }
                }
            }
        }

        private void film_list_Click(object sender, EventArgs e)
        {
            if (film_list.SelectedIndex >= 0)
            {
                var index = film_list.Items.IndexOf(film_list.SelectedItem);
                current_film_index = index;
                film_caption.Text = $"{movies[index].Title}";
                film_poster.Image = movies[index].Poster;
                current_film_poster_location = $"{movies[index].Poster}";
                gb1.Visible = false;
                //
                n_film_title.Text = movies[index].Title;
                film_location.Text = movies[index].Path;
            }
        }

        private void film_list_DoubleClick(object sender, EventArgs e)
        {
            if(film_list.SelectedIndex >= 0)
            {
                gb1.Visible = true;
            }
        }

        private void film_poster_Click(object sender, EventArgs e)
        {
            if (current_film_poster_location != null & current_film_poster_location != string.Empty)
            {
                //  Process.Start(current_film_poster_location, "");
                open_poster(current_film_index);
            }
        }

        private void open_poster(int index)
        {
            Form showposter = new Form();
            var img = movies[index].Poster;
            var w = img.Width;
            var h = img.Height;
            showposter.StartPosition = FormStartPosition.CenterScreen;
            showposter.FormBorderStyle = FormBorderStyle.FixedSingle;
            showposter.MinimizeBox = false;
            showposter.MaximizeBox = false;
            showposter.Size = new Size(703, 1000);
            showposter.Text = movies[current_film_index].Title;
            PictureBox pb = new PictureBox();
            showposter.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Image = movies[index].Poster;
            pb.Cursor = Cursors.Hand;
            pb.Click += delegate { showposter.Close(); };
            showposter.Show();
        }

        private void menu_poster_open_Click(object sender, EventArgs e)
        {
            if (current_film_poster_location != null & current_film_poster_location != string.Empty)
            {
                // Process.Start(current_film_poster_location, "");
                open_poster(current_film_index);
            }
        }

        private void menu_poster_load_Click(object sender, EventArgs e)
        {
            if (film_list.SelectedIndex >= 0)
            {
                using (OpenFileDialog opfile = new OpenFileDialog())
                {
                    opfile.Title = "Open image..";
                    opfile.Filter = "JPEG Image *.jpg|*.jpg";
                    if (opfile.ShowDialog() == DialogResult.OK)
                    {
                        var img = new Bitmap(opfile.FileName);
                        movies[current_film_index].Poster = img;
                    }
                }
            }
        }

        private void add_film_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog opfile = new OpenFileDialog())
            {
                opfile.Title = "Open media files and add to list";
                opfile.Filter = "All acepted files *.mkv, *.mp4, *.avi|*.mkv;*.mp4;*.avi|Matroska Video File *.mkv | *.mkv|Файлы MPEG-4 *.mp4 | *.mp4|Video for Windows *.avi | *.avi";
                if (opfile.ShowDialog() == DialogResult.OK)
                {
                    var file = opfile.FileName;
                    movies.Add(new Movie(Path.GetFileNameWithoutExtension(file), Path.GetFullPath(file), null));
                    film_list.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            library_list.Items.Clear();
            foreach (var item in movies)
            {
                library_list.Items.Add(item.Title);
            }
        }

        private void add_film_MouseHover(object sender, EventArgs e)
        {
            status.Text = "Добавить фильм";
        }

        private void add_films_MouseHover(object sender, EventArgs e)
        {
            status.Text = "Добавить несколько фильмов";
        }

        private void save_list_MouseHover(object sender, EventArgs e)
        {
            status.Text = "Сохранить список фильмов";
        }

        private void load_list_MouseHover(object sender, EventArgs e)
        {
            status.Text = "Загрузить список фильмов";
        }

        private void Element_MouseLeave(object sender, EventArgs e)
        {
            status.Text = "";
        }

        private void mainform_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainform_table.SelectedIndex == 0)
            {
                library_list.Items.Clear();
                foreach (var item in movies)
                {
                    library_list.Items.Add(item.Title);
                }
            }
        }

        public void Serialize(string path, List<Movie> data)
        {
            IFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write, 65000))
            {
                formatter.Serialize(fs, data);
            }
        }
        public bool Deserialize(string path, out List<Movie> data)
        {
            data = null;
            if (File.Exists(path))
            {
                IFormatter formatter = new BinaryFormatter();
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    data = (List<Movie>)formatter.Deserialize(stream);
                }
            }
            return data != null;
        }

        private void save_list_Click(object sender, EventArgs e)
        {
            if (movies.Count > 0)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "MediaCenter file *.bin|*.bin";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Serialize(sfd.FileName, movies);
                    }
                }
            }
        }

        private void load_list_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "MediaCenter file *.bin|*.bin";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Deserialize(ofd.FileName, out movies);
                }

                foreach (var item in movies)
                {
                    film_list.Items.Add(item.Title);
                }
            }
        }

        private void clear_btn_MouseHover(object sender, EventArgs e)
        {
            status.Text = "Очистить список фильмов";
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (movies.Count > 0)
            {
                movies.Clear();
                film_list.Items.Clear();
                film_poster.Image = null;
                gb1.Visible = false;
                film_caption.Text = "...";
                current_film_index = 0;
                current_film_poster_location = null;
            }
        }

        private void open_film_data_location_Click(object sender, EventArgs e)
        {
            var path = Path.GetDirectoryName(movies[current_film_index].Path);
            Process.Start(path, "");
        }

        private void ok_film_title_Click(object sender, EventArgs e)
        {
            movies[current_film_index].Title = n_film_title.Text;
            film_list.Items.Clear();
            foreach (var item in movies)
            {
                film_list.Items.Add(item.Title);
            }
        }

        private void acept_btn_Click(object sender, EventArgs e)
        {
            gb1.Visible = false;
        }

    }
}
