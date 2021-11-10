using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaLoginBack.Dominio;
using VeterinariaLoginBack.Negocio.interfaces;
using VeterinariaLoginBack.servicio.implementacion;

namespace FrontVeterinaria.Presentacion
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

                MessageBox.Show("Datos incorrectos");
            }


        }

        private async Task<bool> confirmarAsync(string data)
        {
            string url = "https://localhost:44350/api/Login/RecuperarContraseña";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("OK");
            }
        }
        private bool validaciones()
        {
            bool flag = true;
            if (txtNroContra.Text == "")
            {
                MessageBox.Show("El Número de dni está vacío");
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
                MessageBox.Show("La Matrícula está vacía");
                txtUsuContra.Focus();
                flag = false;
                return flag;
            }
            if (loginService.existeRestablcer(txtNomContra.Text, txtApeContra.Text, Int32.Parse(txtMatContra.Text), txtUsuContra.Text))
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
                MessageBox.Show("Ingrese su contraseña nueva");
                btnAcepContra.Visible = false;
                btnCanContra.Visible = false;
                btnGuardarContra.Visible = true;
                txtContrContra.Enabled = true;
                txtContrContra.Focus();

                flag = true;
                return flag;

            }
        }

        private async void btnGuardarContra_Click(object sender, EventArgs e)
        {
            if (txtContrContra.TextLength > 8 && txtContrContra.TextLength < 15)
            {

                oVeterinario.Contraseña = txtContrContra.Text;
                string data = JsonConvert.SerializeObject(oVeterinario);
                bool success = await confirmarAsync(data);
                if (success)
                    MessageBox.Show("Exitos");
                else
                    MessageBox.Show("fallo");

                this.Dispose();

            }
            else
            {
                MessageBox.Show("Contraseña no valida");
                txtContrContra.Focus();
                txtContrContra.Text = "";
                return;

            }


        }

        private void FrmRecuperContraseña_Load(object sender, EventArgs e)
        {

        }
    }
}
