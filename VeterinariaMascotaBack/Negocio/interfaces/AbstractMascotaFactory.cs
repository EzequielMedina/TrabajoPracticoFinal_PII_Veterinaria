using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaMascotaBack.Negocio.interfaces
{
    public abstract class AbstractMascotaFactory
    {
        public abstract IMascotaService CrearServicio();
    }
}
