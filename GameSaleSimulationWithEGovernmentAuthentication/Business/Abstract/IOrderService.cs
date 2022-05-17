using GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Business.Abstract
{
    public interface IOrderService
    {

        void Sell(Gamer gamer, Order order, Campaign campaign);


    }
}
