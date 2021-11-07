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
    public partial class FrmAgregarDocente : Form
    {
        private List<TipoDocumento> lstDocumentos;
        
        public FrmAgregarDocente(Form propietario)
        {
            
            this.Owner = propietario;
            lstDocumentos = new List<TipoDocumento>();
            lstDocumentos.Add(new TipoDocumento(0, "-- SELECCIONE--"));
            lstDocumentos.Add(new TipoDocumento(1, "Soltero"));
            lstDocumentos.Add(new TipoDocumento(2, "Casado"));
            //CompletarControles();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        { 
            cmbTipoDocumento.DataSource = null;
            cmbTipoDocumento.DataSource = this.lstDocumentos;
            cmbTipoDocumento.DisplayMember = "Descripción";
            cmbTipoDocumento.ValueMember = "Codigo";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != string.Empty || this.txtApellido.Text != string.Empty)
            {
                //Formularios.Clase1.Entidades.Persona p = new Persona(this.txtNombre.Text, this.txtApellido.Text,this.);
                //txtResultado.Text = p.ToString();
                //MessageBox.Show(p.ToString());
            }
            else
            {
                MessageBox.Show("El nombre no puede ser vacio.");
            }

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntLimpiar_Click(object sender, EventArgs e)
        {
            //this.txtResultado.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtLegajo.Text = string.Empty;
            InicializarControles();
        }
        

        //private void btnListarDocente_Click(object sender, EventArgs e)
        //{
        //    //FrmListarDocente listarDocente = new FrmListarDocente();
        //    //listarDocente.Show();
        //    try
        //    {
        //        _formListaDocente.Show();
        //        this.Hide();
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarDocente_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones();
                Docente d1 = new Docente(Convert.ToInt32(this.txtLegajo.Text), this.txtNombre.Text, this.txtApellido.Text, (TipoDocumento)this.cmbTipoDocumento.SelectedItem);
                ((FrmListarDocente)this.Owner).AgregarDocente(d1);
                //limpiar();

                this.Hide();
                this.Owner.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Validaciones()
        {
            

                if ((int)cmbTipoDocumento.SelectedValue == 0)
                    throw new Exception("Seleccione un valor");
            
        }

        private void bntLimpiar_Click_1(object sender, EventArgs e)
        {
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtLegajo.Text = string.Empty;
            InicializarControles();
        }
    }
}
