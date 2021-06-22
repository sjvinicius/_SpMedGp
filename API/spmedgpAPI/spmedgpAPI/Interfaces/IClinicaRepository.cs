using spmedgpAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.Interfaces
{
    interface IClinicaRepository
    {

        //CRUD

        //Create

        void CriarClinica(Clinica novaClinica);

        //Read

        List<Clinica> ListarClinica();

        Clinica BuscarClinicaId(int id);

        //Update

        void AtualizarClinicaId(int id, Clinica clinicaATT);

        //Delete

        void DeletarClinicaId(int id);
    }
}
