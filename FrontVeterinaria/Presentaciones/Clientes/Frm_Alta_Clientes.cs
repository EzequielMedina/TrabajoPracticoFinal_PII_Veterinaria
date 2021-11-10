using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaClientesBack.Dominio;
using VeterinariaClientesBack.Servicio.Implementacion;
using VeterinariaClientesBack.Servicio.Interfaces;

namespace FrontVeterinaria.Presentaciones.Clientes
{
    public partial class Frm_Alta_Clientes : Form
    {
        private Cliente Cliente;
        private IClientesService servicio;
        private List<Cliente> clientes;
        int id;
        public Frm_Alta_Clientes()
        {
            servicio = new ClienteService();
            InitializeComponent();
        }
        private void Frm_Alta_Clientes_Load(object sender, EventArgs e)
        {

            CargarComboLocalidades();
            CargarComboTiposDni();
            btnActualizar.Enabled = false;
            CargarDgv();



            cboLocalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoDni.DropDownStyle = ComboBoxStyle.DropDownList;

            Cliente = new Cliente();
        }

        public void CargarDgv()
        {
            clientes = servicio.GetClientes();

            foreach (Cliente item in clientes)
            {
                dgvClientes.Rows.Add(new object[] { item.Codigo, item.Nombre, item.Apellido, item.TipoDniEnLetras, item.NroDocumento, item.NombreLocalidad, item.Calle, item.NroCalle });

            }
        }

        private void CargarComboTiposDni()
        {
            DataTable tiposDni = servicio.GetTiposDni();
            cboTipoDni.DataSource = tiposDni;
            cboTipoDni.DisplayMember = tiposDni.Columns[1].ColumnName;
            cboTipoDni.ValueMember = tiposDni.Columns[0].ColumnName;
        }

        private void CargarComboLocalidades()
        {
            DataTable localidades = servicio.GetLocalidades();
            cboLocalidad.DataSource = localidades;
            cboLocalidad.DisplayMember = localidades.Columns[1].ColumnName;
            cboLocalidad.ValueMember = localidades.Columns[0].ColumnName;

        }



        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoDni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (validaciones())
            {
                bool flag;

                Cliente oCliente = new Cliente();
                oCliente.Nombre = txtNombre.Text;
                oCliente.Apellido = txtApellido.Text;
                oCliente.TipoDoc = (int)cboTipoDni.SelectedValue;
                oCliente.NroDocumento = Convert.ToInt32(txtDni.Text);
                oCliente.Localidad = cboLocalidad.SelectedIndex + 1;
                oCliente.Calle = txtCalle.Text;
                oCliente.NroCalle = Convert.ToInt32(txtNumero.Text);

                flag = servicio.SaveClientes(oCliente);

                if (flag)
                {
                    MessageBox.Show("Cliente guardado correctamente!", "Informacion", MessageBoxButtons.OK);
                  

                }
                else
                {
                    MessageBox.Show("No se pudo guardar el cliente!", "Error", MessageBoxButtons.OK);

                }

                DataRowView oDatarow = (DataRowView)cboLocalidad.SelectedItem;
                oCliente.Localidad = Int32.Parse(oDatarow[0].ToString());

                CargarDgv();
                LimpiarControles();
            }

           
        }

        private bool validaciones()
        {
            try
            {
                Convert.ToInt32(txtNumero.Text);
            }
              catch 
            {
                MessageBox.Show("Tipo de dato no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Text = "";
                txtNumero.Focus();
                return false;
            }
            try
            {
                Convert.ToInt32(txtDni.Text);
            }
            catch
            {
                MessageBox.Show("Tipo de dato no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDni.Text = "";
                txtDni.Focus();
                return false;
            }

            return true;
        }

        private void LimpiarControles()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCalle.Text = "";
            txtNumero.Text = "";
            txtDni.Text = "";
        }

        private void dgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {


            if (dgvClientes.CurrentCell.ColumnIndex == 8)
            {
                btnActualizar.Enabled = true;
                btnAceptar.Enabled = false;
                DataGridViewRow row = dgvClientes.CurrentRow;
                if (row != null)
                {

                    id = Int32.Parse(row.Cells["colNro"].Value.ToString());

                    Cliente newCliente = servicio.GetClienteById(id);

                    txtNombre.Text = newCliente.Nombre;
                    txtApellido.Text = newCliente.Apellido;
                    txtDni.Text = newCliente.NroDocumento.ToString();
                    txtCalle.Text = newCliente.Calle;
                    txtNumero.Text = newCliente.NroCalle.ToString();
                    cboLocalidad.SelectedValue = newCliente.Localidad;
                    cboTipoDni.SelectedValue = newCliente.TipoDoc;

                }
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (validaciones())
            {

                Cliente oClienteUp = new Cliente();

                oClienteUp.Codigo = id;
                oClienteUp.Nombre = txtNombre.Text;
                oClienteUp.Apellido = txtApellido.Text;
                oClienteUp.Calle = txtCalle.Text;

                oClienteUp.NroCalle = Convert.ToInt32(txtNumero.Text);
                oClienteUp.NroDocumento = Convert.ToInt32(txtDni.Text);
                oClienteUp.TipoDoc = Convert.ToInt32(cboTipoDni.SelectedValue);
                oClienteUp.Localidad = Convert.ToInt32(cboLocalidad.SelectedValue);

                bool flag = servicio.UpdateCliente(oClienteUp);
                if (flag)
                {
                    MessageBox.Show("Cliente Actualizado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvClientes.Rows.Clear();
                LimpiarControles();
                CargarDgv();
                btnActualizar.Enabled = false;
                btnAceptar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
