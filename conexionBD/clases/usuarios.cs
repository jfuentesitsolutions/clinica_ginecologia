using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.clases
{
    public class usuarios
    {
        private string nombre, contra, iddoc, fecha, comen, activo;
        conexionBD.persisencia bd;

        public usuarios(string nombre, string contra, string iddoc, string fecha, string comen, string activo)
        {
            this.Nombre = nombre;
            this.Contra = contra;
            this.Iddoc = iddoc;
            this.Fecha = fecha;
            this.Comen = comen;
            this.Activo = activo;
            this.bd = new persisencia();
        }

        private usuarios()
        {
            this.bd = new persisencia();
        }

        public string Activo
        {
            get
            {
                return activo;
            }

            set
            {
                activo = value;
            }
        }

        public string Comen
        {
            get
            {
                return comen;
            }

            set
            {
                comen = value;
            }
        }

        public string Contra
        {
            get
            {
                return contra;
            }

            set
            {
                contra = value;
            }
        }

        public string Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public string Iddoc
        {
            get
            {
                return iddoc;
            }

            set
            {
                iddoc = value;
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

        private DataTable datos()
        {
            try
            {
                return bd.consultar("select * from usuarios");
            }
            catch
            {
                return null;
            }
        }

        public static DataTable validar(string usu, string contra)
        {
            persisencia bd = new persisencia();
            try
            {
                return bd.consultar("select * from usuarios where nombre='" + usu + "' and contraseña='" + contra + "';");
            }
            catch
            {
                return null;
            }
        }

        public DataTable datosUsuarios()
        {
            return this.datos();
        }

        
    }
}
