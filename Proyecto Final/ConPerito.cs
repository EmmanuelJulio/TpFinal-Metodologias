﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class ConPerito : AManejador
    {
        public ConPerito(IEfectivoDeGot sucesor) : base(sucesor)
        {
        }
        override public void DenunciaRobo()
        {
                Console.WriteLine("Atendiendo Robo");
        }
        override public void DenunciaAccidente()
        {
            if (ContPerito < 1)
            {
                ContPerito++;
                Console.WriteLine("Perito llego al accidente Accidente ");
                base.DenunciaAccidente();
            }
            else
            {
                if (ContPolicia < 2)
                {
                    Console.WriteLine("El Perito ya esta , esperamos mas Ooficiales");
                    Console.ReadKey();
                    base.DenunciaAccidente();

                }

            }
        }
    }
}
