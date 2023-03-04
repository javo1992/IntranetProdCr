using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class EventosSolicitude
    {
        public int EvsCodigo { get; set; }
        public string? EvsDescripcion { get; set; }
        public string? EvsResponsable { get; set; }
        public string? EvsObservacion { get; set; }
        public string? EvsFecha { get; set; }
        public int SoCodigo { get; set; }

        public virtual Solicitude SoCodigoNavigation { get; set; } = null!;
    }
}
