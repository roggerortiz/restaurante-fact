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
    public partial class frmBuscarCategoria : Form
    {
        public Categoria categoria = new Categoria();

        public frmBuscarCategoria()
        {
            InitializeComponent();
        }

        private void frmBuscarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaController cc = new CategoriaController();

            dgvCategorias.DataSource = cc.Listar();
            dgvCategorias.Columns[0].Visible = false;
            dgvCategorias.Columns[0].HeaderText = "ID";
            dgvCategorias.Columns[1].HeaderText = "Nombre";
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarCategoria(e.RowIndex);
        }

        private void dgvCategorias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                SeleccionarCategoria(dgvCategorias.CurrentRow.Index);
            }
        }

        private void SeleccionarCategoria(Int32 index)
        {
            categoria.ID = Convert.ToInt32(dgvCategorias.Rows[index].Cells[0].Value.ToString());
            categoria.Nombre = dgvCategorias.Rows[index].Cells[1].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }
    }
}
