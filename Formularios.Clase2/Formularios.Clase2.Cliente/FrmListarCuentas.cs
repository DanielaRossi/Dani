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
using Formularios.Clase2.Entidades;

namespace Formularios.Clase2.Cliente
{
    public partial class FrmListarCuentas : Form
    {
        private FrmAgregarCuentas frmAgregarCuentas;
        private CuentasService _cuentasservice;
        public FrmListarCuentas(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
            frmAgregarCuentas = new FrmAgregarCuentas(this);
            _cuentasservice = new CuentasService();
        }

        private void FrmListarCuentas_Load(object sender, EventArgs e)
        {
            CargarListaCuentas();
        }
        private void CargarListaCuentas()
        {
            lstCuentas.DataSource = null;
            lstCuentas.DataSource = _cuentasservice.GetCuentas();
            lstCuentas.DisplayMember = "Mostrar";
            lstCuentas.ValueMember = "Id";

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
