using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2._0
{
    abstract class FabricaDeEfectivos
    {
        public static IEfectivoDeGot crear(string opcion, string nombre, IEfectivoDeGot siguiente)
        {
            FabricaDeEfectivos f = null;
            switch (opcion)
            {
                case "Operador": f = new FabricaDeOperador(); break;
                case "Cientifica": f = new FabricaDeCientifica(); break;
                case "Oficial": f = new FabricaDeOficial(); break;
                case "FuezaEspecial": f = new FabricaDeFuerzaEspecial(); break;
                case "Comisario": f = new FabricaDeComisario(); break;
                case "Perito": f = new FabricaDePerito(); break;
                case "DetectiveSY": f = new FabricaDeDetectiveSY(); break;
                case "DetectiveM": f = new FabricaDeDetectiveM(); break;
                case "DetectiveD": f = new FabricaDeDetectiveD(); break;
            }
            return f.crear(nombre, siguiente);
        }

        abstract protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente);
    }
}
