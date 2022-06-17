using System;
using System.Drawing;

namespace Project_X.MediaCenter
{
    [Serializable]
    public class Movie
    {
        public string Title { get; set; }
        public string Path { get; set; }
        public Image Poster { get; set; }

        public Movie(string title, string path, Image poster)
        {
            Title = title;
            Path = path;
            Poster = poster;
        }
    }
}
