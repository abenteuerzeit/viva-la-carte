using System;
using System.ComponentModel.DataAnnotations;

namespace MvcVivaLaCarte.Models.Products
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public Product()
        {

        }

        public Product(int id)
        {
            Id = id;
        }
    }
}

