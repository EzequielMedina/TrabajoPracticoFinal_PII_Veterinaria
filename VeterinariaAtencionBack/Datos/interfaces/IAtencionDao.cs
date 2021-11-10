using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaAtencionBack.Dominio;
using VeterinariaAtencionBack.Negocio;
using VeterinariaMascotaBack.Dominio;

namespace VeterinariaAtencionBack.Datos.interfaces
{
    public interface IAtencionDao
    {
        List<Atencion> ConsultarAtenciones(List<Parametro> filtros);

        bool EliminarAtencion(int id);

        List<Cliente> GetClientes();

        List<Mascota> GetMascotas(int id);
        int GetProximaAtencion();
        bool SaveAtenciones(Atencion oAtencion);

        Atencion GetAtencion(int id);
        bool UpdateAtencion(Atencion oAtencion);
    }
}
