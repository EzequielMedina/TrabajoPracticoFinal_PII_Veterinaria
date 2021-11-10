using System;
using System.Windows.Forms;
using TpiVeterinaria.Presentacion.Login;
using VeterinariaLoginBack.Datos;
using VeterinariaLoginBack.Negocio.interfaces;

namespace VeterinariaFrontEnd.Presentacion
{
    public partial class FrmLogin : Form
    {
        private ILoginService loginService;
      

        public FrmLogin(AbstractFactoryLogin factory)
        {
            InitializeComponent();
            loginService = factory.CrearServicio();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("El usuario está vacío");
                TxtUsuario.Focus();
                return;
            }
            if (TxtPass.Text == "")
            {
                MessageBox.Show("El password está vacío");
                TxtPass.Focus();
                return;
            }


            if (loginService.ValidarUsuario(TxtUsuario.Text, TxtPass.Text))
            {
                string saludo = loginService.RecuperarUsuario(TxtUsuario.Text, TxtPass.Text);               
                MessageBox.Show("Bienvenido " + saludo);
                this.Dispose();
                
            }
            else {
                MessageBox.Show("Usuario incorrecto");
                TxtUsuario.Focus();
            }
            
            
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario Registrar = new FrmRegistrarUsuario();
            Registrar.ShowDialog();
            
        }

        private void btn_Recuperar_Click(object sender, EventArgs e)
        {
            FrmRecuperContraseña recuperarContraseña = new FrmRecuperContraseña();
            recuperarContraseña.ShowDialog();
        }
    }
}
