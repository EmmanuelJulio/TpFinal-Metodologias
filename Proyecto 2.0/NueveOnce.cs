using System;

namespace Proyecto_2._0
{

    class NueveOnce
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
        private static int  opciones()
        {
            
            Console.WriteLine("¿Cual es su emergencia");
            Console.WriteLine("1) Robo");
            Console.WriteLine("2) Asesinato");
            Console.WriteLine("3) Secuestro");
            Console.WriteLine("4) Disturbio callejero");
            Console.WriteLine("5) Accidente");
            Console.WriteLine("6) Amenaza de bomba");
            Console.WriteLine("......................................Seleccione la denuncia......................................");
            
             int Opcion = Convert.ToInt32(Console.ReadLine());

            if (Opcion <= 6 || Opcion >= 1)
            {
                return Opcion;
            }
        
            else
            {
                Console.WriteLine("Respire repitame el inconveniente");
                opciones();
                return 77;
                
            }
        }

        private static void GenerarDenuncias(IEfectivoDeGot eg)
        {
            int Opcion = opciones();
            switch (Opcion)
                {

                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("Procederemos a atender el robo un momento por favor");
                        eg.DenunciaRobo();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("L@ encontraremos tranquilizate, nuestros ajentes trabajaran en ello");
                        eg.DenunciaAsesinato();
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Atenderemos el homicidio ,procure no adulterar la zona del crimen");
                        eg.DenunciaSecuestro();
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Intentaremos atender la demanda procure despejar la zona con calma");
                        eg.DenunciaDisturbiosCallejeros();
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Intentaremos atender ,el paciente esta conciente? despeje el lugar y espere nuestros refuersos");
                        eg.DenunciaAccidente();
                        break;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("Procure no acercarse al lugar contactare al personal indicado");
                        eg.DenunciaAmenazadeBomba();
                        break;


                } 
            
           

        }


        ///********************************************************************************************************
        /// El código aquí debajo no debe ser modificado

        public static void Main(string[] args)
        {
            //IEfectivoDeGot eg = CrearDepartamentoDePolicia();

            //GenerarDenuncias(eg);

            //Console.Write("Programa finalizado correctamente . . . ");
            //Console.ReadKey(true);


            ////
            ///// ///probar chain of responsability
            AManejador ef = new ConOficiales(null, null);
            ef = new ConOficiales("Pepe", ef);
            ef = new ConOficiales("Francisco", ef);
            ef = new ConPerito("Elias", ef);
            ef = new ConOficiales("JOSE", ef);
            GenerarDenuncias(ef);
            GenerarDenuncias(ef);
            GenerarDenuncias(ef);
            GenerarDenuncias(ef);

            Console.ReadKey();
        }
    }
}


