using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConDetectiveTorpe : AbsDectective
    {
        private string nombre;

        public ConDetectiveTorpe(AManejador sucesor) : base(sucesor)
        {
            investigacion = new ConInvestigacionTorpe();
        }

    }
}
