using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Mesa : Modelo
    {
        private Int32 numero;
        private String estado;

        public Int32 Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
