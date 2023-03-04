using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Tarifa
    {
        public Tarifa()
        {
            SubTarifas = new HashSet<SubTarifa>();
        }

        public int TaCodigo { get; set; }
        public string? TaNombre { get; set; }
        public string? TaEstado { get; set; }

        public virtual ICollection<SubTarifa> SubTarifas { get; set; }
    }
}
