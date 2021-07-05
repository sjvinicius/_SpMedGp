using spmedgpAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.Interfaces
{
    interface IUsuarioRepository
    {

        //CRUD 

        //Create

        void CriarUsuario(Usuario novoUsuario);

        //Read

        List<Usuario> ListarUsuario();

        Usuario BuscarUsuarioId(int id);

        Usuario BuscarUsuarioEmail(string email);

        Usuario AuthUsuario(string email, string senha);

        //Update

        void AtualizarUsuarioId(int id, Usuario usuarioAtt);

        void AtualizarUsuarioEmail(string email, Usuario usuarioAtt);

        //Delete

        void DeletarUsuarioId(int id);

        void DeletarUsuarioEmail(string email);

    }
}
