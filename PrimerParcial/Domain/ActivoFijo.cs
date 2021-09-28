using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ActivoFijo
    {
       public int ID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal ValorActivo { get; set; }
        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public TipoActivo tipoActivo { get; set; }
        public MetodoDepreciacion metodoDepreciacion { get; set; }
    }
}
