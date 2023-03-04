using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Curso
    {
        public int CuCodigo { get; set; }
        public string? CuNombre { get; set; }
        public string? CuDescripcion { get; set; }
        public string? CuEstado { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
    }
}
