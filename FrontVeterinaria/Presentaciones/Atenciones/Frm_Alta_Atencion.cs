using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaAtencionBack.Dominio;
using VeterinariaAtencionBack.Negocio.implementacion;
using VeterinariaAtencionBack.Negocio.interfaces;
using VeterinariaMascotaBack.Dominio;
using System.Net.Http.Json;

namespace FrontVeterinaria.Presentacion
{



    public enum Accion
    {
        CREATE,
        UPDATE
    }

    public partial class Frm_Alta_Atencion : Form
    {



        private IAtencionService servicio;
        private Accion modo;
        private Atencion oAtencion;
        private int idAtencion;

        public Frm_Alta_Atencion(Accion modo, int id)
        {
            InitializeComponent();
            servicio = new AtencionesService();
            this.modo = modo;
            idAtencion = id;

        


        }
 
        public void CargarFormularioUpdate(int id)
        {
            oAtencion = servicio.GetAtencion(id);

            cboClientes.Enabled = false;
            cboMascotas.Enabled = false;

            dtpFechaAtencion.Value = oAtencion.Fecha;
            dtpFechaControl.Value = oAtencion.FechaControl;
            txtImporte.Text = oAtencion.Importe.ToString();
            rtxtDescripcion.Text = oAtencion.Descripcion;
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo.Equals(Accion.CREATE))
            {
                if (cboClientes.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un Cliente!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cboMascotas.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una Mascota!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    Convert.ToDouble(txtImporte.Text);
                }
                 catch
                {
                    MessageBox.Show("Tipo de dato no válido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtImporte.Focus();
                    return;
                }

            }


            if (String.IsNullOrEmpty(txtImporte.Text))
            {
                MessageBox.Show("Debe colocar un Importe!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtImporte.Focus();
                return;
            }
            if (String.IsNullOrEmpty(rtxtDescripcion.Text))
            {
                MessageBox.Show("Debe completar una Descripción!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rtxtDescripcion.Focus();
                return;
            }



            if (modo.Equals(Accion.CREATE))
            {

                Atencion oAtencion = new Atencion();
                oAtencion.NumeroAtencion = servicio.GetProximaAtencion();
                oAtencion.IdMascota = Convert.ToInt32(cboMascotas.SelectedValue.ToString());
                oAtencion.Fecha = dtpFechaAtencion.Value;
                oAtencion.FechaControl = dtpFechaControl.Value;
                oAtencion.Importe = Convert.ToDouble(txtImporte.Text);
                oAtencion.Descripcion = rtxtDescripcion.Text;


                //bool guardado = servicio.SaveAtenciones(oAtencion);

                string data = JsonConvert.SerializeObject(oAtencion);

                bool result = await GrabarAtencionAsync(data);
            

                    if (result)
                    {
                        MessageBox.Show("Atención registrada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No pudo registrarse la atención", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose();
                    }

                }
        
                if (modo.Equals(Accion.UPDATE))
                {
                    Atencion oAtencion = new Atencion();
                    oAtencion.NumeroAtencion = idAtencion;
                    oAtencion.Fecha = dtpFechaAtencion.Value;
                    oAtencion.FechaControl = dtpFechaControl.Value;
                    oAtencion.Importe = Convert.ToDouble(txtImporte.Text);
                    oAtencion.Descripcion = rtxtDescripcion.Text;
                 


                    bool guardado = servicio.UpdateAtencion(oAtencion);

                    if (guardado)
                    {
                        MessageBox.Show("Atención Actualizada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("No pudo Actualizarse la atención", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose();
                    }
                }
        }
        


        private async Task<bool> GrabarAtencionAsync(string data)
        {
            string url = "https://localhost:44350/api/Atencion/SaveAtenciones";
            using (HttpClient client = new HttpClient())
            {
               
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }

        private async void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMascotas.DataSource = null;
            int id = Convert.ToInt32(cboClientes.SelectedIndex + 1);
            await CargarComboMascotas(id);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar la carga?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {

            cboClientes.SelectedIndex = 0;
            cboClientes.SelectedValue = "";
            cboMascotas.DataSource = null;
            dtpFechaAtencion.Value = DateTime.Today;
            dtpFechaControl.Value = DateTime.Today;
            txtImporte.Text = "";
            rtxtDescripcion.Text = "";
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void Frm_Alta_Atencion_Load(object sender, EventArgs e)
        {
            if (modo.Equals(Accion.CREATE))
            {
               await CargarComboClientes();
            }

            if (modo.Equals(Accion.UPDATE))
            {
                oAtencion = new Atencion();
                CargarFormularioUpdate(idAtencion);
                btnLimpiar.Enabled = false;
            }

        }
    }
}
