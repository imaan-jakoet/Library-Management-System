using System.Collections.Generic;
using System;

namespace LibraryManagementSystem.Models {
    public class Book
    {
        //Attributes
        private int id; //Create unique isbn for each book 
        private string title;
        private string author;
        private int datePublished;
        private string genre;

        //Getters and Setters
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public List<Genre> Genres { get; set; }

        // Constructor
        public Book(string title, string author, int datePublished, string genre)
        {
            this.title = title;
            this.author = author;
            this.datePublished = datePublished;
            this.genre = genre;
        }
    }
}