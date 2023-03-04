using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Cargo
    {
        public int CaCodigo { get; set; }
        public string? CaNombre { get; set; }
        public string? CaEstado { get; set; }
        public int DeCodigo { get; set; }

        public virtual Departamento DeCodigoNavigation { get; set; } = null!;
    }
}
