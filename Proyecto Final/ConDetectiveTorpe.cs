using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConDetectiveTorpe : AbsDectective
    {
        public ConDetectiveTorpe(AManejador sucesor) : base(sucesor)
        {
            investigacion = new ConInvestigacionTorpe();
        }

    }
}
