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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            Productos frm = new Productos();
            frm.WindowState = FormWindowState.Normal;
            frm.MdiParent = this;
            frm.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CInitial initial = new CInitial(Application.StartupPath);
            Mesas frm = new Mesas();
            frm.WindowState = FormWindowState.Maximized;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas frm = new Mesas();
            frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
