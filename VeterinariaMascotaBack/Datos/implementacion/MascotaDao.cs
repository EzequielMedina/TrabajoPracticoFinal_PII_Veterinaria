using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaMascotaBack.Datos.interfaces;
using VeterinariaMascotaBack.Dominio;

namespace VeterinariaMascotaBack.Datos.implementacion
{
    public class MascotaDao : IMascotaDao
    {
        public DataTable CargarCombo(string tabla)
        {
            return HelperMascotaDao.ObtenerInstancia().CargarCombo(tabla);
        }

        public bool SaveMascota(Mascota oMascota)
        {
            return HelperMascotaDao.ObtenerInstancia().SaveMascota(oMascota);
        }

        public List<Mascota> GetMascotas()
        {
            return HelperMascotaDao.ObtenerInstancia().GetMascotas();
        }

        public Mascota GetMascotaById(int id)
        {
            return HelperMascotaDao.ObtenerInstancia().GetMascotaById(id);
        }
        public bool UpdateMascota(Mascota oMascota)
        {
            return HelperMascotaDao.ObtenerInstancia().UpdateMascota(oMascota);
        }

    }
}
