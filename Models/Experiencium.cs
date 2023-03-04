using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Experiencium
    {
        public int ExCodigo { get; set; }
        public string? ExEmpresa { get; set; }
        public string? ExDireccion { get; set; }
        public string? ExTelefono { get; set; }
        public string? ExCargoinicial { get; set; }
        public decimal? ExSueldoinicial { get; set; }
        public string? ExCargofinal { get; set; }
        public decimal? ExSueldofinal { get; set; }
        public string? ExMotivorenuncia { get; set; }
        public string? ExEstado { get; set; }
        public string? ExDescripcion { get; set; }
        public string? ExTiempo { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
    }
}
