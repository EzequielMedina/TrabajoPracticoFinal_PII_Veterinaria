using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinariaMascotaBack.Dominio;
using VeterinariaMascotaBack.Negocio.implementacion;
using VeterinariaMascotaBack.Negocio.interfaces;

namespace VeterinariaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MascotaController : ControllerBase
    {
        public IMascotaService app;


        public MascotaController()
        {
            app = new MascotaService();
        }


        [HttpGet("Mascotas")]
        public IActionResult GetSaveMascota(Mascota oMascota)
        {
            if (oMascota == null)
                return BadRequest();
            if (app.SaveMascota(oMascota))
                return Ok("Ok");
            else
                return Ok("No se Agrego la Mascota !");
        }
        [HttpGet("Combo")]
        public IActionResult GetCargarCombo()
        {
            return Ok(app.CargarCombo("Tabla"));
        }



        [HttpGet("GetMascotas")]
        public IActionResult GetMascota(List<Mascota> lst)
        {
            if (lst == null || lst.Count == 0)
                return BadRequest("Se requiere una lista de parámetros!");

            return Ok(app.GetMascotas());
        }


        [HttpPost("UpdateMascota")]
        public IActionResult UpdateMascota(Mascota oMascota)
        {
            if (oMascota == null)
                return BadRequest();
            if (app.UpdateMascota(oMascota))
                return Ok("OK");
            else
                return Ok("No se Puedo actualizar la mascota");
        }

    }
}
