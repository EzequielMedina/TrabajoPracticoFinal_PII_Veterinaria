using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaLoginBack.Negocio.interfaces;

namespace VeterinariaLoginBack.Datos
{
    public abstract class AbstractFactoryLogin
    {
        public abstract ILoginService CrearServicio();
    }
}
