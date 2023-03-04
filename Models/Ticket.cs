using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            EventosTickets = new HashSet<EventosTicket>();
        }

        public int TicCodigo { get; set; }
        public string? TicTitulo { get; set; }
        public string? TicDescripcion { get; set; }
        public string? TicTipo { get; set; }
        public string? TicPrioridad { get; set; }
        public string? TicTecnico { get; set; }
        public string? TicUsuario { get; set; }
        public int? TicCalificacion { get; set; }
        public string? TicInicio { get; set; }
        public string? TicTiempo { get; set; }
        public string? TicEstado { get; set; }
        public string? TicFin { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
        public virtual ICollection<EventosTicket> EventosTickets { get; set; }
    }
}
