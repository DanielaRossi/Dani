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
    public partial class FrmAgregarCuentas : Form
    {
        public FrmAgregarCuentas(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
        }

        private void FrmAgregarCuentas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
