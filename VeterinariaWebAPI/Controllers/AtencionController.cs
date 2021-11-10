using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaAtencionBack.Dominio;
using VeterinariaAtencionBack.Negocio;
using VeterinariaAtencionBack.Negocio.implementacion;
using VeterinariaAtencionBack.Negocio.interfaces;

namespace VeterinariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AtencionController : Controller
    {
        public IAtencionService app;


        public AtencionController()
        {
            app = new AtencionesService();
        }

        [HttpGet("Atenciones")]

        public IActionResult ConsultarAtenciones(List<Parametro> filtros)
        {
            if (filtros == null)
                return BadRequest();
            else
            {
                return Ok(app.ConsultarAtenciones(filtros));
            } 
      
        }

        [HttpPost("EliminarAtencion")]
        public IActionResult EliminarAtencion(int id)
        {

            return Ok(app.EliminarAtencion(id));
           
        }


        [HttpGet("GetClientes")]
        public IActionResult GetClientes()
        {          
           return BadRequest(app.GetClientes()); 
        }

        [HttpGet("{id}")]
        public IActionResult GetMascotas(int id)
        {
            if (id == 0)
                return BadRequest("Id es requerido!");
            return Ok(app.GetMascotas(id));
        }

        [HttpGet("GetProximaAtencion")]
        public IActionResult GetProximaAtencion()
        {

            return Ok(app.GetProximaAtencion());
        }

        [HttpPost("SaveAtenciones")]
        public IActionResult SaveAtenciones(Atencion oAtencion)
        {
            if (oAtencion == null)
            {
                return BadRequest();
            }

            if (app.SaveAtenciones(oAtencion))
                return Ok("Ok");
            else
                return Ok("No se pudo grabar la Atencion!");
        }
    

        [HttpGet("GetAtencion")]
        public IActionResult GetAtencion(int id)
        {
            return Ok(app.GetAtencion(id));
        }

        [HttpPost]
        public IActionResult UpdateAtencion(Atencion oAtencion)
        {
            return Ok(app.UpdateAtencion(oAtencion));
        }


    }
}
