using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi! " + campaign.CampaignName + " İndirim Oranı : " + campaign.CampaignRate);
        }
        public void Update(Campaign campaign)
        {
            campaign.CampaignRate = 20;
            Console.WriteLine("Kampanya güncellendi!" + campaign.CampaignName + " İndirim Oranı : " + campaign.CampaignRate);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya sonlandırıldı! " + campaign.CampaignName);
        }



    }
}
