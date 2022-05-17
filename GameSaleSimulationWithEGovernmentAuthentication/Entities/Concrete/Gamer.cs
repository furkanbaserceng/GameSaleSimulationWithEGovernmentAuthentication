using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete
{
    public class Gamer
    {
        public int Id { get; set; }
        public string GamerFirstName { get; set; }
        public string GamerLastName { get; set; }
        public long NationalIdentityNumber { get; set; }
        public int BirthYear { get; set; }


    }
}
