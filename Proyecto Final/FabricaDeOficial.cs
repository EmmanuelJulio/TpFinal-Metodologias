﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class FabricaDeOficial : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            return new ConOficiales(siguiente);
        }
    }

}
