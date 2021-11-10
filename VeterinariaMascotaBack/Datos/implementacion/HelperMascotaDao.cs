using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinariaMascotaBack.Dominio;

namespace VeterinariaMascotaBack.Datos.implementacion
{
    class HelperMascotaDao
    {
        private static HelperMascotaDao instancia;
        private string connectionString;

        private HelperMascotaDao()
        {
            connectionString = @"Data Source=desktop-w10;Initial Catalog=db_veterinaria_1011;Integrated Security=True";
        }

        internal DataTable CargarCombo(string tabla)
        {
            SqlConnection cnn = new SqlConnection();
            DataTable table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_CONSULTAR_E-R", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
       
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                cmd.Parameters.AddWithValue("@tabla", tabla);
                table.Load(cmd.ExecuteReader());

            }
            catch (SqlException)
            {

                table = null;
                cnn.Close();
            }
            finally
            {

                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return table;
        }

        public bool UpdateMascota(Mascota oMascota)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            bool flag = true;
            try
            {
                
                cnn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE_MASCOTA", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_mascota", oMascota.IdMascota);
                cmd.Parameters.AddWithValue("@NOMBRE", oMascota.Nombre);
                cmd.Parameters.AddWithValue("@Fecha_nac", oMascota.FechaNac);

                if (oMascota.FechaDefun != null)
                    cmd.Parameters.AddWithValue("@Fecha_def", oMascota.FechaDefun);
                else
                    cmd.Parameters.AddWithValue("@Fecha_def", DBNull.Value);

                cmd.Parameters.AddWithValue("@sexo", oMascota.Sexo);
                cmd.Parameters.AddWithValue("@Id_Especie", oMascota.Especie);
                cmd.Parameters.AddWithValue("@raza", oMascota.Raza);
                cmd.Parameters.AddWithValue("@Id_Cliente", oMascota.Clientes);
                cmd.Parameters.AddWithValue("@Esterilizado", oMascota.Esterilizado);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch
            {
                flag = false;
            }

            return flag;
        }

        public Mascota GetMascotaById(int id)
        {
            Mascota oMascota = new Mascota();
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("get_mascota_por_id", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                oMascota.IdMascota = Convert.ToInt32(row["id_mascota"].ToString());
          
                oMascota.Nombre = row["Nombre"].ToString();
                oMascota.FechaNac = Convert.ToDateTime(row["fecha_nac"]);
                if (!row["fecha_def"].Equals(DBNull.Value))
                    oMascota.FechaDefun = Convert.ToDateTime(row["fecha_def"]);
                if (Convert.ToInt32(row["Sexo"]) == 1)
                {
                    oMascota.SexoEnLetras = "M";
                }
                if (Convert.ToInt32(row["Sexo"]) == 0)
                {
                    oMascota.SexoEnLetras = "F";
                }
                oMascota.Especie = Convert.ToInt32(row["Especie"]);
                oMascota.Raza = Convert.ToInt32(row["raza"]);

                oMascota.Raza = Convert.ToInt32(row["raza"].ToString());
                oMascota.Clientes = Convert.ToInt32(row["id_cliente"]);
                if (Convert.ToInt32(row["Esterilizado"]) == 1)
                    oMascota.Esterilizado = true;
                if (Convert.ToInt32(row["Esterilizado"]) == 0)
                    oMascota.Esterilizado = false;



            }

            return oMascota;
        }

        internal List<Mascota> GetMascotas()
        {
            List<Mascota> mascotas = new List<Mascota>();

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("get_all_mascotas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            cnn.Close();

            foreach (DataRow row in table.Rows)
            {
                Mascota oMascota = new Mascota();
                oMascota.IdMascota  = Convert.ToInt32(row["Id_mascota"]);
                oMascota.Nombre = row["Nombre"].ToString();
                oMascota.FechaNac = Convert.ToDateTime(row["fecha_nac"]);
                
                if(Convert.ToInt32(row["Sexo"]) == 1)
                {
                    oMascota.SexoEnLetras = "M";
                }
                if(Convert.ToInt32(row["Sexo"]) == 0)
                {
                    oMascota.SexoEnLetras = "F";
                }
                oMascota.Sexo = Convert.ToInt32(row["Sexo"]); 
                oMascota.EspecieEnLetras = row["especie"].ToString();
                oMascota.RazaEnLetras = row["raza"].ToString();
                oMascota.ClienteEnLetras = row["cliente"].ToString();
                if (!row["fecha_def"].Equals(DBNull.Value))
                    oMascota.FechaDefun = Convert.ToDateTime(row["fecha_def"]);
                if(Convert.ToInt32(row["Esterilizado"]) == 1)
                    oMascota.EsterilizadoEnLetras = "Si";
                if (Convert.ToInt32(row["Esterilizado"]) == 0)
                    oMascota.EsterilizadoEnLetras = "No";

                mascotas.Add(oMascota);

            }
            return mascotas;
        }

        internal bool SaveMascota(Mascota oMascota)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand("INSERTAR_MASCOTA", cnn);
            cnn.ConnectionString = connectionString;
            cnn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", oMascota.Nombre);
            cmd.Parameters.AddWithValue("@Fecha_nac", oMascota.FechaNac);

            if (oMascota.FechaDefun != null)
                cmd.Parameters.AddWithValue("@Fecha_def", oMascota.FechaDefun);
            else
                cmd.Parameters.AddWithValue("@Fecha_def", DBNull.Value);

            cmd.Parameters.AddWithValue("@sexo", oMascota.Sexo);
            cmd.Parameters.AddWithValue("@Id_Especie", oMascota.Especie);
            cmd.Parameters.AddWithValue("@raza", oMascota.Raza);
            cmd.Parameters.AddWithValue("@Id_Cliente", oMascota.Clientes);
            cmd.Parameters.AddWithValue("@Esterilizado", oMascota.Esterilizado);

            int flag = cmd.ExecuteNonQuery();
            cnn.Close();

            if (flag == 1)
                return true;
            else
                return false;
            

        }

        public static HelperMascotaDao ObtenerInstancia()
        {

            if (instancia == null)
            {

                instancia = new HelperMascotaDao();

            }

            return instancia;

        }
    }
}
