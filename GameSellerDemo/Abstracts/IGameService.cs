using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellerDemo.Abstracts
{
     interface IGameService
    {
        void Sell(Game game , Gamer gamer);//Parametrede oyuncuyu geç

    }
}
