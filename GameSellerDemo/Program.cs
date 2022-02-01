using GameSellerDemo.Concretes;
using GameSellerDemo.Entities;
using System;

namespace GameSellerDemo // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Id = 1;
            game.GameName = "God OF War";
            game.GamePrice = 330;
            

            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Melih";
            gamer.LastName = "Kayalı";
            gamer.BirthYear = "2005";
            gamer.IdentityNumber = "2344534";


            Campaign campaign = new Campaign();
            campaign.Id = 1;
            campaign.CampaignName = "Kış İndirimi";


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Discount(campaign , game);
            //campaignManager.Delete(campaign); 
            //campaignManager.Update(campaign);

            GameManager gameManager = new GameManager();
            gameManager.Sell(game, gamer);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
        }
    }
}