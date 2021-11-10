using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaMascotaBack.Negocio.implementacion;

namespace VeterinariaMascotaBack.Negocio.interfaces
{
    public class FactoryMascota : AbstractMascotaFactory
    {
        public override IMascotaService CrearServicio() => new MascotaService();

    }
}
