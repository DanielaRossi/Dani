using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios.Clase1.Entidades;

namespace Formularios.Clase1.WinForm
{
    public partial class FrmListarDocente: Form
    {
        private List<Docente> _docentes;
        private FrmAgregarDocente _frmAgregarDocente;
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
        public FrmListarDocente(Form propietario)
        {
            this.Owner = propietario;
            _frmAgregarDocente = new FrmAgregarDocente(this);
            
            _docentes = new List<Docente>();
            _docentes.Add(new Docente(1, "Rodolfo", "Zavala", new TipoDocumento(1, "Soltero")));
            _docentes.Add(new Docente(2, "Suyai", "Pecoraro", new TipoDocumento(1, "Soltero")));
            _docentes.Add(new Docente(3, "Blanco", "Marcelo", new TipoDocumento(1, "Soltero")));

            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            _frmAgregarDocente.Show();
        }


        //private void FrmListarDocente_Load(object sender, EventArgs e)
        //{
        //    CargarListaDocente();
        //}
        private void CargarListaDocente()
        {
            lstDocentes.DataSource = null;
            lstDocentes.DataSource = this._docentes;
            lstDocentes.ValueMember = "";
            lstDocentes.DisplayMember = "Mostrar";
            lstDocentes.ValueMember = "Legajo";
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                Docente seleccionado = (Docente) lstDocentes.SelectedItem;
                MessageBox.Show(seleccionado.Apellido);

            }
            catch(Exception ex)
            {

            }
        }

        private void FrmListarDocente_Load(object sender, EventArgs e)
        {
            CargarListaDocente();
        }

        private void lstDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cuando toco la fila me muestra el codigo
            try
            {
                if (lstDocentes.DataSource != null && !string.IsNullOrEmpty(lstDocentes.ValueMember))
                {
                    string cod = this.lstDocentes.SelectedValue.ToString();
                    MessageBox.Show(cod);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
