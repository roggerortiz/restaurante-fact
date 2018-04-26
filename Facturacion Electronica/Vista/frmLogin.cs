using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Controlador;
using Modelo;

namespace Vista
{
    public partial class frmLogin : Form
    {
        public Usuario usuario;
        public DataTable usuarios;

        public frmLogin()
        {
            InitializeComponent();
            usuario = new Usuario();
            usuarios = new DataTable();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerramos la aplicación
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Cerramos la aplicación
            this.Close();
        }

        private void linkVer_MouseDown(object sender, MouseEventArgs e)
        {
            // Al soltar el click se oculta el texto del campo clave
            txtClave.UseSystemPasswordChar = false;
        }

        private void linkVer_MouseUp(object sender, MouseEventArgs e)
        {
            // Al hacer click y tenerlo precionado, nos muestra el texto del campo clave
            txtClave.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ingresar();
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ingresar();
            }
        }

        private void ingresar()
        {
            // Se comprueba que los campos no esten vacíos
            if (cboUsuarios.Text == "" || txtClave.Text == "")
            {
                // Si están vacíos se lanza un mensaje de advertencia
                MessageBox.Show("Hay campos no llenados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                // Si no estan vacíos, se procede a realizar el login
                UsuarioController uc = new UsuarioController();
                usuario = uc.Login(cboUsuarios.Text, txtClave.Text);

                // Se verifica si los datos ingresados coinciden con los registrados en la BD
                if (usuario.ID > 0)
                {
                    // Si los datos son correctos, se lanza el Menu Principal
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    // Si los datos no son correctos se lanza un mensaje de advertencia
                    MessageBox.Show("Usuario o Clave No Válidos", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cboUsuarios.DataSource = usuarios;
            cboUsuarios.DisplayMember = "usuario";
            cboUsuarios.ValueMember = "id";

#if DEBUG
            cboUsuarios.SelectedIndex = 0;
            txtClave.Text = "ltorres";
#endif
        }

        private void imgIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }
    }
}
