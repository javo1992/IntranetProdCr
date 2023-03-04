using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Documento
    {
        public int DocCodigo { get; set; }
        public string? DocTipo { get; set; }
        public string? DocDescripcion { get; set; }
        public DateTime? DocPeriodo { get; set; }
        public string? DocEstado { get; set; }
        public DateTime? DocFecha { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
    }
}
