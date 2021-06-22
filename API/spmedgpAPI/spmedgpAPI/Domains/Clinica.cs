using System;
using System.Collections.Generic;

#nullable disable

namespace spmedgpAPI.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int IdClinica { get; set; }
        public string Endereco { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }

        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
