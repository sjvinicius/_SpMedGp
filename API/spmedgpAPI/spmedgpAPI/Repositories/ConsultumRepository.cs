using Microsoft.EntityFrameworkCore;
using spmedgpAPI.Contexts;
using spmedgpAPI.Domains;
using spmedgpAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.Repositories
{

    public class ConsultumRepository : IConsultumRepository
    {

        spmedgpContext ctx = new spmedgpContext();

        public void AtualizarConsulta(int id, Consultum consultaAtt)
        {
            Consultum buscarConsulta = BuscarConsultaId(id);

            //if (consultaAtt.Datacon != null)
            //{

            //    buscarConsulta.Datacon = consultaAtt.Datacon;

            //}

            if (consultaAtt.IdMedico != null)
            {

                buscarConsulta.IdMedico= consultaAtt.IdMedico;

            }

            if (consultaAtt.IdSituacao != null)
            {

                buscarConsulta.IdSituacao = consultaAtt.IdSituacao;

            }

            if (consultaAtt.IdUsuario != null)
            {

                buscarConsulta.IdUsuario = consultaAtt.IdUsuario;

            }

            if(consultaAtt.RelatorioMedico != null)
            {

                buscarConsulta.RelatorioMedico = consultaAtt.RelatorioMedico;

            };

            ctx.Consulta.Update(buscarConsulta);

            ctx.SaveChanges();

        }

        public Consultum BuscarConsultaId(int id)
        {
            
            return ctx.Consulta.FirstOrDefault(consultabuscada => consultabuscada.IdConsulta == id);
        
        }

        public void CriarConsulta(Consultum novaConsulta)
        {

            ctx.Consulta.Add(novaConsulta);

            ctx.SaveChanges();
        
        }

        public void DeletarConsulta(int id)
        {

            ctx.Consulta.Remove(BuscarConsultaId(id));

            ctx.SaveChanges();

        }

        public List<Consultum> ListarConsultas()
        {
            return ctx.Consulta
                .Include(e => e.IdMedicoNavigation.IdEspecialidadeNavigation)
                .Include(e => e.IdUsuarioNavigation)
                .ToList();
        }

        public List<Consultum> ListarConsultasdoUsuario(int id)
        {
            return ctx.Consulta
                .Include(c => c.Datacon)
                .Include(c => c.IdClinicaNavigation.NomeFantasia)
                .Include(c => c.IdMedicoNavigation.Nome)
                .Include(c => c.IdSituacaoNavigation.TituloSituacao)
                .Include(c => c.RelatorioMedico)
                .Where(c => c.IdUsuario == id)
                .ToList();
        }
    }
}
