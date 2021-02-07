using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    interface ICampaignService
    {

        void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi! " + campaign.CampaignName + " İndirim Oranı : " + campaign.CampaignRate);
        }
        void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi!"+ campaign.CampaignName + " İndirim Oranı : " + campaign.CampaignRate);
        }
        void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya sonlandırıldı! " + campaign.CampaignName );
        }

    }
}
