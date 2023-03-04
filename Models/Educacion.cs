using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Educacion
    {
        public int EdCodigo { get; set; }
        public string? EdTipo { get; set; }
        public string? EdNivel { get; set; }
        public string? EdPlantel { get; set; }
        public string? EdCiudad { get; set; }
        public DateTime? EdInicio { get; set; }
        public DateTime? EdFin { get; set; }
        public string? EdTitulo { get; set; }
        public string? EdFinalizado { get; set; }
        public string? EdDescripcion { get; set; }
        public string? EdEstado { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
    }
}
