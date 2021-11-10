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
using TpiVeterinaria.Dominio;
using TpiVeterinaria.servicio;
using TpiVeterinaria.servicio.implementacion;
using TpiVeterinaria.servicio.interfaces;

namespace TpiVeterinaria.Presentacion
{
    public partial class FrmConsultarAtencionMascota : Form
    {
        private IAtencionService servicio;

        public FrmConsultarAtencionMascota()
        {
            InitializeComponent();

            servicio = new AtencionesService();
        }

        private void FormConsultarMascota_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            List<Parametro> filtros = new List<Parametro>();
            filtros.Add(new Parametro("@fechaDesde", dtpDesde.Value));
            filtros.Add(new Parametro("@fechaHasta", dtpHasta.Value));

            object valCliente = DBNull.Value;
            if (!String.IsNullOrEmpty(txtCliente.Text))
                valCliente = txtCliente.Text;
            filtros.Add(new Parametro("@nombreCliente", valCliente));

            object valMascota = DBNull.Value;
            if (!String.IsNullOrEmpty(txtMascota.Text))
                valMascota = txtMascota.Text;
            filtros.Add(new Parametro("@nombreMascota", valMascota));

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
            int id = Int32.Parse(row.Cells["colNro"].Value.ToString());
            Atencion oAtencion = servicio.GetAtencion(id);

            Frm_Alta_Atencion frmAltaAtencion = new Frm_Alta_Atencion();
            frmAltaAtencion.ShowDialog();
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
