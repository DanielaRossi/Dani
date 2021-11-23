
namespace Formularios.TarjetaCredito._1
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtlimite = new System.Windows.Forms.TextBox();
            this.txtnumeroplastico = new System.Windows.Forms.TextBox();
            this.txtcantidadplastico = new System.Windows.Forms.TextBox();
            this.txtlimitepromedio = new System.Windows.Forms.TextBox();
            this.lstTarjetas = new System.Windows.Forms.ListBox();
            this.cmbtipotarjeta = new System.Windows.Forms.ComboBox();
            this.cmbperiodocierre = new System.Windows.Forms.ComboBox();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Período de Cierre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Limite de compra";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número de plástico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad plásticos emitidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Límite promedio";
            // 
            // txtlimite
            // 
            this.txtlimite.Location = new System.Drawing.Point(169, 176);
            this.txtlimite.Name = "txtlimite";
            this.txtlimite.Size = new System.Drawing.Size(160, 22);
            this.txtlimite.TabIndex = 7;
            // 
            // txtnumeroplastico
            // 
            this.txtnumeroplastico.Location = new System.Drawing.Point(201, 265);
            this.txtnumeroplastico.Name = "txtnumeroplastico";
            this.txtnumeroplastico.Size = new System.Drawing.Size(128, 22);
            this.txtnumeroplastico.TabIndex = 8;
            // 
            // txtcantidadplastico
            // 
            this.txtcantidadplastico.Location = new System.Drawing.Point(142, 270);
            this.txtcantidadplastico.Name = "txtcantidadplastico";
            this.txtcantidadplastico.Size = new System.Drawing.Size(100, 22);
            this.txtcantidadplastico.TabIndex = 9;
            this.txtcantidadplastico.TextChanged += new System.EventHandler(this.txtcantidadplastico_TextChanged);
            // 
            // txtlimitepromedio
            // 
            this.txtlimitepromedio.Location = new System.Drawing.Point(142, 328);
            this.txtlimitepromedio.Name = "txtlimitepromedio";
            this.txtlimitepromedio.Size = new System.Drawing.Size(100, 22);
            this.txtlimitepromedio.TabIndex = 10;
            // 
            // lstTarjetas
            // 
            this.lstTarjetas.FormattingEnabled = true;
            this.lstTarjetas.ItemHeight = 16;
            this.lstTarjetas.Location = new System.Drawing.Point(40, 40);
            this.lstTarjetas.Name = "lstTarjetas";
            this.lstTarjetas.Size = new System.Drawing.Size(231, 196);
            this.lstTarjetas.TabIndex = 11;
            // 
            // cmbtipotarjeta
            // 
            this.cmbtipotarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipotarjeta.FormattingEnabled = true;
            this.cmbtipotarjeta.Location = new System.Drawing.Point(180, 40);
            this.cmbtipotarjeta.Name = "cmbtipotarjeta";
            this.cmbtipotarjeta.Size = new System.Drawing.Size(149, 24);
            this.cmbtipotarjeta.TabIndex = 12;
            this.cmbtipotarjeta.SelectedIndexChanged += new System.EventHandler(this.cmbtipotarjeta_SelectedIndexChanged);
            // 
            // cmbperiodocierre
            // 
            this.cmbperiodocierre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbperiodocierre.FormattingEnabled = true;
            this.cmbperiodocierre.Location = new System.Drawing.Point(180, 86);
            this.cmbperiodocierre.Name = "cmbperiodocierre";
            this.cmbperiodocierre.Size = new System.Drawing.Size(149, 24);
            this.cmbperiodocierre.TabIndex = 13;
            // 
            // cmbcliente
            // 
            this.cmbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(169, 134);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(160, 24);
            this.cmbcliente.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbtipotarjeta);
            this.groupBox1.Controls.Add(this.cmbperiodocierre);
            this.groupBox1.Controls.Add(this.cmbcliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnumeroplastico);
            this.groupBox1.Controls.Add(this.txtlimite);
            this.groupBox1.Location = new System.Drawing.Point(47, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 398);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario Tarjeta de Crèdito";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Alta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcantidadplastico);
            this.groupBox2.Controls.Add(this.txtlimitepromedio);
            this.groupBox2.Controls.Add(this.lstTarjetas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(454, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 386);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte Tarjetas";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Decaedro SRL";
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtlimite;
        private System.Windows.Forms.TextBox txtnumeroplastico;
        private System.Windows.Forms.TextBox txtcantidadplastico;
        private System.Windows.Forms.TextBox txtlimitepromedio;
        private System.Windows.Forms.ListBox lstTarjetas;
        private System.Windows.Forms.ComboBox cmbtipotarjeta;
        private System.Windows.Forms.ComboBox cmbperiodocierre;
        private System.Windows.Forms.ComboBox cmbcliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

