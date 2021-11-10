using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaAtencionBack.Datos.interfaces;
using VeterinariaAtencionBack.Dominio;
using VeterinariaAtencionBack.Negocio;
using VeterinariaMascotaBack.Dominio;

namespace VeterinariaAtencionBack.Datos.implementacion
{
    public class AtencionDao : IAtencionDao
    {
        private string connectionString = @"Data Source=desktop-w10;Initial Catalog=db_veterinaria_1011;Integrated Security=True";


       
    


        public List<Atencion> ConsultarAtenciones(List<Parametro> filtros)
        {


            List<Atencion> atenciones = new List<Atencion>();
            DataTable table = new DataTable();
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();

                SqlCommand cmd = new SqlCommand("CONSULTAR_ATENCIONES", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (Parametro p in filtros)
                {
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }

                table.Load(cmd.ExecuteReader());



                foreach (DataRow row in table.Rows)
                {

                    Atencion oAtencion = new Atencion();
                    oAtencion.NumeroAtencion = Convert.ToInt32(row["Id_Atencion"]);
                    oAtencion.Fecha = Convert.ToDateTime(row["fecha"].ToString());
                    oAtencion.Descripcion = row["descripcion"].ToString();
                    oAtencion.Importe = Convert.ToDouble(row["importe"]);
                    oAtencion.FechaControl = Convert.ToDateTime(row["fecha_control"].ToString());
                    if (!row["fecha_baja"].Equals(DBNull.Value))
                        oAtencion.FechaBaja = Convert.ToDateTime(row["fecha_baja"].ToString());

                    atenciones.Add(oAtencion);
                }

                cnn.Close();
            }
            catch (SqlException)
            {
                atenciones = null;
            }
            return atenciones;

        }

        public bool EliminarAtencion(int id)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlTransaction t = null;
            int affected = 0;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand("REGISTRAR_BAJA_ATENCION", cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ATENCION_NRO", id);
                affected = cmd.ExecuteNonQuery();
                t.Commit();

            }
            catch (SqlException)
            {
                t.Rollback();
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return affected == 1;

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
                oCliente.NroDocumento = Convert.ToInt32(row["nro_dni"]);

                clientes.Add(oCliente);

            }
            return clientes;
        }

        public List<Mascota> GetMascotas(int id)
        {
            List<Mascota> mascotas = new List<Mascota>();

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("GET_MASCOTAS", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idCliente", id);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());

            foreach (DataRow row in table.Rows)
            {
                Mascota oMascota = new Mascota();
                oMascota.IdMascota = Convert.ToInt32(row["Id_Mascota"]);
                oMascota.Nombre = row["Nombre"].ToString();
                mascotas.Add(oMascota);

            }
            return mascotas;
        }

        public int GetProximaAtencion()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("sp_proximo_id", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@next";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(param);

            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)param.Value;
        }
        public bool SaveAtenciones(Atencion oAtencion)
        {
            bool flag = true;
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SAVE_ATENCIONES", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAtencion", Convert.ToInt32(oAtencion.NumeroAtencion));
                cmd.Parameters.AddWithValue("@idMascota", Convert.ToInt32(oAtencion.IdMascota));
                cmd.Parameters.AddWithValue("@fechaAtencion", Convert.ToDateTime(oAtencion.Fecha));
                cmd.Parameters.AddWithValue("@fechaControl", Convert.ToDateTime(oAtencion.FechaControl));
                cmd.Parameters.AddWithValue("@Importe", Convert.ToDouble(oAtencion.Importe));
                cmd.Parameters.AddWithValue("@descripcion", oAtencion.Descripcion);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                flag = false;
            }

            return flag;
        }

        public Atencion GetAtencion(int id)
        {
            Atencion oAtencion = new Atencion();
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("get_atencion", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idAtencion", id);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                oAtencion.IdMascota = Convert.ToInt32(row["id_mascota"].ToString());
                oAtencion.NumeroAtencion = Convert.ToInt32(row["Id_Atencion"]);
                oAtencion.Fecha = Convert.ToDateTime(row["fecha"].ToString());
                oAtencion.Descripcion = row["descripcion"].ToString();
                oAtencion.Importe = Convert.ToDouble(row["importe"]);
                oAtencion.FechaControl = Convert.ToDateTime(row["fecha_control"].ToString());
                if (!row["fecha_baja"].Equals(DBNull.Value))
                    oAtencion.FechaBaja = Convert.ToDateTime(row["fecha_baja"].ToString());

            }

            return oAtencion;

        }

        public bool UpdateAtencion(Atencion oAtencion)
        {
            bool flag = true;
            try
            {
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_ATENCION", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAtencion", Convert.ToInt32(oAtencion.NumeroAtencion));
                cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(oAtencion.Fecha));
                cmd.Parameters.AddWithValue("@fechaControl", Convert.ToDateTime(oAtencion.FechaControl));
                cmd.Parameters.AddWithValue("@importe", Convert.ToDouble(oAtencion.Importe));
                cmd.Parameters.AddWithValue("@descripcion", oAtencion.Descripcion);

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
