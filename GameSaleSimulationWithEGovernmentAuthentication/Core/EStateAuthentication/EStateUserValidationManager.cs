using GameSaleSimulationWithEGovernmentAuthentication.Business.Abstract;
using GameSaleSimulationWithEGovernmentAuthentication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Core.EStateAuthentication
{
    public class EStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient kPSPublicSoapClient = 
                                        new MernisServiceReference.KPSPublicSoapClient();

            return kPSPublicSoapClient.TCKimlikNoDogrula(gamer.NationalIdentityNumber,
                                                        gamer.GamerFirstName.ToUpper(),
                                                        gamer.GamerLastName.ToUpper(),
                                                        gamer.BirthYear);
        }
    }
}
