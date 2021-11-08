
namespace Formularios.Clase2.Cliente
{
    partial class FrmListarCuentas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lstCuentas = new System.Windows.Forms.ListBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(598, 353);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(141, 54);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lstCuentas
            // 
            this.lstCuentas.FormattingEnabled = true;
            this.lstCuentas.ItemHeight = 16;
            this.lstCuentas.Location = new System.Drawing.Point(43, 41);
            this.lstCuentas.Name = "lstCuentas";
            this.lstCuentas.Size = new System.Drawing.Size(212, 148);
            this.lstCuentas.TabIndex = 1;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(303, 41);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(139, 45);
            this.btnAgregarCliente.TabIndex = 2;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // FrmListarCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.lstCuentas);
            this.Controls.Add(this.btnVolver);
            this.Name = "FrmListarCuentas";
            this.Text = "FrmListarCuentas";
            this.Load += new System.EventHandler(this.FrmListarCuentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox lstCuentas;
        private System.Windows.Forms.Button btnAgregarCliente;
    }
}