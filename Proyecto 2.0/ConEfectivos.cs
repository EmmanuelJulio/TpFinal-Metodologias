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
            if (SeresolvioElProblema==false)
            {
                ListaEfectivos.Add(this);
                Console.WriteLine("el Comisario inspector "+nombre+" llego a la esena ,aguardando por un perito");
                base.DenunciaRobo();
            }
            else
            {
                base.DenunciaRobo();
            }
        }
        public override void DenunciaSecuestro()
        {
            ContComisarioInspector++;
            if (ContFuerzasEspeciales < 2)
            {
                Console.WriteLine("llego el comisario inspector " + nombre + "esperamos miembros de las fuerzas especiales");
                base.DenunciaSecuestro();
            }
            else
            {
                Console.WriteLine("el equipo ya cuenta con suficientes elementos ahora que el comisario " + nombre + "Ingreso a la ecena");
                SeresolvioElProblema = true;
                base.DenunciaSecuestro();
            }
        }
    }
    #endregion
    #region
    class ConDetectiveMeticuloso : AbsDectective
    {
        bool ocupado = false;   

        public ConDetectiveMeticuloso(string nombre,IEfectivoDeGot sucesor) : base(sucesor) 
        {
            this.nombre = nombre;
            
            this.investigacion = new ConInvestigacionMinusiosa();
        }
        public override void DenunciaAsesinato()
        {
            if (ocupado != true)
            {
                Console.WriteLine("el detective " + nombre + " Llego a la ecena del crimen");
                ocupado = true;

                investigacion = new ConInvestigacionMinusiosa();
                investigacion.realizarInvestigacion();
            }
            else
            {
                Console.WriteLine("el detective " + nombre + "se encuentra ocupado");
                base.DenunciaAsesinato();
            }

        }
    }
    #endregion
    #region
    class ConDetectiveTorpe : AbsDectective
    {
        bool ocupado=false;

        public ConDetectiveTorpe(string nombre ,IEfectivoDeGot sucesor) : base(sucesor)
        {
            
           
        }
        public override void DenunciaAsesinato()
        {
            if (ocupado!=true)
            {
                Console.WriteLine("el detective " + nombre + " Llego a la ecena del crimen");
                ocupado = true;

                investigacion = new ConInvestigacionTorpe();
                investigacion.realizarInvestigacion();
            }
            else
            {
                Console.WriteLine("el detective " + nombre + "se encuentra ocupado");
                base.DenunciaAsesinato();
            }

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
            ContFuerzasEspeciales++;
            if (ContFuerzasEspeciales >= 2 & ContComisarioInspector>0)
            {
                Console.WriteLine("Llego el miembro de las fuerzas especiales " + nombre + "Con el ya el caso puede comensar a solucionarce");
                SeresolvioElProblema = true;
                base.DenunciaSecuestro();
            }
            else
            {
                Console.WriteLine("nos falta aun personal para completar la mision");
                base.DenunciaSecuestro();
            }
        }
        override public void DenunciaAmenazadeBomba()
        {
            Console.WriteLine("Atendiendo Amenaza de Bomba");
        }
        override public void DenunciaRobo()
        {
            if (SeresolvioElProblema == false)
            {
                Console.WriteLine("Llego " + nombre + " un miembro de las Fuerzas especiales");
                Console.WriteLine("aun no llego el perito");
                base.DenunciaRobo();
            }
            else
            {
                base.DenunciaRobo();
            }
        }
       
    }
    #endregion
    #region
    class ConOficialAtencion : AManejador
    {
        private string nombre;
       
        
        private IEfectivoDeGot Susesor;


        public ConOficialAtencion(string nombre, IEfectivoDeGot susesor) : base (susesor)
        {          
            this.nombre = nombre;
            Susesor = susesor;
            if (AManejador.OficialDeAtencion == null) {
                OficialDeAtencion = this;
            }
            
        }

        //public ConOficialAtencion(string nombre, IEfectivoDeGot sucesor) : base(sucesor)
        //{
        //    //this.nombre = nombre;
        //}
        //public static ConOficialAtencion Instancia(string nombre, IEfectivoDeGot sucesor)
        //{
        //    t
        //    get{if 

        //    }
        //    return Instancia;
        //}
        
        override public void DenunciaRobo()
        {
            if (SeresolvioElProblema == true)
            {
                Console.WriteLine("aqui oficial de atencion "+nombre+" su petision fue resuelta");
            }
            else
            {
                Console.WriteLine("aqui oficial de atencion" + nombre + " lamento que no se pudo completar la peticion");
            }
        }
        override public void DenunciaAccidente()
        {
            if (SeresolvioElProblema)
            {
                Console.WriteLine("aqui oficial de atencion" + nombre + " Su problema fue resuelto exitosamente");
            }
            else
            {
                Console.WriteLine("aqui oficial de atencion " + nombre + " lamento que no se pudo completar la Denuncia");
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
            if (SeresolvioElProblema)
            {
                Console.WriteLine("aqui oficial de atencion" + nombre + " Estamos atendiendo el caso de secuestro y pronto sera resuelto");
            }
            else
            {
                Console.WriteLine("Lamento informar que no contamos con recursos para solucionar el caso de secuestro... no contamos con los recursos para hacer los");
            }
        }
      



    }
    #endregion
    //Oficiales
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
            if (SeresolvioElProblema==false)
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
                            base.DenunciaAccidente();
                        }
                        if (ConPoliciaCientifica == 1)
                        {
                            Console.WriteLine("Resolviendo el crimen con la ayuda del Policia cientifico precente");
                            base.DenunciaAccidente();
                        }
                        else
                        {
                            base.DenunciaAccidente();
                        }
                        if (ContPerito == 0 & ConPoliciaCientifica == 0)
                        {
                            Console.WriteLine("Devemos esperar por un perito o un Policia cientifico");

                        }
                        else
                        {
                            base.DenunciaAccidente();
                        }
                    }
                    

                   
                }
            }
            else
            {
                base.DenunciaAccidente();
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

            if (SeresolvioElProblema == false)
            {
                Console.WriteLine("Oficial " + nombre + " llego al Accidente pero aun faltan refuersos");
                Console.WriteLine("aun no llego el perito");
                base.DenunciaRobo(); 
            }
            else
            {
                base.DenunciaRobo();
            }

        }
        override public void DenunciaSecuestro()
        {
            Console.WriteLine("llego el oficial "+nombre+" estamos esperando por refuerzos aun");
            base.DenunciaSecuestro();
        }
    }
    #endregion
    //Perito
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
            if (SeresolvioElProblema == false)
            {
                Console.WriteLine("El perito  " + nombre + " llego la ecena de robo ,procedera a resolver el problema");
                SeresolvioElProblema = true;
                base.DenunciaRobo();
            }
            else
            {
                base.DenunciaRobo();
            }
        }
        override public void DenunciaAccidente()
        {
            if (SeresolvioElProblema==false)
            {
                if (ContPerito < 1)
                {
                    ContPerito++;
                    Console.WriteLine("Perito " + nombre + " llego al accidente");

                }
                if (ContPolicia < 2)
                {
                    Console.WriteLine("El Perito ya esta , esperamos mas Ooficiales");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("El Perito ya esta resolviendo el caso");
                    SeresolvioElProblema = true;
                    

                } 
            }
            base.DenunciaAccidente();

        }
        public override void DenunciaSecuestro()
        {
            Console.WriteLine("El perito "+nombre+"se acerco al lugar");
            base.DenunciaSecuestro();
        }
    }
    //Policia Cientifica
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
            if (SeresolvioElProblema==false)
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

                } 
            }
            base.DenunciaAccidente();
        }
        override public void DenunciaRobo()
        {
            if (SeresolvioElProblema == false)
            {
                Console.WriteLine("Llego " + nombre + " un miembro de la policia cientifica");
                Console.WriteLine("aun no llego el perito");
                base.DenunciaRobo(); 
            }
            else
            {
                base.DenunciaRobo();
            }
        }
        public override void DenunciaSecuestro()
        {
            Console.WriteLine("El miembro de la policia cientifica " + nombre + "se acerco al lugar");
            base.DenunciaSecuestro();
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
