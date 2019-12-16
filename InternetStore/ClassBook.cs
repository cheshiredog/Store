using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore
{
    class Book : Product
    {
        static private string Tipe { get; } = "Book";
        private int Pages { get; set; }
        private string Genre { get; set; }

        public Book(string title, string author, int price, int rating, int pages, string genre) : base(title, author, price, rating)
        {
            Pages = pages;
            Genre = genre;
        }

        public void GetBookInfo()
        {
            Console.WriteLine(
                $"Tipe: {Tipe}, " +
                $"title: {Title}, " +
                $"author: {Author}, " +
                $"rating: {Rating}, " +
                $"price: {Price}, " +
                $"pages: {Pages}, " +
                $"genre: {Genre}.");
        }
    }
}
