using Microsoft.AspNetCore.Identity;
using MvcVivaLaCarte.Models.Carts;
using System;
using System.Security.Policy;

namespace MvcVivaLaCarte.Models.Users
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public string? Password { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Cart> Carts { get; set; }



        public User() { }

        public User(int id, string? firstName, string? lastName, string? email, string? password, DateTime createdDate)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            CreatedDate = createdDate;
        }
    }
}
