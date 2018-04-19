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
    public partial class frmDetalleMesa : Form
    {
        public String mesa;
        public DataTable categorias = new DataTable();
        public DataTable productos = new DataTable();
        public DataTable detalles = new DataTable();

        Utilitarios util = new Utilitarios();

        public frmDetalleMesa()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDetalleMesa_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            ListarCategorias();
            ListarDetalles();
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ListarProductos(dgvCategorias.CurrentRow.Index);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarProducto(dgvProductos.CurrentRow.Index);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            GuardarComprobante();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarDatos()
        {
            txtFecha.Text = DateTime.Today.ToShortDateString();
            txtMesa.Text = mesa;
        }

        private void ListarCategorias()
        {
            dgvCategorias.DataSource = categorias;
            dgvCategorias.Columns[0].Visible = false;
            dgvCategorias.Columns[0].HeaderText = "ID";
            dgvCategorias.Columns[1].HeaderText = "CATEGORÍAS";
            dgvCategorias.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (categorias.Rows.Count > 0)
            {
                ListarProductos(0);
            }
        }

        private void ListarProductos(Int32 index)
        {
            String categoriaId = dgvCategorias.Rows[index].Cells[0].Value.ToString();

            DataTable productosCat = productos.AsEnumerable()
                .Where(row => row["categoria_id"].ToString() == categoriaId)
                .CopyToDataTable();

            dgvProductos.DataSource = productosCat;
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[0].HeaderText = "ID";
            dgvProductos.Columns[1].HeaderText = "PRODUCTOS";
            dgvProductos.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[2].Visible = false;
            dgvProductos.Columns[3].Visible = false;
            dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[5].Visible = false;
        }

        private void ListarDetalles()
        {
            detalles = util.ObtenerDetallesXML(mesa);

            dgvDetalles.DataSource = detalles;
            dgvDetalles.Columns[0].Visible = false;
            dgvDetalles.Columns[1].Visible = false;
            dgvDetalles.Columns[2].Width = 30;
            dgvDetalles.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[3].Width = 240;
            dgvDetalles.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[4].Width = 70;
            dgvDetalles.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDetalles.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            CalcularTotal();
        }

        private void SeleccionarProducto(Int32 index)
        {
            DataRow detalle = detalles.NewRow();

            detalle["Nro"] = dgvDetalles.RowCount + 1;
            detalle["ProductoID"] = dgvProductos.Rows[index].Cells[0].Value.ToString();
            detalle["Nombre"] = dgvProductos.Rows[index].Cells[1].Value.ToString();

            Decimal precio = Convert.ToDecimal(dgvProductos.Rows[index].Cells[2].Value.ToString());

            detalle["Cantidad"] = "1";
            detalle["Precio"] = precio.ToString();
            detalle["Subtotal"] = precio.ToString();

            detalles.Rows.Add(detalle);

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            Decimal subtotal = 0, igv = 0, total = 0;

            foreach (DataRow detalle in detalles.Rows)
            {
                total += Convert.ToDecimal(detalle["Subtotal"]);
            }

            igv = Math.Round((total * 18) / 118, 2);
            subtotal = Math.Round((total * 100) / 118, 2);

            txtSubtotal.Text = String.Format("{0:0.00}", subtotal);
            txtIgv.Text = String.Format("{0:0.00}", igv);
            txtTotal.Text = String.Format("{0:0.00}", total);
        }

        private void GuardarComprobante()
        {
            Comprobante comprobante = new Comprobante();
            comprobante.Tipo = "01";
            comprobante.Fecha = DateTime.Today;
            comprobante.Subtotal = Convert.ToDecimal(txtSubtotal.Text);
            comprobante.IGV = Convert.ToDecimal(txtIgv.Text);
            comprobante.Total = Convert.ToDecimal(txtTotal.Text);
            comprobante.Mesa = Convert.ToInt32(mesa);
            comprobante.ClienteID = 2;
            comprobante.UsuarioID = 1;

            foreach (DataRow detalle in detalles.Rows)
            {
                Detalle deta = new Detalle();
                String numero = detalle["Nro"].ToString();
                deta.Numero = Convert.ToInt32(detalle["Nro"]);
                deta.Nombre = detalle["Nombre"].ToString();
                deta.Cantidad = Convert.ToInt32(detalle["Cantidad"]);
                deta.Precio = Convert.ToDecimal(detalle["Precio"]);
                deta.Subtotal = Convert.ToDecimal(detalle["Subtotal"]);
                deta.ProductoID = Convert.ToInt32(detalle["ProductoID"]);

                comprobante.Detalles.Add(deta);
            }

            util.GuardarComprobanteXML(comprobante);

            MesaController mc = new MesaController();
            mc.Actualizar(Convert.ToInt32(mesa), "Ocupada");

            MessageBox.Show("Comprobante Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }
    }
}
