using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Detalle : Modelo
    {
        private Int32 numero;
        private String nombre;
        private Int32 cantidad;
        private Decimal precio;
        private Decimal subtotal;
        private Int32 comprobanteId;
        private Int32 productoId;

        public Int32 Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Int32 Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Decimal Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public Int32 ComprobanteID
        {
            get { return comprobanteId; }
            set { comprobanteId = value; }
        }

        public Int32 ProductoID
        {
            get { return productoId; }
            set { productoId = value; }
        }
    }
}
