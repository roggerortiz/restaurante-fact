using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Log : Modelo
    {
        private String descripcion;
        private DateTime fecha;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
    }
}
