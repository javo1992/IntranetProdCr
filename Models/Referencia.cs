using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Referencia
    {
        public int ReCodigo { get; set; }
        public string? ReEmpresa { get; set; }
        public string? ReCargo { get; set; }
        public string? ReNombre { get; set; }
        public string? ReDireccion { get; set; }
        public string? ReTelefono { get; set; }
        public string? ReMail { get; set; }
        public string? ReTipo { get; set; }
        public string? ReRelacion { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
    }
}
