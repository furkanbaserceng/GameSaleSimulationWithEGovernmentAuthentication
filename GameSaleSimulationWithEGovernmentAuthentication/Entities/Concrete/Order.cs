using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete
{
    public class Order 
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public double OrderPrice { get; set; }
        public string OrderDetails { get; set; }
    }
}
