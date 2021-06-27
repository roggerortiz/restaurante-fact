using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Detalle : Modelo
    {
        private Int32 posicion;
        private String descripcion;
        private Int32 cantidad;
        private Decimal precioUnitario;
        private Decimal precioNeto;
        private Int32 comprobanteId;
        private Int32 productoId;

        public Int32 Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Int32 Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public Decimal PrecioNeto
        {
            get { return precioNeto; }
            set { precioNeto = value; }
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
