using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Usuario usuario = new Usuario();
        public DataTable categorias = new DataTable();
        public DataTable productos = new DataTable();
        public DataTable detalles = new DataTable();
        
        Utilitarios util = new Utilitarios();
        TableLayoutPanel panelCategorias = new TableLayoutPanel();
        TableLayoutPanel panelProductos = new TableLayoutPanel();

        public frmDetalleMesa()
        {
            InitializeComponent();
        }

        private void frmDetalleMesa_Load(object sender, EventArgs e)
        {
            CrearPanelCategorias();
            CrearPanelProductos();
            ListarCategorias();
            ListarDetalles();
        }

        private void btnCategoria_Click(object sender, EventArgs e, Int32 categoriaId)
        {
            ListarProductos(categoriaId);
        }

        private void btnProducto_Click(object sender, EventArgs e, Int32 productoId)
        {
            SeleccionarProducto(productoId);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarComprobante();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPago pago = new frmPago();
            pago.detalles = detalles;
            pago.total = Convert.ToDecimal(txtTotal.Text);

            if (pago.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {
                Int32 indice = dgvDetalles.CurrentRow.Index;
                Int32 cantidad = Convert.ToInt32(detalles.Rows[indice][2]);
                Decimal precio = Convert.ToDecimal(detalles.Rows[indice][3]);

                cantidad++;
                detalles.Rows[indice][2] = cantidad;
                detalles.Rows[indice][4] = Math.Round((cantidad * precio), 2);

                CalcularTotal();
            }
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {
                Int32 indice = dgvDetalles.CurrentRow.Index;
                Int32 cantidad = Convert.ToInt32(detalles.Rows[indice][2]);
                Decimal precio = Convert.ToDecimal(detalles.Rows[indice][3]);

                if (cantidad > 0)
                {
                    cantidad--;
                    detalles.Rows[indice][2] = cantidad;
                    detalles.Rows[indice][4] = Math.Round((cantidad * precio), 2);
                }
                else
                {
                    detalles.Rows[indice].Delete();
                }

                CalcularTotal();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {
                Int32 indice = dgvDetalles.CurrentRow.Index;
                detalles.Rows[indice].Delete();

                for (Int32 i = 0; i < detalles.Rows.Count; i++)
                {
                    detalles.Rows[i][0] = (i + 1);
                }

                HabilitarGuardado();

                CalcularTotal();
            }
        }

        private void CrearPanelCategorias()
        {
            Int32 columnas = 3, filas = 2;

            panelCategorias.ColumnCount = columnas;
            panelCategorias.RowCount = filas;
            panelCategorias.Padding = new Padding(2, 4, 2, 4);
            panelCategorias.Dock = DockStyle.Fill;

            gbCategorias.Controls.Add(panelCategorias);

            for (Int32 i = 0; i < columnas; i++)
            {
                panelCategorias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100 / columnas)));
            }

            for (Int32 i = 0; i < filas; i++)
            {
                panelCategorias.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100 / filas)));
            }
        }

        private void CrearPanelProductos()
        {
            Int32 columnas = 3, filas = 5;

            panelProductos.ColumnCount = columnas;
            panelProductos.RowCount = filas;
            panelProductos.Padding = new Padding(2, 4, 2, 4);
            panelProductos.Dock = DockStyle.Fill;

            gbProductos.Controls.Add(panelProductos);

            for (Int32 i = 0; i < columnas; i++)
            {
                panelProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100 / columnas)));
            }

            for (Int32 i = 0; i < filas; i++)
            {
                panelProductos.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100 / filas)));
            }
        }

        private void ListarCategorias()
        {
            panelCategorias.Controls.Clear();

            Int32 total = categorias.Rows.Count, columna = 0, fila = 0;

            for (Int32 i = 0; i < total; i++)
            {
                Int32 categoriaId = Convert.ToInt32(categorias.Rows[i][0].ToString());
                String nombre = categorias.Rows[i][1].ToString();

                Button btn = new Button();
                btn.Text = nombre;
                btn.Name = String.Format("btnCategoria{0:00}", categoriaId);
                btn.BackColor = ColorTranslator.FromHtml("#17a2b8");
                btn.ForeColor = ColorTranslator.FromHtml("#ffffff");
                btn.Font = new Font("Arial", 10F);
                btn.Margin = new Padding(1);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Dock = DockStyle.Fill;
                btn.Click += new EventHandler((sender1, e1) => btnCategoria_Click(sender1, e1, categoriaId));

                panelCategorias.Controls.Add(btn, columna, fila);

                columna = (columna == 3) ? 0 : (columna + 1);
                fila = (columna == 0) ? (fila + 1) : fila;
            }

            if (total > 0 && total <= 3)
            {
                panelCategorias.Controls.Add(new Label() { Dock = DockStyle.Fill }, 0, 1);
            }

            if (total > 0)
            {
                ListarProductos(Convert.ToInt32(categorias.Rows[0][0]));
            }
        }

        private void ListarProductos(Int32 categoriaId)
        {
            panelProductos.Controls.Clear();

            EnumerableRowCollection<DataRow> rows = productos.AsEnumerable()
                .Where(row => row["categoria_id"].ToString() == categoriaId.ToString());

            if (rows.Count() > 0)
            {
                DataTable productosCat = rows.CopyToDataTable();

                Int32 total = productosCat.Rows.Count, columna = 0, fila = 0;

                for (Int32 i = 0; i < total; i++)
                {
                    Int32 productoId = Convert.ToInt32(productosCat.Rows[i][0].ToString());
                    String nombre = productosCat.Rows[i][3].ToString();
                    String precio = productosCat.Rows[i][4].ToString();
                    String categoria = productosCat.Rows[i][6].ToString();

                    gbProductos.Text = categoria.ToUpper();

                    nombre = (nombre.Length > 20) ? nombre.Substring(0, 20) : nombre;

                    Button btn = new Button();
                    btn.Text = nombre + "\nS/. " + String.Format("{0:0.00}", precio) + "";
                    btn.Name = String.Format("btnProducto{0:00}", productoId);
                    btn.BackColor = ColorTranslator.FromHtml("#0062cc");
                    btn.ForeColor = ColorTranslator.FromHtml("#ffffff");
                    btn.Font = new Font("Arial", 10F);
                    btn.Margin = new Padding(1);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Dock = DockStyle.Fill;
                    btn.Click += new EventHandler((sender1, e1) => btnProducto_Click(sender1, e1, productoId));

                    panelProductos.Controls.Add(btn, columna, fila);

                    columna = (columna == 3) ? 0 : (columna + 1);
                    fila = (columna == 0) ? (fila + 1) : fila;
                }

                if (total > 0 && total <= 12)
                {
                    panelProductos.Controls.Add(new Label() { Dock = DockStyle.Fill }, 0, 7);
                }
            }
            else
            {
                panelProductos.Controls.Add(new Label() { Dock = DockStyle.Fill }, 0, 0);
                panelProductos.Controls.Add(new Label() { Dock = DockStyle.Fill }, 0, 7);
            }
        }

        private void ListarDetalles()
        {
            detalles = util.ObtenerDetallesXML(mesa);

            dgvDetalles.DataSource = detalles;
            dgvDetalles.DefaultCellStyle.Font = new Font("Arial", 12F);

            dgvDetalles.Columns[0].Width = 50;
            dgvDetalles.Columns[0].HeaderText = "Nro.";
            dgvDetalles.Columns[0].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDetalles.Columns[1].Width = 250;
            dgvDetalles.Columns[1].HeaderText = "Descripción";
            dgvDetalles.Columns[1].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDetalles.Columns[2].Width = 60;
            dgvDetalles.Columns[2].HeaderText = "Cant.";
            dgvDetalles.Columns[2].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDetalles.Columns[3].HeaderText = "P.U.";
            dgvDetalles.Columns[3].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDetalles.Columns[4].HeaderText = "V. Vta.";
            dgvDetalles.Columns[4].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvDetalles.Columns[5].Visible = false;

            HabilitarGuardado();

            CalcularTotal();
        }

        private void SeleccionarProducto(Int32 productoId)
        {
            DataRow detalle = detalles.NewRow();

            EnumerableRowCollection<DataRow> detaProd = detalles.AsEnumerable()
                .Where(row => row[5].ToString() == productoId.ToString());

            if (detaProd.Count() > 0)
            {
                String posicion = detaProd.CopyToDataTable().Rows[0][0].ToString();
                Int32 indice = Convert.ToInt32(posicion) - 1;

                Int32 cantidad = Convert.ToInt32(detalles.Rows[indice][2]);
                Decimal precio = Convert.ToDecimal(detalles.Rows[indice][3]);

                cantidad++;
                detalles.Rows[indice][2] = cantidad;
                detalles.Rows[indice][4] = Math.Round((cantidad * precio), 2);
            }
            else
            {
                DataRow producto = productos.AsEnumerable()
                    .Where(row => row["id"].ToString() == productoId.ToString())
                    .CopyToDataTable().Rows[0];

                detalle[0] = dgvDetalles.RowCount + 1;
                detalle[1] = producto["nombre"].ToString();
                detalle[2] = "1";
                detalle[3] = producto["precio_unitario"];
                detalle[4] = producto["precio_unitario"];
                detalle[5] = producto["id"];

                detalles.Rows.Add(detalle);
            }

            HabilitarGuardado();

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            Decimal total = 0;

            foreach (DataRow detalle in detalles.Rows)
            {
                total += Convert.ToDecimal(detalle[4]);
            }

            txtTotal.Text = String.Format("{0:0.00}", total);
        }

        private void GuardarComprobante()
        {
            List<Detalle> listDeta = new List<Detalle>();

            foreach (DataRow detalle in detalles.Rows)
            {
                Detalle deta = new Detalle();
                String numero = detalle["Nro"].ToString();
                deta.Posicion = Convert.ToInt32(detalle[0]);
                deta.Descripcion = detalle[1].ToString();
                deta.Cantidad = Convert.ToInt32(detalle[2]);
                deta.PrecioUnitario = Convert.ToDecimal(detalle[3]);
                deta.PrecioNeto = Convert.ToDecimal(detalle[4]);
                deta.ProductoID = Convert.ToInt32(detalle[5]);

                listDeta.Add(deta);
            }

            util.GuardarDetallesXML(mesa, listDeta);

            MessageBox.Show("Comprobante Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }

        private void HabilitarGuardado()
        {
            if (detalles.Rows.Count > 0)
            {
                btnGuardar.Enabled = true;
                btnPagar.Enabled = true;
            }
            else 
            {
                btnGuardar.Enabled = false;
                btnPagar.Enabled = false;
            }
        }
    }    
}
