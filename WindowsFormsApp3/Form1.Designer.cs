
namespace WindowsFormsApp3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.historia_clinicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new WindowsFormsApp3.DataSet2();
            this.SP_REPORTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.historia_clinicaTableAdapter = new WindowsFormsApp3.DataSet2TableAdapters.historia_clinicaTableAdapter();
            this.Cliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.historia_clinicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // historia_clinicaBindingSource
            // 
            this.historia_clinicaBindingSource.DataMember = "historia_clinica";
            this.historia_clinicaBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(969, 23);
            this.cboClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(213, 24);
            this.cboClientes.TabIndex = 1;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.historia_clinicaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp3.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 59);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.MaximumSize = new System.Drawing.Size(1167, 630);
            this.reportViewer1.MinimumSize = new System.Drawing.Size(1167, 630);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1167, 630);
            this.reportViewer1.TabIndex = 2;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // historia_clinicaTableAdapter
            // 
            this.historia_clinicaTableAdapter.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(873, 21);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(76, 23);
            this.Cliente.TabIndex = 3;
            this.Cliente.Text = "Cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1216, 736);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cboClientes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Historia Clínica Mascotas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historia_clinicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_REPORTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource SP_REPORTEBindingSource;
     
        private System.Windows.Forms.ComboBox cboClientes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource historia_clinicaBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.historia_clinicaTableAdapter historia_clinicaTableAdapter;
        private System.Windows.Forms.Label Cliente;
    }
}

