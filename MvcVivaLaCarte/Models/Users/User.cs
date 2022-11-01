using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcVivaLaCarte.Models.Carts;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Text;

namespace MvcVivaLaCarte.Models.Users
{
    public enum Gender
    {
        male,
        female,
        undisclosed
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DOB { get; set; }
        public Gender Gender { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public Address? DeliveryAddress { get; set; }

        public Address? BillingAddress { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();


        public User()
        {
            //FirstName = "";
            //LastName = "";
            //Username = "";
            //Email = "";
            //Password = "";
            //Created = DateTime.Now;
        }

        public User() { }

        public User(string firstName, string lastName, string username, string dob, string email, string password, Gender gender = Gender.undisclosed)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Username = username;

            string[] dobInput = dob.Split("-");
            int yyyy = Convert.ToInt32(dobInput[0]);
            int mm = Convert.ToInt32(dobInput[1]);
            int dd = Convert.ToInt32(dobInput[2]);
            DOB = new DateTime(yyyy, mm, dd);

            Email = email;
            Password = password;
            Created = DateTime.Now;
        }

        protected void CreateDeliveryAddress(Address address) => DeliveryAddress = address;
        public void CreateBillingAddress(Address address) => BillingAddress = address;

        public override string ToString()
        {
            return $"Id:{Id}\nLogin: {Username}: {Password}\nDetails:{FirstName} {LastName}\nDOB: {DOB}\nGender:{Gender}\nAddresses:\n\tDelivery: {DeliveryAddress}\n\tBilling: {BillingAddress} ";
        }


    }
}
