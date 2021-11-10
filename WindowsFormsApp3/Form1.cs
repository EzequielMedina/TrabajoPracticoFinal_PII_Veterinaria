using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaClientesBack.Dominio;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        int id;
        private string connectionString = @"Data Source=desktop-w10;Initial Catalog=db_veterinaria_1011;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet2.historia_clinica' Puede moverla o quitarla según sea necesario.



            id = Convert.ToInt32(cboClientes.SelectedIndex.ToString()) + 1;


            CargarCombo();
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SP_REPORTE' Puede moverla o quitarla según sea necesario.
           

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void CargarCombo()
        {
            cboClientes.DataSource = GetClientes();
            cboClientes.DisplayMember = "IdCliente";

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

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(cboClientes.SelectedIndex.ToString()) + 1;
            this.historia_clinicaTableAdapter.Fill(this.DataSet2.historia_clinica, id);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
