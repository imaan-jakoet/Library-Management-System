using System;
using System.Collections.Generic;
using LibraryManagementSystem;

namespace LibraryManagementSystem.Models
{
    public class User
    {
        private string userId;
        private string name;
        private string phone;
        private string email;
        private int userBookCounter;

        public User(string userId, string name, string phone, string email)
        {
            this.userId = userId;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.userBookCounter = 0;           
        }   
    }
}