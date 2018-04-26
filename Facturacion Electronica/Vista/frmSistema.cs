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
using EmisorDLL;

namespace Vista
{
    public partial class frmSistema : Form
    {
        #region Variables Privadas
        private Usuario usuario;
        CInitial m_ini;
        #endregion

        #region Variables Publicas
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        #endregion

        #region Constructor
        public frmSistema()
        {
            InitializeComponent();
            m_ini = new CInitial(Application.StartupPath);
            usuario = new Usuario();
        }
        #endregion

        private void frmSistema_Load(object sender, EventArgs e)
        {
            int left, top;

            //left = Convert.ToInt32(Math.Round(Convert.ToDecimal((panelBotones.Width - btnSalir.Width) / 2), 0));
            panel1.Location = new Point(5, 5);

            left = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Width - panel2.Width) / 2), 0));
            top = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Height - panel2.Height) / 2), 0));
            panel2.Location = new Point(left, top);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            frmNumeroMesas frm = new frmNumeroMesas();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            m_ini.ShowDirectoriesDialog();
        }

        private void btnSunat_Click(object sender, EventArgs e)
        {
            m_ini.ShowSUNATDialog();
        }

        private void btnUBL_Click(object sender, EventArgs e)
        {
            m_ini.ShowUBLDialog();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            m_ini.ShowEMailDialog();
        }

        private void btnVersions_Click(object sender, EventArgs e)
        {
            frmAbout dlg = new frmAbout();
            dlg.ShowDialog();
        }

        private void btnEmisor_Click(object sender, EventArgs e)
        {
            CEmisor emisor = new CEmisor(true);
            emisor.ShowDialog();
        }
    }
}
