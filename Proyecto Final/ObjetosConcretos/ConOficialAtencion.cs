using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConOficialAtencion : AManejador
    {
        private string nombre;

        public ConOficialAtencion(string nombre,AManejador sucesor) : base(sucesor)
        {
        }

        

        override public void DenunciaRobo()
        {
            if (true)
            {
                Console.WriteLine("Atendiendo Robo"); 
            }
        }
        override public void DenunciaAccidente()
        {
            Console.WriteLine("Atendiendo Accidente");
        }


    }
}
