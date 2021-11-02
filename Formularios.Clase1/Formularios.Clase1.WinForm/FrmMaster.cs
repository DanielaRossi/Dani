using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Clase1.WinForm
{
    public partial class FrmMaster : Form
    {
        private FrmListarDocente _formListaDocente;
        public FrmMaster()
        {
            _formListaDocente = new FrmListarDocente(this);
            _formListaDocente.Owner = this;
            //CompletarControles();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty)
            {
                Librería.Persona p = new Librería.Persona(this.txtNombre.Text, this.txtApellido.Text);
                txtResultado.Text = p.ToString();
                //MessageBox.Show(p.ToString());
            }
            else
            {
                MessageBox.Show("El nombre no puede ser vacio.");
            }

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            this.txtResultado.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
        }
        

        private void btnListarDocente_Click(object sender, EventArgs e)
        {
            //FrmListarDocente listarDocente = new FrmListarDocente();
            //listarDocente.Show();
            try
            {
                _formListaDocente.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
