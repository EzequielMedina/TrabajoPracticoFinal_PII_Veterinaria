
namespace TpiVeterinaria.Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.LbPass = new System.Windows.Forms.Label();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Recuperar = new System.Windows.Forms.Button();
            this.Pb_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(210, 38);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(182, 20);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(210, 73);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(181, 20);
            this.TxtPass.TabIndex = 1;
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsuario.Location = new System.Drawing.Point(142, 39);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(63, 16);
            this.LbUsuario.TabIndex = 2;
            this.LbUsuario.Text = "Usuario";
            // 
            // LbPass
            // 
            this.LbPass.AutoSize = true;
            this.LbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPass.Location = new System.Drawing.Point(129, 74);
            this.LbPass.Name = "LbPass";
            this.LbPass.Size = new System.Drawing.Size(77, 16);
            this.LbPass.TabIndex = 3;
            this.LbPass.Text = "Password";
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.Location = new System.Drawing.Point(304, 98);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(87, 33);
            this.btn_Registrarse.TabIndex = 4;
            this.btn_Registrarse.Text = "Registrarse";
            this.btn_Registrarse.UseVisualStyleBackColor = true;
            this.btn_Registrarse.Click += new System.EventHandler(this.btn_Registrarse_Click);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.Location = new System.Drawing.Point(210, 99);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Size = new System.Drawing.Size(88, 31);
            this.Btn_Ingresar.TabIndex = 5;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.UseVisualStyleBackColor = true;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // btn_Recuperar
            // 
            this.btn_Recuperar.Location = new System.Drawing.Point(210, 137);
            this.btn_Recuperar.Name = "btn_Recuperar";
            this.btn_Recuperar.Size = new System.Drawing.Size(181, 28);
            this.btn_Recuperar.TabIndex = 6;
            this.btn_Recuperar.Text = "Recuperar Contraseña";
            this.btn_Recuperar.UseVisualStyleBackColor = true;
            this.btn_Recuperar.Click += new System.EventHandler(this.btn_Recuperar_Click);
            // 
            // Pb_Login
            // 
            this.Pb_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_Login.BackgroundImage")));
            this.Pb_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb_Login.Location = new System.Drawing.Point(12, 38);
            this.Pb_Login.Name = "Pb_Login";
            this.Pb_Login.Size = new System.Drawing.Size(111, 126);
            this.Pb_Login.TabIndex = 7;
            this.Pb_Login.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(404, 196);
            this.Controls.Add(this.Pb_Login);
            this.Controls.Add(this.btn_Recuperar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.LbPass);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 235);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 235);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.Label LbPass;
        private System.Windows.Forms.Button btn_Registrarse;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.Button btn_Recuperar;
        private System.Windows.Forms.PictureBox Pb_Login;
    }
}