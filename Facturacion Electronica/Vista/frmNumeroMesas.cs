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
    public partial class frmNumeroMesas : Form
    {
        Int32 cantidad = 0;

        public frmNumeroMesas()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MesaController mc = new MesaController();

            Int32 nuevaCantidad = Convert.ToInt32(txtNumero.Text);
           
            nuevaCantidad = (nuevaCantidad > 50) ? 50 : nuevaCantidad;

            if (nuevaCantidad > cantidad)
            {
                Mesa mesa = new Mesa();

                for (Int32 i = (cantidad + 1); i <= nuevaCantidad; i++)
                {
                    mesa.Numero = i;
                    mc.Registrar(mesa);
                }
            }
            else if (nuevaCantidad < cantidad)
            {
                mc.EliminarVarias(nuevaCantidad + 1);
            }

            cantidad = nuevaCantidad;
            txtNumero.Text = cantidad.ToString();

            MessageBox.Show("Cantidad de Mesas Actualizada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }

        private void frmNumeroMesas_Load(object sender, EventArgs e)
        {
            MesaController mc = new MesaController();
            cantidad = mc.Cantidad();
            txtNumero.Text = cantidad.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
