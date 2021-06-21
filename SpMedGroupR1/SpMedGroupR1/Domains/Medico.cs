using System;
using System.Collections.Generic;

#nullable disable

namespace SpMedGroupR1.Domains
{
    public partial class Medico
    {
        public int IdMedico { get; set; }
        public int? IdConsulta { get; set; }
        public int? IdClinica { get; set; }
        public int? IdEspecialidade { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }

        public virtual Clinica IdClinicaNavigation { get; set; }
        public virtual Consultum IdConsultaNavigation { get; set; }
        public virtual Especialidade IdEspecialidadeNavigation { get; set; }
    }
}
