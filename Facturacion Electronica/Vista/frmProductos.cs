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

        public frmProductos()
        {
            InitializeComponent();
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

        private void frmProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarProducto(e.RowIndex);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtPrecioCosto.ReadOnly = false;
            txtPrecioVenta.ReadOnly = false;
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecioCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtCategoriaID.Text = "";
            txtCategoria.Text = "";
            txtNombre.Focus();
            btnBuscarCategoria.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            crear = true;
            editar = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtPrecioCosto.ReadOnly = false;
            txtPrecioVenta.ReadOnly = false;
            txtNombre.Focus();
            btnBuscarCategoria.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            crear = false;
            editar = true;
        }

        private void ListarProductos()
        {
            ProductoController pc = new ProductoController();

            dgvProductos.DataSource = pc.Listar();
            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[0].HeaderText = "ID";
            dgvProductos.Columns[1].HeaderText = "Nombre";
            dgvProductos.Columns[2].HeaderText = "Precio Costo";
            dgvProductos.Columns[3].HeaderText = "Precio Venta";
            dgvProductos.Columns[4].Visible = false;
            dgvProductos.Columns[4].HeaderText = "CategoriaID";
            dgvProductos.Columns[5].HeaderText = "Categoria";

            if (dgvProductos.RowCount > 0)
            {
                SeleccionarProducto(0);
            }
            else
            {
                LimpiarSeleccion();
            }
        }

        private void SeleccionarProducto(Int32 index)
        {
            txtID.Text = dgvProductos.Rows[index].Cells[0].Value.ToString();
            txtNombre.Text = dgvProductos.Rows[index].Cells[1].Value.ToString();
            txtPrecioCosto.Text = dgvProductos.Rows[index].Cells[2].Value.ToString();
            txtPrecioVenta.Text = dgvProductos.Rows[index].Cells[3].Value.ToString();
            txtCategoriaID.Text = dgvProductos.Rows[index].Cells[4].Value.ToString();
            txtCategoria.Text = dgvProductos.Rows[index].Cells[5].Value.ToString();
        }

        private void LimpiarSeleccion()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrecioCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtCategoriaID.Text = "";
            txtCategoria.Text = "";
        }

        private void RegistrarProducto()
        {
            Producto p = new Producto();
            p.Nombre = txtNombre.Text;
            p.PrecioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
            p.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            p.CategoriaID = Convert.ToInt32(txtCategoriaID.Text);

            ProductoController pc = new ProductoController();

            if (pc.Registrar(p))
            {
                MessageBox.Show("Registro Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.ReadOnly = true;
                txtPrecioCosto.ReadOnly = true;
                txtPrecioVenta.ReadOnly = true;
                btnBuscarCategoria.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                ListarProductos();
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
            p.PrecioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
            p.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            p.CategoriaID = Convert.ToInt32(txtCategoriaID.Text);

            ProductoController pc = new ProductoController();

            if (pc.Actualizar(p))
            {
                MessageBox.Show("Actualización Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.ReadOnly = true;
                txtPrecioCosto.ReadOnly = true;
                txtPrecioVenta.ReadOnly = true;
                btnBuscarCategoria.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                ListarProductos();
            }
            else
            {
                MessageBox.Show("Error al Actualizar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SeleccionarProducto(dgvProductos.CurrentRow.Index);

            txtNombre.ReadOnly = true;
            txtPrecioCosto.ReadOnly = true;
            txtPrecioVenta.ReadOnly = true;
            btnBuscarCategoria.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());

            ProductoController pc = new ProductoController();

            if (pc.Eliminar(id))
            {
                MessageBox.Show("Eliminación Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.ReadOnly = true;
                txtPrecioCosto.ReadOnly = true;
                txtPrecioVenta.ReadOnly = true;
                btnBuscarCategoria.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                ListarProductos();
            }
            else
            {
                MessageBox.Show("Error al Eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
