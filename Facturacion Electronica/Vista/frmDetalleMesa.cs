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
                // Se obtiene el indice de la fila seleccionada
                Int32 indice = dgvDetalles.CurrentRow.Index;

                // Se obtiene la cantidad y el precio de la fila seleccionada
                Int32 cantidad = Convert.ToInt32(detalles.Rows[indice][2]);
                Decimal precio = Convert.ToDecimal(detalles.Rows[indice][3]);

                // Se aumenta en uno la cantidad y se calcula el nuevo valor de venta
                cantidad++;
                detalles.Rows[indice][2] = cantidad;
                detalles.Rows[indice][4] = Math.Round((cantidad * precio), 2);

                CalcularTotal();
            }
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            // Se valida si se selecciono una fila
            if (dgvDetalles.CurrentRow != null)
            {
                // Se obtiene el indice de la fila seleccionada
                Int32 indice = dgvDetalles.CurrentRow.Index;
                
                // Se obtiene la cantidad y el precio de la fila seleccionada
                Int32 cantidad = Convert.ToInt32(detalles.Rows[indice][2]);
                Decimal precio = Convert.ToDecimal(detalles.Rows[indice][3]);

                // Si la cantidad es mayor a uno se disminuye en uno y se calcula el nuevo valor de venta
                if (cantidad > 1)
                {
                    cantidad--;
                    detalles.Rows[indice][2] = cantidad;
                    detalles.Rows[indice][4] = Math.Round((cantidad * precio), 2);
                }
                else // Si la cantidad es 1 se elimina de la tabla detalle
                {
                    detalles.Rows[indice].Delete();
                }

                CalcularTotal();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Se valida si se selecciono una fila
            if (dgvDetalles.CurrentRow != null)
            {
                // Se obtiene el indice de la fila seleccionada
                Int32 indice = dgvDetalles.CurrentRow.Index;

                // Se elimina la fila de la tabla detales
                detalles.Rows[indice].Delete();

                // Se reajustan las posiciones de los productos
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
            // Se especifican las columnas y filas del panel de categorias
            Int32 columnas = 3, filas = 2;

            // Se da formato al panel de categorias
            panelCategorias.ColumnCount = columnas;
            panelCategorias.RowCount = filas;
            panelCategorias.Padding = new Padding(2, 4, 2, 4);
            panelCategorias.Dock = DockStyle.Fill;

            // Se agrega el panel al groupBox
            gbCategorias.Controls.Add(panelCategorias);

            // Se crean las columnas del panel de categorias
            for (Int32 i = 0; i < columnas; i++)
            {
                panelCategorias.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100 / columnas)));
            }

            // Se crean las filas del panel de categorias
            for (Int32 i = 0; i < filas; i++)
            {
                panelCategorias.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100 / filas)));
            }
        }

        private void CrearPanelProductos()
        {
            // Se especifican las columnas y filas del panel de productos
            Int32 columnas = 3, filas = 5;

            // Se da formato al panel de productos
            panelProductos.ColumnCount = columnas;
            panelProductos.RowCount = filas;
            panelProductos.Padding = new Padding(2, 4, 2, 4);
            panelProductos.Dock = DockStyle.Fill;

            // Se agrega el panel al groupBox
            gbProductos.Controls.Add(panelProductos);

            // Se crean las columnas del panel de productos
            for (Int32 i = 0; i < columnas; i++)
            {
                panelProductos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100 / columnas)));
            }

            // Se crean las filas del panel de productos
            for (Int32 i = 0; i < filas; i++)
            {
                panelProductos.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100 / filas)));
            }
        }

        private void ListarCategorias()
        {
            // Se limpian los controles agregados al panel de categorias
            panelCategorias.Controls.Clear();

            // Definicion de variables a usar
            Int32 total = categorias.Rows.Count, columna = 0, fila = 0;

            for (Int32 i = 0; i < total; i++)
            {
                // Se recorre la tabla categorias por su indice

                //Se obtienen los datos de la fila respectiva
                Int32 categoriaId = Convert.ToInt32(categorias.Rows[i][0].ToString());
                String nombre = categorias.Rows[i][1].ToString();

                // Se crea un nuevo objeto boton
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

                // Se agrega el boton al panel
                panelCategorias.Controls.Add(btn, columna, fila);

                // Se actualizan lo indices de columna y fila de la celda del panel donde se agregara el boton
                columna = (columna == 3) ? 0 : (columna + 1);
                fila = (columna == 0) ? (fila + 1) : fila;
            }

            if (total > 0)
            {
                ListarProductos(Convert.ToInt32(categorias.Rows[0][0]));
            }
        }

        private void ListarProductos(Int32 categoriaId)
        {
            // Se limpian los controles agregados al panel de productos
            panelProductos.Controls.Clear();

            // Se buscan los productod que pertenezcan a la categoria seleccionada
            EnumerableRowCollection<DataRow> rows = productos.AsEnumerable()
                .Where(row => row["categoria_id"].ToString() == categoriaId.ToString());

            // Si existen productos, se agregan controles al panel de productos
            if (rows.Count() > 0)
            {
                // Se agregan los productos seleccionados a una nueva tabla
                DataTable productosCat = rows.CopyToDataTable();

                // Definicion de variables a usar
                Int32 total = productosCat.Rows.Count, columna = 0, fila = 0;

                for (Int32 i = 0; i < total; i++)
                {
                    // Se recorre la nueva tabla productos por su indice

                    //Se obtienen los datos de la fila respectiva
                    Int32 productoId = Convert.ToInt32(productosCat.Rows[i][0].ToString());
                    String nombre = productosCat.Rows[i][3].ToString();
                    String precio = productosCat.Rows[i][4].ToString();
                    String categoria = productosCat.Rows[i][6].ToString();

                    // Si el nombre es muy grande se recorta la cadena a 20 caracteres
                    nombre = (nombre.Length > 20) ? nombre.Substring(0, 20) : nombre;

                    // Se modifica el titulo del groupBox de productos
                    gbProductos.Text = categoria.ToUpper();

                    // Se crea un nuevo objeto boton
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

                    // Se agrega el boton al panel
                    panelProductos.Controls.Add(btn, columna, fila);

                    // Se actualizan lo indices de columna y fila de la celda del panel donde se agregara el boton
                    columna = (columna == 3) ? 0 : (columna + 1);
                    fila = (columna == 0) ? (fila + 1) : fila;
                }

                if (total > 0 && total <= 12)
                {
                    // Si la cantidad de productos no completan las 5 filas se agrega un label en blanco para forza la existencia de una quinta fila
                    panelProductos.Controls.Add(new Label() { Dock = DockStyle.Fill }, 0, 7);
                }
            }
        }

        private void ListarDetalles()
        {
            // Se asocia la Tabla detalles al DataGridView
            dgvDetalles.DataSource = detalles;

            // Se cambia el Tamaño de Letra de las Celdas
            dgvDetalles.DefaultCellStyle.Font = new Font("Arial", 12F);

            // Formato de la Columna Nro (Posicion)
            dgvDetalles.Columns[0].Width = 50;
            dgvDetalles.Columns[0].HeaderText = "Nro.";
            dgvDetalles.Columns[0].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Formato de la Columna Descripcion (Nombre del Producto)
            dgvDetalles.Columns[1].Width = 250;
            dgvDetalles.Columns[1].HeaderText = "Descripción";
            dgvDetalles.Columns[1].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Formato de la Columna Cantidad
            dgvDetalles.Columns[2].Width = 60;
            dgvDetalles.Columns[2].HeaderText = "Cant.";
            dgvDetalles.Columns[2].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Formato de la Columna Precio Unitario
            dgvDetalles.Columns[3].HeaderText = "P.U.";
            dgvDetalles.Columns[3].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Formato de la Columna Valor de la Venta (Precio Neto)
            dgvDetalles.Columns[4].HeaderText = "V. Vta.";
            dgvDetalles.Columns[4].HeaderCell.Style.Font = new Font("Arial", 12F);
            dgvDetalles.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDetalles.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //Formato de la Columna ProductoID (No se vera pero se utilizara su valor)
            dgvDetalles.Columns[5].Visible = false;

            HabilitarGuardado();
            CalcularTotal();
        }

        private void SeleccionarProducto(Int32 productoId)
        {
            // Se crea una nueva fila de la tabla detalles
            DataRow detalle = detalles.NewRow();

            // Se busca si el producto ya ha sido agregado al detalle
            EnumerableRowCollection<DataRow> detaProd = detalles.AsEnumerable()
                .Where(row => row[5].ToString() == productoId.ToString());

            // Si ya ha sido agregado al detalle, se aumenta la cantidad en uno
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
            else // Si no ha sido agregado al detalle, se agrega
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

            // Se recorre la tabla detalles y se va sumando el Valor de la Venta (Precio Neto)
            foreach (DataRow detalle in detalles.Rows)
            {
                total += Convert.ToDecimal(detalle[4]);
            }

            // Se muestra el valor total de la venta
            txtTotal.Text = String.Format("{0:0.00}", total);
        }

        private void GuardarComprobante()
        {
            // Se muestra un mensaje y se devuelve un valor OK para agregar el detalle al diccionario (lista) de detalles de mesas
            MessageBox.Show("Comprobante Guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void HabilitarGuardado()
        {
            // Se habilitan los botones para guardar y pagar si tiene filas la tabla detalles
            btnGuardar.Enabled = (detalles.Rows.Count > 0);
            btnPagar.Enabled = (detalles.Rows.Count > 0);
        }
    }    
}
