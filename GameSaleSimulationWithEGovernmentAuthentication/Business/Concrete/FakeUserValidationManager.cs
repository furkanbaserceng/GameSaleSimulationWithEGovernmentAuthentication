using GameSaleSimulationWithEGovernmentAuthentication.Business.Abstract;
using GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Business.Concrete
{
    public class FakeUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.GamerFirstName=="Furkan" && gamer.GamerLastName=="Başer" 
                                              && gamer.NationalIdentityNumber==123456789
                                              && gamer.BirthYear==1900)
            {
                return true;
            }
            else
            {
                return false;
            }
                                        
        }
    }
}
