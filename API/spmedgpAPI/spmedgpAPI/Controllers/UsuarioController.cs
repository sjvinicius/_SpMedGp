using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using spmedgpAPI.Domains;
using spmedgpAPI.Interfaces;
using spmedgpAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {

            _usuarioRepository = new UsuarioRepository();

        }

        [HttpPut("{id}")]
        public IActionResult AtualizarId(int id, Usuario usuarioAtt)
        {

            try
            {

                _usuarioRepository.AtualizarUsuarioId(id, usuarioAtt);

                return StatusCode(200);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

        [HttpGet("{email}")]
        public IActionResult BuscarEmail(string email)
        {

            try
            {

                return Ok(_usuarioRepository.BuscarUsuarioEmail(email));

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
                
            }

        }

        [HttpPost]
        public IActionResult CriarConsulta(Usuario novoUsuario)
        {

            try
            {

                _usuarioRepository.CriarUsuario(novoUsuario);

                return StatusCode(201);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpGet("id/{id}")]
        public IActionResult BuscarId(int id)
        {

            try
            {

                return Ok(_usuarioRepository.BuscarUsuarioId(id));

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

        [HttpDelete("id/{id}")]
        public IActionResult DeletarId(int id)
        {

            try
            {

                _usuarioRepository.DeletarUsuarioId(id);

                return StatusCode(204);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpDelete("{email}")]
        public IActionResult DeletarEmail(string email) {

            try
            {

                _usuarioRepository.DeletarUsuarioEmail(email);

                return StatusCode(204);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

        [HttpGet]
        public IActionResult ListarUsuarios()
        {

            try
            {

                return Ok(_usuarioRepository.ListarUsuario());

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

    }
}
