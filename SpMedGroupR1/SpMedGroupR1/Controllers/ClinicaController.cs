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
    public class ClinicaController : ControllerBase
    {

        private IClinicaRepository _clinicaRepository { get; set; }

        public ClinicaController()
        {

            _clinicaRepository = new ClinicaRepository();

        }

        [HttpPut("{id}")]
        public IActionResult AtualizarId(int id, Clinica novaClinica)
        {

            try
            {

                _clinicaRepository.AtualizaClinicaId(id, novaClinica);

                return StatusCode(200);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

        [HttpPut("nome/{nome}")]
        public IActionResult AtualizarNome(string nome, Clinica novaClinica)
        {

            try
            {

                _clinicaRepository.AtualizarClinicaNome(nome, novaClinica);

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

        [HttpGet("nome/{nome}")]
        public IActionResult FindName(string nome)
        {

            try
            {

                return Ok(_clinicaRepository.BuscarClinicaNome(nome));

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }            

        }   
        
        [HttpPost]
        public IActionResult Create(Clinica novaClinica)
        {

            try
            {
                
                _clinicaRepository.CriarClinica(novaClinica);

                return StatusCode(200);

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

        [HttpDelete("nome/{nome}")]
        public IActionResult Deletenome(string nome)
        {

            try
            {

                _clinicaRepository.DeletarClinicaNome(nome);

                return StatusCode(204);

            }
            catch (Exception ex)
            {

                return BadRequest(ex);

            }

        }

        [HttpGet]
        public IActionResult List()
        {

            try
            {
                
                return Ok(_clinicaRepository.ListarClinicas());

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
                
            }

        }

    }
}
