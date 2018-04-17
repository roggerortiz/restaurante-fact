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
    public partial class Mesas : Form
    {
        public Mesas()
        {
            InitializeComponent();
        }

        private void Mesas_Load(object sender, EventArgs e)
        {
            //MesaController mc = new MesaController();
            //DataTable dt = mc.Listar();
            
            //Int32 mesas = dt.Rows.Count;
            //Int32 columnas = 10, filas = 5;

            //TableLayoutPanel panel = new TableLayoutPanel();
            //panel.ColumnCount = columnas;
            //panel.RowCount = mesas / columnas;
            //panel.Dock = DockStyle.Fill;

            //for (Int32 i = 0; i < columnas; i++)
            //{
            //    panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)(100 / columnas)));
            //}

            //for (Int32 i = 0; i < filas; i++)
            //{
            //    panel.RowStyles.Add(new RowStyle(SizeType.Percent, (float)(100 / filas)));
            //}

            //panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));

            //Int32 celdaX = 0;
            //Int32 celdaY = 0;

            //for (Int32 i = 0; i < 50; i++)
            //{                
            //    String numero = "1";
            //    String estado = "Libre";
            //    String color = (estado == "Libre") ? "#28a745" : ((estado == "Reservada") ? "#bd2130" : "#e0a800");

            //    Button btn = new Button();
            //    btn.BackColor = ColorTranslator.FromHtml(color);
            //    btn.FlatAppearance.BorderSize = 0;
            //    btn.FlatStyle = FlatStyle.Flat;
            //    btn.Dock = DockStyle.Fill;
            //    btn.Text = numero;

            //    panel.Controls.Add(btn, celdaX, celdaY);

            //    celdaX++;

            //    if (celdaX == 11)
            //    {
            //        celdaX = 0;
            //        celdaY++;
            //    }
            //}

            //panel.Controls.Add(new Label() { Dock = DockStyle.Bottom }, 9, 11);

            MesaController mc = new MesaController();
            DataTable dt = mc.Listar();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                String numero = dt.Rows[i][1].ToString();
                String estado = dt.Rows[i][2].ToString();
                String color = (estado == "Libre") ? "#28a745" : ((estado == "Reservada") ? "#bd2130" : "#e0a800");

                Button btn = new Button();
                btn.BackColor = ColorTranslator.FromHtml(color);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Text = numero;
                btn.Width = 100;
                btn.Height = 100;

                panelMesas.Controls.Add(btn);
            }
        }
    }
}
