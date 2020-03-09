using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.clases
{
    public class telefonos
    {
        string tipo, numero, estado, id;

        public telefonos(string tipo, string numero, string estado)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.estado = estado;
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
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

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

      
    }
}
