using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcVivaLaCarte.Models;
using MvcVivaLaCarte.Models.Users;
using NuGet.Protocol;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace MvcVivaLaCarte.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserDbContext _context;

        public RegisterController(UserDbContext context)
        {
            _context = context;
        }
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here


                string json = collection.ToJson();
                /// collection.ToJSON() returns:
                /// [
                /// {"Key":"user[full_name]","Value":["Joe Biden"]},
                /// {"Key":"user[username]","Value":["nomalarky"]},
                /// {"Key":"user[birthday]","Value":["1942-11-20"]},
                /// {"Key":"user[email]","Value":["presjoe12@whitehouse.gov"]},
                /// {"Key":"user[password]","Value":["$p@ma&3665"]},
                /// {"Key":"user[password_confirmation]","Value":["$p@ma&3665"]},
                /// {"Key":"gender","Value":["male"]},
                /// {"Key":"user[address_streetNr]","Value":["1600 Pennsylvania Avenue NW"]},
                /// {"Key":"user[address_postalCode]","Value":["20500"]},
                /// {"Key":"user[address_city]","Value":["Washington D.C."]},
                /// {"Key":"user[phone_nr]","Value":["2024561111"]},
                /// {"Key":"country","Value":["Poland"]},
                /// {"Key":"__RequestVerificationToken","Value":["CfDJ8CPzw3tY-VhIqi4mtNOq4ZGB2ZFiwNvpk5IHjUjOkRBKf-_TIVzoIbgF3ceSC7HDLKuNQasvcoAsGtANDXmxDnj0I5dANw3BFuO0ccI1YyhpHO1lS-8icb_8iKSboYATDnv173POneOYvE323RNPCHk"]}
                /// ]
                /// 

                bool isFullName = collection.TryGetValue("user[full_name]", out var fullName);
                bool isUsername = collection.TryGetValue("user[username]", out var username);
                bool isDOB = collection.TryGetValue("user[birthday]", out var DOB);
                var dateArr = DOB.ToString().Split('-');
                int yy = int.Parse(dateArr[0]);
                int mm = int.Parse(dateArr[1]);
                int dd = int.Parse(dateArr[2]);
                bool isEmail = collection.TryGetValue("user[email]", out var email);
                bool isPassword = collection.TryGetValue("user[password]", out var password);
                bool isGender = collection.TryGetValue("gender", out var gender);
                bool isPhone = collection.TryGetValue("user[phone_nr]", out var phone);
                bool isStreetData = collection.TryGetValue("user[address_streetNr]", out var streetData);
                bool isPostCode = collection.TryGetValue("user[address_postalCode]", out var postCode);
                bool isCity = collection.TryGetValue("user[address_city]", out var city);
                bool isCountry = collection.TryGetValue("country", out var country);

                User user = new();
                string[] name = fullName.ToString().Split(" ");
                user.FirstName = name[0].Trim();
                user.LastName = name[1].Trim();
                user.Gender = (Gender)Enum.Parse(typeof(Gender), gender.ToString());
                user.DOB = new DateTime(yy, mm, dd).Date;


                user.UserName = username;
                user.PasswordHash = password;
                user.Email = email;
                user.PhoneNumber = phone;
                


                string fullInputLine = streetData.ToString();
                string[] streetArr = streetData.ToString().Split(' ');
                string streetNr = streetArr[0].Trim();
                string streetName = streetArr[1].Trim();
                //string apartNr = "666"; //streetArr[].Trim();

                // TODO Make Registration form coherent with model
                Address addressDetails = new()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PhoneNumber = phone,
                    BuildingNr = streetNr,
                    Street = fullInputLine, //streetName,
                    //ApartamentNr = apartNr,
                    //FullStreetName = fullInputLine,
                    PostalCode = postCode,
                    City = city,
                    Country = country,
                };
                user.BillingAddress = user.DeliveryAddress = addressDetails;

                _context.Users.Add(user);
                _context.SaveChanges();

                return View(user);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}