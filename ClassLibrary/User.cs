﻿namespace ClassLibrary
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime LastLogin { get; set; }

        public void printDisplayName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
       
    }
}