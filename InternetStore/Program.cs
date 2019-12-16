using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Add new book (1) or board game (2): ");
                string userAnswer = Console.ReadLine();

                AddNewProduct(userAnswer);
            }
        }

        static void AddNewProduct(string userAnswer)
        {
            switch (userAnswer)
            {
                case "1": // add book
                    break;

                case "2": // add board game
                    break;

                default:
                    break;
            }
        }

        static string AskTitle()
        {
            Console.WriteLine("Title: ");
            string title = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(title))
            {
                title = AskTitle();
            }

            return title;
        }

        static string AskAuthor()
        {
            Console.WriteLine("Author: ");
            string author = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(author))
            {
                author = AskAuthor();
            }

            return author;
        }

        static int AskPrice()
        {
            Console.WriteLine("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            if (price < 0)
            {
                price = AskPrice();
            }

            return price;
        }

        static Book NewBook(string title, string author, int price, int rating, int pages, string genre)
        {
            Book newBook = new Book(title, author, price, rating, pages, genre);

            return newBook;
        }

        static BoardGame NewBoardGame(string title, string author, int price, int rating, string numberOfplayers, int playingTime, string age)
        {
            BoardGame newBoardGame = new BoardGame(title, author, price, rating, numberOfplayers, playingTime, age);

            return newBoardGame;
        }
    }
}
