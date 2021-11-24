
namespace Formulario.Deuda2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtImportetotal = new System.Windows.Forms.TextBox();
            this.txtInterespunitorio = new System.Windows.Forms.TextBox();
            this.txtFechapago = new System.Windows.Forms.TextBox();
            this.txtfechavencimiento = new System.Windows.Forms.TextBox();
            this.txtImporteadeudado = new System.Windows.Forms.TextBox();
            this.txtPunitorio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInteréspromedio = new System.Windows.Forms.TextBox();
            this.txtDíasatraso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lstPagos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Punitorio por dìa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Importe adeudado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Pago";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbServicio);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtImportetotal);
            this.groupBox1.Controls.Add(this.txtInterespunitorio);
            this.groupBox1.Controls.Add(this.txtFechapago);
            this.groupBox1.Controls.Add(this.txtfechavencimiento);
            this.groupBox1.Controls.Add(this.txtImporteadeudado);
            this.groupBox1.Controls.Add(this.txtPunitorio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 409);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de Pago Tardío";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(178, 35);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(121, 24);
            this.cmbServicio.TabIndex = 15;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pagar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtImportetotal
            // 
            this.txtImportetotal.Enabled = false;
            this.txtImportetotal.Location = new System.Drawing.Point(178, 344);
            this.txtImportetotal.Name = "txtImportetotal";
            this.txtImportetotal.Size = new System.Drawing.Size(121, 22);
            this.txtImportetotal.TabIndex = 12;
            // 
            // txtInterespunitorio
            // 
            this.txtInterespunitorio.Enabled = false;
            this.txtInterespunitorio.Location = new System.Drawing.Point(178, 308);
            this.txtInterespunitorio.Name = "txtInterespunitorio";
            this.txtInterespunitorio.Size = new System.Drawing.Size(121, 22);
            this.txtInterespunitorio.TabIndex = 11;
            // 
            // txtFechapago
            // 
            this.txtFechapago.Location = new System.Drawing.Point(178, 201);
            this.txtFechapago.Name = "txtFechapago";
            this.txtFechapago.Size = new System.Drawing.Size(121, 22);
            this.txtFechapago.TabIndex = 10;
            // 
            // txtfechavencimiento
            // 
            this.txtfechavencimiento.Location = new System.Drawing.Point(178, 165);
            this.txtfechavencimiento.Name = "txtfechavencimiento";
            this.txtfechavencimiento.Size = new System.Drawing.Size(121, 22);
            this.txtfechavencimiento.TabIndex = 9;
            // 
            // txtImporteadeudado
            // 
            this.txtImporteadeudado.Location = new System.Drawing.Point(178, 129);
            this.txtImporteadeudado.Name = "txtImporteadeudado";
            this.txtImporteadeudado.Size = new System.Drawing.Size(121, 22);
            this.txtImporteadeudado.TabIndex = 8;
            // 
            // txtPunitorio
            // 
            this.txtPunitorio.Enabled = false;
            this.txtPunitorio.Location = new System.Drawing.Point(178, 77);
            this.txtPunitorio.Name = "txtPunitorio";
            this.txtPunitorio.Size = new System.Drawing.Size(121, 22);
            this.txtPunitorio.TabIndex = 7;
            this.txtPunitorio.TextChanged += new System.EventHandler(this.txtPunitorio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Importe Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Interès Punitorio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInteréspromedio);
            this.groupBox2.Controls.Add(this.txtDíasatraso);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lstPagos);
            this.groupBox2.Location = new System.Drawing.Point(417, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 391);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte de Moras";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtInteréspromedio
            // 
            this.txtInteréspromedio.Enabled = false;
            this.txtInteréspromedio.Location = new System.Drawing.Point(203, 345);
            this.txtInteréspromedio.Name = "txtInteréspromedio";
            this.txtInteréspromedio.Size = new System.Drawing.Size(100, 22);
            this.txtInteréspromedio.TabIndex = 4;
            // 
            // txtDíasatraso
            // 
            this.txtDíasatraso.Enabled = false;
            this.txtDíasatraso.Location = new System.Drawing.Point(203, 316);
            this.txtDíasatraso.Name = "txtDíasatraso";
            this.txtDíasatraso.Size = new System.Drawing.Size(100, 22);
            this.txtDíasatraso.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Interés promedio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Días de atraso promedio";
            // 
            // lstPagos
            // 
            this.lstPagos.FormattingEnabled = true;
            this.lstPagos.ItemHeight = 16;
            this.lstPagos.Location = new System.Drawing.Point(24, 44);
            this.lstPagos.Name = "lstPagos";
            this.lstPagos.Size = new System.Drawing.Size(269, 244);
            this.lstPagos.TabIndex = 0;
            this.lstPagos.SelectedIndexChanged += new System.EventHandler(this.lstPagos_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rapi Cobranzas SA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtImportetotal;
        private System.Windows.Forms.TextBox txtInterespunitorio;
        private System.Windows.Forms.TextBox txtFechapago;
        private System.Windows.Forms.TextBox txtfechavencimiento;
        private System.Windows.Forms.TextBox txtImporteadeudado;
        private System.Windows.Forms.TextBox txtPunitorio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInteréspromedio;
        private System.Windows.Forms.TextBox txtDíasatraso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstPagos;
    }
}

