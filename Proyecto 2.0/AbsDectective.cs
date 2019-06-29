using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2._0
{
     abstract class AbsDectective : AManejador
    {
        protected string nombre;
        public AbsDectective(string nombre, IEfectivoDeGot sucesor) : base(sucesor)
        {
            this.nombre = nombre;
        }

        protected AbsDectective(IEfectivoDeGot sucesor) : base(sucesor)
        {
            this.sucesor = sucesor;
        }

       

        protected AbsInvestigacion investigacion;
        private IEfectivoDeGot sucesor;

        override public void DenunciaAsesinato()
        {
            Console.WriteLine("Atendiendo Asesinato");
            investigacion.realizarInvestigacion();
        }
    }
}
