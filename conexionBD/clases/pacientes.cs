
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.clases
{
    public class pacientes
    {
        string nombres, apellidos, direccion, telefono, edad, expediente, observacion, id;

        public pacientes(string nombres, string apellidos, string direccion, string telefono, string edad, string expediente, string observacion)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Edad = edad;
            this.Expediente = expediente;
            this.Observacion = observacion;
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public string Expediente
        {
            get
            {
                return expediente;
            }

            set
            {
                expediente = value;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombres
        {
            get
            {
                return nombres;
            }

            set
            {
                nombres = value;
            }
        }

        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public static DataTable datosPacientes()
        {
            DataTable datos = null;
            persisencia per = new persisencia();
            datos = per.datosPacientes();

            return datos;
        }
    }
}
