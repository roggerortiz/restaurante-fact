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
    public partial class frmMenuPrincipal : Form
    {
        CInitial initial = new CInitial(Application.StartupPath);

        // Se instancian una sola vez, los formularios que seran llamados desde el Menu Principal.
        frmProductos frmProductos = new frmProductos();
        frmMesas frmMesas = new frmMesas();
        frmNumeroMesas frmNumeroMesas = new frmNumeroMesas();

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Se Abre el Formulario donde se listan todas las mesas.
            // MostrarMesas();
        }

        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Se cierra toda la aplicación.
            Application.Exit();
        }

        private void mnuProductos_Click(object sender, EventArgs e)
        {
            // Se verifica si la instancia del formulario es nulo o ha sido cerrado.
            // Solo si es asi, se vuelve a instanciar.
            if (frmProductos == null || frmProductos.IsDisposed)
            {
                frmProductos = new frmProductos();
            }

            //Se indicar que el formulario sera abierto dentro del contenedor Menu Principal.
            frmProductos.MdiParent = this;
            // Se especifica que este formulario sera el activo, el que se vera delante de los demas.
            frmProductos.Activate();
            frmProductos.Show();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMesas();
        }

        private void MostrarMesas()
        {
            // Se verifica si la instancia del formulario es nulo o ha sido cerrado.
            // Solo si es asi, se vuelve a instanciar.
            if (frmMesas == null || frmMesas.IsDisposed)
            {
                frmMesas = new frmMesas();
            }

            frmMesas.Show();
        }

        private void mnuNumeroMesas_Click(object sender, EventArgs e)
        {

            // Se verifica si la instancia del formulario es nulo o ha sido cerrado.
            // Solo si es asi, se vuelve a instanciar.
            if (frmNumeroMesas == null || frmNumeroMesas.IsDisposed)
            {
                frmNumeroMesas = new frmNumeroMesas();
            }

            // Se indicar que el formulario sera abierto dentro del contenedor Menu Principal.
            frmNumeroMesas.MdiParent = this;
            // Se especifica que este formulario sera el activo, el que se vera delante de los demas.
            frmNumeroMesas.Activate();
            frmNumeroMesas.Show();
        }
    }
}
