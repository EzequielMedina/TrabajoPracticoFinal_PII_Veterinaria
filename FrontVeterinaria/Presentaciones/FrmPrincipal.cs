using FontAwesome.Sharp;
using FrontVeterinaria.Presentacion;
using FrontVeterinaria.Presentaciones.Clientes;
using FrontVeterinaria.Presentaciones.Login;
using FrontVeterinaria.Presentaciones.Mascotas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontVeterinaria.Presentaciones
{
    public partial class FrmPrincipal : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FrmPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50); //ancho de borde izq
            pnlMenu.Controls.Add(leftBorderBtn);

            //Eliminamos barras sup de windows
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            lblFecha.Visible = true;
            tmrEscritorio.Enabled = true;
        }

        //Comportamiento botones

        private struct RGBColor
        {
            public static Color color = Color.FromArgb(60, 38, 13); //vino
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconBarra.IconChar = IconChar.Home;
            iconBarra.IconColor = Color.FromArgb(60, 38, 13); //vino
            lblBarra.Text = "Inicio";
            lblFecha.Visible = true;
        }

        private void DisableButton() //Volvemos el boton al estado original
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(137, 198, 207); //celeste 
                currentBtn.ForeColor = Color.FromArgb(60, 38, 13); //vino
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(60, 38, 13); //vino
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(112, 167, 175); //fondo boton celeste oscuro
                currentBtn.ForeColor = color; //cambio color fuente
                currentBtn.TextAlign = ContentAlignment.MiddleCenter; //nueva posición texto boton
                currentBtn.IconColor = color; //cambio color icono
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage; // texto antes de icono
                currentBtn.ImageAlign = ContentAlignment.MiddleRight; //alineación de icono a la derecha

                //borde naranja izq boton
                leftBorderBtn.BackColor = Color.FromArgb(255, 102, 51);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //barra superior
                iconBarra.IconChar = currentBtn.IconChar;
                iconBarra.IconColor = color;
                lblBarra.Text = currentBtn.Text;
            }
        }

        private void btnAltaUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
            AbrirFormActual(new FrmRegistrarUsuario());
            lblFecha.Visible = false;
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

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
            lblFecha.Visible = false;
            AbrirFormActual(new Frm_Alta_Clientes());

        }

        private void btnAltaMascota_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
            lblFecha.Visible = false;
            AbrirFormActual(new Frm_Mascota());
        }

        private void btnNuevaAten_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
            lblFecha.Visible = false;
            AbrirFormActual(new Frm_Alta_Atencion(Accion.CREATE, 1));
        }

        private void btnConsAten_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
            lblFecha.Visible = false;
            AbrirFormActual(new FrmConsultarAtencionMascota());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColor.color);
            lblFecha.Visible = false;
            AbrirFormActual(new FrmAbout());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de abandonar la aplicación ?",
                "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                   Application.Exit();
            
        }

        //importamos lib para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pnlBarra_Paint(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tmrEscritorio_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
