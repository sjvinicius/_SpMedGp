using spmedgpAPI.Contexts;
using spmedgpAPI.Domains;
using spmedgpAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {

        spmedgpContext ctx = new spmedgpContext();

        public void AtualizarClinicaId(int id, Clinica clinicaATT)
        {
            Clinica clinicaBuscada = BuscarClinicaId(id);

            if (clinicaATT.Cnpj != null)
            {

                clinicaBuscada.Cnpj = clinicaATT.Cnpj;

            }
            if (clinicaATT.Endereco != null)
            {

                clinicaBuscada.Endereco = clinicaATT.Endereco;

            }
            if (clinicaATT.NomeFantasia != null)
            {

                clinicaBuscada.NomeFantasia = clinicaATT.NomeFantasia;

            }
            if (clinicaATT.RazaoSocial != null)
            {

                clinicaBuscada.RazaoSocial = clinicaATT.RazaoSocial;

            }

            ctx.Clinicas.Update(clinicaBuscada);

            ctx.SaveChanges();

        }

        public Clinica BuscarClinicaId(int id)
        {

            return ctx.Clinicas.FirstOrDefault(clinicabuscada => clinicabuscada.IdClinica == id);

        }

        public void CriarClinica(Clinica novaClinica)
        {

            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();

        }

        public void DeletarClinicaId(int id)
        {

            ctx.Clinicas.Remove(BuscarClinicaId(id));

            ctx.SaveChanges();

        }

        public List<Clinica> ListarClinica()
        {

            return ctx.Clinicas.ToList();

        }
    }
}
