using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConDetectiveMeticuloso : AbsDectective
    {
        public ConDetectiveMeticuloso(AManejador sucesor) : base(sucesor)
        {
            this.investigacion = new ConInvestigacionMinusiosa();
        }
    }
}
