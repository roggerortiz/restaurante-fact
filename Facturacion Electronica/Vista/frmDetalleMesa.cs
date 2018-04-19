using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Vista
{
    public partial class frmDetalleMesa : Form
    {
        Utilitarios util = new Utilitarios();

        public frmDetalleMesa()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDetalleMesa_Load(object sender, EventArgs e)
        {
            Comprobante comprobante = new Comprobante();
            comprobante.Tipo = "01";
            comprobante.Serie = "F001";
            comprobante.Numero = "00000001";
            comprobante.Fecha = new DateTime();
            comprobante.Descuento = 0;
            comprobante.Subtotal = 100;
            comprobante.IGV = 18;
            comprobante.Total = 118;
            comprobante.ClienteID = 2;
            comprobante.UsuarioID = 1;

            ComprobanteProducto detalle = new ComprobanteProducto();
            detalle.Cantidad = 2;
            detalle.Subtotal = 10;
            detalle.ProductoID = 3;
            comprobante.Detalles.Add(detalle);

            detalle = new ComprobanteProducto();
            detalle.Cantidad = 5;
            detalle.Subtotal = 20;
            detalle.ProductoID = 4;
            comprobante.Detalles.Add(detalle);

            util.ComprobanteXML(comprobante);
        }
    }
}
