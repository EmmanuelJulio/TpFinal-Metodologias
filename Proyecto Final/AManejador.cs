using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
     abstract class AManejador : IEfectivoDeGot
    {
        public static int ContPolicia=0;
        public static int ContPerito = 0;
        public static int ContFuerzasEspeciales=0;
        public static int ContOficiales=0;
       IEfectivoDeGot _sucesor;
        AManejador Susesor;
       string nombre;
        private IEfectivoDeGot sucesor;

        protected AManejador(IEfectivoDeGot Sucesor)
        {
            this.sucesor = Susesor;
        }



        protected AManejador(string Nombre ,IEfectivoDeGot sucesor)
        {
            this.nombre = Nombre;
            this._sucesor= sucesor;
        }

        //protected AManejador(AManejador sucesor)
        //{
        //    this.sucesor = sucesor;
        //}

        virtual public void DenunciaAccidente()
        {
            if (_sucesor != null)
            {
                _sucesor.DenunciaAccidente();
            }
            else
            {
                Console.WriteLine("no se pudo antender la amenza debomba");
            }
        }

        virtual public void DenunciaAmenazadeBomba()
        {
            if (_sucesor !=null)
            {
                _sucesor.DenunciaAmenazadeBomba();
            }
            else
            {
                Console.WriteLine("no se pudo antender la amenza debomba");
            }
        }

        virtual public void DenunciaAsesinato()
        {
            if (_sucesor != null)
            {
                _sucesor.DenunciaAsesinato();
            }
            else
            {
                Console.WriteLine("no se pudo antender Asesinato");
            }
        }

        virtual public void DenunciaDisturbiosCallejeros()
        {
            if (_sucesor != null)
            {
                _sucesor.DenunciaDisturbiosCallejeros();
            }
            else
            {
                Console.WriteLine("no se pudieron antender Los disturbios callejeros");
            }
        }

        virtual public void DenunciaRobo()
        {
            if (_sucesor != null)
            {
                _sucesor.DenunciaRobo();
            }
            else
            {
                Console.WriteLine("no se pudo atender el robo");
            }
        }

        virtual public void DenunciaSecuestro()
        {
            if (_sucesor != null)
            {
                _sucesor.DenunciaSecuestro();
            }
            else
            {
                Console.WriteLine("no se pudo atender el secuestro");
            }
        }
    }
}
