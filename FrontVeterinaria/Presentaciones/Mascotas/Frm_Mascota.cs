using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaAtencionBack.Dominio;
using VeterinariaAtencionBack.Negocio.implementacion;
using VeterinariaAtencionBack.Negocio.interfaces;
using VeterinariaMascotaBack.Dominio;
using VeterinariaMascotaBack.Negocio.interfaces;


namespace FrontVeterinaria.Presentaciones.Mascotas
{
    public partial class Frm_Mascota : Form
    {
        private IAtencionService servicioCiente;
        private IMascotaService servicioMascota;
        private Mascota oMascota;
        private List<Mascota> mascotas;
        private int id;
        public Frm_Mascota()
        {
            InitializeComponent();
            servicioCiente = new AtencionesService();
            servicioMascota = new FactoryMascota().CrearServicio();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Mascota_Load(object sender, EventArgs e)
        {
            CargarCombo();
            CargarDgv();
            dtpFechaDefuncion.Enabled = false;
            btnActualizar.Enabled = false;
            btnAceptar.Enabled = true;

        }

        public void CargarCombo()
        {
            List<Cliente> clientes = servicioCiente.GetClientes();
            cbo_Cliente.Items.AddRange(clientes.ToArray());

            cbo_especie.DataSource = servicioMascota.CargarCombo("Especies");
            cbo_especie.DisplayMember = "Nombre";
            cbo_especie.ValueMember = "Id_especie";

            cbo_raza.DataSource = servicioMascota.CargarCombo("Razas");
            cbo_raza.DisplayMember = "Nombre";
            cbo_raza.ValueMember = "Id_Raza";
        }


        private bool Validaciones()
        {
            if (String.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if(cbo_Cliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Seleccionar un Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbo_Cliente.Focus();
                return false;
            } 
            return true;
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Validaciones())
                {
                    DialogResult result = MessageBox.Show("¿Desea Agregar?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        oMascota = new Mascota();
                        oMascota.Clientes = Int32.Parse(cbo_Cliente.SelectedIndex.ToString()) + 1;
                        oMascota.Nombre = txtNombre.Text;
                        oMascota.Especie = Int32.Parse(cbo_especie.SelectedValue.ToString());
                        oMascota.Raza = Int32.Parse(cbo_raza.SelectedValue.ToString());

                        if (rbMascota.Checked)
                            oMascota.Sexo = 1;
                        else
                            oMascota.Sexo = 0;

                        oMascota.FechaNac = dtpFechaNacimiento.Value;
                        if (dtpFechaDefuncion.Enabled)
                            oMascota.FechaDefun = dtpFechaDefuncion.Value;
                        else
                            oMascota.FechaDefun = null;

                        oMascota.Esterilizado = ckbEsterilizado.Checked;

                        if (servicioMascota.SaveMascota(oMascota))
                        {
                            MessageBox.Show("Mascota guardada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar la Mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            CargarDgv();
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtNombre.Text = "";
            cbo_Cliente.SelectedIndex = -1;

        }

        public void CargarDgv()
        {
            mascotas = servicioMascota.GetMascotas();

            foreach (Mascota item in mascotas)
            {
                dgvMascotas.Rows.Add(new object[] { item.IdMascota, item.Nombre, item.ClienteEnLetras, item.EspecieEnLetras, item.RazaEnLetras, item.SexoEnLetras, item.FechaNac, item.FechaDefun, item.EsterilizadoEnLetras });

            }
        }

        private void chDef_CheckedChanged(object sender, EventArgs e)
        {
            if (chDef.Checked)
                dtpFechaDefuncion.Enabled = true;
            else
                dtpFechaDefuncion.Enabled = false;
        }

        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMascotas.CurrentCell.ColumnIndex == 9)
            {
                btnActualizar.Enabled = true;
                btnAceptar.Enabled = false;
                DataGridViewRow row = dgvMascotas.CurrentRow;
                if (row != null)
                {
                    id = Int32.Parse(row.Cells["colNro"].Value.ToString());

                    Mascota newMascota = servicioMascota.GetMascotaById(id);

                    txtNombre.Text = newMascota.Nombre;
                    cbo_Cliente.SelectedIndex = newMascota.Clientes - 1;
                    cbo_raza.SelectedValue = (int)newMascota.Raza;
                    cbo_especie.SelectedValue = newMascota.Especie;
                    ckbEsterilizado.Checked = newMascota.Esterilizado;
                    if (newMascota.FechaDefun != null)
                        chDef.Checked = true;
                    else
                        chDef.Checked = false;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            oMascota = new Mascota();
            oMascota.Clientes = Int32.Parse(cbo_Cliente.SelectedIndex.ToString()) + 1;
            oMascota.Nombre = txtNombre.Text;
            oMascota.Especie = Int32.Parse(cbo_especie.SelectedValue.ToString());
            oMascota.Raza = Int32.Parse(cbo_raza.SelectedValue.ToString());
            oMascota.IdMascota = id;
            if (rbMascota.Checked)
                oMascota.Sexo = 1;
            else
                oMascota.Sexo = 0;

            oMascota.FechaNac = dtpFechaNacimiento.Value;
            if (dtpFechaDefuncion.Enabled)
                oMascota.FechaDefun = dtpFechaDefuncion.Value;
            else
                oMascota.FechaDefun = null;



            oMascota.Esterilizado = ckbEsterilizado.Checked;

            if (servicioMascota.UpdateMascota(oMascota))
            {
                MessageBox.Show("Información de Mascota Actualizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar la Información de la Mascota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvMascotas.Rows.Clear();
            CargarDgv();
            LimpiarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
