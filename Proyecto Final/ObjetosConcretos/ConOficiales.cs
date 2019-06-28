using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConOficiales : AManejador
    {
        string nombre;
        public ConOficiales(string nombre, AManejador sucesor) : base(sucesor)
        {
            
            this.nombre = nombre;
        }
        override public void DenunciaAccidente()
        {
            if (ContPolicia<2)
            {
                ContPolicia++;
                Console.WriteLine("Oficial "+nombre+ " llego al Accidente pero aun faltan refuersos");
                base.DenunciaAccidente();
            }
            else {
                if (ContPolicia == 2)
                {
                    Console.WriteLine("Con la llegada del oficial "+nombre+" ya hAY TRES OFICIALES");
                    ContPolicia++;
                    if (ContPerito == 1)
                    {
                        Console.WriteLine("Resolviendo el crimen con la ayuda del perito");
                        SeresolvioElProblema = true;
                        base.DenunciaAccidente();

                    }
                }

                
            }
            
        }
        override public void DenunciaAmenazadeBomba()
        {
            Console.WriteLine("Atendiendo Amenaza de Bomba");
        }
        override public void DenunciaDisturbiosCallejeros()
        {
            Console.WriteLine("Atendiendo Disturbios Callejeros");
        }
        override public void DenunciaRobo()
        {
            Console.WriteLine("Atendiendo Robo");
        }
        override public void DenunciaSecuestro()
        {
            Console.WriteLine("Atendiendo Secuestro");
        }
    }
}
