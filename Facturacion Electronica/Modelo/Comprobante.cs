using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Comprobante : Modelo
    {
        private String tipo;
        private String serie;
        private String numero;
        private DateTime fecha;
        private Decimal descuento;
        private Decimal subtotal;
        private Decimal igv;
        private Decimal total;
        private Int32 mesa;
        private String estado;
        private Int32 usuarioId;
        private Int32 clienteId;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Serie
        {
            get { return serie; }
            set { serie = value; }
        }

        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }

        public Decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public Decimal IGV
        {
            get { return igv; }
            set { igv = value; }
        }

        public Decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public Int32 Mesa
        {
            get { return mesa; }
            set { mesa = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Int32 UsuarioID
        {
            get { return usuarioId; }
            set { usuarioId = value; }
        }

        public Int32 ClienteID
        {
            get { return clienteId; }
            set { clienteId = value; }
        }
    }
}
