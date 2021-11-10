using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using VeterinariaLoginBack.Dominio;

namespace VeterinariaLoginBack.Datos.implementacion
{
    class HelperLoginDao
    {
        private static HelperLoginDao instancia;
        private string connectionString;

        private HelperLoginDao()
        {
            connectionString = @"Data Source=desktop-w10;Initial Catalog=db_veterinaria_1011;Integrated Security=True";
        }

        public static HelperLoginDao ObtenerInstancia()
        {

            if (instancia == null)
            {

                instancia = new HelperLoginDao();

            }

            return instancia;

        }

        public bool ValidarUsuario(Veterinario oVeterinario)
        {
            SqlConnection cnn = new SqlConnection();
            DataTable table = new DataTable();

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_Login", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", oVeterinario.Usuario);
                cmd.Parameters.AddWithValue("@password ", oVeterinario.Contraseña);


                table.Load(cmd.ExecuteReader());


            }
            catch (SqlException)
            {

                table = null;
            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public string RecuperarUsuario(string usuario, string password)
        {
            string saludar = "";
            SqlConnection cnn = new SqlConnection();
            DataTable table = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SP_Login", cnn);
                cnn.ConnectionString = connectionString;
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@password ", password);

                table.Load(cmd.ExecuteReader());
            }
            catch (Exception)
            {
                table = null;

            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }


            foreach (DataRow item in table.Rows)
            {
                saludar = item[1].ToString();
                saludar += " ";
                saludar += item[8].ToString();
            }

            return saludar;

        }

        public bool RegistrarUsuario(Veterinario oVeterinario)
        {

            SqlConnection cnn = new SqlConnection();
            //EN EL SP MODIFICAR PARA QUE ACEPTE DOMICILIO Y DNI
            SqlCommand cmd = new SqlCommand("SP_INSERT_VETERINARIO", cnn);

            cnn.ConnectionString = connectionString;
            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", oVeterinario.Nombre);
            cmd.Parameters.AddWithValue("@Apellido ", oVeterinario.Apellido);
            cmd.Parameters.AddWithValue("@Matricula ", oVeterinario.Matricula);
            cmd.Parameters.AddWithValue("@Usuario ", oVeterinario.Usuario);
            cmd.Parameters.AddWithValue("@Contraseña ", oVeterinario.Contraseña);
            //cmd.Parameters.AddWithValue("@Id_Domicilio ", oVeterinario.Domicilio);

            //cmd.Parameters.AddWithValue("@Tipo ", oVeterinario.TipoDni);
            cmd.Parameters.AddWithValue("@nro ", oVeterinario.NroDni);

            
            if (cmd.ExecuteNonQuery() == 1)
            {
                cnn.Close();
                return true;
            }
            else
            {
                cnn.Close();
                return false;
            }


        }

        public bool existe(string usuario)
        {
            SqlConnection cnn = new SqlConnection();

            SqlCommand cmd = new SqlCommand("SP_EXISTE_USUARIO", cnn);
            DataTable table = new DataTable();


            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Usuario", usuario);

                table.Load(cmd.ExecuteReader());
            }
            catch
            {

                table = null;

            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }


            if (table.Rows.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool RecuperarContraseña(Veterinario oVeterinario)
        {
            SqlConnection cnn = new SqlConnection();

            SqlCommand cmd = new SqlCommand("SP_UPDATE_CONTRASEÑA", cnn);
            DataTable table = new DataTable();


            try
            {
                cnn.ConnectionString = connectionString;
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                cmd.Parameters.AddWithValue("@nombre", oVeterinario.Nombre);
                cmd.Parameters.AddWithValue("@apellido ", oVeterinario.Apellido);
                cmd.Parameters.AddWithValue("@matricula ", oVeterinario.Matricula);
                cmd.Parameters.AddWithValue("@usuario ", oVeterinario.Usuario);
                cmd.Parameters.AddWithValue("@contraseña ", oVeterinario.Contraseña);
                table.Load(cmd.ExecuteReader());
            }
            catch
            {

                table = null;

            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }


            if (table.Rows.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }



        }
        public bool existeRestablcer(string nombre, string apellido, int matricula, string usuario)
        {
            SqlConnection cnn = new SqlConnection();

            SqlCommand cmd = new SqlCommand("SP_EXISTE_RESTABLECER", cnn);
            DataTable table = new DataTable();


            try
            {
                cnn.ConnectionString = connectionString;
                cmd.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                table.Load(cmd.ExecuteReader());
            }
            catch
            {

                table = null;

            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }


            if (table.Rows.Count == 1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public DataTable CargarCombo(string tabla)
        {
            SqlConnection cnn = new SqlConnection();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_CONSULTAR", cnn);

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tabla", tabla);
                table.Load(cmd.ExecuteReader());

            }
            catch (SqlException)
            {

                table = null;
            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return table;

        }

        public int ProximoId()
        {
            SqlConnection cnn = new SqlConnection();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_PROXIMO_ID", cnn);
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
    }
}
