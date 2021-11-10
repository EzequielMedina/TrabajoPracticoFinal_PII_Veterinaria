using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiVeterinaria.acceso_a_datos.implementacion;
using TpiVeterinaria.acceso_a_datos.interfaces;
using TpiVeterinaria.Dominio;
using TpiVeterinaria.servicio.interfaces;

namespace TpiVeterinaria.servicio.implementacion
{
    class AtencionesService : IAtencionService
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

        public bool SaveAtenciones(Atencion oAtencion)
        {
            return dao.SaveAtenciones(oAtencion);
        }

        public int GetProximaAtencion()
        {
            return dao.GetProximaAtencion();
        }

        public Atencion GetAtencion(int id)
        {
            return dao.GetAtencion(id);
        }
    }
}
