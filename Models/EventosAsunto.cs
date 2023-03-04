using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class EventosAsunto
    {
        public int EvaCodigo { get; set; }
        public string? EvaDescripcion { get; set; }
        public string? EvaResponsable { get; set; }
        public string? EvaObservacion { get; set; }
        public string? EvaFecha { get; set; }
        public int AsuCodigo { get; set; }

        public virtual Asunto AsuCodigoNavigation { get; set; } = null!;
    }
}
