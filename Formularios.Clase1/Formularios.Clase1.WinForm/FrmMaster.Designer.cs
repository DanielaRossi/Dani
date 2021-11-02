
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lstVacunas = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.bntLimpiar = new System.Windows.Forms.Button();
            this.btnListarDocente = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.btnModificarDocente = new System.Windows.Forms.Button();
            this.btnDetallePersona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(66, 318);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(145, 43);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // lstVacunas
            // 
            this.lstVacunas.FormattingEnabled = true;
            this.lstVacunas.ItemHeight = 16;
            this.lstVacunas.Location = new System.Drawing.Point(66, 199);
            this.lstVacunas.Name = "lstVacunas";
            this.lstVacunas.Size = new System.Drawing.Size(162, 100);
            this.lstVacunas.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(66, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(66, 114);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(130, 17);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Tipo de documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(272, 36);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 6;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(275, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 22);
            this.txtApellido.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(69, 382);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(261, 22);
            this.txtResultado.TabIndex = 8;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // bntLimpiar
            // 
            this.bntLimpiar.Location = new System.Drawing.Point(252, 318);
            this.bntLimpiar.Name = "bntLimpiar";
            this.bntLimpiar.Size = new System.Drawing.Size(140, 43);
            this.bntLimpiar.TabIndex = 9;
            this.bntLimpiar.Text = "Limpiar";
            this.bntLimpiar.UseVisualStyleBackColor = true;
            this.bntLimpiar.Click += new System.EventHandler(this.bntLimpiar_Click);
            // 
            // btnListarDocente
            // 
            this.btnListarDocente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnListarDocente.Location = new System.Drawing.Point(552, 67);
            this.btnListarDocente.Name = "btnListarDocente";
            this.btnListarDocente.Size = new System.Drawing.Size(152, 23);
            this.btnListarDocente.TabIndex = 10;
            this.btnListarDocente.Text = "Listar Docente";
            this.btnListarDocente.UseVisualStyleBackColor = true;
            this.btnListarDocente.Click += new System.EventHandler(this.btnListarDocente_Click);
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarDocente.Location = new System.Drawing.Point(552, 123);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(152, 30);
            this.btnAgregarDocente.TabIndex = 11;
            this.btnAgregarDocente.Text = "Agregar Docente";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            // 
            // btnModificarDocente
            // 
            this.btnModificarDocente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnModificarDocente.Location = new System.Drawing.Point(552, 182);
            this.btnModificarDocente.Name = "btnModificarDocente";
            this.btnModificarDocente.Size = new System.Drawing.Size(152, 33);
            this.btnModificarDocente.TabIndex = 12;
            this.btnModificarDocente.Text = "Modificar Docente";
            this.btnModificarDocente.UseVisualStyleBackColor = true;
            // 
            // btnDetallePersona
            // 
            this.btnDetallePersona.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDetallePersona.Location = new System.Drawing.Point(552, 247);
            this.btnDetallePersona.Name = "btnDetallePersona";
            this.btnDetallePersona.Size = new System.Drawing.Size(152, 41);
            this.btnDetallePersona.TabIndex = 13;
            this.btnDetallePersona.Text = "Detalle Persona";
            this.btnDetallePersona.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista Docentes activos";
            // 
            // lbtBox
            // 
            this.lbtBox.FormattingEnabled = true;
            this.lbtBox.ItemHeight = 16;
            this.lbtBox.Location = new System.Drawing.Point(560, 335);
            this.lbtBox.Name = "lbtBox";
            this.lbtBox.Size = new System.Drawing.Size(120, 84);
            this.lbtBox.TabIndex = 15;
            // 
            // FrmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDetallePersona);
            this.Controls.Add(this.btnModificarDocente);
            this.Controls.Add(this.btnAgregarDocente);
            this.Controls.Add(this.btnListarDocente);
            this.Controls.Add(this.bntLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstVacunas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnMostrar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FrmMaster";
            this.Text = "Formulario de inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lstVacunas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button bntLimpiar;
        private System.Windows.Forms.Button btnListarDocente;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.Button btnModificarDocente;
        private System.Windows.Forms.Button btnDetallePersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbtBox;
    }
}

