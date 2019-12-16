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
}
