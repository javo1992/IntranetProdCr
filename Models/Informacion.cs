using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Informacion
    {
        public int InfCodigo { get; set; }
        public string? InfOrigen { get; set; }
        public string? InfGenero { get; set; }
        public string? InfIdentificacion { get; set; }
        public string? InfEtnia { get; set; }
        public string? InfSangre { get; set; }
        public string? InfProvincia { get; set; }
        public string? InfCiudad { get; set; }
        public string? InfDireccion { get; set; }
        public string? InfTelefono { get; set; }
        public string? InfMail { get; set; }
        public string? InfEstadoCivil { get; set; }
        public string? InfLugarNacimiento { get; set; }
        public DateTime? InfFechaNacimiento { get; set; }
        public string? InfDiscapacidad { get; set; }
        public int? InfPorcentajeDiscapacidad { get; set; }
        public string? InfNombreContacto { get; set; }
        public string? InfTelefonoContacto { get; set; }
        public string? InfRelacion { get; set; }
        public string? InfObservaciones { get; set; }
        public string? InfMigranteRetornado { get; set; }
        public string? InfEstado { get; set; }
        public byte[]? InfFoto { get; set; }
        public string? InfNombreFoto { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
    }
}
