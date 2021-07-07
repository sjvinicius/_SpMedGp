using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using spmedgpAPI.Domains;
using spmedgpAPI.Interfaces;
using spmedgpAPI.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace spmedgpAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultumController : ControllerBase
    {

        private IConsultumRepository _consultumRepository { get; set; }

        public ConsultumController()
        {
            _consultumRepository = new ConsultumRepository();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateId(int id, Consultum consultaAtt) {

            try
            {

                _consultumRepository.AtualizarConsulta(id, consultaAtt);

                return StatusCode(200);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpGet("{id}")]
        public IActionResult FindId(int id)
        {

            try
            {

                return Ok(_consultumRepository.BuscarConsultaId(id));

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpPost]
        public IActionResult CreateConsulta(Consultum novaConsulta)
        {

            try
            {

                _consultumRepository.CriarConsulta(novaConsulta);

                return StatusCode(201);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteId(int id)
        {   

            try
            {

                _consultumRepository.DeletarConsulta(id);

                return StatusCode(204);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpGet]
        public IActionResult ListConsulta()
        {

            try
            {

                return Ok(_consultumRepository.ListarConsultas());

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpGet("minhas")]
        public IActionResult ListConsultasUsers(int id)
        {
            try
            {
                int idusuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

                return Ok(_consultumRepository.ListarConsultasdoUsuario(idusuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            
            }

        }
    }
}
