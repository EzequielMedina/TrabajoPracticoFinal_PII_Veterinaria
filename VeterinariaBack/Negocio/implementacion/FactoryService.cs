using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaLoginBack.acceso_a_datos.implementacion;
using VeterinariaLoginBack.acceso_a_datos.interfaces;
using VeterinariaLoginBack.servicio.implementacion;

namespace VeterinariaLoginBack.Negocio.implementacion
{
    class FactoryService : AbstractFactoriService
    {
        public override ILoginDao CrearServicio() => new LoginDao();
    }
}
