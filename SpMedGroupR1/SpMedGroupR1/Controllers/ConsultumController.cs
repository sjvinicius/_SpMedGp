using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpMedGroupR1.Domains;
using SpMedGroupR1.Interfaces;
using SpMedGroupR1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroupR1.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultumController : ControllerBase
    {

        private IConsultumRepository _ConsultumRepository { get; set; }

        public ConsultumController()
        {
            _ConsultumRepository = new ConsultumRepository();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarConsulta(int id, Consultum novaConsulta)
        {

            try
            {

                _ConsultumRepository.AtualizarConsultaId(id, novaConsulta);


                return StatusCode(200);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

        [HttpGet("{id}")]
        public IActionResult BuscarId(int id)
        {

            try
            {

                return Ok(_ConsultumRepository.BuscarConsultaId(id));

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpPost]
        public IActionResult CriarConsulta(Consultum novaConsulta)
        {

            try
            {
                _ConsultumRepository.CriarConsulta(novaConsulta);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
                
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeletarConsulta(int id)
        {

            try
            {

                _ConsultumRepository.DeletarConsultaId(id);

                return StatusCode(204);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

        [HttpGet]
        public IActionResult ListarConsultas()
        {

            try
            {

                ;

                return Ok( _ConsultumRepository.ListarConsultas() );

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

    }
}
