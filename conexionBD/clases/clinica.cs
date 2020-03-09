using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.clases
{
    public class clinica
    {
        String nombre, email, id;

        public clinica(string nombre, string email)
        {
            this.nombre = nombre;
            this.email = email;
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public static DataTable datosClinica()
        {
            DataTable datos = null;
            persisencia per = new persisencia();
            datos = per.datosClinica();

            return datos;
        }
    }
}
