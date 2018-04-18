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

namespace Vista
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            MostrarDatos();
            ListarMesas();
        }

        private void btnMesa_Click(object sender, EventArgs e, Int32 numero)
        {
            frmDetalleMesa detaMesa = new frmDetalleMesa();
            detaMesa.Text = String.Format("MESA {0:00}", numero);
            detaMesa.Show();
        }

        private void ListarMesas()
        {
            MesaController mc = new MesaController();
            DataTable dt = mc.Listar();

            Int32 mesas = dt.Rows.Count;
            Int32 columnas = 10, filas = 5;

            // Crear Un Panel tipo Tabla
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.ColumnCount = columnas;
            panel.RowCount = mesas / columnas;
            panel.Padding = new Padding(10);
            panel.Dock = DockStyle.Fill;

            // Agregar el Panel como Control del Formulario
            this.Controls.Add(panel);

            // Agregar 10 Columnas a la Tabla
            for (Int32 i = 0; i < columnas; i++)
            {
                panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100 / columnas)));
            }

            // Agregar 1 fila al inicio que funcione como margen superior;
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            // Agregar 10 filas para las mesas
            for (Int32 i = 0; i < filas; i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100 / filas)));
            }

            // Agregar 1 fila al final que funcione como margen inferior;
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));

            // Agregar un label a la fila del inicio
            panel.Controls.Add(new Label() { Dock = DockStyle.Bottom}, 0, 0);

            // Agregar un Boton para cada mesa en cada celda de la tabla
            Int32 total = (columnas * filas), celdaX = 0, celdaY = 1;

            for (Int32 i = 0; i < total; i++)
            {
                // Obtener datos de la mesa
                Int32 numero = Convert.ToInt32(dt.Rows[i][1].ToString());
                String estado = dt.Rows[i][2].ToString();
                String color = (estado == "Libre") ? "#28a745" : ((estado == "Reservada") ? "#bd2130" : "#e0a800");

                // Crear un nuevo boton
                Button btn = new Button();
                btn.BackColor = ColorTranslator.FromHtml(color);
                btn.Text = String.Format("{0:00}", numero);
                btn.Font = new Font("Arial", 20F);
                btn.Margin = new Padding(10);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Dock = DockStyle.Fill;
                btn.Click += new EventHandler((sender1, e1) => btnMesa_Click(sender1, e1, numero));

                // Agregar el boton a la celda de la tabla
                panel.Controls.Add(btn, celdaX, celdaY);

                celdaX++;

                if (celdaX == 11)
                {
                    celdaX = 0;
                    celdaY++;
                }
            }

            // Agregar un label a la fila del final
            panel.Controls.Add(new Label() { Dock = DockStyle.Bottom }, 9, 11);
        }

        private void MostrarDatos()
        {
            lblTitLibres.BackColor = ColorTranslator.FromHtml("#28a745");
            lblTitLibres.ForeColor = ColorTranslator.FromHtml("#ffffff");
            lblTitOcupadas.BackColor = ColorTranslator.FromHtml("#bd2130");
            lblTitOcupadas.ForeColor = ColorTranslator.FromHtml("#ffffff");
            lblTitReservadas.BackColor = ColorTranslator.FromHtml("#e0a800");
            lblTitReservadas.ForeColor = ColorTranslator.FromHtml("#ffffff");

            MesaController mc = new MesaController();

            lblLibres.Text = String.Format("{0:00}", mc.Libres());
            lblOcupadas.Text = String.Format("{0:00}", mc.Ocupadas());
            lblReservadas.Text = String.Format("{0:00}", mc.Reservadas());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
