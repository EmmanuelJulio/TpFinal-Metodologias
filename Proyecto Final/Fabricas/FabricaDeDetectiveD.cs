using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class FabricaDeDetectiveD : FabricaDeEfectivos
    {
        public FabricaDeDetectiveD()
        {
            throw new System.NotImplementedException();
        }

        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            // Detective que lleva a cabo una investigación desprolija
            return null;
        }
    }
}
