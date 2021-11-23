using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarjetaCredito.Entidades;
using TarjetaCredito.Entidades.Enum;
using TarjetaCredito.Entidades.Modelos;
using TarjetaCredito.Negocio;

namespace Formularios.TarjetaCredito._1
{
    public partial class Form1 : Form
    {
        private ClienteNegocio _clienteNegocio;
        private TarjetaNegocio _tarjetaNegocio;
        private List<Tarjeta> _tarjetas;
        
        public Form1()
        {
            InitializeComponent();
            _clienteNegocio = new ClienteNegocio();
            _tarjetaNegocio = new TarjetaNegocio();
            _tarjetas = new List<Tarjeta>();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCombos();
            RecargarLista();
            RecargarCalculos();
            
        }
        private void CargarCombos()
        {
           
            cmbtipotarjeta.DataSource = Enum.GetValues(typeof(TipoTarjetaEnum));
            cmbperiodocierre.DataSource = Enum.GetValues(typeof(PeriodoEnum));
            cmbcliente.DataSource = _clienteNegocio.TraerConCuentas();
            cmbcliente.DisplayMember = "DisplayParaCombo";
            cmbcliente.ValueMember = "id";

        }

        private void cmbtipotarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void RecargarLista()
        {
            _tarjetas = _tarjetaNegocio.TraerSinCliente();
            lstTarjetas.DataSource = null;
            lstTarjetas.DataSource = _tarjetas;
        }
        private void RecargarCalculos()
        {
            OperadorFormulario operadorformulario = new OperadorFormulario(_tarjetas);
            txtcantidadplastico.Text = operadorformulario.Cantidad.ToString();
            txtlimitepromedio.Text = operadorformulario.LimitePromedio.ToString(0.00);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtcantidadplastico_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txtnumeroplastico.Clear();
            txtlimite.Clear();
            cmbtipotarjeta.SelectedIndex = 0;
            cmbperiodocierre.SelectedIndex = 0;
        }
        private void ValidacionesCalcularTarjeta()
        {
            TipoTarjetaEnum tipo = (TipoTarjetaEnum)cmbtipotarjeta.SelectedItem;
            PeriodoEnum periodo = (PeriodoEnum)cmbperiodocierre.SelectedItem;
            Cliente cliente = (Cliente)cmbcliente.SelectedItem;

            // valido que exista selección
            if (((int)tipo) == 0)
            {
                throw new Exception("Seleccione tipo");
            }

            if (((int)periodo) == 0)
            {
                throw new Exception("Seleccione periodo");
            }

            if (cliente == null || cliente.id == 0)
            {
                throw new Exception("Seleccione cliente válido");
            }


        }
        private void ValidacionesAlta()
        {
            ValidacionesCalcularTarjeta();

            // agregamos más validaciones:
            // dígitos del plástico depende del tipo tarjeta,
            // que el limite sea numerico y que respete los límites

            int limite = Convert.ToInt32(txtlimite.Text);

            if(limite < 1000|| limite > 50000)
            {
                throw new Exception("El limite de compra debe estar entre 1000 a 50000");
            }

        }
        private void _btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesCalcularTarjeta();

                Cliente cliente = (Cliente)cmbcliente.SelectedItem;
                TipoTarjetaEnum tipo = (TipoTarjetaEnum)cmbtipotarjeta.SelectedItem;
                PeriodoEnum periodo = (PeriodoEnum)cmbperiodocierre.SelectedItem;

                if (cliente != null)
                {
                    // le damos la responsabilidad a la capa de negocio de calcular la tarjeta
                    string nroTarjeta = _tarjetaNegocio.CalcularNroPlastico(cliente, tipo, periodo);

                    txtnumeroplastico.Text = nroTarjeta;
                }
            }
            // capturar las distintas exceptions
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void _btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionesAlta();

                TipoTarjetaEnum tipo = (TipoTarjetaEnum)cmbtipotarjeta.SelectedItem;
                PeriodoEnum periodo = (PeriodoEnum)cmbperiodocierre.SelectedItem;
                Cliente cliente = (Cliente)cmbcliente.SelectedItem;
                string plastico = txtnumeroplastico.Text;
                double limite = Convert.ToDouble(txtlimite.Text);
                _tarjetaNegocio.Alta(tipo, periodo, cliente, plastico, limite);

                Limpiar();
                RecargarLista();
                RecargarCalculos();
            }
            // capturar las distintas exceptions
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
