using SpMedGroupR1.Contexts;
using SpMedGroupR1.Domains;
using SpMedGroupR1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroupR1.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {

        SpMedContext ctx = new SpMedContext();

        public void AtualizaClinicaId(int id, Clinica clinicaAtt)
        {

            Clinica clinicaBuscada = BuscarClinicaId(id);

            if (clinicaAtt.CNpj != null)
            {

                clinicaBuscada.CNpj = clinicaAtt.CNpj;

            }

            if (clinicaAtt.Ceo != null)
            {

                clinicaBuscada.Ceo = clinicaAtt.Ceo;

            }

            if (clinicaAtt.Endereco != null)
            {

                clinicaBuscada.Endereco = clinicaAtt.Endereco;

            }

            if (clinicaAtt.Medicos != null)
            {

                clinicaBuscada.Medicos = clinicaAtt.Medicos;

            }

            if (clinicaAtt.Nome != null)
            {

                clinicaBuscada.Nome = clinicaAtt.Nome;

            }

            if (clinicaAtt.RazaoSocial != null)
            {

                clinicaBuscada.RazaoSocial = clinicaAtt.RazaoSocial;

            }

            ctx.Clinicas.Update(clinicaBuscada);

            ctx.SaveChanges();

        }

        public void AtualizarClinicaNome(string nome, Clinica clinicaAtt)
        {

            Clinica clinicaBuscada = BuscarClinicaNome(nome);

            if (clinicaAtt.CNpj != null)
            {

                clinicaBuscada.CNpj = clinicaAtt.CNpj;

            }

            if (clinicaAtt.Ceo != null)
            {

                clinicaBuscada.Ceo = clinicaAtt.Ceo;

            }

            if (clinicaAtt.Endereco != null)
            {

                clinicaBuscada.Endereco = clinicaAtt.Endereco;

            }

            if (clinicaAtt.Medicos != null)
            {

                clinicaBuscada.Medicos = clinicaAtt.Medicos;

            }

            if (clinicaAtt.Nome != null)
            {

                clinicaBuscada.Nome = clinicaAtt.Nome;

            }

            if (clinicaAtt.RazaoSocial != null)
            {

                clinicaBuscada.RazaoSocial = clinicaAtt.RazaoSocial;

            }

            ctx.Clinicas.Update(clinicaAtt);

            ctx.SaveChanges();

        }

        public Clinica BuscarClinicaId(int id)
        {
            
            return ctx.Clinicas.FirstOrDefault(clinica => clinica.IdClinica == id);

        }

        public Clinica BuscarClinicaNome(string nome)
        {
        
            return ctx.Clinicas.FirstOrDefault(clinica => clinica.Nome == nome);
        
        }

        public void CriarClinica(Clinica novaClinica)
        {

            ctx.Clinicas.Add(novaClinica);

            ctx.SaveChanges();

        }

        public void DeletarClinicaId(int id)
        {

            Clinica clinicaBuscada = BuscarClinicaId(id);

            ctx.Clinicas.Remove(clinicaBuscada);

            ctx.SaveChanges();

        }

        public void DeletarClinicaNome(string nome)
        {

            Clinica clinicaBuscada = BuscarClinicaNome(nome);

            ctx.Clinicas.Remove(clinicaBuscada);

            ctx.SaveChanges();

        }

        public List<Clinica> ListarClinicas()
        {
            return ctx.Clinicas.ToList();   
        }
    }
}
