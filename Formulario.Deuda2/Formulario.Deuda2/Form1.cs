using Formulario.Deuda2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario.Deuda2
{
    public partial class Form1 : Form
    {
        private List<Servicio> _lstServicios;
        public Form1()
        {
            InitializeComponent();
            _lstServicios = new List<Servicio>();
            _lstServicios.Add(new Servicio(1,"Edenor",8.45));
            _lstServicios.Add(new Servicio(2, "Expensas",5.20));
            _lstServicios.Add(new Servicio(3, "Telecom", 2.21));
        }

        private void txtPunitorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            cmbServicio.DataSource = null;
            cmbServicio.DataSource = this._lstServicios;
            _cmbTipoDocumento.DisplayMember = "Descripcion";
            _cmbTipoDocumento.ValueMember = "Codigo";

        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
