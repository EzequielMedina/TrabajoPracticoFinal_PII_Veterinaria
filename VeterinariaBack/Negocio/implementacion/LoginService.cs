using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaLoginBack.acceso_a_datos.interfaces;
using VeterinariaLoginBack.Datos;
using VeterinariaLoginBack.Dominio;
using VeterinariaLoginBack.Negocio;
using VeterinariaLoginBack.Negocio.interfaces;
using VeterinariaLoginBack.acceso_a_datos.implementacion;
using VeterinariaLoginBack.Negocio.implementacion;

namespace VeterinariaLoginBack.servicio.implementacion
{
    public class LoginService : ILoginService
    {
       private ILoginDao LoginDao;

        
        public LoginService()
        {
            LoginDao = new FactoryService().CrearServicio();
        }

        public List<Domicilios> CargarComboDomicilio(string tabla)
        {
            return LoginDao.CargarComboDomicilio(tabla);
        }
        public List<Localidades> CargarComboLocalidad(string tabla)
        {
            return LoginDao.CargarComboLocalidad(tabla);
        }
        public List<Tipos_Dni> CargarComboTipo(string tabla)
        {
            return LoginDao.CargarComboTipo(tabla);
        }
        public bool existe(string usuario)
        {
            return LoginDao.existe(usuario);
        }

        public bool existeRestablcer(string nombre, string apellido, int matricula, string usuario)
        {
            return LoginDao.existeRestablcer( nombre,  apellido,  matricula,  usuario);
        }

       

        public bool RecuperarContraseña(Veterinario oVeterinario)
        {
            return LoginDao.RecuperarContraseña(oVeterinario);
        }

        public string RecuperarUsuario(string usuario, string password)
        {
            return LoginDao.RecuperarUsuario(usuario, password);
        }

        public bool RegistrarUsuario(Veterinario oVeterinario)
        {
            return LoginDao.RegistrarUsuario(oVeterinario);
        }

        public bool ValidarUsuario(Veterinario oVeterinario) {
            return LoginDao.ValidarUsuario(oVeterinario);
        
        }

        public int ProximoId() {
            return LoginDao.ProximoId();
        
        }


    }
}
