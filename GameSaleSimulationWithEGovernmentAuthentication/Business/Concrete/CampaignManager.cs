using GameSaleSimulationWithEGovernmentAuthentication.Business.Abstract;
using GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Business.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" applied.");
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
