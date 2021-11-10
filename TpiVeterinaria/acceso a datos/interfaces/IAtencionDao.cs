using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpiVeterinaria.Dominio;
using TpiVeterinaria.servicio;

namespace TpiVeterinaria.acceso_a_datos.interfaces
{
    interface IAtencionDao
    {
        List<Atencion> ConsultarAtenciones(List<Parametro> filtros);

        bool EliminarAtencion(int id);

        List<Cliente> GetClientes();

        List<Mascota> GetMascotas(int id);

        bool SaveAtenciones(Atencion oAtencion);

        int GetProximaAtencion();

        Atencion GetAtencion(int id);
    }
}
