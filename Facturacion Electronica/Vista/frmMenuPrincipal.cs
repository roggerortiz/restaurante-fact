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
using Modelo;

namespace Vista
{
    public partial class frmMenuPrincipal : Form
    {
        public Int32 categoria = 0;
        public Usuario usuario = new Usuario();

        // Lista de los detalles de las mesas
        public Dictionary<string, Mesa> listaMesas = new Dictionary<string, Mesa>();

        // Panel de Mesas
        TableLayoutPanel panelMesas = new TableLayoutPanel();

        // Lista de las categorias y productos
        DataTable categorias = new DataTable();
        DataTable productos = new DataTable();
        DataTable mozos = new DataTable();

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            int top = Convert.ToInt32(Math.Round(Convert.ToDecimal(this.Height - panelFonseca1.Height), 0));
            panelFonseca1.Location = new Point(panelFonseca1.Location.X, top);

            mnuMantenedores.Visible = (categoria == 0);
            mnuSistema.Visible = (categoria == 0);
            mnuMesas.Visible = (categoria != 0);

            if (categoria != 0)
            {
                // Se crea el panel de mesas
                CrearPanelMesas();

                // Se Listan las mesas registradas.
                ListarMesas();

                // Se listan las categorias y productos
                ListarCategoriasProductos();

                ListarMozos();
            }
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            if (frm.cambios && categoria != 0)
            {
                ListarCategoriasProductos();
                ActualizarDetalles();
            }
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void mnuNumeroMesas_Click(object sender, EventArgs e)
        {
            frmNumeroMesas frm = new frmNumeroMesas();
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK && categoria != 0)
            {
                ListarMesas();
            }
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void mnuMesas_Click(object sender, EventArgs e)
        {
            ListarMesas();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMesa_Click(object sender, EventArgs e, Int32 numero)
        {
            frmDetalleMesa detaMesa = new frmDetalleMesa();

            // Se envia el numero de mesa
            detaMesa.mesa = String.Format("{0:00}", numero);

            // Se envia el usuario logueado
            detaMesa.usuario = usuario;

            // Se envia el mozo
            detaMesa.mozo = listaMesas.ContainsKey(detaMesa.mesa) ? listaMesas[detaMesa.mesa].Mozo : null;

            // Se cambia el titulo del groupBox principal del formulario
            detaMesa.lbMesa.Text = String.Format("MESA {0:00}", numero);

            // Se envia el detalle de la mesa seleccionada, si no tiene detalles se envia una tabla vacia
            detaMesa.detalles = listaMesas.ContainsKey(detaMesa.mesa) ? listaMesas[detaMesa.mesa].Detalles : TablaDetallesVacia();

            // Se envian las tablas categorias, productos y mozos
            detaMesa.categorias = categorias;
            detaMesa.productos = productos;
            detaMesa.mozos = mozos;

            // Si el formulario detalle de mesa devuelve OK, se agrega o actualiza los detalles de la mesa
            if (detaMesa.ShowDialog() == DialogResult.OK)
            {
                if (detaMesa.detalles.Rows.Count > 0 && detaMesa.estado == "Ocupada")
                {
                    Mesa mesa = new Mesa();
                    mesa.Numero = numero;
                    mesa.Mozo = detaMesa.mozo;
                    mesa.Detalles = detaMesa.detalles;

                    listaMesas[detaMesa.mesa] = mesa;
                }
                else
                {
                    listaMesas.Remove(detaMesa.mesa);
                }

                String color = (detaMesa.estado == "Libre") ? "#28a745" : "#bd2130";
                panelPrincipal.Controls.Find("btnMesa" + detaMesa.mesa, true)[0].BackColor = ColorTranslator.FromHtml(color);
            }
        }

        private void CrearPanelMesas()
        {
            Int32 columnas = 10, filas = 5;

            // Crear Un Panel tipo Tabla
            panelMesas.ColumnCount = columnas;
            panelMesas.RowCount = filas;
            panelMesas.Padding = new Padding(10);
            panelMesas.Dock = DockStyle.Fill;

            // Agregar el Panel como Control del Formulario
            panelPrincipal.Controls.Add(panelMesas);
            panelPrincipal.Dock = DockStyle.Fill;

            // Agregar 10 Columnas a la Tabla
            for (Int32 i = 0; i < columnas; i++)
            {
                panelMesas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100 / columnas)));
            }

            // Agregar 5 filas para las mesas
            for (Int32 i = 0; i < filas; i++)
            {
                panelMesas.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100 / filas)));
            }
        }

        private void ListarMesas()
        {
            panelMesas.Controls.Clear();

            MesaController mc = new MesaController();
            DataTable mesas = mc.Listar();

            Int32 total = mesas.Rows.Count, columna = 0, fila = 0;            

            // Agregar un Boton para cada mesa en cada celda de la tabla
            for (Int32 i = 0; i < total; i++)
            {
                // Obtener datos de la mesa
                Int32 numero = Convert.ToInt32(mesas.Rows[i][1].ToString());
                String estado = mesas.Rows[i][2].ToString();
                String color = listaMesas.ContainsKey(String.Format("{0:00}", numero)) ? "#bd2130" : "#28a745";

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
                panelMesas.Controls.Add(btn, columna, fila);

                columna = (columna == 9) ? 0 : (columna + 1);
                fila = (columna == 0) ? (fila + 1) : fila;
            }

            // Si no se completan las 5 filas se agrega un elemento a la fila final para forzar su existencia
            if (total > 0 && total <= 40)
            {
                panelMesas.Controls.Add(new Label() { Dock = DockStyle.Fill }, 0, 4);
            }
        }

        private void ListarCategoriasProductos()
        {
            CategoriaController cc = new CategoriaController();
            ProductoController pc = new ProductoController();

            categorias = cc.Listar();
            productos = pc.Listar();
        }

        private void ListarMozos()
        {
            UsuarioController uc = new UsuarioController();
            mozos = uc.ListarMozos();
        }

        private void ActualizarDetalles()
        {
            foreach (KeyValuePair<String, Mesa> itemMesa in listaMesas)
            {
                for (Int32 i = 0; i < itemMesa.Value.Detalles.Rows.Count; i++)
                {
                    EnumerableRowCollection<DataRow> productoSelec = productos.AsEnumerable()
                        .Where(row => row[0].ToString() == listaMesas[itemMesa.Key].Detalles.Rows[i][5].ToString());

                    if (productoSelec.Count() == 0)
                    {
                        listaMesas[itemMesa.Key].Detalles.Rows[i].Delete();
                    }
                    else
                    {
                        DataRow producto = productoSelec.CopyToDataTable().Rows[0];

                        listaMesas[itemMesa.Key].Detalles.Rows[i][1] = producto["nombre"];
                        listaMesas[itemMesa.Key].Detalles.Rows[i][3] = producto["precio_unitario"];
                        listaMesas[itemMesa.Key].Detalles.Rows[i][4] = String.Format("{0:0.00}", Math.Round((Convert.ToInt32(listaMesas[itemMesa.Key].Detalles.Rows[i][2]) * Convert.ToDecimal(listaMesas[itemMesa.Key].Detalles.Rows[i][3])), 2));
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
