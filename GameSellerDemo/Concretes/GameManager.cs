using GameSellerDemo.Abstracts;
using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellerDemo.Concretes
{
    internal class GameManager : IGameService
    {
        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName +" "+ gamer.FirstName +" e başarı ile satıldı.");
        }
    }
}
