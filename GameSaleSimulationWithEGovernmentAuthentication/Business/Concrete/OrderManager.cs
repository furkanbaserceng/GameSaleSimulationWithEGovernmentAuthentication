using GameSaleSimulationWithEGovernmentAuthentication.Business.Abstract;
using GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Business.Concrete
{
    public class OrderManager : IOrderService
    {

        private ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }

        public void Sell(Gamer gamer, Order order, Campaign campaign)
        {
            
            _campaignService.Add(campaign);

            double newPrice = order.OrderPrice - (order.OrderPrice * campaign.CampaignDiscountRate);

            Console.WriteLine("Customer:{0} {1}",gamer.GamerFirstName,gamer.GamerLastName  );
            Console.WriteLine("Order:{0} Price: {1}",order.OrderName,newPrice );
        }
    }
}
