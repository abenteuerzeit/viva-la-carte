using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcVivaLaCarte.Models.Carts;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Text;

namespace MvcVivaLaCarte.Models.Users
{
    // TODO Move to Data Folder
    public enum Gender
    {
        male,
        female,
        undisclosed
    }
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DOB { get; set; }
        public Gender Gender { get; set; }
        
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


        public User(string firstName, string lastName, string username, string dob, string email, string password, Gender gender = Gender.undisclosed)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            UserName = username;

            string[] dobInput = dob.Split("-");
            int yyyy = Convert.ToInt32(dobInput[0]);
            int mm = Convert.ToInt32(dobInput[1]);
            int dd = Convert.ToInt32(dobInput[2]);
            DOB = new DateTime(yyyy, mm, dd);

            Email = email;
            PasswordHash = password;
            Created = DateTime.Now;
        }

        protected void CreateDeliveryAddress(Address address) => DeliveryAddress = address;
        public void CreateBillingAddress(Address address) => BillingAddress = address;

        public override string ToString()
        {
            return $"Id:{Id}\nLogin: {UserName}: {PasswordHash}\nDetails:{FirstName} {LastName}\nDOB: {DOB}\nGender:{Gender}\nAddresses:\n\tDelivery: {DeliveryAddress}\n\tBilling: {BillingAddress} ";
        }


    }
}
