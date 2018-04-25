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
    public partial class frmInicio : Form
    {
        private Usuario usuario;
        private DataTable usuarios;
        private Dictionary<string, DataTable> listaMesas;
        private CInitial initial;
        private CDatabase database;
        private CLogDLL log;

        public frmInicio()
        {
            InitializeComponent();
            usuario = null;
            usuarios = new DataTable();
            listaMesas = new Dictionary<string, DataTable>();
            initial = new CInitial("C:\\FactISG\\");
            database = new CDatabase("C:\\FactISG\\");
            log = new CLogDLL();
        }

        private void frmOpciones_Load(object sender, EventArgs e)
        {
            if (initial.LogLevel == LogLevel.Normal)
                log.WriteLog(LogType.Applog, "INFO", "Ejecucion del sistema.");
            
            Int32 top, left, left1, left2, left3, left4;
                
            left = Convert.ToInt32(Math.Round(Convert.ToDecimal((panelBotones.Width - btnSalir.Width) / 2), 0));
            btnSalir.Location = new Point(left, btnSalir.Location.Y);

            left = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Width - panelBotones.Width) / 2), 0));
            top = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Height - panelBotones.Height) / 2), 0));
            panelBotones.Location = new Point(left, top);

            left1 = Convert.ToInt32(Math.Round(Convert.ToDecimal((left - panelPlatos1.Width) / 2), 0));
            panelPlatos1.Location = new Point(left1, top);

            left2 = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Width - left1 - panelPlatos2.Width)), 0));
            panelPlatos2.Location = new Point(left2, top);

            left3 = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Width - panelISG.Width - 10)), 0));
            top = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Height - panelISG.Height - 10)), 0));
            panelISG.Location = new Point(left3, top);

            left4 = Convert.ToInt32(Math.Round(Convert.ToDecimal((this.Width - panelFonseca.Width)/2), 0));
            panelFonseca.Location = new Point(left4, 20);

            UsuarioController uc = new UsuarioController();
            usuarios = uc.Listar();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                frmLogin login = new frmLogin();
                login.usuarios = usuarios;

                if (login.ShowDialog() == DialogResult.OK)
                {
                    if (initial.LogLevel == LogLevel.Normal)
                        log.WriteLog(LogType.Applog, "INFO", "Inicio de Sesion");

                    usuario = login.usuario;
                    btnIngresar.Text = "Cerrar Sesion";

                    switch (usuario.Categoria)
                    {
                        case 0: btnMozo.Enabled = true;
                            btnCajero.Enabled = true;
                            btnSistema.Enabled = true;
                            btnSalir.Enabled = true;
                            break;
                        case 1: btnMozo.Enabled = true;
                            btnCajero.Enabled = true;
                            btnSistema.Enabled = false;
                            btnSalir.Enabled = true;
                            break;
                        case 2: btnMozo.Enabled = true;
                            btnCajero.Enabled = false;
                            btnSistema.Enabled = false;
                            btnSalir.Enabled = false;
                            break;
                    }
                }
            }
            else
            {
                if (initial.LogLevel == LogLevel.Normal)
                    log.WriteLog(LogType.Applog, "INFO", "Cerrardo de sesion.");

                MessageBox.Show("Se cerró la sesión", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIngresar.Text = "Iniciar Sesion";
                btnMozo.Enabled = false;
                btnCajero.Enabled = false;
                btnSistema.Enabled = false;
                btnSalir.Enabled = false;
                usuario = null;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (initial.LogLevel == LogLevel.Normal)
                log.WriteLog(LogType.Applog, "INFO", "Salir del sistema.");
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
            menu.listaMesas = listaMesas;
            menu.ShowDialog();

            this.listaMesas = menu.listaMesas;
        }
    }
}
