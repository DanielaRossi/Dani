using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios.Clase2.Entidades;
using Formularios.Clase2.Negocio;

namespace Formularios.Clase2.Cliente
{
    public partial class FormAgregarCliente : Form
    {
        
        public FormAgregarCliente(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
        }

        private void FormAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            Limpiar();

        }
        public void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtCuit.Text = string.Empty;
            
            this.checksi.Checked = false;
            this.txtFechaNacimiento.Text = string.Empty;
        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Cliente c1 = new Cliente(Convert.ToInt32(this.txtId.Text),checksi.Checked, this.txtNombre.Text, this.txtApellido.Text, this.txtDireccion.Text, this.txtTelefono.Text, this.txtEmail.Text, Convert.ToDateTime(this.txtFechaNacimiento.Text), Convert.ToInt64(this.txtCuit.Text));
                //((FrmListarCliente)this.Owner).AgregarCliente(c1);
                Limpiar();

                this.Hide();
                this.Owner.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
