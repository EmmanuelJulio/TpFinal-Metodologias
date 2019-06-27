using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class FabricaDeCientifica : FabricaDeEfectivos
    {
        public FabricaDeCientifica()
        {
            throw new System.NotImplementedException();
        }

        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConDectectConPoliciaCientificaive CPCientifica = new ConDectectConPoliciaCientificaive();
            return ((IEfectivoDeGot)CPCientifica);

        }
    }
}
