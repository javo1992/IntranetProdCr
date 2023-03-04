using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class ContactoFacturacion
    {
        public int CofCodigo { get; set; }
        public string? CofNombre { get; set; }
        public string? CofTelefono { get; set; }
        public string? CofMail { get; set; }
        public string? CofDireccion { get; set; }
        public string? CofEstado { get; set; }
        public int CliCodigo { get; set; }

        public virtual Cliente CliCodigoNavigation { get; set; } = null!;
    }
}
