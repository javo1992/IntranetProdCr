using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Cargos = new HashSet<Cargo>();
        }

        public int DeCodigo { get; set; }
        public string? DeNombre { get; set; }
        public string? DeMail { get; set; }
        public string? DeSucursal { get; set; }
        public string? DeEstado { get; set; }
        public int EmCodigo { get; set; }

        public virtual Empresa EmCodigoNavigation { get; set; } = null!;
        public virtual ICollection<Cargo> Cargos { get; set; }
    }
}
