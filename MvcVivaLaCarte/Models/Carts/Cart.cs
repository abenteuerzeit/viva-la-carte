using Microsoft.AspNetCore.Identity;
using MvcVivaLaCarte.Models.Products;
using MvcVivaLaCarte.Models.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace MvcVivaLaCarte.Models.Carts
{
    public class Cart
    {
        [Key]
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
            Id = id;
            UserId = userId;
            Category = category;
            Products = products;
            OrderId = orderId;
        }

    }
}

