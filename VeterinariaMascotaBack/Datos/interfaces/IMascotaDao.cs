using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaMascotaBack.Dominio;

namespace VeterinariaMascotaBack.Datos.interfaces
{
    public interface IMascotaDao
    {
        DataTable CargarCombo(string tabla);
        bool SaveMascota(Mascota oMascota);
        List<Mascota> GetMascotas();
        Mascota GetMascotaById(int id);
        bool UpdateMascota(Mascota oMascota);
    }
}
