using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
        public static int ContComisarioInspector = 0;
        public static List<IEfectivoDeGot> ListaEfectivos = new List<IEfectivoDeGot>();
        public static IEfectivoDeGot OficialDeAtencion=null;
        public static List<IEfectivoDeGot> OficialesDisturbios = new List<IEfectivoDeGot>();
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
            //Thread.Sleep(1000);
            if (Efectivo != null)
            {
                if (SeresolvioElProblema == true)
                {
                    AManejador.OficialDeAtencion.DenunciaAccidente();
                }
                else
                {
                    Efectivo.DenunciaAccidente();
                }

            }
        }
        virtual public void DenunciaAmenazadeBomba()
        {
           // Thread.Sleep(1000);
            if (Efectivo != null)
            {
                if (SeresolvioElProblema == true)
                {
                    AManejador.OficialDeAtencion.DenunciaAmenazadeBomba();
                }
                else
                {
                    Efectivo.DenunciaAmenazadeBomba();
                }

            }
        }
        virtual public void DenunciaAsesinato()
        {
          //  Thread.Sleep(1000);
            if (Efectivo != null)
            {
                if (SeresolvioElProblema == true)
                {
                    AManejador.OficialDeAtencion.DenunciaAsesinato();
                }
                else
                {
                    Efectivo.DenunciaAsesinato();
                }

            }


        }
        virtual public void DenunciaDisturbiosCallejeros()
        {
           // Thread.Sleep(1000);
            if (Efectivo != null)
            {
                if (SeresolvioElProblema == true)
                {
                    AManejador.OficialDeAtencion.DenunciaDisturbiosCallejeros();
                }
                else
                {
                    Efectivo.DenunciaDisturbiosCallejeros();
                }

            }
        }
        virtual public void DenunciaRobo()
        {
           // Thread.Sleep(1000);
            if (Efectivo != null)
            {
                if (SeresolvioElProblema == true)
                {
                    AManejador.OficialDeAtencion.DenunciaRobo();
                }
                else
                {
                    Efectivo.DenunciaRobo();
                }

            }

        }
        virtual public void DenunciaSecuestro()
        {
          //  Thread.Sleep(1000);
            if (Efectivo != null)
            {
                if (SeresolvioElProblema == true)
                {
                    AManejador.OficialDeAtencion.DenunciaSecuestro();
                }
                else
                {
                    Efectivo.DenunciaSecuestro();
                }

            }
        }
    }
}
