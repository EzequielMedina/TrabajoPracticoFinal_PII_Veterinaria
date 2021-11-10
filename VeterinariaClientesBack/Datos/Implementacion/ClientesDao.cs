using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaClientesBack.Datos.Interfaces;
using VeterinariaClientesBack.Dominio;

namespace VeterinariaClientesBack.Datos.Implementacion
{
    class ClientesDao : IClientesDao
    {
        public DataTable GetLocalidades()
        {
            return HelperCliente.ObtenerInstancia().GetLocalidades();
        }

        public DataTable GetTiposDni()
        {
            return HelperCliente.ObtenerInstancia().GetTiposDni();
        }

        public bool SaveClientes(Cliente oCliente)
        {
            return HelperCliente.ObtenerInstancia().SaveClientes(oCliente);
        }

        public List<Cliente> GetClientes()
        {
            return HelperCliente.ObtenerInstancia().GetClientes();
        }

        public Cliente GetClienteById(int id)
        {
            return HelperCliente.ObtenerInstancia().GetClienteById(id);

        }

        public bool UpdateCliente(Cliente oCliente)
        {
            return HelperCliente.ObtenerInstancia().UpdateCliente(oCliente);

        }
    }
}
