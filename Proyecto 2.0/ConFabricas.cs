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
            return of;
        }
    }
    class FabricaDeCientifica : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            
                ConDectectConPoliciaCientificaive of = new ConDectectConPoliciaCientificaive(nombre, siguiente);
            return of;
        }
    }
    class FabricaDeOficial : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConOficiales of = new ConOficiales(nombre, siguiente);
            return of;
        }
    }
    class FabricaDeFuerzaEspecial : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConFuerzasEspeciales of = new ConFuerzasEspeciales(nombre, siguiente);
            return of;
        }
    }
    class FabricaDeComisario : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConComisarioImpector of = new ConComisarioImpector(nombre, siguiente);
            return of;
        }
    }
    class FabricaDePerito : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConPerito of = new ConPerito(nombre, siguiente);
            return of;
        }
    }
    class FabricaDeDetectiveM : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConDetectiveMeticuloso of = new ConDetectiveMeticuloso(nombre, siguiente);
            return of;
            // Detective que lleva a cabo una investigación minuiciosa 
            
        }
    }
    class FabricaDeDetectiveD : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            ConDetectiveTorpe of = new ConDetectiveTorpe(nombre, siguiente);
            return of;
            // Detective que lleva a cabo una investigación desprolija
            
        }
    }
    class FabricaDeDetectiveSY : FabricaDeEfectivos
    {
        override protected IEfectivoDeGot crear(string nombre, IEfectivoDeGot siguiente)
        {
            // Detective que lleva a cabo una investigación al estilo Scotland Yard
            // Deberá usar la clase InvestigacionAlEstiloScotlandYard provista más abajo
            ConDetectiveSCotlandYard Dsy = new ConDetectiveSCotlandYard(nombre,siguiente);
            return Dsy;
        }
    }
}
