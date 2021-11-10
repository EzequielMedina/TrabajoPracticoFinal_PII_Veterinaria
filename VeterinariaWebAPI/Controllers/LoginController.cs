using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaAtencionBack.Negocio;
using VeterinariaLoginBack.Dominio;
using VeterinariaLoginBack.Negocio.interfaces;
using VeterinariaLoginBack.servicio.implementacion;

namespace VeterinariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private ILoginService app;


        public LoginController()
        {
            app = new LoginService();
        }
        [HttpPost("Validar")]
        public IActionResult GetValidar(Veterinario oVeterinario)
        {
            if (oVeterinario == null)
                return BadRequest();

            if (app.ValidarUsuario(oVeterinario))
                return Ok("OK");
            else
                return Ok("No se Puedo Registrar");

        }

        [HttpPost("RecuperarContraseña")]
        public IActionResult GetRecuperarContraseña(Veterinario oVeterinario)
        {
            if (oVeterinario == null)
                return BadRequest();
            if (app.RecuperarContraseña(oVeterinario))
                return Ok("OK");
            else
                return Ok("No se Puedo Recuperar Contraseña");

        }
        [HttpPost("RegistrarUsuario")]
        public IActionResult GetRegistrarUsuario(Veterinario oVeterinario)
        {
            if (oVeterinario == null)
                return BadRequest();

            if (app.RegistrarUsuario(oVeterinario))
                return Ok("OK");
            else
                return Ok("No se Puedo Registrar");

        }
        [HttpGet("CboDomicilio")]
        public IActionResult GetDomicilio()
        {
            return Ok(app.CargarComboDomicilio("Domicilio"));


        }
        [HttpGet("CboLocalidad")]
        public IActionResult GetLocalidad()
        {

            return Ok(app.CargarComboLocalidad("Localidad"));

        }

        [HttpGet("CboTipo")]
        public IActionResult GetTipo()
        {

            return Ok(app.CargarComboTipo("Tipo"));

        }

    }
}
