using SpMedGroupR1.Contexts;
using SpMedGroupR1.Domains;
using SpMedGroupR1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroupR1.Repositories
{
    public class ConsultumRepository : IConsultumRepository
    {

        SpMedContext ctx = new SpMedContext();

        public void AtualizarConsultaId(int id, Consultum novaConsulta)
        {
            Consultum consultaBuscada = BuscarConsultaId(id);

            if (novaConsulta.Diagnostico != null )
            {

                consultaBuscada.Diagnostico = novaConsulta.Diagnostico;

            }

            if (novaConsulta.RelatorioMedico != null)
            {

                consultaBuscada.RelatorioMedico = novaConsulta.RelatorioMedico;

            }

            if (novaConsulta.DataConsulta != null)
            {

                consultaBuscada.DataConsulta = novaConsulta.DataConsulta;

            }

            ctx.Consulta.Update(consultaBuscada);

            ctx.SaveChanges();


        }

        public Consultum BuscarConsultaData(DateTime dataConsulta)
        {
            throw new NotImplementedException();
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

        public void DeletarConsultaId(int id)
        {
            ctx.Consulta.Remove(BuscarConsultaId(id));

            ctx.SaveChanges();

        }

        public List<Consultum> ListarConsultas()
        {
            return ctx.Consulta.ToList();
        }
    }
}
