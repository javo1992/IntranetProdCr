using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IntranetProdCr.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Contratos = new HashSet<Contrato>();
            Cursos = new HashSet<Curso>();
            Documentos = new HashSet<Documento>();
            Educacions = new HashSet<Educacion>();
            Experiencia = new HashSet<Experiencium>();
            Familiares = new HashSet<Familiare>();
            Informacions = new HashSet<Informacion>();
            Referencia = new HashSet<Referencia>();
            Solicitudes = new HashSet<Solicitude>();
            Tickets = new HashSet<Ticket>();
        }

        public int UsCodigo { get; set; }
        public string? UsNombre1 { get; set; }
        public string? UsNombre2 { get; set; }
        public string? UsNombre3 { get; set; }
        public string? UsApellido1 { get; set; }
        public string? UsApellido2 { get; set; }
        public string? UsEstado { get; set; }
        public string? UsActivo { get; set; }
        public string? UsJefe { get; set; }
        public string? UsGerencia { get; set; }
        public string? UsCambio { get; set; }
        public string? UsTerminos { get; set; }
        public int EmCodigo { get; set; }
        public string? Id { get; set; } = null!;

        public virtual Empresa EmCodigoNavigation { get; set; } = null!;
        public virtual AspNetUser IdNavigation { get; set; } = null!;
        public virtual ICollection<Contrato> Contratos { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
        public virtual ICollection<Educacion> Educacions { get; set; }
        public virtual ICollection<Experiencium> Experiencia { get; set; }
        public virtual ICollection<Familiare> Familiares { get; set; }
        public virtual ICollection<Informacion> Informacions { get; set; }
        public virtual ICollection<Referencia> Referencia { get; set; }
        public virtual ICollection<Solicitude> Solicitudes { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
