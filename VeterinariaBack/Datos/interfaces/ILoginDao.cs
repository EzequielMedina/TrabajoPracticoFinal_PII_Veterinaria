using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaLoginBack.Dominio;

namespace VeterinariaLoginBack.acceso_a_datos.interfaces
{
    public interface ILoginDao
    {
        public bool ValidarUsuario(Veterinario oVeterinario);
        string RecuperarUsuario(string usuario, string password);
        bool RegistrarUsuario(Veterinario oVeterinario);
        bool existe(string usuario);
        bool RecuperarContraseña(Veterinario oVeterinario);
        bool existeRestablcer(string nombre, string apellido, int matricula, string usuario);
        List<Domicilios> CargarComboDomicilio(string tabla);
        List<Localidades> CargarComboLocalidad(string tabla);
        List<Tipos_Dni> CargarComboTipo(string tabla);

        int ProximoId();
    }
}
