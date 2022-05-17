using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete
{
    public class Campaign
    {

        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscountRate { get; set; }
        public string CampaignDescription { get; set; }


    }
}
