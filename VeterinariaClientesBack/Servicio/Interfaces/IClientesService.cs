using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaClientesBack.Dominio;

namespace VeterinariaClientesBack.Servicio.Interfaces
{
    public interface IClientesService
    {
        DataTable GetLocalidades();
        DataTable GetTiposDni();

        bool SaveClientes(Cliente oCliente);
        List<Cliente> GetClientes();
        Cliente GetClienteById(int id);
        bool UpdateCliente(Cliente oCleinte);
    }
}
