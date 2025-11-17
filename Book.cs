using System.Collections.Generic;
using System;

namespace LibraryManagementSystem.Models {
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private int datePublished;
        private string genre;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public List<Genre> Genres { get; set; }
    }
}