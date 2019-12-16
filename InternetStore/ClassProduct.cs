using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore
{
    class Product
    {
        protected string Title { get; set; }
        protected string Author { get; set; }
        protected int Price { get; set; } = 0;
        protected int Rating { get; set; } = 0;

        public Product(string title, string autor, int price, int rating)
        {
            Title = title;
            Author = autor;
            Price = price;
            Rating = rating;
        }

        public void GetProductInfo()
        {
            Console.WriteLine(
                $"Product: {Title}, " +
                $"author: {Author}, " +
                $"rating: {Rating}, " +
                $"price: {Price}.");
        }
    }
}
