using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaMascotaBack.Datos.implementacion;
using VeterinariaMascotaBack.Datos.interfaces;
using VeterinariaMascotaBack.Dominio;
using VeterinariaMascotaBack.Negocio.interfaces;

namespace VeterinariaMascotaBack.Negocio.implementacion
{
    public class MascotaService : IMascotaService
    {
        private IMascotaDao MascotaDao;

        public MascotaService()
        {
            MascotaDao = new MascotaDao();
        }

        public DataTable CargarCombo(string tabla)
        {
            return MascotaDao.CargarCombo(tabla);
        }

        public bool SaveMascota(Mascota oMascota)
        {
            return MascotaDao.SaveMascota(oMascota);
        }

        public List<Mascota> GetMascotas()
        {
            return MascotaDao.GetMascotas();
        }

        public Mascota GetMascotaById(int id)
        {
            return MascotaDao.GetMascotaById(id);
        }

        public bool UpdateMascota(Mascota oMascota)
        {
            return MascotaDao.UpdateMascota(oMascota);
        }
    }
}
