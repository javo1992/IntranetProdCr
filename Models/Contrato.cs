using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Contrato
    {
        public int CoCodigo { get; set; }
        public string? CoTipo { get; set; }
        public DateTime? CoInicio { get; set; }
        public DateTime? CoFin { get; set; }
        public decimal? CoSueldo { get; set; }
        public decimal? CoBono { get; set; }
        public string? CoMotivoSalida { get; set; }
        public decimal? CoLiquidacion { get; set; }
        public string? CoObservacion { get; set; }
        public string? CoEstado { get; set; }
        public string? CoUbicacion { get; set; }
        public string? CoExtension { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
    }
}
