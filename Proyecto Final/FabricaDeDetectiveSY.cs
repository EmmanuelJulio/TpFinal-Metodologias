using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class FabricaDeDetectiveSY : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            // Detective que lleva a cabo una investigación al estilo Scotland Yard
            // Deberá usar la clase InvestigacionAlEstiloScotlandYard provista más abajo
            return null;
        }
    }
}
