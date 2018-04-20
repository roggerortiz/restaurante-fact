using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmPago : Form
    {
        public Usuario usuario = new Usuario();
        public DataTable detalles = new DataTable();
        public Decimal total = 0;

        public frmPago()
        {
            InitializeComponent();
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.');
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            txtTotal.Text = String.Format("{0:0.00}", total);
            txtVuelto.Text = String.Format("{0:0.00}", 0);
            cboTipoPago.SelectedIndex = 0;
            txtPago.Focus();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal pago = Convert.ToDecimal(txtPago.Text);
                Decimal vuelto = (pago >= total) ? (pago - total) : 0;

                txtVuelto.Text = String.Format("{0:0.00}", vuelto);
            }
            catch(Exception ex)
            {
                txtVuelto.Text = String.Format("{0:0.00}", 0);
                Console.WriteLine("Error al obtener monto de pago: " + ex.Message);
            }
        }

        private void MostrarComprobante()
        {
            frmComprobante comprobante = new frmComprobante();
            comprobante.detalles = detalles;

            if (comprobante.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnBoleta_Click(object sender, EventArgs e)
        {
            MostrarComprobante();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            MostrarComprobante();
        }

        private void cboTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoPago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cboTipoPago.Text)
            {
                case "Efectivo":
                    txtPago.Enabled = true;
                    break;
                default:
                    txtPago.Enabled = false;
                    txtPago.Text = txtTotal.Text;
                    txtVuelto.Text = "0.00";
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
