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

namespace VeterinariaFrontEnd.Presentacion.Login
{
    public partial class FrmRecuperContraseña : Form
    {
        private ILoginService loginService;
        private Veterinario oVeterinario;
        public FrmRecuperContraseña()
        {
            InitializeComponent();
            loginService = new LoginService();
            oVeterinario = new Veterinario();
        }

        private void btnAcepContra_Click(object sender, EventArgs e)
        {


            try
            {
                if (validaciones())
                {
                    oVeterinario.Nombre = txtNomContra.Text;
                    oVeterinario.Apellido = txtApeContra.Text;
                    oVeterinario.Matricula = Int32.Parse(txtMatContra.Text);

                    oVeterinario.NroDni = txtNroContra.Text;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("datos incorrectos");
            }
            

        }

        private void confirmar()
        {
            if (loginService.RecuperarContraseña(oVeterinario))
                MessageBox.Show("Exitos");
            else
                MessageBox.Show("fallo");
        }

        private bool validaciones()
        {
            bool flag = true;
            if (txtNroContra.Text == "")
            {
                MessageBox.Show("El Numero de dni está vacío");
                txtNroContra.Focus();
                flag = false;
                return flag;
            }
            if (txtUsuContra.Text == "")
            {
                MessageBox.Show("El Usuario está vacío");
                txtUsuContra.Focus();
                flag = false;
                return flag;
            }
            if (txtNomContra.Text == "")
            {
                MessageBox.Show("El Nombre está vacío");
                txtNomContra.Focus();
                flag = false;
                return flag;
            }
            if (txtApeContra.Text == "")
            {
                MessageBox.Show("El Apellido está vacío");
                txtApeContra.Focus();
                flag = false;
                return flag;
            }
            
            if (txtUsuContra.Text == "")
            {
                MessageBox.Show("La Matricula está vacío");
                txtUsuContra.Focus();
                flag = false;
                return flag;
            }
            if (!loginService.existeRestablcer(txtNomContra.Text, txtApeContra.Text, Int32.Parse(txtMatContra.Text), txtUsuContra.Text))
            {
                MessageBox.Show("usuario No existe");
                txtUsuContra.Focus();
                
                txtUsuContra.Text = "";
                flag = false;
                return flag;
            }
            else
            {
                oVeterinario.Usuario = txtUsuContra.Text;
                btnAcepContra.Enabled = true;
                MessageBox.Show("Ingrese su contraseña nueva") ;
                btnAcepContra.Visible = false;
                btnCanContra.Visible = false;
                btnGuardarContra.Visible = true;
                txtContrContra.Enabled = true;
                txtContrContra.Focus();

                flag = true;
                return flag;

            }
        }

        private void btnGuardarContra_Click(object sender, EventArgs e)
        {
            if (txtContrContra.TextLength > 8 && txtContrContra.TextLength < 15)
            {

                oVeterinario.Contraseña = txtContrContra.Text;
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Contraseña no valida");
                txtContrContra.Focus();
                txtContrContra.Text = "";
                return;

            }
            
            confirmar();
        }

        private void FrmRecuperContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
