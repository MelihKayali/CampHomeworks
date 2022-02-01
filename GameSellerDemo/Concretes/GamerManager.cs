using GameSellerDemo.Abstracts;
using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellerDemo.Concretes
{
    internal class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " başarı ile eklendi.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " başarı ile silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " başarı ile güncellendi.");
        }
    }
}
