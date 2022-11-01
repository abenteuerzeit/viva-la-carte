using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Routing;
using System.IO;
using System.Numerics;

namespace MvcVivaLaCarte.Models.Users
{
    public class Address
    {
        public int Id { get; set; }
        //public string? FullStreetName { get; set; }
        public string? Street { get; set; }
        public string? BuildingNr { get; set; }
        public string? ApartamentNr { get; set; }
        public string? Country { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public Address() { }
        public Address(string streetName,
                       string buildingNr,
                       string apartamentNr,
                       string country,
                       string firstName,
                       string lastName,
                       string companyName,
                       string city,
                       string district,
                       string region,
                       string postalCode,
                       string email,
                       string phoneNumber)
        {
            Street = streetName;
            BuildingNr = buildingNr;
            ApartamentNr = apartamentNr;
            Country = country;
            FirstName = firstName;
            LastName = lastName;
            CompanyName = companyName;
            City = city;
            District = district;
            Region = region;
            PostalCode = postalCode;
            Email = email;
            PhoneNumber = phoneNumber;

        }

        public override string ToString()
        {
            return $"{Street} {PostalCode} {City} {Country}";
        }
    }

    public static class StreetAbbrev
    {
        public enum Cardinals
        {
            N, E, S, W,
            NE, SE, SW, NW
        }
        public enum US
        {
            AVE, BLVD, CIR, CT, EXPY, FWY, LN, PKY, RD, SQ, ST, TPKE,
        }

        public enum PL
        {
            ul, //ulica
            os, // osiedle
            pl, // plac
            al, // aleja lub aleje


            /* 
            PL
                [First name] [Family name]
                ul. [Street name] [House number] m. [Apartment number]
                [Postal code] [City/town name]
                POLSKA

            USA
                Name or attention line:
                Company:
                Delivery address:
                City, state, ZIP Code:

                JANE L MILLER
                MILLER ASSOCIATES
                1960 W CHELSEA AVE STE 2006R
                ALLENTOWN PA 18104

             */

        }
    }
}