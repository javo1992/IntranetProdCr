using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Contacto
    {
        public int CoCodigo { get; set; }
        public string? CoNombre { get; set; }
        public string? CoApellido { get; set; }
        public string? CoEmpresa { get; set; }
        public string? CoTelefono { get; set; }
        public string? CoDireccion { get; set; }
        public string? CoPais { get; set; }
        public string? CoCreador { get; set; }
        public string? CoFecha { get; set; }
        public string? CoEstado { get; set; }
        public int EmCodigo { get; set; }

        public virtual Empresa EmCodigoNavigation { get; set; } = null!;
    }
}
