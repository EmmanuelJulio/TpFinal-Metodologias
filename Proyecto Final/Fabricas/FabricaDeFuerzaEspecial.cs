﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class FabricaDeFuerzaEspecial : FabricaDeEfectivos
    {
        public FabricaDeFuerzaEspecial()
        {
            throw new System.NotImplementedException();
        }

        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            return null;
        }
    }
}