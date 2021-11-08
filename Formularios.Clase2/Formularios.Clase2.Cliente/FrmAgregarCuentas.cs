using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios.Clase2.Negocio;

namespace Formularios.Clase2.Cliente
{
    public partial class FrmAgregarCuentas : Form
    {
        
        private CuentasService _cuentasservice;
        public FrmAgregarCuentas(Form propietario)
        {
            InitializeComponent();
            this.Owner = propietario;
            _cuentasservice = new CuentasService();
        }

        private void FrmAgregarCuentas_Load(object sender, EventArgs e)
        {
            CargarIdCliente();
        }
        private void CargarIdCliente()
        {
            cmbIDCLIENTE.DataSource = null;
            cmbIDCLIENTE.DataSource = _cuentasservice.GetCuentas();
            cmbIDCLIENTE.DisplayMember = "Id";
            cmbIDCLIENTE.ValueMember = "Descripcion";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            try
            {

                
                

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
