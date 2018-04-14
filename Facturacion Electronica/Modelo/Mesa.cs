using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Mesa
    {
        private Int32 id;
        private Int32 numero;
        private String estado;

        public Int32 ID
        {
            get { return id; }
            set { id = value; }
        }

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
