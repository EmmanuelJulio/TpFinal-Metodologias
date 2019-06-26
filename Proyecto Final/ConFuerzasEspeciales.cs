using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConFuerzasEspeciales : AManejador
    {
        public ConFuerzasEspeciales(AManejador sucesor) : base(sucesor)
        {
        }
        override public void DenunciaSecuestro()
        {
            Console.WriteLine("Atendiendo Secuestro");
        }
        override public void DenunciaAmenazadeBomba()
        {
            Console.WriteLine("Atendiendo Amenaza de Bomba");
        }
    }
}
