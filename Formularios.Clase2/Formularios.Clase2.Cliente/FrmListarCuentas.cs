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
        public FrmListarCuentas(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
        }

        private void FrmListarCuentas_Load(object sender, EventArgs e)
        {
            CargarListaCuentas();
        }
        private void CargarListaCuentas()
        {
            lstCuentas.DataSource = null;
            //lstCuentas.DataSource=
            lstCuentas.DisplayMember= ""

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();

        }
    }
}
