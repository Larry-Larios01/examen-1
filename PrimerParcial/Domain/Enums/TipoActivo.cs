using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Enums
{
    public enum TipoActivo
    {
        Edificio = 20,
        Vehiculo = 5,
        Maquinaria = 3,
        Mobiliario = 2,
        EquipoComputo = 1
    }
    public enum MetodoDepreciacion
    {
        LineaRecta,
        Incremental
    }
}
