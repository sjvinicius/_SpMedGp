using System;
using System.Collections.Generic;

#nullable disable

namespace spmedgpAPI.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdUsuario { get; set; }
        public int? IdConsulta { get; set; }
        public int? IdTipoUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual Consultum IdConsultaNavigation { get; set; }
        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
