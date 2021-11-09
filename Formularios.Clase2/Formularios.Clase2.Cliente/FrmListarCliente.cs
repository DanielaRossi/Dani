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
    public partial class FrmListarCliente : Form
    {
        private ClienteService _clienteservice;
        private FormAgregarCliente _frmAgregarCliente;
        public FrmListarCliente(Form propietario)
        {
            this.Owner = propietario;
            InitializeComponent();
            _clienteservice = new ClienteService();
            _frmAgregarCliente = new FormAgregarCliente(this);
        }

        private void FrmListarCliente_Load(object sender, EventArgs e)
        {
            CargarListaCliente();
        }

        public void CargarListaCliente()
        {
            lstClientes.DataSource = null;
            lstClientes.DataSource = _clienteservice.GetCliente();
            lstClientes.DisplayMember = "Mostrar";
            lstClientes.ValueMember = "Id";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmAgregarCliente.Show();
        }
        public void AgregarCliente(Clientes cliente)
        {
            _clienteservice.AddCliente(cliente);
            CargarListaCliente();
        }
    }
}
