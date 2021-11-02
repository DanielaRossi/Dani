using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios.Clase1.WinForm
{
    public partial class FrmListarDocente: Form
    {
        public FrmListarDocente(Form propietario)
        {
            _docentes = new List<Docente>();
            _docentes.Add(new Docente(1, "Dani", "Rossi"));
            _docentes.Add(new Docente(2, "Agus", "Rossi"));
            //CompletarControles();
            InitializeComponent();
        }

        private void FrmListarDocente_Load(object sender, EventArgs e)
        {
            CargarListaDocente();
        }
        private List<Docente> _docentes;
        private void CargarListaDocente()
        {
            lstDocentes.DataSource = null;
            lstDocentes.DataSource = this._docentes;
            lstDocentes.ValueMember = "";
            lstDocentes.DisplayMember = "Mostrar";
            lstDocentes.ValueMember = "Legajo";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("HOVER");
            this.Hide();
        }
    }
}
