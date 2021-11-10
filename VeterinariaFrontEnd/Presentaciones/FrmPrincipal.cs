using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpiVeterinaria.Presentacion;
using System.Runtime.InteropServices;

namespace VeterinariaFrontEnd
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();

            //Eliminamos barras sup de windows
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

       
       //Metodo para resaltar el color de los botones
     

      

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //NO ESTA HABILITADO PARA QUE SE PUEDA PROGRAMAR MAS TRANQUILO
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            


        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AboutBox1 about = new AboutBox1();
            //about.ShowDialog("Hola");
            
        }

        private void acercaDeVeterinariaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación Veterinaria");
        }

        private void consultarMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarAtencionMascota frmConsulta = new FrmConsultarAtencionMascota();
            frmConsulta.ShowDialog();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconBarra.IconChar = IconChar.Home;
            iconBarra.IconColor = Color.FromArgb(60, 38, 13); //vino
            lblBarra.Text = "Inicio";

        }

        private void btnAltaVet_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
            AbrirFormActual(new FrmRegistrarUsuario());
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
        }

        private void btnAltaMascota_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
        }

        private void btnNuevaAten_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
            AbrirFormActual(new FrmConsultarAtencionMascota());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
        }

        //importamos lib para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Close-Maximize-Minimize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void AbrirFormActual(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlEscritorio.Controls.Add(childForm);
            pnlEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblBarra.Text = childForm.Text;
        }


    }
   
}
