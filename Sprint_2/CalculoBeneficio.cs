using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Sprint_2
{
    public partial class CalculoBeneficio : Form
    {
        Suscrito suscrito = new Suscrito();
        Suscriptos suscriptos = new Suscriptos();
        public CalculoBeneficio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml("Tabla_Suscriptos");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.ReadOnly = true;

            suscrito.Agregar(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDNI.Text,
                txtNSuscripto.Text, txtCuotasPagadas.Text, Convert.ToInt16(txtMontoCuota.Text));
            suscriptos.InsertSuscrito(suscrito);

            MessageBox.Show("Suscripto cargado correctamente","",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
         
            Suscrito sus = suscriptos.BuscarSuscripto("aNSuscripto", txtAbuscar.Text);

            if (sus != null)
            {
                
                txtNombreB.Text = sus.Nombre;
                txtApellidoB.Text = sus.Apellido;
                txtTelefonoB.Text = sus.Telefono;
                txtDNIB.Text = sus.DNI;
                txtNSuscriptoB.Text = sus.NSuscripto;
                txtCuotasPagadasB.Text = sus.CuotasPagadas;
                txtMontoCuotaB.Text = sus.MontoCuota.ToString();
            }
            else
            {
                MessageBox.Show("Suscripto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
         var X = int.Parse(txtMontoTotal.Text);
           var Y = int.Parse(txtValorCompradoPlan.Text);
            txtBeneficio.Text = (X - Y).ToString();
        }

        private void btBuscarCalcular_Click(object sender, EventArgs e)
        {
            Suscrito sus = suscriptos.BuscarSuscripto("aNSuscripto", txtNsuctiproBenef.Text);

            txtCantCuotasPagadas.Text = sus.CuotasPagadas;
            txtMontoTotal.Text = (Convert.ToInt16(sus.CuotasPagadas) * sus.MontoCuota).ToString();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreB.Text = "";
            txtApellidoB.Text = "";
            txtTelefonoB.Text = "";
            txtDNIB.Text = "";
            txtNSuscriptoB.Text = "";
            txtCuotasPagadasB.Text = "";
            txtMontoCuotaB.Text = "";
        }

        private void btMostrarGrid_Click(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml("Tabla_Suscriptos");
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.ReadOnly = true;
        }

        private void btLimpiarGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

        }
    }
}
