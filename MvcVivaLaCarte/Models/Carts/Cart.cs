using System;
using System.Net.Http.Headers;
using MvcVivaLaCarte.Models.Products;
using Microsoft.AspNetCore.Identity;
using MvcVivaLaCarte.Models.Utils;

namespace MvcVivaLaCarte.Models.Carts
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Category Category { get; set; }
        public List<Product>? Products { get; set; }
        public int OrderId { get; set; }

        public Cart()
        {

        }

        public Cart(int id, int userId, Category category, List<Product> products, int orderId)
        {
            this.Id = id;
            this.UserId = userId;
            this.Category = category;
            this.Products = products;
            this.OrderId = orderId;
        }

    }
}

