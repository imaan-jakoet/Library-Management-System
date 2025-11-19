using System;
using System.Collections.Generic;
using LibraryManagementSystem;

namespace LibraryManagementSystem.Business.Models
{
    public class Library
    {
        private string name;
        private string address;
        private string libraryId;
        private Hash<string, Book> books = new Hash<string, Book>();

        public Library(string libraryId, string name, string address)
        {
            this.libraryId = libraryId;
            this.name = name;
            this.address = address;
        }

        public void addBook(Book book)
        {
            books.add(bookId, book);
        }

        public void removeBook(Book book)
        {
            books.remove(bookId, book);
        }

        public Book searchBook(string bookName)
        {
            if (books.contains(bookName))
            {
                return books(bookName);
            }
            else
            {
                console.WriteLine("This library does not have this book");
            }
        }

        public void borrowBook(Book book)
        {
            book.isAvailable = false;
            // User's book total increases by 1
            // Book gets added to user's account
        }
    }
}