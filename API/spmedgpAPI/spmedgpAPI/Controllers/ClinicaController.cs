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
    public class ClinicaController : ControllerBase
    {

        private IClinicaRepository _clinicaRepository { get; set; }

        public ClinicaController()
        {

            _clinicaRepository = new ClinicaRepository();

        }

        [HttpPut("{id}")]
        public IActionResult UpdateId(int id, Clinica clinicaATT)
        {

            try
            {

                _clinicaRepository.AtualizarClinicaId(id, clinicaATT);

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

                return Ok(_clinicaRepository.BuscarClinicaId(id));

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            
            }

        }

        [HttpPost]
        public IActionResult CreateClinica(Clinica novaClinica) {

            try
            {

                _clinicaRepository.CriarClinica(novaClinica);

                return StatusCode(201);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

        [HttpGet]
        public IActionResult ListClinicas()
        {

            try
            {

                return Ok(_clinicaRepository.ListarClinica());

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

                _clinicaRepository.DeletarClinicaId(id);

                return StatusCode(204);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

    }
}
