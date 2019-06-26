using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConOficiales : AManejador
    {
        public ConOficiales(IEfectivoDeGot sucesor) : base(sucesor)
        {
        }
        override public void DenunciaAccidente()
        {
            if (ContPolicia<2)
            {
                ContPolicia++;
                Console.WriteLine("Oficial Accidente faltan refuersos");
                base.DenunciaAccidente();
            }
            else {
                if (ContPolicia == 2)
                {
                    Console.WriteLine("Oficial Accidente");
                    ContPolicia++;
                    if (ContPerito < 1)
                    {
                        Console.WriteLine("ya hAY TRES OFICIALES FALTAN PERITOS");
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
