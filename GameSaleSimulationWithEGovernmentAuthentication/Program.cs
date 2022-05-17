using GameSaleSimulationWithEGovernmentAuthentication.Business.Abstract;
using GameSaleSimulationWithEGovernmentAuthentication.Business.Concrete;
using GameSaleSimulationWithEGovernmentAuthentication.Business.DependenyResolvers.Ninject;
using GameSaleSimulationWithEGovernmentAuthentication.Core.EStateAuthentication;
using GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                GamerFirstName = "Furkan",
                GamerLastName = "Başer",
                BirthYear = 1900,
                NationalIdentityNumber = 00000000000  
                //bilgiler yanlış verildiğinden mernisden geçemez.
                //programın son halinde BusinessModulde FakeUserValidationManager aktif edildi.
                //ilgili kısım EStateUserValidationManager e çekildiğinde gamer 1 in eklenemediği görülebilir.
                //gerçek vatandaşlık bilgileri girildiği takdirde gamer1 başarılı biçimde sisteme dahil olabilir.
            };

            Gamer gamer2 = new Gamer
            {
                GamerFirstName = "Salih",
                GamerLastName = "Başer",
                BirthYear = 1975,
                NationalIdentityNumber = 123456789
            };

            IGamerService gamerService = InstanceFactory.GetInstance<IGamerService>();
            gamerService.Add(gamer1); // gamer1 oyuncusu gerçek mernis verilerine uymadığından dolayı eklenemez.
            gamerService.Add(gamer2); // gamer2 oyuncusu fake servise göre uygun olduğundan eklenir.

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                CampaignName = "%30 Discount",
                CampaignDescription = "...",
                CampaignDiscountRate = 0.3
            };

            ICampaignService campaignManager = new CampaignManager();
            

            IOrderService orderService = new OrderManager(campaignManager);
            orderService.Sell(gamer1,
                new Order
                {
                Id = 1,
                OrderName = "Call Of Duty Ghosts",
                OrderDetails = "...",
                OrderPrice = 100
                },
               campaign1);


            
           


            Console.Read();
            



        }
    }
}
