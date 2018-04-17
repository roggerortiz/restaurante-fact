using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Cliente : Modelo
    {
        private String ruc;
        private String razonSocial;
        private String dni;
        private String nombres;
        private String apellidos;
        private String direccion;
        private String telefono;
        private String correo;

        public String RUC
        {
            get { return ruc; }
            set { ruc = value; }
        }

        public String RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        public String DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }
    }
}
