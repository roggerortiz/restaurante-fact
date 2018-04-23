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
    public partial class frmClientes : Form
    {
        private Boolean crear = false;
        private Boolean editar = false;
        public Boolean cambios = false;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboPersona.SelectedIndex = 0;

            ListarClientes();
            SeleccionarCliente(0);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarCliente(e.RowIndex);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (crear && !editar)
            {
                RegistrarCliente();
            }
            else if (!crear && editar)
            {
                ActualizarCliente();
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
            EliminarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SeleccionarCliente();
            HabilitarForm(false);
        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 persona = cboPersona.SelectedIndex;

            lblDoc.Text = (persona == 0) ? "DNI: " : "RUC: ";
            lblRazSoc.Text = (persona == 0) ? "Nombres" : "Raz. Soc.: ";
            lblApellido.Visible = (persona == 0);

            txtRUC.Visible = !(persona == 0);
            txtRazonSocial.Visible = !(persona == 0);
            txtDNI.Visible = (persona == 0);
            txtNombres.Visible = (persona == 0);
            txtApellidos.Visible = (persona == 0);

            ListarClientes();
        }

        private void ListarClientes()
        {
            ClienteController cc = new ClienteController();

            Int32 persona = cboPersona.SelectedIndex;

            dgvClientes.Enabled = true;
            dgvClientes.DataSource = cc.Listar(persona);
            dgvClientes.Columns[0].Visible = false;
            dgvClientes.Columns[1].Visible = false;
            dgvClientes.Columns[2].Visible = !(persona == 0);
            dgvClientes.Columns[2].HeaderText = "RUC";
            dgvClientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns[3].Visible = !(persona == 0);
            dgvClientes.Columns[3].HeaderText = "Razón Social";
            dgvClientes.Columns[4].Visible = (persona == 0);
            dgvClientes.Columns[4].HeaderText = "DNI";
            dgvClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns[5].Visible = (persona == 0);
            dgvClientes.Columns[5].HeaderText = "Nombres";
            dgvClientes.Columns[6].Visible = (persona == 0);
            dgvClientes.Columns[6].HeaderText = "Apellidos";
            dgvClientes.Columns[7].HeaderText = "Dirección";
            dgvClientes.Columns[8].HeaderText = "Teléfono";
            dgvClientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns[9].HeaderText = "Correo";

            SeleccionarCliente(0);
        }

        private void SeleccionarCliente(Int32 index = -1)
        {
            if (dgvClientes.RowCount > 0)
            {
                if (index == -1)
                {
                    index = (dgvClientes.CurrentRow != null) ? dgvClientes.CurrentRow.Index : 0;
                }
                    
                txtID.Text = dgvClientes.Rows[index].Cells[0].Value.ToString();
                txtDireccion.Text = dgvClientes.Rows[index].Cells[7].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[index].Cells[8].Value.ToString();
                txtCorreo.Text = dgvClientes.Rows[index].Cells[9].Value.ToString();

                if (cboPersona.SelectedIndex == 0)
                {
                    txtDNI.Text = dgvClientes.Rows[index].Cells[4].Value.ToString();
                    txtNombres.Text = dgvClientes.Rows[index].Cells[5].Value.ToString();
                    txtApellidos.Text = dgvClientes.Rows[index].Cells[6].Value.ToString();
                }
                else
                {
                    txtRUC.Text = dgvClientes.Rows[index].Cells[2].Value.ToString();
                    txtRazonSocial.Text = dgvClientes.Rows[index].Cells[3].Value.ToString();
                }
            }
            else
            {
                LimpiarForm();
            }
        }

        private void LimpiarForm()
        {
            txtID.Text = "";
            txtRUC.Text = "";
            txtRazonSocial.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void HabilitarForm(Boolean habilitado, Boolean isCreacion = false)
        {
            txtRUC.ReadOnly = !habilitado;
            txtRazonSocial.ReadOnly = !habilitado;
            txtDNI.ReadOnly = !habilitado;
            txtNombres.ReadOnly = !habilitado;
            txtApellidos.ReadOnly = !habilitado;
            txtDireccion.ReadOnly = !habilitado;
            txtTelefono.ReadOnly = !habilitado;
            txtCorreo.ReadOnly = !habilitado;
            btnNuevo.Enabled = !habilitado;
            btnEditar.Enabled = !habilitado;
            btnEliminar.Enabled = !habilitado;
            btnGuardar.Enabled = habilitado;
            btnCancelar.Enabled = habilitado;
            dgvClientes.Enabled = !habilitado;
            crear = (habilitado && isCreacion);
            editar = (habilitado && !isCreacion);
            if (habilitado)
            {
                if (cboPersona.SelectedIndex == 0)
                {
                    txtDNI.Focus();
                }
                else
                {
                    txtRUC.Focus();
                }
            }
            if (!habilitado) dgvClientes.Focus();
        }

        private void RegistrarCliente()
        {
            Cliente c = new Cliente();

            c.Persona = cboPersona.SelectedIndex;
            c.Direccion = txtDireccion.Text;
            c.Telefono = txtTelefono.Text;
            c.Correo = txtCorreo.Text;

            if (cboPersona.SelectedIndex == 0)
            {
                c.DNI = txtDNI.Text;
                c.Nombres = txtNombres.Text;
                c.Apellidos = txtApellidos.Text;
            }
            else
            {
                c.RUC = txtRUC.Text;
                c.RazonSocial = txtRazonSocial.Text;
            }

            ClienteController cc = new ClienteController();

            if (cc.Registrar(c))
            {
                MessageBox.Show("Registro Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarForm(false);
                ListarClientes();
                cambios = true;
            }
            else
            {
                MessageBox.Show("Error al Registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarCliente()
        {
            Cliente c = new Cliente();

            c.ID = Convert.ToInt32(txtID.Text);
            c.Persona = cboPersona.SelectedIndex;
            c.Direccion = txtDireccion.Text;
            c.Telefono = txtTelefono.Text;
            c.Correo = txtCorreo.Text;

            if (cboPersona.SelectedIndex == 0)
            {
                c.DNI = txtDNI.Text;
                c.Nombres = txtNombres.Text;
                c.Apellidos = txtApellidos.Text;
            }
            else
            {
                c.RUC = txtRUC.Text;
                c.RazonSocial = txtRazonSocial.Text;
            }

            ClienteController cc = new ClienteController();

            if (cc.Actualizar(c))
            {
                MessageBox.Show("Actualización Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarForm(false);
                ListarClientes();
                cambios = true;
            }
            else
            {
                MessageBox.Show("Error al Actualizar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarCliente()
        {
            if (dgvClientes.CurrentRow != null)
            {
                Int32 id = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString());

                ClienteController cc = new ClienteController();

                if (cc.Eliminar(id))
                {
                    MessageBox.Show("Eliminación Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarForm(false);
                    ListarClientes();
                    cambios = true;
                }
                else
                {
                    MessageBox.Show("Error al Eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
