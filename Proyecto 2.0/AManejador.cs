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
        public static int ConPoliciaCientifica = 0;
        public static List<IEfectivoDeGot> ListaEfectivos = new List<IEfectivoDeGot>();
        //IEfectivoDeGot _sucesor;
       
        string nombre;
        AManejador _manejador = null;
        IEfectivoDeGot Efectivo;

        protected AManejador(IEfectivoDeGot Sucesor)
        {
            this.Efectivo =Sucesor;
        }
        protected AManejador(string Nombre ,IEfectivoDeGot sucesor)
        {
            this.nombre = Nombre;
            this.Efectivo = sucesor;
        }
        virtual public void DenunciaAccidente()
        {
            if (Efectivo!=null)
            {
                if (SeresolvioElProblema=!true)
                {
                    Console.WriteLine("el caso fue resuelto");
                }
                else
                {
                    Efectivo.DenunciaAccidente();
                }
            }
            else
            {
                Console.WriteLine("no se pudo antender el accidente");
            }
        }

        virtual public void DenunciaAmenazadeBomba()
        {
            if (Efectivo != null)
            {
                Efectivo.DenunciaAmenazadeBomba();
            }
            else
            {
                Console.WriteLine("no se pudo antender la amenza debomba");
            }
        }

        virtual public void DenunciaAsesinato()
        {
            if (Efectivo != null)
            {
                Efectivo.DenunciaAsesinato();
            }
            else
            {
                Console.WriteLine("no se pudo antender Asesinato");
            }
        }

        virtual public void DenunciaDisturbiosCallejeros()
        {
            if (Efectivo != null)
            {
                Efectivo.DenunciaDisturbiosCallejeros();
            }
            else
            {
                Console.WriteLine("no se pudieron antender Los disturbios callejeros");
            }
        }

        virtual public void DenunciaRobo()
        {
            if (Efectivo != null)
            {
                Efectivo.DenunciaRobo();
            }
            else
            {
                Console.WriteLine("no se pudo atender el robo");
            }
        }

        virtual public void DenunciaSecuestro()
        {
            if (Efectivo != null)
            {
                Efectivo.DenunciaSecuestro();
            }
            else
            {
                Console.WriteLine("no se pudo atender el secuestro");
            }
        }
    }
}
