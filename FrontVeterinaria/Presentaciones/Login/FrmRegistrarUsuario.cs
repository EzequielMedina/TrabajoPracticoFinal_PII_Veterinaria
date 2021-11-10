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
    //refactorizar para la web api
    public partial class FrmRegistrarUsuario : Form
    {
        private ILoginService loginService;
        private Veterinario oVeterinario;
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
            loginService = new LoginService();
            oVeterinario = new Veterinario();
        }

        private async void btnAcepReg_ClickAsync(object sender, EventArgs e)
        {
            //VALIDACIONES HASTA QUE NO SE CARGEN DOMICILIOS

            try
            {
                if (validaciones())
                {

                    DialogResult result = MessageBox.Show("¿Desea Agregar?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        oVeterinario.Nombre = txtNomReg.Text;
                        oVeterinario.Apellido = txtApeReg.Text;
                        oVeterinario.Matricula = Int32.Parse(txtMatReg.Text);

                        //oVeterinario.Domicilio = Int32.Parse(cboDomicilio.SelectedValue.ToString());
                        //oVeterinario.Localidad = Int32.Parse(cboLocReg.SelectedValue.ToString());
                        //oVeterinario.TipoDni = Int32.Parse(cboTiporeg.SelectedValue.ToString());
                        oVeterinario.NroDni = txtNroReg.Text;
                        string data = JsonConvert.SerializeObject(oVeterinario);

                        bool success = await GrabarVeterinarioAsync(data);
                        if (success)
                        {
                            MessageBox.Show("Usuario registrado con éxito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await limipiarCamposAsync();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un inconveniente al registrar el Usuario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        //confirmarAsync();
                        this.Dispose();

                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Datos incorrectos");
                return;
            }



        }

        private async Task limipiarCamposAsync()
        {

            txtNomReg.Text = string.Empty;
            txtNomReg.Focus();
            txtApeReg.Text = string.Empty;
        }

        private bool validaciones()
        {
            bool flag = true;
            if (txtNomReg.Text == "")
            {
                MessageBox.Show("El Nombre está vacío");
                txtNomReg.Focus();
                flag = false;
                return flag;
            }
            if (txtApeReg.Text == "")
            {
                MessageBox.Show("El Apellido está vacío");
                txtApeReg.Focus();
                flag = false;
                return flag;
            }

            if (txtNroReg.Text == "")
            {
                MessageBox.Show("El Número de dni está vacío");
                txtContrReg.Focus();
                flag = false;
                return flag;
            }
            if (txtUsuReg.Text == "")
            {
                MessageBox.Show("El Usuario está vacío");
                txtContrReg.Focus();
                flag = false;
                return flag;
            }
            if (txtContrReg.Text == "")
            {
                MessageBox.Show("La Contraseña está vacía");
                txtContrReg.Focus();
                flag = false;
                return flag;
            }
            if (txtMatReg.Text == "")
            {
                MessageBox.Show("La Matrícula está vacía");
                txtMatReg.Focus();
                flag = false;
                return flag;
            }


            if (loginService.existe(txtUsuReg.Text))
            {
                oVeterinario.Usuario = txtUsuReg.Text;
            }
            else
            {
                MessageBox.Show("usuario ya existe");
                txtUsuReg.Focus();
                txtUsuReg.Text = "";
                flag = false;
                return flag;
            }

            if (txtContrReg.TextLength > 8 && txtContrReg.TextLength < 15)
            {

                oVeterinario.Contraseña = txtContrReg.Text;

            }
            else
            {
                MessageBox.Show("Contraseña no valida");
                txtContrReg.Focus();
                txtContrReg.Text = "";
                flag = false;
                return flag;

            }
            try
            {
                Convert.ToInt32(txtMatReg.Text);
            }
            catch
            {
                MessageBox.Show("Dato No válido");
                txtMatReg.Focus();
                txtMatReg.Text = "";
                flag = false;
                return flag;
            }
            try
            {
                Convert.ToInt32(txtNroReg.Text);
            }
            catch
            {
                MessageBox.Show("Documento No válido");
                txtNroReg.Focus();
                txtNroReg.Text = "";
                flag = false;
                return flag;
            }
            return flag;
        }

        private async void confirmarAsync()
        {
            //FALTA LAS CAPAS Y LAS INTERFACES




            if (loginService.RegistrarUsuario(oVeterinario))
                MessageBox.Show("Exitos");


            else
                MessageBox.Show("fallo");

        }

        private async Task<bool> GrabarVeterinarioAsync(string data)
        {
            string url = "https://localhost:44350/api/Login/RegistrarUsuario";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("OK");

            }
        }

        private async void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            await CargarComboAsync();

        }

        private async Task CargarComboAsync()
        {
            string urlDomicilio = "https://localhost:44350/api/Login/CboDomicilio";
            using (HttpClient clienteD = new HttpClient())
            {
                var resultD = await clienteD.GetAsync(urlDomicilio);
                var bodyJSOND = await resultD.Content.ReadAsStringAsync();
                List<Domicilios> lstD = JsonConvert.DeserializeObject<List<Domicilios>>(bodyJSOND);
                //cargar combo:

                cboDomicilio.DataSource = lstD;
                cboDomicilio.DisplayMember = "Nombre";
                //cboDomicilio.ValueMember = "Id_domicilio";
            }

            string urlLocalidad = "https://localhost:44350/api/Login/CboLocalidad";
            using (HttpClient clientL = new HttpClient())
            {

                var resultL = await clientL.GetAsync(urlLocalidad);
                var bodyJSONL = await resultL.Content.ReadAsStringAsync();
                List<Localidades> lstL = JsonConvert.DeserializeObject<List<Localidades>>(bodyJSONL);
                //cargar combo:

                cboLocReg.DataSource = lstL;
                cboLocReg.DisplayMember = "Nombre";
                //cboLocReg.ValueMember = "Id_localidad";
            }



            string urlTipo = "https://localhost:44350/api/Login/CboTipo";
            using (HttpClient clienteT = new HttpClient())
            {
                var resultT = await clienteT.GetAsync(urlTipo);
                var bodyJSONT = await resultT.Content.ReadAsStringAsync();
                List<Tipos_Dni> lstT = JsonConvert.DeserializeObject<List<Tipos_Dni>>(bodyJSONT);
                //cargar combo:

                cboTiporeg.DataSource = lstT;
                cboTiporeg.DisplayMember = "Nombre";
                //cboDomicilio.ValueMember = "Id_tipo";
            }

        }

        private void cboLocReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCanReg_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
