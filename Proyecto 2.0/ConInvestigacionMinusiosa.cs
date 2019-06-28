using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2._0
{
    class ConInvestigacionMinusiosa : AbsInvestigacion
    {
        private string nombre;

        public override void entrevistaTestigos()
        {
            Console.WriteLine("Entrevestando testigos de a uno por ves ,en un cuarto cerrado sin celulares cerca");
        }

        public override void formulaHipotesis()
        {
            Console.WriteLine("En base a la evidencia recolectada se formula una hipotesis");
        }

        public override void realizaAcusacion()
        {
            Console.WriteLine("El acusado es el culpable devido a huellas encontradas en la esena (acusacion)");
        }

        public override void reccorerCrimen()
        {
            Console.WriteLine("Se recorre la esena de crimen con guantes de latex en la mano con cuidado de no adulterar la esena");
        }

        public override void revisarVictima()
        {
            Console.WriteLine("Se recaban datos de la victica utilizando guantes y buenas practicas forences");
        }
    }
}
