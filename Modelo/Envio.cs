using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Envio : Modelo
    {
        private String codigo;
        private String respuesta;
        private DateTime fecha;
        private Int32 comprobanteId;

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Int32 ComprobanteID
        {
            get { return comprobanteId; }
            set { comprobanteId = value; }
        }
    }
}
