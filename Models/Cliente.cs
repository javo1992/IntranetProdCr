using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Asuntos = new HashSet<Asunto>();
            ContactoFacturacions = new HashSet<ContactoFacturacion>();
        }

        public int CliCodigo { get; set; }
        public string? CliNombre { get; set; }
        public string? CliRazonSocial { get; set; }
        public string? CliTipoIdentificacion { get; set; }
        public string? CliIdentificacion { get; set; }
        public string? CliEncargado { get; set; }
        public string? CliComercial { get; set; }
        public string? CliImpuestos { get; set; }
        public string? CliDireccion { get; set; }
        public string? CliPostal { get; set; }
        public string? CliPais { get; set; }
        public string? CliCiudad { get; set; }
        public string? CliTelefono { get; set; }
        public string? CliSolicitante { get; set; }
        public string? CliTelefonoSol { get; set; }
        public string? CliMailSol { get; set; }
        public string? CliDireccionSol { get; set; }
        public string? CliTarifa { get; set; }
        public string? CliDescuento { get; set; }
        public string? CliEstado { get; set; }
        public DateTime? CliFecha { get; set; }
        public int EmCodigo { get; set; }

        public virtual Empresa EmCodigoNavigation { get; set; } = null!;
        public virtual ICollection<Asunto> Asuntos { get; set; }
        public virtual ICollection<ContactoFacturacion> ContactoFacturacions { get; set; }
    }
}
