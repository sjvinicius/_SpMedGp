using SpMedGroupR1.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroupR1.Interfaces
{
    interface IClinicaRepository
    {

        //CRUD

        //Create
        void CriarClinica(Clinica novaClinica);

        //Read

        List<Clinica> ListarClinicas();


        Clinica BuscarClinicaId(int id);

        Clinica BuscarClinicaNome(string nome);

        //Update

        void AtualizaClinicaId(int id, Clinica clinicaAtt);

        void AtualizarClinicaNome(string nome, Clinica clinicaAtt);

        //Delete

        void DeletarClinicaId(int id);

        void DeletarClinicaNome(string nome);

    }
}
