using GameSaleSimulationWithEGovernmentAuthentication.Business.Abstract;
using GameSaleSimulationWithEGovernmentAuthentication.Business.Concrete;
using GameSaleSimulationWithEGovernmentAuthentication.Core.EStateAuthentication;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleSimulationWithEGovernmentAuthentication.Business.DependenyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {

        public override void Load()
        {
            Bind<IGamerService>().To<GamerManager>();
           // Bind<IUserValidationService>().To<EStateUserValidationManager>();
            Bind<IUserValidationService>().To<FakeUserValidationManager>();

            Bind<ICampaignService>().To<CampaignManager>();
        }

    }
}
