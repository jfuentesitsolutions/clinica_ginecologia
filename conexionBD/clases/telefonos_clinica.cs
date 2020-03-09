using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.clases
{
    public class telefonos_clinica
    {
        string idclinica, idtelefono;

        public telefonos_clinica(string idclinica, string idtelefono)
        {
            this.idclinica = idclinica;
            this.idtelefono = idtelefono;
        }

        public string Idclinica
        {
            get
            {
                return idclinica;
            }

            set
            {
                idclinica = value;
            }
        }

        public string Idtelefono
        {
            get
            {
                return idtelefono;
            }

            set
            {
                idtelefono = value;
            }
        }

        public static DataTable tel_clinica(string id)
        {
            DataTable datos = null;
            persisencia per = new persisencia();
            datos = per.datostelefonos_clinicas(id);

            return datos;
        }

    }
}
