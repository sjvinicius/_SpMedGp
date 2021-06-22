using spmedgpAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.Interfaces
{
    interface IConsultumRepository
    {

        //CRUD

        //Create

        void CriarConsulta(Consultum novaConsulta);

        //Read

        List<Consultum> ListarConsultas();

        Consultum BuscarConsultaId(int id);


        //Update

        void AtualizarConsulta(int id, Consultum consultaAtt);

        //Dekete

        void DeletarConsulta(int id);

    }
}
