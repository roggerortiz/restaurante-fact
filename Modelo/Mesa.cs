using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Mesa : Modelo
    {
        private Int32 numero;
        private String estado;
        private String mozo;
        private DataTable detalles;

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

        public String Mozo
        {
            get { return mozo; }
            set { mozo = value; }
        }

        public DataTable Detalles
        {
            get { return detalles; }
            set { detalles = value; }
        }
    }
}
