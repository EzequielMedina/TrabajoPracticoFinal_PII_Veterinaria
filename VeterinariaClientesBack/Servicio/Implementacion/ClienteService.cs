using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaClientesBack.Datos.Implementacion;
using VeterinariaClientesBack.Datos.Interfaces;
using VeterinariaClientesBack.Dominio;
using VeterinariaClientesBack.Servicio.Interfaces;

namespace VeterinariaClientesBack.Servicio.Implementacion
{
    public class ClienteService : IClientesService
    {
        private IClientesDao dao;

        public ClienteService()
        {
            dao = new ClientesDao();
        }
        public DataTable GetTiposDni()
        {
            return dao.GetTiposDni();
        }


        public DataTable GetLocalidades()
        {


            return dao.GetLocalidades();
        }

        public bool SaveClientes(Cliente oCliente)
        {
            return dao.SaveClientes(oCliente);
        }

        public List<Cliente> GetClientes()
        {
            return dao.GetClientes();
        }

        public Cliente GetClienteById(int id)
        {
            return dao.GetClienteById(id);
        }

        public bool UpdateCliente(Cliente oCliente)
        {
            return dao.UpdateCliente(oCliente);
        }
    }
}
