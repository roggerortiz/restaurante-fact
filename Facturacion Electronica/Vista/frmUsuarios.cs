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
using InitialDLL;
using LogDLL;
using ISGStructures;

namespace Vista
{
    public partial class frmUsuarios : Form
    {
        private Boolean crear = false;
        private Boolean editar = false;
        public Boolean cambios = false;
        private CInitial initial;
        private CLogDLL log;

        public frmUsuarios()
        {
            InitializeComponent();
            initial = new CInitial();
            log = new CLogDLL();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
            SeleccionarUsuario(0);
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarUsuario(e.RowIndex);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (crear && !editar)
            {
                RegistrarUsuario();
            }
            else if (!crear && editar)
            {
                ActualizarUsuario();
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
            EliminarUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            SeleccionarUsuario();
            HabilitarForm(false);
        }

        private void ListarUsuarios()
        {
            UsuarioController uc = new UsuarioController();

            dgvUsuarios.Enabled = true;
            dgvUsuarios.DataSource = uc.Listar();
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[1].HeaderText = "DNI";
            dgvUsuarios.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns[2].HeaderText = "Nombres";
            dgvUsuarios.Columns[3].HeaderText = "Apellidos";
            dgvUsuarios.Columns[4].HeaderText = "Dirección";
            dgvUsuarios.Columns[5].HeaderText = "Teléfono";
            dgvUsuarios.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns[6].HeaderText = "Usuario";
            dgvUsuarios.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns[7].HeaderText = "Clave";
            dgvUsuarios.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns[8].Visible = false;
            dgvUsuarios.Columns[9].Visible = false;
            dgvUsuarios.Columns[10].HeaderText = "Categoría";
            dgvUsuarios.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            SeleccionarUsuario(0);
        }

        private void SeleccionarUsuario(Int32 index = -1)
        {
            if (dgvUsuarios.RowCount > 0)
            {
                if (index == -1)
                {
                    index = (dgvUsuarios.CurrentRow != null) ? dgvUsuarios.CurrentRow.Index : 0;
                }

                txtID.Text = dgvUsuarios.Rows[index].Cells[0].Value.ToString();
                txtDNI.Text = dgvUsuarios.Rows[index].Cells[1].Value.ToString();
                txtNombres.Text = dgvUsuarios.Rows[index].Cells[2].Value.ToString();
                txtApellidos.Text = dgvUsuarios.Rows[index].Cells[3].Value.ToString();
                txtDireccion.Text = dgvUsuarios.Rows[index].Cells[4].Value.ToString();
                txtTelefono.Text = dgvUsuarios.Rows[index].Cells[5].Value.ToString();
                txtUsuario.Text = dgvUsuarios.Rows[index].Cells[6].Value.ToString();
                txtClave.Text = dgvUsuarios.Rows[index].Cells[7].Value.ToString();
                cboCategoria.SelectedIndex = Convert.ToInt32(dgvUsuarios.Rows[index].Cells[8].Value);
            }
            else
            {
                LimpiarForm();
            }
        }

        private void LimpiarForm()
        {
            txtID.Text = "";
            txtDNI.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            cboCategoria.SelectedIndex = 0;
        }

        private void HabilitarForm(Boolean habilitado, Boolean isCreacion = false)
        {
            txtDNI.ReadOnly = !habilitado;
            txtNombres.ReadOnly = !habilitado;
            txtApellidos.ReadOnly = !habilitado;
            txtDireccion.ReadOnly = !habilitado;
            txtTelefono.ReadOnly = !habilitado;
            txtUsuario.ReadOnly = !habilitado;
            txtClave.ReadOnly = !habilitado;
            cboCategoria.Enabled = habilitado;
            btnNuevo.Enabled = !habilitado;
            btnEditar.Enabled = !habilitado;
            btnEliminar.Enabled = !habilitado;
            btnGuardar.Enabled = habilitado;
            btnCancelar.Enabled = habilitado;
            dgvUsuarios.Enabled = !habilitado;
            crear = (habilitado && isCreacion);
            editar = (habilitado && !isCreacion);
            if (habilitado) txtDNI.Focus();
            if (!habilitado) dgvUsuarios.Focus();
        }

        private void RegistrarUsuario()
        {
            Usuario u = new Usuario();
            u.DNI = txtDNI.Text;
            u.Nombres = txtNombres.Text;
            u.Apellidos = txtApellidos.Text;
            u.Direccion = txtDireccion.Text;
            u.Telefono = txtTelefono.Text;
            u.NombUsu = txtUsuario.Text;
            u.Clave = txtClave.Text;
            u.Categoria = Convert.ToInt32(cboCategoria.SelectedIndex);

            UsuarioController uc = new UsuarioController();

            if (uc.Registrar(u))
            {
                if (initial.LogLevel == LogLevel.Normal)
                    log.WriteLog(LogType.Applog, "INFO", "Registrar Usuarios");

                MessageBox.Show("Registro Exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarForm(false);
                ListarUsuarios();
                cambios = true;
            }
            else
            {
                MessageBox.Show("Error al Registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarUsuario()
        {
            Usuario u = new Usuario();
            u.ID = Convert.ToInt32(txtID.Text);
            u.DNI = txtDNI.Text;
            u.Nombres = txtNombres.Text;
            u.Apellidos = txtApellidos.Text;
            u.Direccion = txtDireccion.Text;
            u.Telefono = txtTelefono.Text;
            u.NombUsu = txtUsuario.Text;
            u.Clave = txtClave.Text;
            u.Categoria = Convert.ToInt32(cboCategoria.SelectedIndex);

            UsuarioController uc = new UsuarioController();

            if (uc.Actualizar(u))
            {
                if (initial.LogLevel == LogLevel.Normal)
                    log.WriteLog(LogType.Applog, "INFO", "Actualizar Usuarios");

                MessageBox.Show("Actualización Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HabilitarForm(false);
                ListarUsuarios();
                cambios = true;
            }
            else
            {
                MessageBox.Show("Error al Actualizar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarUsuario()
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                Int32 id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());

                UsuarioController uc = new UsuarioController();

                if (uc.Eliminar(id))
                {
                    if (initial.LogLevel == LogLevel.Normal)
                        log.WriteLog(LogType.Applog, "INFO", "Eliminar Usuarios");

                    MessageBox.Show("Eliminación Exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HabilitarForm(false);
                    ListarUsuarios();
                    cambios = true;
                }
                else
                {
                    MessageBox.Show("Error al Eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Porfavor, seleccione un usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
