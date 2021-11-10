using FrontVeterinaria.Presentacion;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaLoginBack.Datos;
using VeterinariaLoginBack.Dominio;
using VeterinariaLoginBack.Negocio;
using VeterinariaLoginBack.Negocio.interfaces;

namespace FrontVeterinaria.Presentacion
{
    public partial class FrmLogin : Form
    {
        private ILoginService loginService;
        private Veterinario oVeterinario;
        private int cerrar = 0;

        public FrmLogin()
        {
            InitializeComponent();
            loginService = new FactoryLogin().CrearServicio();
            oVeterinario = new Veterinario();
            
        }




        private async void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            cerrar = 1;
            if (TxtUsuario.Text == "")
            {
                MessageBox.Show("El usuario está vacío");
                TxtUsuario.Focus();
                return;
            }
            if (TxtPass.Text == "")
            {
                MessageBox.Show("La contraseña está vacía");
                TxtPass.Focus();
                return;
            }
            oVeterinario.Usuario = TxtUsuario.Text;
            oVeterinario.Contraseña = TxtPass.Text;

            string data = JsonConvert.SerializeObject(oVeterinario);


            bool success = await ValidarUsuarioAsync(data);

            if (success)
            {

                string saludo = loginService.RecuperarUsuario(TxtUsuario.Text, TxtPass.Text);
                MessageBox.Show("Bienvenido " + saludo);
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
                TxtUsuario.Focus();
            }

            
        }

        private async Task<bool> ValidarUsuarioAsync(string data)
        {
            string url = "https://localhost:44350/api/Login/Validar";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("OK");

            }
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            cerrar = 1;
            FrmRegistrarUsuario Registrar = new FrmRegistrarUsuario();
            Registrar.ShowDialog();
            

        }

        private void btn_Recuperar_Click(object sender, EventArgs e)
        {
            cerrar = 1;
            FrmRecuperContraseña recuperarContraseña = new FrmRecuperContraseña();
            recuperarContraseña.ShowDialog();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrar == 0)
            {
                if (MessageBox.Show("Seguro de abandonar la aplicación ?",
                  "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    cerrar = 1;
                    Application.Exit();
            }


        }
    }
}
