using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_2._0
{
    interface IEfectivoDeGot
    {
        // Se deberá usar esta interface para implementar los distintos actores del departamento de policía de Got
        void DenunciaRobo();
        void DenunciaAsesinato();
        void DenunciaAccidente();
        void DenunciaSecuestro();
        void DenunciaAmenazadeBomba();
        void DenunciaDisturbiosCallejeros();
    }
}
