﻿using System;
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

        IEfectivoDeGot _sucesor;
        public  AManejador(IEfectivoDeGot sucesor)
        {
            this._sucesor= sucesor;
        }
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
