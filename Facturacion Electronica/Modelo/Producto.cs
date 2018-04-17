using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Producto : Modelo
    {
        private String nombre;
        private Decimal precioCosto;
        private Decimal precioVenta;
        private Int32 categoriaId;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Decimal PrecioCosto
        {
            get { return precioCosto; }
            set { precioCosto = value; }
        }

        public Decimal PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public Int32 CategoriaID
        {
            get { return categoriaId; }
            set { categoriaId = value; }
        }
    }
}
