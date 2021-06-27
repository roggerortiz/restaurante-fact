using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Producto : Modelo
    {
        private String nombre;
        private Decimal precioUnitario;
        private Int32 categoriaId;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Decimal PrecioUnitario
        {
            get { return precioUnitario; }
            set { precioUnitario = value; }
        }

        public Int32 CategoriaID
        {
            get { return categoriaId; }
            set { categoriaId = value; }
        }
    }
}
