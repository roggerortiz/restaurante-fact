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

            // Se listan las categorias y productos para el detalle de la mesa
            ListarProductosYCategoria();
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
            frmProductos.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnMesa_Click(object sender, EventArgs e, Int32 numero)
        {
            frmDetalleMesa detaMesa = new frmDetalleMesa();
            detaMesa.Text = String.Format("MESA {0:00}", numero);
            detaMesa.mesa = String.Format("{0:00}", numero);
            detaMesa.categorias = categorias;
            detaMesa.productos = productos;
            detaMesa.gbDetalleMesa.Text = "MESA " + numero;
            detaMesa.ShowDialog();
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

        private void ListarProductosYCategoria()
        {
            CategoriaController cc = new CategoriaController();
            categorias = cc.Listar();

            ProductoController pc = new ProductoController();
            productos = pc.Listar();
        }
    }
}
