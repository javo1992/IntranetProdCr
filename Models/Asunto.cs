using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Asunto
    {
        public Asunto()
        {
            EventosAsuntos = new HashSet<EventosAsunto>();
            Hitos = new HashSet<Hito>();
        }

        public int AsuCodigo { get; set; }
        public string? AsuTitulo { get; set; }
        public string? AsuIdioma { get; set; }
        public string? AsuCategoria { get; set; }
        public string? AsuArea { get; set; }
        public string? AsuSucursal { get; set; }
        public string? AsuResponsable { get; set; }
        public string? AsuDescripcion { get; set; }
        public string? AsuMoneda { get; set; }
        public string? AsuFormaLiquidacion { get; set; }
        public string? AsuFeeMonto { get; set; }
        public string? AsuFeePeriodicidad { get; set; }
        public decimal? AsuMontoMaximo { get; set; }
        public int? AsuHorasMaximo { get; set; }
        public string? AsuDetalleCobranza { get; set; }
        public string? AsuEstado { get; set; }
        public string? AsuCliente { get; set; }
        public string? AsuTarifa { get; set; }
        public string? AsuNombreSol { get; set; }
        public string? AsuMailSol { get; set; }
        public string? AsuDireccionSol { get; set; }
        public string? AsuTelefonoSol { get; set; }
        public string? AsuCobrable { get; set; }
        public string? AsuDescuento { get; set; }
        public string? AsuImpuestos { get; set; }
        public string? AsuCodigoSecundario { get; set; }
        public string? AsuCreador { get; set; }
        public int CliCodigo { get; set; }

        public virtual Cliente CliCodigoNavigation { get; set; } = null!;
        public virtual ICollection<EventosAsunto> EventosAsuntos { get; set; }
        public virtual ICollection<Hito> Hitos { get; set; }
    }
}
