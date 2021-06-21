using System;
using System.Collections.Generic;

#nullable disable

namespace SpMedGroupR1.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdClinica { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Ceo { get; set; }
        public string CNpj { get; set; }
        public string RazaoSocial { get; set; }

        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
