using System;
using System.Collections.Generic;

#nullable disable

namespace SpMedGroupR1.Domains
{
    public partial class Consultum
    {
        public Consultum()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdConsulta { get; set; }
        public int? IdPaciente { get; set; }
        public int? IdSituacao { get; set; }
        public byte[] DataConsulta { get; set; }
        public string Diagnostico { get; set; }
        public string RelatorioMedico { get; set; }

        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Situacao IdSituacaoNavigation { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
