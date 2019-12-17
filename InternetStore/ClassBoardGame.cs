using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore
{
    class BoardGame : Product
    {
        static private string Tipe { get; } = "Board game";
        private string NumberOfPlayers { get; set; }
        private int PlayingTime { get; set; }
        private int Age { get; set; }

        public BoardGame(string title, string author, int price, int rating, string numberOfPlayers, int playingTime, int age) : base(title, author, price, rating)
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
                $"author: {Author}, " +
                $"rating: {Rating}, " +
                $"price: {Price}, " +
                $"number of players: {NumberOfPlayers}, " +
                $"playing time: {PlayingTime}, " +
                $"age: {Age}+.");
        }
    }
}
