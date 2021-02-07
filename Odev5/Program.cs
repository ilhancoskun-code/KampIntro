using System;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamerManager = new GamerManager( new UserValidationManager());
            Gamer gamer = new Gamer{ Id = 1, BirthYear = 1986, FirstName = "İLHAN", LastName = "COŞKUN", TcNo = 12345678901 };
            gamerManager.Add(gamer);

            Console.WriteLine("************************");
            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "İlk 10000 kişi";
            campaign.CampaignRate = 50;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 2;
            campaign2.CampaignName = "Yeni Yıl İndirimi";
            campaign2.CampaignRate = 30;



            Console.WriteLine("************************");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            CampaignManager campaignManager2 = new CampaignManager();
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign2);

            Console.WriteLine("************************");
            Games game = new Games { GameId = 1, GameName = "FIFA21", GamePrice = 450 };
            Games game2 = new Games { GameId = 1, GameName = "Call of Duty", GamePrice = 399 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            GameManager gameManager2 = new GameManager();
            gameManager2.Add(game2);

            Console.WriteLine("************************");

            SalesManager salesManager = new SalesManager();
            salesManager.Buy(game,gamer);

            salesManager.BuyWithCampaign(game2, gamer, campaign2);




        }
    }
}
