using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Usuario
    {
        private Int32 id;
        private String dni;
        private String nombres;
        private String apellidos;
        private String direccion;
        private String telefono;
        private String nombUsu;
        private String clave;
        private Int32 estado;

        public Int32 ID
        {
            get { return id; }
            set { id = value; }
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

        public String NombUsu
        {
            get { return nombUsu; }
            set { nombUsu = value; }
        }

        public String Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public Int32 Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
