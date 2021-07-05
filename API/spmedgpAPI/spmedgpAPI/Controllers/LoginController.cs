using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using spmedgpAPI.Interfaces;
using spmedgpAPI.Repositories;
using spmedgpAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace spmedgpAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {

            _usuarioRepository = new UsuarioRepository();

        }

        [HttpPost]
        public IActionResult AuthUser( LoginViewModel login )
        {

            try
            {

                var usuarioencontrado = _usuarioRepository.AuthUsuario(login.Email , login.Senha);;

                if (usuarioencontrado == null)
                {

                    return NotFound("Esse usuário não existe, verifique se digitou os dados corretamente");

                }

                var claim = new[]
                {

                    new Claim(JwtRegisteredClaimNames.Email, usuarioencontrado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioencontrado.IdTipoUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioencontrado.IdTipoUsuario.ToString()),

                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("CHAVESEGURANCASPMEDGP"));

                var keycript = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(

                    issuer: "spmedgp.webApi",
                    audience: "spmedgp.webApi",
                    claims: claim,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: keycript


                );

                return Ok(new
                {

                    token = new JwtSecurityTokenHandler().WriteToken(token)

                }
                );

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

    }
}
