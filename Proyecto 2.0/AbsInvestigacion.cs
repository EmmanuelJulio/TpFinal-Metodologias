using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2._0
{
    abstract class AbsInvestigacion
    {
        public void realizarInvestigacion()
        {
            entrevistaTestigos();
            revisarVictima();
            entrevistaTestigos();
            formulaHipotesis();
            realizaAcusacion();
        }
        public abstract void reccorerCrimen();
        public abstract void revisarVictima();
        public abstract void entrevistaTestigos();
        public abstract void formulaHipotesis();
        public abstract void realizaAcusacion();
    }
}
