using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaClientesBack.Dominio;

namespace VeterinariaClientesBack.Datos.Interfaces
{
    public interface IClientesDao
    {
        DataTable GetTiposDni();

        DataTable GetLocalidades();

        bool SaveClientes(Cliente oCliente);
        List<Cliente> GetClientes();
        Cliente GetClienteById(int id);
        bool UpdateCliente(Cliente oCliente);

    }
}
