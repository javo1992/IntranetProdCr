using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Familiare
    {
        public int FaCodigo { get; set; }
        public string? FaIdentificacion { get; set; }
        public string? FaNombres { get; set; }
        public string? FaRelacion { get; set; }
        public string? FaNacimiento { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
    }
}
