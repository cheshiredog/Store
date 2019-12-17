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
                Console.Write("Add new book (1) or new board game (2): ");
                string userAnswer = Console.ReadLine();

                AddNewProduct(userAnswer);
            }
        }

        #region Get data from user

        static string AskTitle()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(title))
            {
                Console.Write("Wrong answer.");
                title = AskTitle();
            }

            return title;
        }

        static string AskAuthor()
        {
            Console.Write("Author: ");
            string author = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(author))
            {
                Console.Write("Wrong answer.");
                author = AskAuthor();
            }

            return author;
        }

        static int AskPrice()
        {
            Console.Write("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            if (price < 0)
            {
                Console.Write("Price must be grater than 0.");
                price = AskPrice();
            }

            return price;
        }

        static int AskRating()
        {
            Console.Write("Rating: ");
            int rating = Convert.ToInt32(Console.ReadLine());

            if (rating < 0 && rating > 10)
            {
                Console.Write("Rating must be grater than 0 and less than 10.");
                rating = AskRating();
            }

            return rating;
        }

        static int AskPages()
        {
            Console.Write("Pages: ");
            int pages = Convert.ToInt32(Console.ReadLine());

            if (pages < 1)
            {
                Console.Write("Quantity of pages must be grater than 0.");
                pages = AskPages();
            }

            return pages;
        }

        static string AskGenre()
        {
            Console.Write("Genre: ");
            string genre = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(genre))
            {
                Console.Write("Wrong answer.");
                genre = AskGenre();
            }

            return genre;
        }

        static string AskNumberOfPlayers()
        {
            Console.Write("Number of players: ");
            string numberOfPlayers = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(numberOfPlayers))
            {
                Console.Write("Wrong answer.");
                numberOfPlayers = AskNumberOfPlayers();
            }

            return numberOfPlayers;
        }

        static int AskPlayingTime()
        {
            Console.Write("Palying time: ");
            int playingTime = Convert.ToInt32(Console.ReadLine());

            if (playingTime < 1)
            {
                Console.Write("Playing time must be grater than 1 min.");
                playingTime = AskPlayingTime();
            }

            return playingTime;
        }

        static int AskAge()
        {
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 1)
            {
                Console.Write("Age must be grater than 0.");
                age = AskAge();
            }

            return age;
        }

        #endregion

        #region Create new object

        static void AddNewProduct(string userAnswer)
        {
            string title = AskTitle();
            string author = AskAuthor();
            int price = AskPrice();
            int rating = AskRating();

            switch (userAnswer)
            {
                case "1": // add book
                    int pages = AskPages();
                    string genre = AskGenre();
                    Book newBook = NewBook(title, author, price, rating, pages, genre);
                    newBook.GetBookInfo();
                    break;

                case "2": // add board game
                    string numberOfPlayers = AskNumberOfPlayers();
                    int playingTime = AskPlayingTime();
                    int age = AskAge();
                    BoardGame newBoardGame = NewBoardGame(title, author, price, rating, numberOfPlayers, playingTime, age);
                    newBoardGame.GetBoardGameInfo();
                    break;

                default:
                    break;
            }
        }

        static Book NewBook(string title, string author, int price, int rating, int pages, string genre)
        {
            Book newBook = new Book(title, author, price, rating, pages, genre);

            return newBook;
        }

        static BoardGame NewBoardGame(string title, string author, int price, int rating, string numberOfplayers, int playingTime, int age)
        {
            BoardGame newBoardGame = new BoardGame(title, author, price, rating, numberOfplayers, playingTime, age);

            return newBoardGame;
        }

        #endregion
    }
}
