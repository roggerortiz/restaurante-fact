using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class frmProductos : Form
    {
        private Boolean crear = false;
        private Boolean editar = false;
        public Boolean cambios = false;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
            SeleccionarProducto(0);
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarProducto(e.RowIndex);
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            frmBuscarCategoria frm = new frmBuscarCategoria();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCategoriaID.Text = frm.categoria.ID.ToString();
                txtCategoria.Text = frm.categoria.Nombre;
            }
            else
            {
                txtCategoriaID.Text = "";
                txtCategoria.Text = "";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (crear && !editar)
            {
                RegistrarProducto();
            }
            else if (!crear && editar)
            {
                ActualizarProducto();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            HabilitarForm(true, true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarForm(true, false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SeleccionarProducto();
            HabilitarForm(false);
        }

        private void ListarProductos()
        {
            ProductoController pc = new ProductoController();

            dgvProductos.Enabled = true;
            dgvProductos.DataSource = pc.Listar();
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Visible = false;
            dgvProductos.Columns[2].Visible = false;
            dgvProductos.Columns[3].HeaderText = "Nombre";
            dgvProductos.Columns[4].HeaderText = "Precio Unitario (S/.)";
            dgvProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.Columns[5].Visible = false;
            dgvProductos.Columns[6].HeaderText = "Categoría";

            SeleccionarProducto(0);
        }

        private void SeleccionarProducto(Int32 index = -1)
        {
            if (dgvProductos.RowCount > 0)
            {
                if (index == -1)
                {
                    index = (dgvProductos.CurrentRow != null) ? dgvProductos.CurrentRow.Index : index;
                }

                txtID.Text = dgvProductos.Rows[index].Cells[0].Value.ToString();
                txtNombre.Text = dgvProductos.Rows[index].Cells[3].Value.ToString();
                txtPrecioUnitario.Text = dgvProductos.Rows[index].Cells[4].Value.ToString();
                txtCategoriaID.Text = dgvProductos.Rows[index].Cells[5].Value.ToString();
                txtCategoria.Text = dgvProductos.Rows[index].Cells[6].Value.ToString();
            }
            else
            {
                LimpiarForm();
            }
        }

        private void LimpiarForm()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecioUnitario.Text = "";
            txtCategoriaID.Text = "";
            txtCategoria.Text = "";
        }

        private void HabilitarForm(Boolean habilitado, Boolean isCreacion = false)
        {
            txtNombre.ReadOnly = !habilitado;
            txtPrecioUnitario.ReadOnly = !habilitado;
            btnBuscarCategoria.Enabled = habilitado;
            btnNuevo.Enabled = !habilitado;
            btnEditar.Enabled = !habilitado;
            btnEliminar.Enabled = !habilitado;
            btnGuardar.Enabled = habilitado;
            btnCancelar.Enabled = habilitado;
            dgvProductos.Enabled = !habilitado;
            crear = (habilitado && isCreacion);
            editar = (habilitado && !isCreacion);
            if (habilitado) txtNombre.Focus();
        }

        private void RegistrarProducto()
        {
            Producto p = new Producto();
            p.Nombre = txtNombre.Text;
            p.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
            p.CategoriaID = Convert.ToInt32(txtCategoriaID.Text);

            ProductoController pc = new ProductoController();

            if (pc.Registrar(p))
            {
                MessageBox.Show("Registro Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarForm(false);
                ListarProductos();
                cambios = true;
            }
            else
            {
                MessageBox.Show("Error al Registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarProducto()
        {
            Producto p = new Producto();
            p.ID = Convert.ToInt32(txtID.Text);
            p.Nombre = txtNombre.Text;
            p.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
            p.CategoriaID = Convert.ToInt32(txtCategoriaID.Text);

            ProductoController pc = new ProductoController();

            if (pc.Actualizar(p))
            {
                MessageBox.Show("Actualización Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarForm(false);
                ListarProductos();
                cambios = true;
            }
            else
            {
                MessageBox.Show("Error al Actualizar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarProducto()
        {
            if (dgvProductos.CurrentRow != null)
            {
                Int32 id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());

                ProductoController pc = new ProductoController();

                if (pc.Eliminar(id))
                {
                    MessageBox.Show("Eliminación Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarForm(false);
                    ListarProductos();
                    cambios = true;
                }
                else
                {
                    MessageBox.Show("Error al Eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
