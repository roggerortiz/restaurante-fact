using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            if (txtUsuario.Text == "" || txtClave.Text == "")
            {
                MessageBox.Show("Hay campos no llenados", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("BIENVENIDO AL SISTEMA DE FACTURACIÓN", "RESTAURANTE .....", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu_Principal mp = new Menu_Principal();
                mp.Show();
            }
        }
    }
}
