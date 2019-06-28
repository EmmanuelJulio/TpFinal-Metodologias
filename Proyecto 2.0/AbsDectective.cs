using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2._0
{
    abstract class AbsDectective : AManejador
    {
        public AbsDectective(AManejador sucesor) : base(sucesor)
        {
        }
        protected AbsInvestigacion investigacion;
        override public void DenunciaAsesinato()
        {
            Console.WriteLine("Atendiendo Asesinato");
            investigacion.realizarInvestigacion();
        }
    }
}
