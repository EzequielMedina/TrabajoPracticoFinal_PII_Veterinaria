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
using TpiVeterinaria.servicio.implementacion;
using TpiVeterinaria.servicio.interfaces;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace TpiVeterinaria
{
    public partial class FrmPrincipal : Form
    {

        //boton actual 
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private object iconBarra;
        private object lblBarra;

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

        private struct RGBColor
        {
            public static Color color = Color.FromArgb(60, 38, 13); //vino
        }

       //Metodo para resaltar el color de los botones
        private void ActivateButton(object senderBtn, Color color)
        {
                if (senderBtn != null)
                {
                DisableButton();
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(112, 167, 175); //cambio de color del boton marron
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

        private void DisableButton() //Volvemos el boton al estado original
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(137, 198, 207); //celeste 
                currentBtn.ForeColor = Color.FromArgb(60,38,13); //vino
                currentBtn.TextAlign = ContentAlignment.MiddleLeft; 
                currentBtn.IconColor = Color.FromArgb(60, 38, 13); //vino
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
               

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

        private void cargarAtencionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Atencion frmAltaAtencion = new Frm_Alta_Atencion();
            frmAltaAtencion.ShowDialog();
        }
    }
}
