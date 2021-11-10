
namespace FrontVeterinaria.Presentaciones.Mascotas
{
    partial class Frm_Mascota
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbo_Cliente = new System.Windows.Forms.ComboBox();
            this.lb_Cliente = new System.Windows.Forms.Label();
            this.cbo_raza = new System.Windows.Forms.ComboBox();
            this.cbo_especie = new System.Windows.Forms.ComboBox();
            this.lblespecia = new System.Windows.Forms.Label();
            this.lblRaza = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbMascota = new System.Windows.Forms.RadioButton();
            this.RbFemenino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.ckbEsterilizado = new System.Windows.Forms.CheckBox();
            this.dgvMascotas = new System.Windows.Forms.DataGridView();
            this.lbFechaNac = new System.Windows.Forms.Label();
            this.lbDefuncion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDefuncion = new System.Windows.Forms.DateTimePicker();
            this.chDef = new System.Windows.Forms.CheckBox();
            this.colNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRaza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaDefuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEsterilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_Cliente
            // 
            this.cbo_Cliente.FormattingEnabled = true;
            this.cbo_Cliente.Location = new System.Drawing.Point(151, 32);
            this.cbo_Cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_Cliente.Name = "cbo_Cliente";
            this.cbo_Cliente.Size = new System.Drawing.Size(200, 24);
            this.cbo_Cliente.TabIndex = 0;
            // 
            // lb_Cliente
            // 
            this.lb_Cliente.AutoSize = true;
            this.lb_Cliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Cliente.Location = new System.Drawing.Point(75, 35);
            this.lb_Cliente.Name = "lb_Cliente";
            this.lb_Cliente.Size = new System.Drawing.Size(48, 16);
            this.lb_Cliente.TabIndex = 2;
            this.lb_Cliente.Text = "Cliente";
            // 
            // cbo_raza
            // 
            this.cbo_raza.FormattingEnabled = true;
            this.cbo_raza.Location = new System.Drawing.Point(151, 136);
            this.cbo_raza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_raza.Name = "cbo_raza";
            this.cbo_raza.Size = new System.Drawing.Size(200, 24);
            this.cbo_raza.TabIndex = 4;
            // 
            // cbo_especie
            // 
            this.cbo_especie.FormattingEnabled = true;
            this.cbo_especie.Location = new System.Drawing.Point(151, 101);
            this.cbo_especie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_especie.Name = "cbo_especie";
            this.cbo_especie.Size = new System.Drawing.Size(200, 24);
            this.cbo_especie.TabIndex = 5;
            // 
            // lblespecia
            // 
            this.lblespecia.AutoSize = true;
            this.lblespecia.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblespecia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblespecia.Location = new System.Drawing.Point(70, 106);
            this.lblespecia.Name = "lblespecia";
            this.lblespecia.Size = new System.Drawing.Size(53, 16);
            this.lblespecia.TabIndex = 6;
            this.lblespecia.Text = "Especie";
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRaza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRaza.Location = new System.Drawing.Point(92, 139);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(36, 16);
            this.lblRaza.TabIndex = 7;
            this.lblRaza.Text = "Raza";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 67);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Location = new System.Drawing.Point(68, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbMascota
            // 
            this.rbMascota.AutoSize = true;
            this.rbMascota.Checked = true;
            this.rbMascota.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbMascota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbMascota.Location = new System.Drawing.Point(604, 120);
            this.rbMascota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMascota.Name = "rbMascota";
            this.rbMascota.Size = new System.Drawing.Size(67, 20);
            this.rbMascota.TabIndex = 11;
            this.rbMascota.TabStop = true;
            this.rbMascota.Text = "Macho";
            this.rbMascota.UseVisualStyleBackColor = true;
            // 
            // RbFemenino
            // 
            this.RbFemenino.AutoSize = true;
            this.RbFemenino.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RbFemenino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RbFemenino.Location = new System.Drawing.Point(604, 150);
            this.RbFemenino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RbFemenino.Name = "RbFemenino";
            this.RbFemenino.Size = new System.Drawing.Size(72, 20);
            this.RbFemenino.TabIndex = 12;
            this.RbFemenino.Text = "Hembra";
            this.RbFemenino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSexo.Location = new System.Drawing.Point(542, 138);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(36, 16);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo";
            // 
            // ckbEsterilizado
            // 
            this.ckbEsterilizado.AutoSize = true;
            this.ckbEsterilizado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbEsterilizado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ckbEsterilizado.Location = new System.Drawing.Point(723, 134);
            this.ckbEsterilizado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckbEsterilizado.Name = "ckbEsterilizado";
            this.ckbEsterilizado.Size = new System.Drawing.Size(91, 20);
            this.ckbEsterilizado.TabIndex = 16;
            this.ckbEsterilizado.Text = "Esterilizado";
            this.ckbEsterilizado.UseVisualStyleBackColor = true;
            // 
            // dgvMascotas
            // 
            this.dgvMascotas.AllowUserToAddRows = false;
            this.dgvMascotas.AllowUserToDeleteRows = false;
            this.dgvMascotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMascotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNro,
            this.colNombre,
            this.colCliente,
            this.colEspecie,
            this.colRaza,
            this.colSexo,
            this.colFechaNac,
            this.colFechaDefuncion,
            this.colEsterilizado,
            this.colButton});
            this.dgvMascotas.Location = new System.Drawing.Point(20, 202);
            this.dgvMascotas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMascotas.Name = "dgvMascotas";
            this.dgvMascotas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMascotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMascotas.RowHeadersWidth = 51;
            this.dgvMascotas.RowTemplate.Height = 25;
            this.dgvMascotas.Size = new System.Drawing.Size(1065, 190);
            this.dgvMascotas.TabIndex = 17;
            this.dgvMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellContentClick);
            // 
            // lbFechaNac
            // 
            this.lbFechaNac.AutoSize = true;
            this.lbFechaNac.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFechaNac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFechaNac.Location = new System.Drawing.Point(442, 38);
            this.lbFechaNac.Name = "lbFechaNac";
            this.lbFechaNac.Size = new System.Drawing.Size(115, 16);
            this.lbFechaNac.TabIndex = 18;
            this.lbFechaNac.Text = "Fecha Nacimiento";
            // 
            // lbDefuncion
            // 
            this.lbDefuncion.AutoSize = true;
            this.lbDefuncion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDefuncion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDefuncion.Location = new System.Drawing.Point(452, 75);
            this.lbDefuncion.Name = "lbDefuncion";
            this.lbDefuncion.Size = new System.Drawing.Size(106, 16);
            this.lbDefuncion.TabIndex = 20;
            this.lbDefuncion.Text = "Fecha Defunción";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptar.Location = new System.Drawing.Point(396, 405);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 36);
            this.btnAceptar.TabIndex = 21;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(642, 405);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 36);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(167)))), ((int)(((byte)(175)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnActualizar.Location = new System.Drawing.Point(888, 405);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 36);
            this.btnActualizar.TabIndex = 23;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(604, 32);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(375, 22);
            this.dtpFechaNacimiento.TabIndex = 24;
            // 
            // dtpFechaDefuncion
            // 
            this.dtpFechaDefuncion.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtpFechaDefuncion.Location = new System.Drawing.Point(666, 70);
            this.dtpFechaDefuncion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFechaDefuncion.Name = "dtpFechaDefuncion";
            this.dtpFechaDefuncion.Size = new System.Drawing.Size(313, 22);
            this.dtpFechaDefuncion.TabIndex = 25;
            // 
            // chDef
            // 
            this.chDef.AutoSize = true;
            this.chDef.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chDef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chDef.Location = new System.Drawing.Point(604, 74);
            this.chDef.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chDef.Name = "chDef";
            this.chDef.Size = new System.Drawing.Size(35, 20);
            this.chDef.TabIndex = 26;
            this.chDef.Text = "Si";
            this.chDef.UseVisualStyleBackColor = true;
            this.chDef.CheckedChanged += new System.EventHandler(this.chDef_CheckedChanged);
            // 
            // colNro
            // 
            this.colNro.HeaderText = "id";
            this.colNro.MinimumWidth = 6;
            this.colNro.Name = "colNro";
            this.colNro.ReadOnly = true;
            this.colNro.Visible = false;
            this.colNro.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 150;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 150;
            // 
            // colEspecie
            // 
            this.colEspecie.HeaderText = "Especie";
            this.colEspecie.MinimumWidth = 6;
            this.colEspecie.Name = "colEspecie";
            this.colEspecie.ReadOnly = true;
            this.colEspecie.Width = 80;
            // 
            // colRaza
            // 
            this.colRaza.HeaderText = "Raza";
            this.colRaza.MinimumWidth = 6;
            this.colRaza.Name = "colRaza";
            this.colRaza.ReadOnly = true;
            this.colRaza.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.MinimumWidth = 6;
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colFechaNac
            // 
            this.colFechaNac.HeaderText = "Fecha Nac.";
            this.colFechaNac.MinimumWidth = 6;
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            this.colFechaNac.Width = 125;
            // 
            // colFechaDefuncion
            // 
            this.colFechaDefuncion.HeaderText = "Fecha Def.";
            this.colFechaDefuncion.MinimumWidth = 6;
            this.colFechaDefuncion.Name = "colFechaDefuncion";
            this.colFechaDefuncion.ReadOnly = true;
            this.colFechaDefuncion.Width = 125;
            // 
            // colEsterilizado
            // 
            this.colEsterilizado.HeaderText = "Esterilizado";
            this.colEsterilizado.MinimumWidth = 6;
            this.colEsterilizado.Name = "colEsterilizado";
            this.colEsterilizado.ReadOnly = true;
            this.colEsterilizado.Width = 80;
            // 
            // colButton
            // 
            this.colButton.HeaderText = "Acción";
            this.colButton.MinimumWidth = 6;
            this.colButton.Name = "colButton";
            this.colButton.ReadOnly = true;
            this.colButton.Text = "Editar";
            this.colButton.UseColumnTextForButtonValue = true;
            // 
            // Frm_Mascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1389, 454);
            this.Controls.Add(this.chDef);
            this.Controls.Add(this.dtpFechaDefuncion);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbDefuncion);
            this.Controls.Add(this.lbFechaNac);
            this.Controls.Add(this.dgvMascotas);
            this.Controls.Add(this.ckbEsterilizado);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.RbFemenino);
            this.Controls.Add(this.rbMascota);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblRaza);
            this.Controls.Add(this.lblespecia);
            this.Controls.Add(this.cbo_especie);
            this.Controls.Add(this.cbo_raza);
            this.Controls.Add(this.lb_Cliente);
            this.Controls.Add(this.cbo_Cliente);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Mascota";
            this.Text = "Alta Mascota";
            this.Load += new System.EventHandler(this.Frm_Mascota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMascotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_Cliente;
        private System.Windows.Forms.Label lb_Cliente;
        private System.Windows.Forms.ComboBox cbo_raza;
        private System.Windows.Forms.ComboBox cbo_especie;
        private System.Windows.Forms.Label lblespecia;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbMascota;
        private System.Windows.Forms.RadioButton RbFemenino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.CheckBox ckbEsterilizado;
        private System.Windows.Forms.DataGridView dgvMascotas;
        private System.Windows.Forms.Label lbFechaNac;
        private System.Windows.Forms.Label lbDefuncion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaDefuncion;
        private System.Windows.Forms.CheckBox chDef;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaDefuncion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEsterilizado;
        private System.Windows.Forms.DataGridViewButtonColumn colButton;
    }
}