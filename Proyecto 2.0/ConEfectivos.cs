using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2._0
{
    #region
    class ConComisarioImpector : AManejador
    {
        private string nombre;

        public ConComisarioImpector(string nombre, IEfectivoDeGot sucesor) : base(sucesor)
        {
            this.nombre = nombre;
        }

        override public void DenunciaRobo()
        {
            if (ContPerito != 1)
            {
                ListaEfectivos.Add(this);
                Console.WriteLine("el Comisario inspector "+nombre+" llego a la esena ,aguardando por un perito");
                base.DenunciaRobo();
            }
        }
        

    }
    #endregion
    #region
    class ConDetectiveMeticuloso : AbsDectective
    {
        

        public ConDetectiveMeticuloso(string nombre,IEfectivoDeGot sucesor) : base(sucesor) 
        {
            this.nombre = nombre;
            
            this.investigacion = new ConInvestigacionMinusiosa();
        }
    }
    #endregion
    #region
    class ConDetectiveTorpe : AbsDectective
    {
        

        public ConDetectiveTorpe(string nombre ,IEfectivoDeGot sucesor) : base(sucesor)
        {
            
            investigacion = new ConInvestigacionTorpe();
        }

    }
    #endregion
    #region
    class ConFuerzasEspeciales : AManejador
    {
        private string nombre;

        public ConFuerzasEspeciales(string nombre ,IEfectivoDeGot sucesor) : base(sucesor)
        {
            this.nombre = nombre;
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
    #endregion
    #region
    class ConOficialAtencion : AManejador
    {
        private string nombre;
        private IEfectivoDeGot Susesor;
        public ConOficialAtencion(string nombre, IEfectivoDeGot sucesor) : base(sucesor)
        {
            this.Susesor = sucesor;
        }
        override public void DenunciaRobo()
        {
            if (Susesor==null)
            {
                Console.WriteLine("aqui oficial de atencion"+nombre+" lamento que no se pudo completar la peticion");
            }
            else
            {
                base.DenunciaRobo();
            }
        }
        override public void DenunciaAccidente()
        {
            if (Susesor == null)
            {
                Console.WriteLine("aqui oficial de atencion" + nombre + " lamento que no se pudo completar la Denuncia");
            }
            else
            {
                base.DenunciaAccidente();
            }
        }
        public override void DenunciaAmenazadeBomba()
        {
            if (Susesor == null)
            {
                Console.WriteLine("aqui oficial de atencion" + nombre + " lamento que no se pudo completar la amenanaza de bomba");
            }
            else
            {
                base.DenunciaAmenazadeBomba();
            }
        }
        public override void DenunciaAsesinato()
        {
            if (Susesor == null )
            {
                Console.WriteLine("aqui oficial de atencion" + nombre + " lamento que no se pudo completar la De nuncia de asecinato");
            }
            else
            {
                base.DenunciaAsesinato();
            }
        }
        public override void DenunciaDisturbiosCallejeros()
        {
            if (Susesor == null)
            {
                Console.WriteLine("aqui oficial de atencion" + nombre + " lamento que no se pudieron completar Los disturbios callejeros");
            }
            else
            {
                base.DenunciaDisturbiosCallejeros();
            }
        }
        public override void DenunciaSecuestro()
        {
            if (Susesor == null)
            {
                Console.WriteLine("aqui oficial de atencion" + nombre + " lamento que no se pudieron completar la peticion de secuestro");
            }
            else
            {
                base.DenunciaSecuestro();
            }
        }
      



    }
    #endregion
    #region
    class ConOficiales : AManejador
    {
        string nombre;
        public ConOficiales(string nombre, IEfectivoDeGot sucesor) : base(sucesor)
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
                    }
                    if (ConPoliciaCientifica == 1)
                    {
                        Console.WriteLine("Resolviendo el crimen con la ayuda del Policia cientifico precente");
                        
                    }
                    if (ContPerito == 0 & ConPoliciaCientifica == 0)
                    {
                        Console.WriteLine("Devemos esperar por un perito o un Policia cientifico");
                        base.DenunciaAccidente();
                    }
                }
                else
                {
                    if (SeresolvioElProblema != true)
                    {

                    }
                    else
                    {
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
    #endregion
    #region
    class ConPerito : AManejador
    {
        string nombre;
        public ConPerito(string nombre, IEfectivoDeGot sucesor) : base(sucesor)
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
                Console.WriteLine("Perito " + nombre + " llego al accidente");
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
    #endregion
    #region
    class ConDectectConPoliciaCientificaive : AManejador
    {
        string nombre;
        public ConDectectConPoliciaCientificaive(string nombre, IEfectivoDeGot sucesor) : base(sucesor)
        {

            this.nombre = nombre;
        }
        public override void DenunciaAccidente()
        {
            ConPoliciaCientifica++;
            Console.WriteLine("Llego " + nombre + " un miembro de la policia cientifica");
            if (ContPolicia == 3)
            {
                Console.WriteLine("el caso esta siendo resuelto por el policia cientifico " + nombre);
                SeresolvioElProblema = true;
            }
            else
            {
                Console.WriteLine("Nesesito al menos 3 oficiales para proceder con la investigacion " + nombre);
                base.DenunciaAccidente();
            }
        }
    }
    #endregion
    #region
    class ConDetectiveSCotlandYard : AManejador
    {
        string nombre;
        public ConDetectiveSCotlandYard(string nombre, IEfectivoDeGot sucesor) : base(sucesor)
        {

            this.nombre = nombre;
        }
    }
    #endregion
    
    
}
