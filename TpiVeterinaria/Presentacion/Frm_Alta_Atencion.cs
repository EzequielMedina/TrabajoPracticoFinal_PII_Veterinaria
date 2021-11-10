using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpiVeterinaria.Dominio;
using TpiVeterinaria.servicio.implementacion;
using TpiVeterinaria.servicio.interfaces;

namespace TpiVeterinaria.Presentacion
{
   
  
    public partial class Frm_Alta_Atencion : Form
    {
        //oooo
        private IAtencionService servicio;
        //private Atencion oAtencion;
        //private int idAtencion; 
        //public Frm_Alta_Atencion(int idAtencion)
        //{
        //    InitializeComponent();
        //    servicio = new AtencionesService();
        //    oAtencion = new Atencion();
        //    CargarComboClientes();
        //    idAtencion = this.idAtencion;
        //}
    
        public Frm_Alta_Atencion()
        {
            InitializeComponent();
            servicio = new AtencionesService();
            CargarComboClientes();
           
                //CargarFormularioUpdate(idAtencion);
            
        }

        //public void CargarFormularioUpdate(int id)
        //{
        //    oAtencion = servicio.GetAtencion(id);

        //    cboClientes.Enabled = false;
        //    cboMascotas.Enabled = false;

        //    dtpFechaAtencion.Value = oAtencion.Fecha;
        //    dtpFechaControl.Value = oAtencion.FechaControl;
        //    txtImporte.Text = oAtencion.Importe.ToString();
        //    rtxtDescripcion.Text = oAtencion.Descripcion;
        //}

        public void CargarComboClientes()
        {
            List<Cliente> clientes = servicio.GetClientes();

           // cboClientes.DataSource = clientes;
           
           

            cboClientes.Items.AddRange(clientes.ToArray());
            //cboClientes.ValueMember = "Codigo";
            //cboClientes.DisplayMember = "Nombre";
        }

        public void CargarComboMascotas(int id)
        {
            List<Mascota> mascotas = servicio.GetMascotas(id);

            cboMascotas.DataSource = mascotas;
            cboMascotas.ValueMember = "IdMascota";
            cboMascotas.DisplayMember = "Nombre";
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Atencion oAtencion = new Atencion();
            oAtencion.NumeroAtencion = servicio.GetProximaAtencion();
            oAtencion.IdMascota = cboMascotas.SelectedIndex + 1;
            oAtencion.Fecha = dtpFechaAtencion.Value;
            oAtencion.FechaControl = dtpFechaControl.Value;
            oAtencion.Importe = Convert.ToDouble(txtImporte.Text);
            oAtencion.Descripcion = rtxtDescripcion.Text;
            

            bool guardado = servicio.SaveAtenciones(oAtencion);

            if (guardado)
            {
                MessageBox.Show("Atención registrada con éxito!");
            }
            else
            {
                MessageBox.Show("No pudo registrarse la atención");
            }
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMascotas.DataSource = null;
            int id  = Convert.ToInt32(cboClientes.SelectedIndex +1);
            CargarComboMascotas(id);
        }
    }
}
