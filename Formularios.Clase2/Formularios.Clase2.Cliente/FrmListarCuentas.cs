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
    public partial class FrmListarCuentas : Form
    {
        private FrmAgregarCuentas frmAgregarCuentas;
        public FrmListarCuentas(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
            frmAgregarCuentas = new FrmAgregarCuentas(this);
        }

        private void FrmListarCuentas_Load(object sender, EventArgs e)
        {
            CargarListaCuentas();
        }
        private void CargarListaCuentas()
        {
            lstCuentas.DataSource = null;
            //lstCuentas.DataSource=
            //lstCuentas.DisplayMember = "";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgregarCuentas.Show();

        }
    }
}
