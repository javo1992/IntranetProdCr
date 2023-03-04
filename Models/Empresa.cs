using System;
using System.Collections.Generic;

namespace IntranetProdCr.Models
{
    public partial class Empresa
    {
        public Empresa()
        {
            Clientes = new HashSet<Cliente>();
            Contactos = new HashSet<Contacto>();
            Departamentos = new HashSet<Departamento>();
            Directorios = new HashSet<Directorio>();
            Usuarios = new HashSet<Usuario>();
        }

        public int EmCodigo { get; set; }
        public string? EmNombre { get; set; }
        public string? EmRazonSocial { get; set; }
        public string? EmRuc { get; set; }
        public string? EmEstado { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<Contacto> Contactos { get; set; }
        public virtual ICollection<Departamento> Departamentos { get; set; }
        public virtual ICollection<Directorio> Directorios { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
