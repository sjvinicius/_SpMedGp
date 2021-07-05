using spmedgpAPI.Contexts;
using spmedgpAPI.Domains;
using spmedgpAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        spmedgpContext ctx = new spmedgpContext();

        public void AtualizarUsuarioEmail(string email, Usuario usuarioAtt)
        {
            Usuario usuarioBuscado = BuscarUsuarioEmail(email);

            if (usuarioAtt.Consulta != null)
            {

                usuarioBuscado.Consulta = usuarioAtt.Consulta;

            }
            if (usuarioAtt.Email != null)
            {

                usuarioBuscado.Email = usuarioAtt.Email;

            }
            if (usuarioAtt.IdConsulta != null)
            {

                usuarioBuscado.IdTipoUsuario = usuarioAtt.IdTipoUsuario;

            }
            if (usuarioAtt.Senha != null)
            {

                usuarioBuscado.Senha = usuarioAtt.Senha;

            }

            ctx.Usuarios.Update(usuarioBuscado);

            ctx.SaveChanges();

        }

        public void AtualizarUsuarioId(int id, Usuario usuarioAtt)
        {

            Usuario usuarioBuscado = BuscarUsuarioId(id);

            if (usuarioAtt.Consulta != null)
            {

                usuarioBuscado.Consulta = usuarioAtt.Consulta;

            }
            if (usuarioAtt.Email != null)
            {

                usuarioBuscado.Email = usuarioAtt.Email;

            }
            if (usuarioAtt.IdConsulta != null)
            {

                usuarioBuscado.IdTipoUsuario = usuarioAtt.IdTipoUsuario;

            }
            if (usuarioAtt.Senha != null)
            {

                usuarioBuscado.Senha = usuarioAtt.Senha;

            }

            ctx.Usuarios.Update(usuarioBuscado);

            ctx.SaveChanges();

        }

        public Usuario AuthUsuario(string email, string senha)
        {
            
            return ctx.Usuarios.FirstOrDefault(usuarioBuscado => usuarioBuscado.Email == email && usuarioBuscado.Senha == senha);

        }

        public Usuario BuscarUsuarioEmail(string email)
        {

            return ctx.Usuarios.FirstOrDefault(usuarioBuscado => usuarioBuscado.Email == email);

        }

        public Usuario BuscarUsuarioId(int id)
        {
            
            return ctx.Usuarios.FirstOrDefault(usuarioBuscado => usuarioBuscado.IdUsuario == id);
        
        }

        public void CriarUsuario(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void DeletarUsuarioEmail(string email)
        {

            ctx.Usuarios.Remove(BuscarUsuarioEmail(email));

            ctx.SaveChanges();

        }

        public void DeletarUsuarioId(int id)
        {

            ctx.Usuarios.Remove(BuscarUsuarioId(id));

            ctx.SaveChanges();

        }

        public List<Usuario> ListarUsuario()
        {

            return ctx.Usuarios.ToList();

        }
    }
}
