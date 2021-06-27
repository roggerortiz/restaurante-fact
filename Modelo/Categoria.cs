using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Categoria : Modelo
    {
        private String nombre;
        private List<Producto> productos = new List<Producto>();

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public List<Producto> Productos
        {
            get { return productos; }
            set { productos = value; }
        }
    }
}
