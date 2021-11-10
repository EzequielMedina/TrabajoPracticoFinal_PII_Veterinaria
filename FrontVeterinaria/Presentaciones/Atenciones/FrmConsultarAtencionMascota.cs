using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaAtencionBack.Dominio;
using VeterinariaAtencionBack.Negocio;
using VeterinariaAtencionBack.Negocio.implementacion;
using VeterinariaAtencionBack.Negocio.interfaces;
using VeterinariaMascotaBack.Dominio;

namespace FrontVeterinaria.Presentacion
{
    public partial class FrmConsultarAtencionMascota : Form
    {
        private IAtencionService servicio;

        public FrmConsultarAtencionMascota()
        {
            InitializeComponent();

            servicio = new AtencionesService();
        }

        private async void FormConsultarMascota_Load(object sender, EventArgs e)
        {
            await CargarComboClientes();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtNombreCliente.Text))
            //{
            //    MessageBox.Show("Debe ingresar el nombre del Cliente!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtNombreCliente.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(txtApellidoCliente.Text))
            //{
            //    MessageBox.Show("Debe ingresar el apellido del Cliente!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtApellidoCliente.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(txtDni.Text))
            //{
            //    MessageBox.Show("Debe ingresar el DNI del Cliente!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtDni.Focus();
            //    return;
            //}
            //if (String.IsNullOrEmpty(txtMascota.Text))
            //{
            //    MessageBox.Show("Debe ingresar el nombre de la Mascota!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtMascota.Focus();
            //    return;
            //}
            //try
            //{
            //    Convert.ToInt32(txtDni.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Tipo de dato no válido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtDni.Focus();
            //    return;
            //}


            List<Parametro> filtros = new List<Parametro>();
            filtros.Add(new Parametro("@fechaDesde", dtpDesde.Value));
            filtros.Add(new Parametro("@fechaHasta", dtpHasta.Value));

            object valMascota = DBNull.Value;
            if (cboMascotas.SelectedIndex != -1)
                valMascota = Convert.ToInt32(cboMascotas.SelectedValue.ToString());
            filtros.Add(new Parametro("@IdMascota", valMascota));

            string conBaja = "N";
            if (chkBaja.Checked)
                conBaja = "S";
            filtros.Add(new Parametro("@datosBaja", conBaja));

            List<Atencion> lista = servicio.ConsultarAtenciones(filtros);

            dgvResultados.Rows.Clear();
            foreach (Atencion oAtencion in lista)
            {

                dgvResultados.Rows.Add(new object[]{
                                        oAtencion.NumeroAtencion,
                                        oAtencion.Fecha.ToString("dd/MM/yyyy"),
                                        oAtencion.Descripcion,
                                        oAtencion.Importe,
                                        oAtencion.FechaControl.ToString("dd/MM/yyyy"),
                                        oAtencion.GetFechaBajaFormato(),

                 });

            }

            if (dgvResultados.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados con los criterios de búsqueda seleccionados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvResultados.CurrentRow;
            if (row != null)
            {
                int id = Int32.Parse(row.Cells["colNro"].Value.ToString());
                if (MessageBox.Show("¿Esta seguro que desea eliminar la atencion seleccionada?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool respuesta = servicio.EliminarAtencion(id);

                    if (respuesta)
                    {
                        MessageBox.Show("Atencion eliminada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnConsultar_Click(null, null);
                    }
                    else
                        MessageBox.Show("Error al intentar eliminar la atencion!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvResultados.CurrentRow;
            if (row != null)
            {
                int id = Int32.Parse(row.Cells["colNro"].Value.ToString());
                Atencion oAtencion = servicio.GetAtencion(id);

                Frm_Alta_Atencion frmAltaAtencion = new Frm_Alta_Atencion(Accion.UPDATE, id);
                frmAltaAtencion.ShowDialog();
            }

        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

 //           new Frm_Reporte().ShowDialog();

        }

        public async Task CargarComboClientes()
        {
            string url = "https://localhost:44350/api/Atencion/GetClientes";
            using (HttpClient cliente = new HttpClient())
            {
                var result = await cliente.GetAsync(url);
                var bodyJSON = await result.Content.ReadAsStringAsync();
                List<Cliente> clientes = JsonConvert.DeserializeObject<List<Cliente>>(bodyJSON);
                cboClientes.Items.AddRange(clientes.ToArray());

            }
        }

        public async Task CargarComboMascotas(int id)
        {
            string url = "https://localhost:44350/api/Atencion/" + id;
            using (HttpClient cliente = new HttpClient())
            {

                var result = await cliente.GetAsync(url);
                var bodyJSON = await result.Content.ReadAsStringAsync();

                List<Mascota> mascotas = JsonConvert.DeserializeObject<List<Mascota>>(bodyJSON);
                cboMascotas.DataSource = mascotas;
                cboMascotas.ValueMember = "IdMascota";
                cboMascotas.DisplayMember = "Nombre";
            }

        }

        private async void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMascotas.DataSource = null;
            int id = Convert.ToInt32(cboClientes.SelectedIndex + 1);
            await CargarComboMascotas(id);
        }
    }
}
