using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Producto
    {
        private Int32 id;
        private String nombre;
        private Decimal precioCosto;
        private Decimal precioVenta;
        private Int32 categoriaId;

        public Int32 ID
        {
            get { return id; }
            set { id = value; }
        }

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
