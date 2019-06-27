using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class FabricaDeOficial : FabricaDeEfectivos
    {
        public FabricaDeOficial()
        {
            throw new System.NotImplementedException();
        }

        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConOficiales cp = new ConOficiales(nombre, ((AManejador)siguiente));
            return cp;
        }
    }

}
