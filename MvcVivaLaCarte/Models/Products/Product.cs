using System;
namespace MvcVivaLaCarte.Models.Products
{
    public class Product
    {
        public int Id { get; set; }

        public Product()
        {

        }

        public Product(int id)
        {
            this.Id = id;
        }
    }
}

