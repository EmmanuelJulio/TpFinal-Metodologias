using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2._0
{
    class FabricaDeOperador : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConOficialAtencion of = new ConOficialAtencion(nombre, siguiente);
            return null;
        }
    }
    class FabricaDeCientifica : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            return null;
        }
    }
    class FabricaDeOficial : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            return null;
        }
    }
    class FabricaDeFuerzaEspecial : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            return null;
        }
    }
    class FabricaDeComisario : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            return null;
        }
    }
    class FabricaDePerito : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            return null;
        }
    }
    class FabricaDeDetectiveM : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            // Detective que lleva a cabo una investigación minuiciosa 
            return null;
        }
    }
    class FabricaDeDetectiveD : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            // Detective que lleva a cabo una investigación desprolija
            return null;
        }
    }
    class FabricaDeDetectiveSY : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            // Detective que lleva a cabo una investigación al estilo Scotland Yard
            // Deberá usar la clase InvestigacionAlEstiloScotlandYard provista más abajo
            return null;
        }
    }
}
