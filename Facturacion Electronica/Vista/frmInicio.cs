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
    public partial class frmInicio : Form
    {
        Usuario usuario = new Usuario();
        DataTable usuarios = new DataTable();

        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            Int32 top, left;
                
            left = Convert.ToInt32(Math.Round(Convert.ToDecimal((panelBotones.Width - btnSalir.Width) / 2), 0));
            btnSalir.Location = new Point(left, btnSalir.Location.Y);

            left = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Width - panelBotones.Width) / 2), 0));
            top = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Height - panelBotones.Height) / 2), 0));
            panelBotones.Location = new Point(left, top);

            UsuarioController uc = new UsuarioController();
            usuarios = uc.Listar();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.usuarios = usuarios;

            if (login.ShowDialog() == DialogResult.OK)
            {
                usuario = login.usuario;

                switch (usuario.Categoria)
                {
                    case 0: btnMozo.Enabled = true;
                        btnCajero.Enabled = true;
                        btnSistema.Enabled = true;
                        break;
                    case 1: btnMozo.Enabled = true;
                        btnCajero.Enabled = true;
                        btnSistema.Enabled = false;
                        break;
                    case 2: btnMozo.Enabled = true;
                        btnCajero.Enabled = false;
                        btnSistema.Enabled = false;
                        break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMozo_Click(object sender, EventArgs e)
        {
            MostrarMenu(2);
        }

        private void btnCajero_Click(object sender, EventArgs e)
        {
            MostrarMenu(1);
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            MostrarMenu(0);
        }

        private void MostrarMenu(Int32 categoria)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.categoria = categoria;
            menu.usuario = usuario;
            menu.ShowDialog();
        }
    }
}
