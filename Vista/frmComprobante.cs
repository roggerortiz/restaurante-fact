using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Vista
{
    public partial class frmComprobante : Form
    {
        public Usuario usuario = new Usuario();
        public DataTable detalles = new DataTable();

        public frmComprobante()
        {
            InitializeComponent();
        }

        private void frmDetalleMesa_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            dtpFecha.Text = DateTime.Today.ToShortDateString();

            dgvDetalles.DataSource = detalles;

            dgvDetalles.Columns[0].Width = 50;
            dgvDetalles.Columns[0].HeaderText = "Nro.";
            dgvDetalles.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDetalles.Columns[1].Width = 250;
            dgvDetalles.Columns[1].HeaderText = "Descripción";
            dgvDetalles.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDetalles.Columns[2].Width = 60;
            dgvDetalles.Columns[2].HeaderText = "Cant.";
            dgvDetalles.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDetalles.Columns[3].HeaderText = "P.U.";
            dgvDetalles.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDetalles.Columns[4].HeaderText = "V. Vta.";
            dgvDetalles.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDetalles.Columns[5].Visible = false;

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            Decimal subtotal = 0, igv = 0, total = 0;

            foreach (DataRow detalle in detalles.Rows)
            {
                total += Convert.ToDecimal(detalle[4]);
            }

            igv = Math.Round((total * 18) / 118, 2);
            subtotal = Math.Round((total * 100) / 118, 2);

            txtSubtotal.Text = String.Format("{0:0.00}", subtotal);
            txtIgv.Text = String.Format("{0:0.00}", igv);
            txtTotal.Text = String.Format("{0:0.00}", total);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
