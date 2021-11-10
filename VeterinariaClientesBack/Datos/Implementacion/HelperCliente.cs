using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaClientesBack.Dominio;

namespace VeterinariaClientesBack.Datos.Implementacion
{
    class HelperCliente
    {
        private static HelperCliente _instancia;
        private string connectionString;

        private HelperCliente()
        {
            connectionString = @"Data Source=desktop-w10;Initial Catalog=db_veterinaria_1011;Integrated Security=True";
        }

        public static HelperCliente ObtenerInstancia()
        {
            if (_instancia == null)
            {

                _instancia = new HelperCliente();
            }

            return _instancia;
        }
        public DataTable GetTiposDni()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            //CMD: TIPO_DNI
            DataTable tabla = new DataTable();
            SqlCommand cmd3 = new SqlCommand("SP_CONSULTAR_TIPO_DNI", cnn);
            cmd3.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd3.ExecuteReader());
            cnn.Close();
            return tabla;

        }

        public DataTable GetLocalidades()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();

            DataTable tabla = new DataTable();
            SqlCommand cmd2 = new SqlCommand("SP_CONSULTAR_LOCALIDAD", cnn);
            cmd2.CommandType = CommandType.StoredProcedure;

            tabla.Load(cmd2.ExecuteReader());
            cnn.Close();
            return tabla;
        }

        public bool SaveClientes(Cliente oCliente)
        {
            bool flag = true;
            SqlTransaction t = null;
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            try
            {

                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("SAVE_CLIENTES", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CALLE", oCliente.Calle);
                cmd.Parameters.AddWithValue("@ID_LOCALIDAD", oCliente.Localidad);
                cmd.Parameters.AddWithValue("@NRO_DIRECCION", oCliente.NroCalle);
                cmd.Parameters.AddWithValue("@ID_TIPO", oCliente.TipoDoc);
                cmd.Parameters.AddWithValue("@NOMBRE", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@APELLIDO", oCliente.Apellido);
                cmd.Parameters.AddWithValue("@nro_dni", oCliente.NroDocumento);
                cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                t.Rollback();
                flag = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return flag;
        }

        public List<Cliente> GetClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("GET_CLIENTES", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());

            foreach (DataRow row in table.Rows)
            {
                Cliente oCliente = new Cliente();
                oCliente.Codigo = Convert.ToInt32(row["Id_cliente"]);
                oCliente.Nombre = row["Nombre"].ToString();
                oCliente.Apellido = row["Apellido"].ToString();
                oCliente.Calle = row["calle"].ToString();
                oCliente.NroCalle = Convert.ToInt32(row["numero"]);
                oCliente.NombreLocalidad = row["nombre_localidad"].ToString();
                oCliente.TipoDniEnLetras = row["Descripcion"].ToString();
                oCliente.NroDocumento = Convert.ToInt32(row["nro_dni"]);

                clientes.Add(oCliente);

            }
            return clientes;
        }

        public Cliente GetClienteById(int id)
        {
            Cliente oCliente = new Cliente();
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("GET_CLIENTE_BY_ID", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                oCliente.Codigo = Convert.ToInt32(row["id_cliente"].ToString());
                oCliente.Localidad = Convert.ToInt32(row["Id_Localidad"]);
                oCliente.Nombre = row["Nombre"].ToString();
                oCliente.Apellido = row["Apellido"].ToString();
                oCliente.TipoDoc = Convert.ToInt32(row["Id_tipo"]);
                oCliente.NroDocumento = Convert.ToInt32(row["nro_dni"]);
                oCliente.Calle = row["Calle"].ToString();
                oCliente.NroCalle = Convert.ToInt32(row["Numero"]);

            }

            return oCliente;
        }

        public bool UpdateCliente(Cliente oCliente)
        {
            bool flag = true;
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_CLIENTE", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_CLIENTE", oCliente.Codigo);
                cmd.Parameters.AddWithValue("@CALLE", oCliente.Calle);
                cmd.Parameters.AddWithValue("@NRO_DIRECCION", oCliente.NroCalle);
                cmd.Parameters.AddWithValue("@ID_LOCALIDAD", oCliente.Localidad);
                cmd.Parameters.AddWithValue("@NOMBRE", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@APELLIDO", oCliente.Apellido);
                cmd.Parameters.AddWithValue("@ID_TIPO", oCliente.TipoDoc);
                cmd.Parameters.AddWithValue("@NRO_DNI", oCliente.NroDocumento);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                flag = false;
            }

            return flag;
        }
    }

}
