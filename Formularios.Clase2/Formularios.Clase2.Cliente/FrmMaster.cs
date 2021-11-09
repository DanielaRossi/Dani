using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Clase2.Cliente
{
    public partial class FrmMaster : Form
    {
        private FrmListarCliente _frmListarCliente;
        private FrmListarCuentas _frmListarCuentas;
        public FrmMaster()
        {
            _frmListarCliente = new FrmListarCliente(this);
            _frmListarCuentas = new FrmListarCuentas(this);
            InitializeComponent();
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                _frmListarCliente.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnListarCuentas_Click(object sender, EventArgs e)
        {
            _frmListarCuentas.Show();
            this.Hide();
        }

        private void FrmMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
