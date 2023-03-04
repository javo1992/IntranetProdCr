using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class SubTarifa
    {
        public int SutCodigo { get; set; }
        public string? SutCategoria { get; set; }
        public decimal? SutTarifa { get; set; }
        public string? SutMoneda { get; set; }
        public string? SutEstado { get; set; }
        public int TaCodigo { get; set; }

        public virtual Tarifa TaCodigoNavigation { get; set; } = null!;
    }
}
