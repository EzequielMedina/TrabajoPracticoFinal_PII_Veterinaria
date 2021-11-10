using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaLoginBack.acceso_a_datos.interfaces;
using VeterinariaLoginBack.Datos.implementacion;
using VeterinariaLoginBack.Dominio;

namespace VeterinariaLoginBack.acceso_a_datos.implementacion
{
    public class LoginDao : ILoginDao
    {
        public List<Domicilios> CargarComboDomicilio(string tabla)
        {
            
            List<Domicilios> lst = new List<Domicilios>();

            DataTable table =  HelperLoginDao.ObtenerInstancia().CargarCombo(tabla);
            foreach (DataRow item in table.Rows)
            {
                
                    Domicilios oDomicilios = new Domicilios();
                    oDomicilios.IdDomicilio = Convert.ToInt32(item[0].ToString());
                    oDomicilios.Nombre = item[1].ToString();

                    lst.Add(oDomicilios);
             
               
            }

            return lst;
        }
        public List<Localidades> CargarComboLocalidad(string tabla)
        {

            List<Localidades> lst = new List<Localidades>();

            DataTable table = HelperLoginDao.ObtenerInstancia().CargarCombo(tabla);
            foreach (DataRow item in table.Rows)
            {

                Localidades oLocalidades = new Localidades();
                oLocalidades.Id_localidades = Convert.ToInt32(item[0].ToString());
                oLocalidades.Nombre = item[1].ToString();

                lst.Add(oLocalidades);
            }
            return lst;
        }
        public List<Tipos_Dni> CargarComboTipo(string tabla)
        {

            List<Tipos_Dni> lst = new List<Tipos_Dni>();

            DataTable table = HelperLoginDao.ObtenerInstancia().CargarCombo(tabla);
            foreach (DataRow item in table.Rows)
            {

                Tipos_Dni oTipo = new Tipos_Dni();
                oTipo.IdDni = Convert.ToInt32(item[0].ToString());
                oTipo.Nombre = item[1].ToString();

                lst.Add(oTipo);

            }
            return lst;
        }

        public bool existe(string usuario)
        {
            return HelperLoginDao.ObtenerInstancia().existe(usuario);
        }

        public bool existeRestablcer(string nombre, string apellido, int matricula, string usuario)
        {
            return HelperLoginDao.ObtenerInstancia().existeRestablcer(nombre, apellido, matricula, usuario);
        }

        public bool RecuperarContraseña(Veterinario oVeterinario)
        {
            return HelperLoginDao.ObtenerInstancia().RecuperarContraseña(oVeterinario);
        }

        public string RecuperarUsuario(string usuario, string password)
        {
            return HelperLoginDao.ObtenerInstancia().RecuperarUsuario(usuario, password);
        }

        public bool RegistrarUsuario(Veterinario oVeterinario)
        {
            return HelperLoginDao.ObtenerInstancia().RegistrarUsuario(oVeterinario);
        }

        public bool ValidarUsuario(Veterinario oVeterinario)
        {
            return HelperLoginDao.ObtenerInstancia().ValidarUsuario(oVeterinario);
            }
        public int ProximoId()
        {
            return HelperLoginDao.ObtenerInstancia().ProximoId();
        }

    }
}
