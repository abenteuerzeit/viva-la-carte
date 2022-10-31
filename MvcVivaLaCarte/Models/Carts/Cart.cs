using System;
using System.Net.Http.Headers;
using MvcVivaLaCarte.Models.Products;
using Microsoft.AspNetCore.Identity;

namespace MvcVivaLaCarte.Models.Carts
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Categories Category { get; set; }
        public List<Product>? Products { get; set; }
        public int OrderId { get; set; }

        public Cart()
        {

        }

        public Cart(int id, int userId, Categories category, List<Product> products, int orderId)
        {
            this.Id = id;
            this.UserId = userId;
            this.Category = category;
            this.Products = products;
            this.OrderId = orderId;
        }

    }



    public enum Categories
    {
        Vegan,
        Vegetarian,
        GlutenFree
    }
}

