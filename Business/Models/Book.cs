using System.Collections.Generic;
using System;
using LibraryManagementSystem; 

namespace LibraryManagementSystem.Models {
    public class Book
    {
        //Getters and Setters
        public int bookId {get; set;}
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