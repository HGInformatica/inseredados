using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static Entidades.ClassesDeEntidade;

namespace ServiceInsercao
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool InsereCargo(Cargo objCargo)
        {
            NegocioCargo obj = new NegocioCargo();
            return obj.InsereCargo(objCargo);
        }

        public List<Cargo> RecuperaCargos()
        {
            NegocioCargo obj = new NegocioCargo();
            return obj.RecuperaCargos();
        }
    }
}
