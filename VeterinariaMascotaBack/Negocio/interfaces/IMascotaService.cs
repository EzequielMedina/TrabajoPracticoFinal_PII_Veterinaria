using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaAtencionBack.Dominio;
using VeterinariaMascotaBack.Dominio;

namespace VeterinariaMascotaBack.Negocio.interfaces
{
    public interface IMascotaService
    {
        DataTable CargarCombo(string tabla);
        bool SaveMascota(Mascota oMascota);
        List<Mascota> GetMascotas();
        Mascota GetMascotaById(int id);
        bool UpdateMascota(Mascota oMascota);
    }
}
