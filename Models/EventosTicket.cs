using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class EventosTicket
    {
        public int EvtCodigo { get; set; }
        public string? EvtDescripcion { get; set; }
        public string? EvtResponsable { get; set; }
        public string? EvtObservacion { get; set; }
        public string? EvtFecha { get; set; }
        public int TicCodigo { get; set; }
        public int? UsCodigo { get; set; }
        public int? EmCodigo { get; set; }
        public string? Id { get; set; }

        public virtual Ticket TicCodigoNavigation { get; set; } = null!;
    }
}
