using System;
using System.Collections.Generic;

#nullable disable

namespace spmedgpAPI.Domains
{
    public partial class Consultum
    {
        public Consultum()
        {
            Medicos = new HashSet<Medico>();
            Usuarios = new HashSet<Usuario>();
        }

        public int IdConsulta { get; set; }
        public int? IdSituacao { get; set; }
        public int? IdMedico { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdClinica { get; set; }
        public DateTime? Datacon { get; set; }
        public string RelatorioMedico { get; set; }

        public virtual Clinica IdClinicaNavigation { get; set; }
        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Situacao IdSituacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
