using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InitialDLL;
using Controlador;

namespace Vista
{
    public partial class frmMenuPrincipal : Form
    {
        CInitial initial = new CInitial(Application.StartupPath);

        // Lista de los detalles de las mesas
        Dictionary<string, DataTable> listaMesas = new Dictionary<string,DataTable>();

        // Lista de las categorias y productos
        DataTable categorias = new DataTable();
        DataTable productos = new DataTable();

        // Se instancian una sola vez, los formularios que seran llamados desde el Menu Principal.
        frmProductos frmProductos = new frmProductos();
        frmNumeroMesas frmNumeroMesas = new frmNumeroMesas();

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Se Listan las mesas registradas.
            ListarMesas();
            // Se listan las categorias y productos
            ListarCategoriasProductos();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se cierra toda la aplicación.
            Application.Exit();
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            // Se verifica si la instancia del formulario es nulo o ha sido cerrado.
            // Solo si es asi, se vuelve a instanciar.
            if (frmProductos == null || frmProductos.IsDisposed)
            {
                frmProductos = new frmProductos();
            }

            frmProductos.StartPosition = FormStartPosition.CenterScreen;
            frmProductos.Activate();
            frmProductos.ShowDialog();

            if (frmProductos.cambios)
            {
                ListarCategoriasProductos();
                ActualizarDetalles();
            }
        }

        private void mnuMesas_Click(object sender, EventArgs e)
        {
            ListarMesas();
        }

        private void mnuNumeroMesas_Click(object sender, EventArgs e)
        {
            // Se verifica si la instancia del formulario es nulo o ha sido cerrado.
            // Solo si es asi, se vuelve a instanciar.
            if (frmNumeroMesas == null || frmNumeroMesas.IsDisposed)
            {
                frmNumeroMesas = new frmNumeroMesas();
            }

            frmNumeroMesas.StartPosition = FormStartPosition.CenterScreen;
            frmProductos.Activate();

            if (frmNumeroMesas.ShowDialog() == DialogResult.OK)
            {
                ListarMesas();
            }
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMesa_Click(object sender, EventArgs e, Int32 numero)
        {
            frmDetalleMesa detaMesa = new frmDetalleMesa();

            // Se envia el numero de mesa
            detaMesa.mesa = String.Format("{0:00}", numero);

            // Se cambia el titulo del groupBox principal del formulario
            detaMesa.gbDetalleMesa.Text = String.Format("MESA {0:00}", numero);

            // Se envia el detalle de la mesa seleccionada, si no tiene detalles se envia una tabla vacia
            detaMesa.detalles = listaMesas.ContainsKey(detaMesa.mesa) ? listaMesas[detaMesa.mesa] : TablaDetallesVacia();

            // Se envian las tablas categorias y productos
            detaMesa.categorias = categorias;
            detaMesa.productos = productos;

            // Si el formulario detalle de mesa devuelve OK, se agrega o actualiza los detalles de la mesa
            if (detaMesa.ShowDialog() == DialogResult.OK)
            {
                // Si la mesa ya ha sido agregada se actualizan sus detalles
                if (listaMesas.ContainsKey(detaMesa.mesa))
                {
                    listaMesas[detaMesa.mesa] = detaMesa.detalles;
                }
                else // Si la mesa no ha sido agregada, se agrega
                {
                    listaMesas.Add(detaMesa.mesa, detaMesa.detalles);
                }
            }
        }

        private void ListarMesas()
        {
            panelMesas.Controls.Clear();

            MesaController mc = new MesaController();
            DataTable dt = mc.Listar();

            Int32 mesas = dt.Rows.Count;
            Int32 columnas = 10, filas = 5, columna = 0, fila = 0;

            // Crear Un Panel tipo Tabla
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = columnas;
            panel.RowCount = mesas / columnas;
            panel.Padding = new Padding(10);
            panel.Dock = DockStyle.Fill;

            // Agregar el Panel como Control del Formulario
            panelMesas.Controls.Add(panel);

            // Agregar 10 Columnas a la Tabla
            for (Int32 i = 0; i < columnas; i++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100 / columnas)));
            }

            // Agregar 5 filas para las mesas
            for (Int32 i = 0; i < filas; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100 / filas)));
            }

            // Agregar un Boton para cada mesa en cada celda de la tabla
            for (Int32 i = 0; i < mesas; i++)
            {
                // Obtener datos de la mesa
                Int32 numero = Convert.ToInt32(dt.Rows[i][1].ToString());
                String estado = dt.Rows[i][2].ToString();
                String color = (estado == "Libre") ? "#28a745" : ((estado == "Reservada") ? "#bd2130" : "#e0a800");

                // Crear un nuevo boton
                Button btn = new Button();
                btn.BackColor = ColorTranslator.FromHtml(color);
                btn.Name = String.Format("btnMesa{0:00}", numero);
                btn.Text = String.Format("{0:00}", numero);
                btn.Font = new Font("Arial", 20F);
                btn.Margin = new Padding(10);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Dock = DockStyle.Fill;
                btn.Click += new EventHandler((sender1, e1) => btnMesa_Click(sender1, e1, numero));

                // Agregar el boton a la celda de la tabla
                panel.Controls.Add(btn, columna, fila);

                columna = (columna == 9) ? 0 : (columna + 1);
                fila = (columna == 0) ? (fila + 1) : fila;
            }

            // Si no se completan las 5 filas se agrega un elemento a la fila final para forzar su existencia
            if (mesas > 0 && mesas <= 40)
            {
                panel.Controls.Add(new Label() { Dock = DockStyle.Fill }, 0, 4);
            }
        }

        private void ListarCategoriasProductos()
        {
            CategoriaController cc = new CategoriaController();
            ProductoController pc = new ProductoController();

            categorias = cc.Listar();
            productos = pc.Listar();
        }

        private void ActualizarDetalles()
        {
            foreach (KeyValuePair<String, DataTable> mesa in listaMesas)
            {
                for (Int32 i = 0; i < mesa.Value.Rows.Count; i++)
                {
                    EnumerableRowCollection<DataRow> productoSelec = productos.AsEnumerable()
                        .Where(row => row[0].ToString() == listaMesas[mesa.Key].Rows[i][5].ToString());

                    if (productoSelec.Count() == 0)
                    {
                        listaMesas[mesa.Key].Rows[i].Delete();
                    }
                    else
                    {
                        DataRow producto = productoSelec.CopyToDataTable().Rows[0];

                        listaMesas[mesa.Key].Rows[i][1] = producto["nombre"];
                        listaMesas[mesa.Key].Rows[i][3] = producto["precio_unitario"];
                        listaMesas[mesa.Key].Rows[i][4] = String.Format("{0:0.00}", Math.Round((Convert.ToInt32(listaMesas[mesa.Key].Rows[i][2]) * Convert.ToDecimal(listaMesas[mesa.Key].Rows[i][3])), 2));
                    }
                }
            }
        }

        private DataTable TablaDetallesVacia()
        {
            DataTable detalles = new DataTable();
            detalles.Columns.Add("posicion");
            detalles.Columns.Add("descripcion");
            detalles.Columns.Add("cantidad");
            detalles.Columns.Add("precio_unitario");
            detalles.Columns.Add("precio_neto");
            detalles.Columns.Add("producto_id");

            return detalles;
        }
    }
}
