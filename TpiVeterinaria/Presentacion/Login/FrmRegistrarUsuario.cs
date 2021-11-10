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

        private void btnAcepReg_Click(object sender, EventArgs e)
        {
            //VALIDACIONES HASTA QUE NO SE CARGEN DOMICILIOS

            try
            {
                if (validaciones()) {

                    DialogResult result = MessageBox.Show("¿Desea Agregar?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        oVeterinario.Nombre = txtNomReg.Text;
                        oVeterinario.Apellido = txtApeReg.Text;
                        oVeterinario.Matricula = Int32.Parse(txtMatReg.Text);

                        oVeterinario.Domicilio = Int32.Parse(cboDomicilio.SelectedValue.ToString());
                        oVeterinario.Localidad = Int32.Parse(cboLocReg.SelectedValue.ToString());
                        oVeterinario.TipoDni = Int32.Parse(cboTiporeg.SelectedValue.ToString());
                        oVeterinario.NroDni = txtNroReg.Text;
                        confirmar();
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
                MessageBox.Show("El Numero de dni está vacío");
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
                MessageBox.Show("La Contraseña está vacío");
                txtContrReg.Focus();
                flag = false;
                return flag;
            }
            if (txtMatReg.Text == "")
            {
                MessageBox.Show("La Matricula está vacío");
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
                MessageBox.Show("valor No valido");
                txtMatReg.Focus();
                txtMatReg.Text = "";
                flag = false;
                return flag;
            }
            return flag;
        }

        private void confirmar()
        {
            //FALTA LAS CAPAS Y LAS INTERFACES
            if (loginService.RegistrarUsuario( oVeterinario))
                MessageBox.Show("Exitos");
                
                
            else
                MessageBox.Show("fallo");

        }

        private void FrmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            cboDomicilio.DataSource = loginService.CargarCombo("Domicilio");
            cboDomicilio.DisplayMember = "Calle";
            cboDomicilio.ValueMember = "id_domicilio";

            cboLocReg.DataSource = loginService.CargarCombo("Localidad");
            cboLocReg.ValueMember = "Id_localidad";
            cboLocReg.DisplayMember = "Nombre";

            cboTiporeg.DataSource = loginService.CargarCombo("Tipo");
            cboTiporeg.ValueMember = "Id_tipo";
            cboTiporeg.DisplayMember = "Descripcion";

        }

        private void cboLocReg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
