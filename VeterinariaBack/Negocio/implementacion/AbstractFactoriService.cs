using VeterinariaLoginBack.acceso_a_datos.interfaces;

namespace VeterinariaLoginBack.Negocio.implementacion
{
    public abstract class AbstractFactoriService
    {
        public abstract ILoginDao CrearServicio();
    }
}