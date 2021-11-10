
using System.Windows.Forms;

namespace VeterinariaFrontEnd
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeMascotaToolStripMenuItem,
            this.consultarMascotaToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // altaDeMascotaToolStripMenuItem
            // 
            this.altaDeMascotaToolStripMenuItem.Name = "altaDeMascotaToolStripMenuItem";
            this.altaDeMascotaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.altaDeMascotaToolStripMenuItem.Text = "Alta de Mascota";
            // 
            // consultarMascotaToolStripMenuItem
            // 
            this.consultarMascotaToolStripMenuItem.Name = "consultarMascotaToolStripMenuItem";
            this.consultarMascotaToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.consultarMascotaToolStripMenuItem.Text = "Consultar Atenciones Mascota";
            this.consultarMascotaToolStripMenuItem.Click += new System.EventHandler(this.consultarMascotaToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeVeterinariaAppToolStripMenuItem,
            this.informacionToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.acercaDeToolStripMenuItem.Text = "Ayuda";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // acercaDeVeterinariaAppToolStripMenuItem
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // altaDeMascotaToolStripMenuItem
            // 
            this.acercaDeVeterinariaAppToolStripMenuItem.Name = "acercaDeVeterinariaAppToolStripMenuItem";
            this.acercaDeVeterinariaAppToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.acercaDeVeterinariaAppToolStripMenuItem.Text = "Acerca de Veterinaria App";
            this.acercaDeVeterinariaAppToolStripMenuItem.Click += new System.EventHandler(this.acercaDeVeterinariaAppToolStripMenuItem_Click);
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.pnlMenu.Controls.Add(this.btnInfo);
            this.pnlMenu.Controls.Add(this.btnConsulta);
            this.pnlMenu.Controls.Add(this.btnNuevaAten);
            this.pnlMenu.Controls.Add(this.btnAltaMascota);
            this.pnlMenu.Controls.Add(this.btnAltaCliente);
            this.pnlMenu.Controls.Add(this.btnAltaVet);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 24);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnlMenu.Size = new System.Drawing.Size(200, 570);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 32;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 440);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInfo.Size = new System.Drawing.Size(200, 50);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Acerca de";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConsulta.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnConsulta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsulta.IconSize = 32;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 390);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsulta.Size = new System.Drawing.Size(200, 50);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consulta Atención";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnNuevaAten
            // 
            this.btnNuevaAten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnNuevaAten.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaAten.FlatAppearance.BorderSize = 0;
            this.btnNuevaAten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaAten.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaAten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevaAten.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.btnNuevaAten.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevaAten.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaAten.IconSize = 32;
            this.btnNuevaAten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaAten.Location = new System.Drawing.Point(0, 340);
            this.btnNuevaAten.Name = "btnNuevaAten";
            this.btnNuevaAten.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNuevaAten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNuevaAten.Size = new System.Drawing.Size(200, 50);
            this.btnNuevaAten.TabIndex = 5;
            this.btnNuevaAten.Text = "Nueva Atención";
            this.btnNuevaAten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaAten.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaAten.UseVisualStyleBackColor = false;
            this.btnNuevaAten.Click += new System.EventHandler(this.btnNuevaAten_Click);
            // 
            // btnAltaMascota
            // 
            this.btnAltaMascota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnAltaMascota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaMascota.FlatAppearance.BorderSize = 0;
            this.btnAltaMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaMascota.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaMascota.IconChar = FontAwesome.Sharp.IconChar.Cat;
            this.btnAltaMascota.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaMascota.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaMascota.IconSize = 32;
            this.btnAltaMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaMascota.Location = new System.Drawing.Point(0, 290);
            this.btnAltaMascota.Name = "btnAltaMascota";
            this.btnAltaMascota.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAltaMascota.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAltaMascota.Size = new System.Drawing.Size(200, 50);
            this.btnAltaMascota.TabIndex = 4;
            this.btnAltaMascota.Text = "Alta Mascota";
            this.btnAltaMascota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaMascota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaMascota.UseVisualStyleBackColor = false;
            this.btnAltaMascota.Click += new System.EventHandler(this.btnAltaMascota_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnAltaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaCliente.FlatAppearance.BorderSize = 0;
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAltaCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaCliente.IconSize = 32;
            this.btnAltaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.Location = new System.Drawing.Point(0, 240);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAltaCliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAltaCliente.Size = new System.Drawing.Size(200, 50);
            this.btnAltaCliente.TabIndex = 3;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaCliente.UseVisualStyleBackColor = false;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnAltaVet
            // 
            this.btnAltaVet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnAltaVet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaVet.FlatAppearance.BorderSize = 0;
            this.btnAltaVet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaVet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaVet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaVet.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.btnAltaVet.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaVet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaVet.IconSize = 32;
            this.btnAltaVet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaVet.Location = new System.Drawing.Point(0, 190);
            this.btnAltaVet.Name = "btnAltaVet";
            this.btnAltaVet.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAltaVet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAltaVet.Size = new System.Drawing.Size(200, 50);
            this.btnAltaVet.TabIndex = 2;
            this.btnAltaVet.Text = "Alta Veterinario";
            this.btnAltaVet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaVet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaVet.UseVisualStyleBackColor = false;
            this.btnAltaVet.Click += new System.EventHandler(this.btnAltaVet_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 32;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 140);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInicio.Size = new System.Drawing.Size(200, 50);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 140);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpiVeterinaria.Properties.Resources.Logo_Vet_Tr;
            this.pictureBox1.Location = new System.Drawing.Point(35, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.lblBarra);
            this.panel2.Controls.Add(this.iconBarra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 80);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.lblBarra.Location = new System.Drawing.Point(60, 34);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(44, 16);
            this.lblBarra.TabIndex = 1;
            this.lblBarra.Text = "Inicio";
            // 
            // iconBarra
            // 
            this.iconBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.iconBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.iconBarra.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconBarra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(38)))), ((int)(((byte)(13)))));
            this.iconBarra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBarra.Location = new System.Drawing.Point(25, 24);
            this.iconBarra.Name = "iconBarra";
            this.iconBarra.Size = new System.Drawing.Size(32, 32);
            this.iconBarra.TabIndex = 0;
            this.iconBarra.TabStop = false;
            // 
            // pnlEscritorio
            // 
            this.pnlEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pnlEscritorio.BackgroundImage = global::TpiVeterinaria.Properties.Resources.background_5;
            this.pnlEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEscritorio.Location = new System.Drawing.Point(200, 104);
            this.pnlEscritorio.Name = "pnlEscritorio";
            this.pnlEscritorio.Size = new System.Drawing.Size(684, 490);
            this.pnlEscritorio.TabIndex = 5;
            // consultarMascotaToolStripMenuItem
            // 
            this.consultarMascotaToolStripMenuItem.Name = "consultarMascotaToolStripMenuItem";
            this.consultarMascotaToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.consultarMascotaToolStripMenuItem.Text = "Consultar Atenciones Mascota";
            this.consultarMascotaToolStripMenuItem.Click += new System.EventHandler(this.consultarMascotaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 594);
            this.Controls.Add(this.pnlEscritorio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "Veterinaria TerraVision";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMascotaToolStripMenuItem;
    }
}

