using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Cliente : Modelo
    {
        private Int32 persona;
        private String ruc = null;
        private String razonSocial = null;
        private String dni = null;
        private String nombres = null;
        private String apellidos = null;
        private String direccion;
        private String telefono;
        private String correo;

        public Int32 Persona
        {
            get { return persona; }
            set { persona = value; }
        }

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
