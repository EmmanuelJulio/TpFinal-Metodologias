using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2._0
{
    abstract class AbsInvestigacion
    {
        public virtual void realizarInvestigacion()
        {
            entrevistaTestigos();
            revisarVictima();
            entrevistaTestigos();
            formulaHipotesis();
            realizaAcusacion();
        }
        public abstract void reccorerCrimen();
        public abstract void revisarVictima();
        public abstract void entrevistaTestigos();
        public abstract void formulaHipotesis();
        public abstract void realizaAcusacion();
    }
    class InvestigacionAlEstiloScotlandYard
    {
        public void tourCrimeScene()
        {
            Console.WriteLine("Taking steps in a circle at the crime scene");
        }

        public void inspectVictim()
        {
            Console.WriteLine("Reviewing the victim, including his clothes");
        }

        public void interviewWitness()
        {
            Console.WriteLine("Asking questions to all the witnesses of the crime");
        }

        public void formulateHypothesis()
        {
            Console.WriteLine("Closing the eyes, meditating and formulating possible hypotheses according to the clues found");
        }

        public void toAcusse()
        {
            Console.WriteLine("Pointing the murderer with the index finger");
        }
    }
    class ConInvestigacionMinusiosa : AbsInvestigacion
    {
        private string nombre;

        public override void entrevistaTestigos()
        {
            Console.WriteLine("Entrevestando testigos de a uno por ves ,en un cuarto cerrado sin celulares cerca");
        }

        public override void formulaHipotesis()
        {
            Console.WriteLine("En base a la evidencia recolectada se formula una hipotesis");
        }

        public override void realizaAcusacion()
        {
            Console.WriteLine("El acusado es el culpable devido a huellas encontradas en la esena (acusacion)");
        }

        public override void reccorerCrimen()
        {
            Console.WriteLine("Se recorre la esena de crimen con guantes de latex en la mano con cuidado de no adulterar la esena");
        }

        public override void revisarVictima()
        {
            Console.WriteLine("Se recaban datos de la victica utilizando guantes y buenas practicas forences");
        }
    }
    class ConInvestigacionTorpe : AbsInvestigacion
    {
        

        public override void realizarInvestigacion()
        {
            entrevistaTestigos();
            revisarVictima();
            entrevistaTestigos();
            formulaHipotesis();
            realizaAcusacion();
        }

        public override void entrevistaTestigos()
        {
            Console.WriteLine("Se consulta los testigos de a grupos en un bar");
        }

        public override void formulaHipotesis()
        {
            Console.WriteLine("Se formula la hipotesis en base a una pelicula que el detective vio la noche anterior");
        }

        public override void realizaAcusacion()
        {
            Console.WriteLine("La acusacion esta echa en base a evidencia sircunstancial");
        }

        public override void reccorerCrimen()
        {
            Console.WriteLine("Se recorre la esena del crimen sin guantes y dejando restos de sanguche por todos lados");
        }

        public override void revisarVictima()
        {
            Console.WriteLine("Se revisa a la victima de forma casual toca el cuerpo con las manos desnudas");
        }
    }
    class adpater : AbsInvestigacion
    {
        InvestigacionAlEstiloScotlandYard nb;
        public adpater(InvestigacionAlEstiloScotlandYard nb)
        {
            this.nb = nb;
        }
        
        public override void entrevistaTestigos()
        {
            nb.interviewWitness();
        }

        public override void formulaHipotesis()
        {
            nb.formulateHypothesis();
        }

        public override void realizaAcusacion()
        {
            nb.toAcusse();
        }

        public override void reccorerCrimen()
        {
            nb.tourCrimeScene();
        }

        public override void revisarVictima()
        {
            nb.inspectVictim();
        }
    }
    class ProxyDetective : AbsDectective
    {
        int Tipo;
        IEfectivoDeGot susesor;
        string Nombre;
        AbsDectective Detective;
        public ProxyDetective(string nombre, IEfectivoDeGot sucesor,int tipo) : base(nombre, sucesor)
        {
            this.susesor = sucesor;
            this.Nombre = nombre;
            this.Tipo =tipo;
            
        }
        public override void DenunciaAsesinato()
        {
            switch (Tipo)
            {
                case 1:
                    this.Detective = new ConDetectiveMeticuloso(Nombre, susesor);
                    Detective.DenunciaAsesinato();
                    ocupado = true;
                    break;
                case 2:
                    this.Detective = new ConDetectiveTorpe(Nombre, susesor);            
                    Detective.DenunciaAsesinato();
                  ocupado=true;
                    break;
                case 3:
                    this.Detective = new ConDetectiveSCotlandYard(Nombre, susesor);
                    Detective.DenunciaAsesinato();
                    ocupado = true;
                    
                    break;
            }

            
        }

    }
}