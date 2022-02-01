using GameSellerDemo.Abstracts;
using GameSellerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellerDemo.Concretes
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " başarı ile eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " başarı ile silindi.");
        }

        public void Discount(Campaign campaign , Game game)
        {
            //Parametreye gameyi de ekle ve gamenın parasından  matematiksel işlemler yap .
            int discount = game.GamePrice * 12 / 100;
            Console.WriteLine(campaign.CampaignName +" kampanyasından" + discount + " TL indirim kazandınız");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " başarı ile güncellendi.");
        }
    }
}
