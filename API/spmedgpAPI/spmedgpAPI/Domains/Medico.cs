using System;
using System.Collections.Generic;

#nullable disable

namespace spmedgpAPI.Domains
{
    public partial class Medico
    {
        public Medico()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdMedico { get; set; }
        public int? IdConsulta { get; set; }
        public int? IdEspecialidade { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }

        public virtual Consultum IdConsultaNavigation { get; set; }
        public virtual Especialidade IdEspecialidadeNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
