using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using spmedical_API.Domains;
using spmedical_API.Interfaces;
using spmedical_API.Repositories;
using spmedical_API.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace spmedical_API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private IUsuarioSPRepository _usuarioSPRepository { get; set; }

        public LoginController()
        {
            _usuarioSPRepository = new UsuarioSPRepository();
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                UsuarioSp usuarioSPBuscado = _usuarioSPRepository.Login(login.Email, login.Senha);

                if (usuarioSPBuscado == null)
                {
                    return BadRequest("Email ou Senha inválidos!");
                }

                var minhasClaims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioSPBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioSPBuscado.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Role, usuarioSPBuscado.IdTipoUsuario.ToString()),
                }; 

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("SPMedical-Chave-Autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var meuToken = new JwtSecurityToken(
                        issuer:             "SPMedical",
                        audience:           "SPMedical",
                        claims:             minhasClaims,
                        expires:            DateTime.Now.AddMinutes(30),
                        signingCredentials: creds
                    );

                return Ok(new { 
                    token = new JwtSecurityTokenHandler().WriteToken(meuToken)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
