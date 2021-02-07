using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface ISalesService
    {
        void BuyWithCampaign(Games game, Gamer gamer, Campaign campaign);
        void Buy(Games game, Gamer gamer);


    }
}
