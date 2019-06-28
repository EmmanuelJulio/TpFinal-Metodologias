using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2._0
{

    class ConComisarioImpector : AManejador
    {
        private string nombre;

        public ConComisarioImpector(string nombre, AManejador sucesor) : base(sucesor)
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
    class ConDetectiveMeticuloso : AbsDectective
    {
        private string nombre;

        public ConDetectiveMeticuloso(AManejador sucesor) : base(sucesor)
        {
            this.investigacion = new ConInvestigacionMinusiosa();
        }
    }
    class ConDetectiveTorpe : AbsDectective
    {
        private string nombre;

        public ConDetectiveTorpe(AManejador sucesor) : base(sucesor)
        {
            investigacion = new ConInvestigacionTorpe();
        }

    }
    class ConFuerzasEspeciales : AManejador
    {
        private string nombre;

        public ConFuerzasEspeciales(AManejador sucesor) : base(sucesor)
        {
        }
        override public void DenunciaSecuestro()
        {
            Console.WriteLine("Atendiendo Secuestro");
        }
        override public void DenunciaAmenazadeBomba()
        {
            Console.WriteLine("Atendiendo Amenaza de Bomba");
        }
    }
    class ConOficialAtencion : AManejador
    {
        private string nombre;

        public ConOficialAtencion(string nombre, AManejador sucesor) : base(sucesor)
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
    class ConOficiales : AManejador
    {
        string nombre;
        public ConOficiales(string nombre, AManejador sucesor) : base(sucesor)
        {

            this.nombre = nombre;
        }
        override public void DenunciaAccidente()
        {
            if (ContPolicia < 2)
            {
                ContPolicia++;
                Console.WriteLine("Oficial " + nombre + " llego al Accidente pero aun faltan refuersos");
                base.DenunciaAccidente();
            }
            else
            {
                if (ContPolicia == 2)
                {
                    Console.WriteLine("Con la llegada del oficial " + nombre + " ya hAY TRES OFICIALES");
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
            if (ContPerito != 1)
            {
                Console.WriteLine("aun no llego el perito");
                base.DenunciaRobo();
            }
            else{
                Console.WriteLine("llego el perito, resolviendo el caso");
            }

        }
        override public void DenunciaSecuestro()
        {
            Console.WriteLine("Atendiendo Secuestro");
        }
    }
    class ConPerito : AManejador
    {
        string nombre;
        public ConPerito(string nombre, AManejador sucesor) : base(sucesor)
        {

            this.nombre = nombre;
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
                Console.WriteLine("Perito " + nombre + " llego al accidente Accidente ");
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
    class ConDectectConPoliciaCientificaive
    {
    }
}
