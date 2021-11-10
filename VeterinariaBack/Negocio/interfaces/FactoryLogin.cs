using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaLoginBack.Datos;
using VeterinariaLoginBack.Negocio.implementacion;
using VeterinariaLoginBack.Negocio.interfaces;
using VeterinariaLoginBack.servicio.implementacion;

namespace VeterinariaLoginBack.Negocio
{

    public class FactoryLogin : AbstractFactoryLogin
    {
        public override ILoginService CrearServicio() => new LoginService();
    }
}
