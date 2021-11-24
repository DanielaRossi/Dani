﻿using Formulario.Deuda2.Entidades;
using Formulario.Deuda2.Negocio;
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
        private PagoNegocio pagoNegocio;
        private List<PagoMorosos> listapago;
        private PagoModel pagoModel;

        public Form1()
        {
            InitializeComponent();
            _lstServicios = new List<Servicio>();
            _lstServicios.Add(new Servicio(1, "Edenor", 8.45));
            _lstServicios.Add(new Servicio(2, "Expensas", 5.20));
            _lstServicios.Add(new Servicio(3, "Telecom", 2.21));
            pagoNegocio = new PagoNegocio();
            listapago = new List<PagoMorosos>();
            pagoModel = new PagoModel(listapago);
        }

        private void txtPunitorio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarControles();
            CargarLista();
            CargarDatos();
        }
        private void CargarLista()
        {
            listapago = pagoNegocio.Traer();
            lstPagos.DataSource = null;
            lstPagos.DataSource = listapago;
        }
        private void InicializarControles()
        {
            cmbServicio.DataSource = null;
            cmbServicio.DataSource = this._lstServicios;


        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbServicio.SelectedIndex > -1)
            {
                Servicio servicioseleccionado = (Servicio)cmbServicio.SelectedItem;
                txtPunitorio.Text = servicioseleccionado.PunitoiroDiario.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime Fechafinal = Convert.ToDateTime(txtFechapago.Text);
            //DateTime Fechaincial = Convert.ToDateTime(txtfechavencimiento.Text);

            //int dias = (Fechafinal - Fechafinal).Days;


            //Servicio servicioseleccionado = (Servicio)cmbServicio.SelectedItem;
            //double interesdia = servicioseleccionado.PunitoiroDiario;

            //double resultadodia = dias * interesdia;

            //double importetotal = Convert.ToDouble(txtImporteadeudado);

            //double resultado = resultadodia * importetotal;


            //txtInterespunitorio.Text = (resultadodia).ToString("0.00");



            //txtImportetotal.Text = (resultado).ToString("0.00");
            try
            {
                DateTime SalidaF = DateTime.Now;
                DateTime SalidaV = DateTime.Now;
                ValidarFecha(txtFechapago.Text, ref SalidaF);
                ValidarFecha(txtfechavencimiento.Text, ref SalidaV);
                int dias = (SalidaF - SalidaV).Days;
                Servicio servicioseleccionado = (Servicio)cmbServicio.SelectedItem;
                double interesdia = servicioseleccionado.PunitoiroDiario;
                double resultadodia = dias * interesdia;
                txtInterespunitorio.Text = resultadodia.ToString("0.00");

                double SalidaD = 0;
                ValidarDouble(txtImporteadeudado.Text, ref SalidaD);
                double resultado = resultadodia + SalidaD;
                txtImportetotal.Text = (resultado).ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
        private void ValidarVacio(string Valor, string Campo)
        {
            if (string.IsNullOrEmpty(Valor))
            {
                throw new Exception("El campo" + Campo + " no debe estar vacio" + System.Environment.NewLine);
            }
        }
        private void ValidarInt(string Valor, ref int Salida)
        {
            

            if (!int.TryParse(Valor, out Salida))
            {
                throw new Exception("El valor debe ser númerico" + System.Environment.NewLine);
            }
            else if (Salida <= 0)
            {
                throw new Exception("El valor debe ser positivo" + System.Environment.NewLine);
            }
        }
        private void ValidarDouble(string Valor, ref double Salida)
        {
            

            if (!double.TryParse(Valor, out Salida))
            {
                throw new Exception("El valor debe ser númerico" + System.Environment.NewLine);
            }
            else if (Salida <= 0)
            {
                throw new Exception("El valor debe ser positivo" + System.Environment.NewLine);
            }
        }
        private void ValidarFecha(string Valor, ref DateTime Salida)
        {
            

            if (!DateTime.TryParse(Valor, out Salida))
            {
                throw new Exception("El valor debe ser una fecha" + System.Environment.NewLine);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                Servicio servicioseleccionado = (Servicio)cmbServicio.SelectedItem;
                int id = servicioseleccionado.Id;
                int idcliente = 1;
                DateTime fechav = Convert.ToDateTime(txtfechavencimiento.Text);
                DateTime fechapago = Convert.ToDateTime(txtFechapago.Text);
            double SalidaD = 0;
            ValidarDouble(txtImporteadeudado.Text, ref SalidaD);
            double importeadeudado = SalidaD;
            double SalidaI = 0;
            ValidarDouble(txtInterespunitorio.Text, ref SalidaI);
            double interesespunitorio = SalidaD;
            //double interesespunitorio = Convert.ToDouble(txtInterespunitorio);
                TransactionResult resultado = null;
                resultado = pagoNegocio.Insertar(id, idcliente, fechav, fechapago, importeadeudado, interesespunitorio);
                CargarLista();
                CargarDatos();


        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void lstPagos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarDatos()
        {
            txtInteréspromedio.Text = pagoModel.InteresPromedio.ToString("0.00");
            
                
        }
    }
}
