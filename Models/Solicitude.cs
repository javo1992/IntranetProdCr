using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Solicitude
    {
        public Solicitude()
        {
            EventosSolicitudes = new HashSet<EventosSolicitude>();
        }

        public int SoCodigo { get; set; }
        public string? SoTipo { get; set; }
        public string? SoOtros { get; set; }
        public string? SoMotivo { get; set; }
        public string? SoDetalle { get; set; }
        public decimal? SoPrestamoCantidad { get; set; }
        public int? SoPrestamoCuotas { get; set; }
        public decimal? SoPrestamoValor { get; set; }
        public string? SoPermisoDesde { get; set; }
        public string? SoPermisoHasta { get; set; }
        public string? SoAusenciaDesde { get; set; }
        public string? SoAusenciaHasta { get; set; }
        public string? SoAusenciaRetorno { get; set; }
        public string? SoPersonalCargo { get; set; }
        public int? SoPersonalCupos { get; set; }
        public string? SoPersonalSueldo { get; set; }
        public string? SoPersonalContrato { get; set; }
        public string? SoPersonalArea { get; set; }
        public string? SoPersonalSucursal { get; set; }
        public string? SoPersonalMotivo { get; set; }
        public string? SoPersonalReemplaza { get; set; }
        public string? SoPersonalTiempo { get; set; }
        public string? SoPersonalJornada { get; set; }
        public string? SoPersonalInicio { get; set; }
        public string? SoPersonalObservacion { get; set; }
        public string? SoPersonalJefe { get; set; }
        public string? SoEstado { get; set; }
        public DateTime? SoFecha { get; set; }
        public int UsCodigo { get; set; }

        public virtual Usuario UsCodigoNavigation { get; set; } = null!;
        public virtual ICollection<EventosSolicitude> EventosSolicitudes { get; set; }
    }
}
