using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConInvestigacionTorpe : AbsInvestigacion
    {
        private string nombre;

        public override void entrevistaTestigos()
        {
            Console.WriteLine("Se consulta los testigos de a grupos en un bar");
        }

        public override void formulaHipotesis()
        {
            Console.WriteLine("Se formula la hipotesis en base a una pelicula que el detective vio la noche anterior");
        }

        public override void realizaAcusacion()
        {
            Console.WriteLine("La acusacion esta echa en base a evidencia sircunstancial");
        }

        public override void reccorerCrimen()
        {
            Console.WriteLine("Se recorre la esena del crimen sin guantes y dejando restos de sanguche por todos lados");
        }

        public override void revisarVictima()
        {
            Console.WriteLine("Se revisa a la victima de forma casual toca el cuerpo con las manos desnudas");
        }
    }
}
