using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Hito
    {
        public int HiCodigo { get; set; }
        public string? HiFecha { get; set; }
        public string? HiDescripcion { get; set; }
        public decimal? HiValor { get; set; }
        public string? HiObservacion { get; set; }
        public DateTime? HiFechaRecordatorio { get; set; }
        public int AsuCodigo { get; set; }

        public virtual Asunto AsuCodigoNavigation { get; set; } = null!;
    }
}
