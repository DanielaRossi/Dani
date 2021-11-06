
namespace Formularios.Clase1.WinForm
{
    partial class FrmMaster
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
            this.btnListarDocentes = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnDetallePersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarDocentes
            // 
            this.btnListarDocentes.Location = new System.Drawing.Point(83, 64);
            this.btnListarDocentes.Name = "btnListarDocentes";
            this.btnListarDocentes.Size = new System.Drawing.Size(209, 39);
            this.btnListarDocentes.TabIndex = 0;
            this.btnListarDocentes.Text = "Listar Docentes";
            this.btnListarDocentes.UseVisualStyleBackColor = true;
            this.btnListarDocentes.Click += new System.EventHandler(this.btnListarDocentes_Click);
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.Location = new System.Drawing.Point(83, 144);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(209, 51);
            this.btnModificarDocente.TabIndex = 1;
            this.btnModificarDocente.Text = "Modificar Docente";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            // 
            // btnDetallePersona
            // 
            this.btnDetallePersona.Location = new System.Drawing.Point(83, 244);
            this.btnDetallePersona.Name = "btnDetallePersona";
            this.btnDetallePersona.Size = new System.Drawing.Size(209, 52);
            this.btnDetallePersona.TabIndex = 2;
            this.btnDetallePersona.Text = "Detalle Persona";
            this.btnDetallePersona.UseVisualStyleBackColor = true;
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDetallePersona);
            this.Controls.Add(this.btnModificarDocente);
            this.Controls.Add(this.btnListarDocentes);
            this.Name = "FrmMaster";
            this.Text = "Formulario de inicio";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarDocentes;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnDetallePersona;
    }
}