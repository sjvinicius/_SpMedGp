using SpMedGroupR1.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroupR1.Interfaces
{
    interface IConsultumRepository
    {

        //CRUD

        //CREATE

        void CriarConsulta(Consultum novaConsulta);

        // READ

        List<Consultum> ListarConsultas();

        Consultum BuscarConsultaData(DateTime dataConsulta);

        Consultum BuscarConsultaId(int id);


        //Update

        void AtualizarConsultaId(int id, Consultum novaConsulta);

        //DELETE

        void DeletarConsultaId(int id);

    }
}
