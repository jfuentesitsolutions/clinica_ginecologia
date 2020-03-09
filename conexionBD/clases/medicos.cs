using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.clases
{
    public class medicos
    {
        private string nombres, apellidos, numero_junta, telefono, correo;

        public medicos(string nom, string apelli, string nu_ju, string tel, string corre)
        {
            this.nombres = nom;
            this.apellidos = apelli;
            this.numero_junta = nu_ju;
            this.telefono = tel;
            this.correo = corre;
        }

        public medicos()
        {

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

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
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

        public string Numero_junta
        {
            get
            {
                return numero_junta;
            }

            set
            {
                numero_junta = value;
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

        public DataTable datosMedicos()
        {
            DataTable datos=null;
            persisencia per = new persisencia();
            datos = per.datosMedicos();

            return datos;
        }

    }
}
