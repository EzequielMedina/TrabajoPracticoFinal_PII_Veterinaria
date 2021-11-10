using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaLoginBack.Dominio;


namespace VeterinariaLoginBack.Negocio.interfaces
{
    public interface ILoginService
    {
        public bool ValidarUsuario(Veterinario oVeterinario);
        public string RecuperarUsuario(string usuario, string password);
        public bool RegistrarUsuario(Veterinario oVeterinario);
        public bool existe(string usuario);
        public bool RecuperarContraseña(Veterinario oVeterinario);
        public bool existeRestablcer(string nombre, string apellido, int matricula, string usuario);
        public List<Domicilios> CargarComboDomicilio(string tabla);
        public List<Localidades> CargarComboLocalidad(string tabla);
        public List<Tipos_Dni> CargarComboTipo(string tabla);

        public int ProximoId();
    }
}
