using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Directorio
    {
        public int DirCodigo { get; set; }
        public string? DirCliente { get; set; }
        public string? DirArea { get; set; }
        public string? DirIndustria { get; set; }
        public string? DirDetalle { get; set; }
        public string? DirCosto { get; set; }
        public string? DirInvolucrados { get; set; }
        public string? DirEncargados { get; set; }
        public string? DirMiembros { get; set; }
        public string? DirOtros { get; set; }
        public string? DirInicio { get; set; }
        public string? DirFin { get; set; }
        public string? DirAdicional { get; set; }
        public string? DirCreado { get; set; }
        public string? DirModificado { get; set; }
        public string? DirRevisado { get; set; }
        public string? DirConfidencial { get; set; }
        public string? DirDescripcion { get; set; }
        public string? DirFechaIngreso { get; set; }
        public string? DirNumeroCaso { get; set; }
        public int EmCodigo { get; set; }

        public virtual Empresa EmCodigoNavigation { get; set; } = null!;
    }
}
