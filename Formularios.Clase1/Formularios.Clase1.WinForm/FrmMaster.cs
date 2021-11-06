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
    public partial class FrmMaster : Form
    {
        private FrmListarDocente _formListaDocentes;

        public FrmMaster()
        {
            _formListaDocentes = new FrmListarDocente(this);
            CompletarControles();
            InitializeComponent();
        }

        

        private void btnListarDocentes_Click(object sender, EventArgs e)
        {
            try
            {
                _formListaDocentes.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void CompletarControles()
        {

        }
    }
}
