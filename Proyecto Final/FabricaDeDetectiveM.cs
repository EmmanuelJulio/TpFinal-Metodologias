using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class FabricaDeDetectiveM : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            // Detective que lleva a cabo una investigación minuiciosa 
            return null;
        }
    }
}
