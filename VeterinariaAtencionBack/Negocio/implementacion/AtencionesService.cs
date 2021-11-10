using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaAtencionBack.Datos.implementacion;
using VeterinariaAtencionBack.Datos.interfaces;
using VeterinariaAtencionBack.Dominio;
using VeterinariaAtencionBack.Negocio.interfaces;
using VeterinariaMascotaBack.Dominio;

namespace VeterinariaAtencionBack.Negocio.implementacion
{
    public class AtencionesService : IAtencionService
    {
        private IAtencionDao dao;

        public AtencionesService()
        {
            dao = new AtencionDao();
        }

        public List<Atencion> ConsultarAtenciones(List<Parametro> filtros)
        {
           return dao.ConsultarAtenciones(filtros);
        }

        public bool EliminarAtencion(int id)
        {
            return dao.EliminarAtencion(id);
        }

        public List<Cliente> GetClientes()
        {
            return dao.GetClientes();
        }

        public List<Mascota> GetMascotas(int id)
        {
            return dao.GetMascotas(id);
        }

        public int GetProximaAtencion()
        {
            return dao.GetProximaAtencion();
        }

        public bool SaveAtenciones(Atencion oAtencion)
        {
            return dao.SaveAtenciones(oAtencion);
        }

        public Atencion GetAtencion(int id)
        {
            return dao.GetAtencion(id);
        }

        public bool UpdateAtencion(Atencion oAtencion)
        {
            return dao.UpdateAtencion(oAtencion);
        }

    }
}
