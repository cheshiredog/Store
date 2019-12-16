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
        protected string Autor { get; set; }
        protected int Price { get; set; } = 0;
        protected int Rating { get; set; } = 0;

        public Product(string title, string autor, int price, int rating)
        {
            Title = title;
            Autor = autor;
            Price = price;
            Rating = rating;
        }

        public void GetProductInfo()
        {
            Console.WriteLine(
                $"Product: {Title}, " +
                $"autor: {Autor}, " +
                $"rating: {Rating}, " +
                $"price: {Price}.");
        }
    }

    class Book : Product
    {
        static private string Tipe { get; } = "Book";
        private int Pages { get; set; }
        private string Genre { get; set; }

        public Book(string title, string autor, int price, int rating, int pages, string genre) : base(title, autor, price, rating)
        {
            Pages = pages;
            Genre = genre;
        }

        public void GetBookInfo()
        {
            Console.WriteLine(
                $"Tipe: {Tipe}, " +
                $"title: {Title}, " +
                $"autor: {Autor}, " +
                $"rating: {Rating}, " +
                $"price: {Price}, " +
                $"pages: {Pages}, " +
                $"genre: {Genre}.");
        }
    }

    class BoardGame : Product
    {
        static private string Tipe { get; } = "Board game";
        private string NumberOfPlayers { get; set; }
        private int PlayingTime { get; set; }
        private string Age { get; set; }

        public BoardGame(string title, string autor, int price, int rating, string numberOfPlayers, int playingTime, string age) : base(title, autor, price, rating)
        {
            NumberOfPlayers = numberOfPlayers;
            PlayingTime = playingTime;
            Age = age;
        }

        public void GetBoardGameInfo()
        {
            Console.WriteLine(
                $"Tipe: {Tipe}, " +
                $"title: {Title}, " +
                $"autor: {Autor}, " +
                $"rating: {Rating}, " +
                $"price: {Price}, " +
                $"number of players: {NumberOfPlayers}, " +
                $"playing time: {PlayingTime}, " +
                $"age: {Age}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
