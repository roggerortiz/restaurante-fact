using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InitialDLL;
using Controlador;

namespace Vista
{
    public partial class MenuPrincipal : Form
    {
        Productos frmProductos = new Productos();
        Mesas frmMesas = new Mesas();

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CInitial initial = new CInitial(Application.StartupPath);
            frmMesas.WindowState = FormWindowState.Normal;
            frmMesas.MdiParent = this;
            frmMesas.Show();
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            if (frmProductos == null || frmProductos.IsDisposed)
            {
                frmProductos = new Productos();
            }

            frmProductos.WindowState = FormWindowState.Normal;
            frmProductos.MdiParent = this;
            frmProductos.Activate();
            frmProductos.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMesas == null || frmMesas.IsDisposed)
            {
                frmMesas = new Mesas();
            }

            frmMesas.WindowState = FormWindowState.Normal;
            frmMesas.MdiParent = this;
            frmMesas.Activate();
            frmMesas.Show();
        }
    }
}
