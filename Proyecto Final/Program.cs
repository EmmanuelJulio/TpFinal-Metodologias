using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Program
    {
        private static IEfectivoDeGot CrearDepartamentoDePolicia()
        {
            // Este método puede ser modificado si se desea probar con otra cadena de responsabilidades

            IEfectivoDeGot eg = null;

            // Con esta cadena, todos los casos deberán ser atendidos
            eg = FabricaDeEfectivos.crear("Operador", "Tyrion Lannister", eg);
            eg = FabricaDeEfectivos.crear("Cientifica", "Daenerys Targaryen", eg);
            eg = FabricaDeEfectivos.crear("Oficial", "Arya Stark", eg);
            eg = FabricaDeEfectivos.crear("Oficial", "Jon Snow", eg);
            eg = FabricaDeEfectivos.crear("DetectiveM", "Eddard Stark", eg);
            eg = FabricaDeEfectivos.crear("FuezaEspecial", "Jaime Lannister", eg);
            eg = FabricaDeEfectivos.crear("Oficial", "Cersei Lannister", eg);
            eg = FabricaDeEfectivos.crear("Comisario", "Sansa Stark", eg);
            eg = FabricaDeEfectivos.crear("Perito", "Robb Stark", eg);
            eg = FabricaDeEfectivos.crear("Oficial", "Khal Drogo", eg);
            eg = FabricaDeEfectivos.crear("DetectiveSY", "Sam Tarly", eg);
            eg = FabricaDeEfectivos.crear("FuezaEspecial", "Varys", eg);
            eg = FabricaDeEfectivos.crear("Oficial", "Bran Stark", eg);
            eg = FabricaDeEfectivos.crear("DetectiveD", "Petyr Baelish", eg);
            eg = FabricaDeEfectivos.crear("Oficial", "Tywin Lannister", eg);

            /*
			// Con esta cadena, los robos, asesinatos, secuestros y amenazas de bomba no son atendidos
			
			eg	= FabricaDeEfectivos.crear("Operador", "Theon Greyjoy", eg);
			eg = FabricaDeEfectivos.crear("Cientifica", "Joffrey Baratheon", eg);
			eg = FabricaDeEfectivos.crear("Oficial", "Aemon Targaryen", eg);
			eg = FabricaDeEfectivos.crear("FuezaEspecial", "Hodor", eg);
			eg = FabricaDeEfectivos.crear("FuezaEspecial", "Stannis Baratheon", eg);
			eg = FabricaDeEfectivos.crear("Oficial", "Robert Baratheon", eg);
			*/

            return eg;
        }

        private static void GenerarDenuncias(IEfectivoDeGot eg)
        {
            // Complete este método con las siguientes denuncias y sus correspondientes acciones
           
            // Robo

            // Asesinato

            // Secuestro

            // Disturbio callejero

            // Asesinato

            // Accidente

            // Amenaza de bomba

            // Asesinato
        }


        ///********************************************************************************************************
        /// El código aquí debajo no debe ser modificado

        public static void Main(string[] args)
        {
            //IEfectivoDeGot eg = CrearDepartamentoDePolicia();

            //GenerarDenuncias(eg);

            //Console.Write("Programa finalizado correctamente . . . ");
            //Console.ReadKey(true);


            ///esta parte la hice para
            ///ver que Chain Of responsability funcione bien
            ///
            AManejador ef = new ConOficiales(null,null);
             ef = new ConOficiales("Pepe",ef);
             ef = new ConOficiales("Francisco",ef);
             ef = new ConPerito("Elias",ef);
            ef = new ConOficiales("JOSE",ef);

           

            ef.DenunciaAccidente();
            Console.ReadKey();

        }
    }

}
