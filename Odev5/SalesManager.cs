using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class SalesManager : ISalesService
    {
        public void Buy(Games game, Gamer gamer)
        {
            Console.WriteLine("{0} adlı oyuncu {1} oyununu {2} fiyatı ile satın adlı",gamer.FirstName,game.GameName,game.GamePrice);
        }

        public void BuyWithCampaign(Games game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("{0} adlı oyuncu {1} oyununu {2} fiyatı üzerinden {3} kampanyası ile % {4} indirimli satın adlı", 
                gamer.FirstName, game.GameName, game.GamePrice,campaign.CampaignName,campaign.CampaignRate);
        }
    }
}
