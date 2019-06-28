using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2._0
{
     abstract class AManejador : IEfectivoDeGot
    {
       public static bool SeresolvioElProblema;
        public static int ContPolicia=0;
        public static int ContPerito = 0;
        public static int ContFuerzasEspeciales=0;
        public static int ContOficiales=0;
        //IEfectivoDeGot _sucesor;
       
        string nombre;
        AManejador _manejador = null;

        protected AManejador(AManejador Sucesor)
        {
            this._manejador =Sucesor;
        }



        protected AManejador(string Nombre ,AManejador sucesor)
        {
            this.nombre = Nombre;
            this._manejador = sucesor;
        }

        //protected AManejador(AManejador sucesor)
        //{
        //    this.sucesor = sucesor;
        //}

        virtual public void DenunciaAccidente()
        {
            if (_manejador != null)
            {
                if (SeresolvioElProblema)
                {
                    Console.WriteLine("El problema fue resuelto");
                }
                else
                {
                    _manejador.DenunciaAccidente();
                }
            }
            else
            {
                Console.WriteLine("no se pudo antender la amenza debomba");
            }
        }

        virtual public void DenunciaAmenazadeBomba()
        {
            if (_manejador != null)
            {
                _manejador.DenunciaAmenazadeBomba();
            }
            else
            {
                Console.WriteLine("no se pudo antender la amenza debomba");
            }
        }

        virtual public void DenunciaAsesinato()
        {
            if (_manejador != null)
            {
                _manejador.DenunciaAsesinato();
            }
            else
            {
                Console.WriteLine("no se pudo antender Asesinato");
            }
        }

        virtual public void DenunciaDisturbiosCallejeros()
        {
            if (_manejador != null)
            {
                _manejador.DenunciaDisturbiosCallejeros();
            }
            else
            {
                Console.WriteLine("no se pudieron antender Los disturbios callejeros");
            }
        }

        virtual public void DenunciaRobo()
        {
            if (_manejador != null)
            {
                _manejador.DenunciaRobo();
            }
            else
            {
                Console.WriteLine("no se pudo atender el robo");
            }
        }

        virtual public void DenunciaSecuestro()
        {
            if (_manejador != null)
            {
                _manejador.DenunciaSecuestro();
            }
            else
            {
                Console.WriteLine("no se pudo atender el secuestro");
            }
        }
    }
}
