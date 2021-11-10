
namespace FrontVeterinaria.Presentaciones
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.btnConsAten = new FontAwesome.Sharp.IconButton();
            this.btnNuevaAten = new FontAwesome.Sharp.IconButton();
            this.btnAltaMascota = new FontAwesome.Sharp.IconButton();
            this.btnAltaCliente = new FontAwesome.Sharp.IconButton();
            this.btnAltaUser = new FontAwesome.Sharp.IconButton();
            this.btnInicio = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnMax = new FontAwesome.Sharp.IconPictureBox();
            this.btnMin = new FontAwesome.Sharp.IconPictureBox();
            this.lblBarra = new System.Windows.Forms.Label();
            this.iconBarra = new FontAwesome.Sharp.IconPictureBox();
            this.pnlEscritorio = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.PictureBox();
            this.tmrEscritorio = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBarra)).BeginInit();
            this.pnlEscritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnInfo);
            this.pnlMenu.Controls.Add(this.btnConsAten);
            this.pnlMenu.Controls.Add(this.btnNuevaAten);
            this.pnlMenu.Controls.Add(this.btnAltaMascota);
            this.pnlMenu.Controls.Add(this.btnAltaCliente);
            this.pnlMenu.Controls.Add(this.btnAltaUser);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.MinimumSize = new System.Drawing.Size(275, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(277, 803);
            this.pnlMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 710);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 93);
            this.panel1.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDate.Location = new System.Drawing.Point(25, 56);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 19);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Fecha";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTime.Location = new System.Drawing.Point(25, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 37);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Hora";
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btnInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 32;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 589);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnInfo.Size = new System.Drawing.Size(277, 67);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Acerca de";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnConsAten
            // 
            this.btnConsAten.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsAten.FlatAppearance.BorderSize = 0;
            this.btnConsAten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsAten.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsAten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConsAten.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnConsAten.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConsAten.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConsAten.IconSize = 32;
            this.btnConsAten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsAten.Location = new System.Drawing.Point(0, 522);
            this.btnConsAten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsAten.Name = "btnConsAten";
            this.btnConsAten.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnConsAten.Size = new System.Drawing.Size(277, 67);
            this.btnConsAten.TabIndex = 6;
            this.btnConsAten.Text = "Consulta Atenciones";
            this.btnConsAten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsAten.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsAten.UseVisualStyleBackColor = true;
            this.btnConsAten.Click += new System.EventHandler(this.btnConsAten_Click);
            // 
            // btnNuevaAten
            // 
            this.btnNuevaAten.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaAten.FlatAppearance.BorderSize = 0;
            this.btnNuevaAten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaAten.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaAten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevaAten.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            this.btnNuevaAten.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevaAten.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevaAten.IconSize = 32;
            this.btnNuevaAten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaAten.Location = new System.Drawing.Point(0, 455);
            this.btnNuevaAten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevaAten.Name = "btnNuevaAten";
            this.btnNuevaAten.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnNuevaAten.Size = new System.Drawing.Size(277, 67);
            this.btnNuevaAten.TabIndex = 5;
            this.btnNuevaAten.Text = "Nueva Atención";
            this.btnNuevaAten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaAten.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaAten.UseVisualStyleBackColor = true;
            this.btnNuevaAten.Click += new System.EventHandler(this.btnNuevaAten_Click);
            // 
            // btnAltaMascota
            // 
            this.btnAltaMascota.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaMascota.FlatAppearance.BorderSize = 0;
            this.btnAltaMascota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaMascota.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaMascota.IconChar = FontAwesome.Sharp.IconChar.Paw;
            this.btnAltaMascota.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaMascota.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaMascota.IconSize = 32;
            this.btnAltaMascota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaMascota.Location = new System.Drawing.Point(0, 388);
            this.btnAltaMascota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAltaMascota.Name = "btnAltaMascota";
            this.btnAltaMascota.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnAltaMascota.Size = new System.Drawing.Size(277, 67);
            this.btnAltaMascota.TabIndex = 4;
            this.btnAltaMascota.Text = "Alta Mascota";
            this.btnAltaMascota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaMascota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaMascota.UseVisualStyleBackColor = true;
            this.btnAltaMascota.Click += new System.EventHandler(this.btnAltaMascota_Click);
            // 
            // btnAltaCliente
            // 
            this.btnAltaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaCliente.FlatAppearance.BorderSize = 0;
            this.btnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAltaCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaCliente.IconSize = 32;
            this.btnAltaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.Location = new System.Drawing.Point(0, 321);
            this.btnAltaCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAltaCliente.Name = "btnAltaCliente";
            this.btnAltaCliente.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnAltaCliente.Size = new System.Drawing.Size(277, 67);
            this.btnAltaCliente.TabIndex = 3;
            this.btnAltaCliente.Text = "Alta Cliente";
            this.btnAltaCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaCliente.UseVisualStyleBackColor = true;
            this.btnAltaCliente.Click += new System.EventHandler(this.btnAltaCliente_Click);
            // 
            // btnAltaUser
            // 
            this.btnAltaUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAltaUser.FlatAppearance.BorderSize = 0;
            this.btnAltaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaUser.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            this.btnAltaUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAltaUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAltaUser.IconSize = 32;
            this.btnAltaUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaUser.Location = new System.Drawing.Point(0, 254);
            this.btnAltaUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAltaUser.Name = "btnAltaUser";
            this.btnAltaUser.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnAltaUser.Size = new System.Drawing.Size(277, 67);
            this.btnAltaUser.TabIndex = 2;
            this.btnAltaUser.Text = "Alta Usuario";
            this.btnAltaUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltaUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAltaUser.UseVisualStyleBackColor = true;
            this.btnAltaUser.Click += new System.EventHandler(this.btnAltaUser_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInicio.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInicio.IconSize = 32;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 187);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(11, 0, 23, 0);
            this.btnInicio.Size = new System.Drawing.Size(277, 67);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(277, 187);
            this.pnlLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontVeterinaria.Properties.Resources.Logo_Vet_Tr;
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.pnlBarra.Controls.Add(this.btnClose);
            this.pnlBarra.Controls.Add(this.btnMax);
            this.pnlBarra.Controls.Add(this.btnMin);
            this.pnlBarra.Controls.Add(this.lblBarra);
            this.pnlBarra.Controls.Add(this.iconBarra);
            this.pnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarra.Location = new System.Drawing.Point(277, 0);
            this.pnlBarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(765, 107);
            this.pnlBarra.TabIndex = 1;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 37;
            this.btnClose.Location = new System.Drawing.Point(724, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 43);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 37;
            this.btnMax.Location = new System.Drawing.Point(691, 5);
            this.btnMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(37, 43);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMax.TabIndex = 3;
            this.btnMax.TabStop = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 37;
            this.btnMin.Location = new System.Drawing.Point(654, 5);
            this.btnMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(37, 43);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lblBarra
            // 
            this.lblBarra.AutoSize = true;
            this.lblBarra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBarra.Location = new System.Drawing.Point(57, 39);
            this.lblBarra.Name = "lblBarra";
            this.lblBarra.Size = new System.Drawing.Size(54, 19);
            this.lblBarra.TabIndex = 1;
            this.lblBarra.Text = "Inicio";
            // 
            // iconBarra
            // 
            this.iconBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.iconBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconBarra.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconBarra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconBarra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBarra.IconSize = 37;
            this.iconBarra.Location = new System.Drawing.Point(19, 28);
            this.iconBarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconBarra.Name = "iconBarra";
            this.iconBarra.Size = new System.Drawing.Size(37, 43);
            this.iconBarra.TabIndex = 0;
            this.iconBarra.TabStop = false;
            // 
            // pnlEscritorio
            // 
            this.pnlEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.pnlEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEscritorio.Controls.Add(this.lblFecha);
            this.pnlEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEscritorio.Location = new System.Drawing.Point(277, 107);
            this.pnlEscritorio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlEscritorio.Name = "pnlEscritorio";
            this.pnlEscritorio.Size = new System.Drawing.Size(765, 696);
            this.pnlEscritorio.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFecha.Image = global::FrontVeterinaria.Properties.Resources.background_5;
            this.lblFecha.Location = new System.Drawing.Point(0, 0);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(765, 696);
            this.lblFecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblFecha.TabIndex = 0;
            this.lblFecha.TabStop = false;
            // 
            // tmrEscritorio
            // 
            this.tmrEscritorio.Tick += new System.EventHandler(this.tmrEscritorio_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 803);
            this.Controls.Add(this.pnlEscritorio);
            this.Controls.Add(this.pnlBarra);
            this.Controls.Add(this.pnlMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBarra.ResumeLayout(false);
            this.pnlBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBarra)).EndInit();
            this.pnlEscritorio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnInfo;
        private FontAwesome.Sharp.IconButton btnConsAten;
        private FontAwesome.Sharp.IconButton btnNuevaAten;
        private FontAwesome.Sharp.IconButton btnAltaMascota;
        private FontAwesome.Sharp.IconButton btnAltaCliente;
        private FontAwesome.Sharp.IconButton btnAltaUser;
        private FontAwesome.Sharp.IconButton btnInicio;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.Label lblBarra;
        private FontAwesome.Sharp.IconPictureBox iconBarra;
        private System.Windows.Forms.Panel pnlEscritorio;
        private System.Windows.Forms.PictureBox lblFecha;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnMax;
        private FontAwesome.Sharp.IconPictureBox btnMin;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrEscritorio;
        private System.Windows.Forms.Panel panel1;
    }
}