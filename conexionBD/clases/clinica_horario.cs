using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.clases
{
    public class clinica_horario
    {
        string idclinica, dia, hora_aper, hora_cierre, activo, id;

        public clinica_horario(string idclinica, string dia, string hora_aper, string hora_cierre, string activo)
        {
            this.Idclinica = idclinica;
            this.Dia = dia;
            this.Hora_aper = hora_aper;
            this.Hora_cierre = hora_cierre;
            this.Activo = activo;
        }

        public clinica_horario(string idclinica, string dia, string hora_aper, string hora_cierre, string activo, string id)
        {
            this.idclinica = idclinica;
            this.dia = dia;
            this.hora_aper = hora_aper;
            this.hora_cierre = hora_cierre;
            this.activo = activo;
            this.id = id;
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
        public string Dia
        {
            get
            {
                return dia;
            }

            set
            {
                dia = value;
            }
        }
        public string Hora_aper
        {
            get
            {
                return hora_aper;
            }

            set
            {
                hora_aper = value;
            }
        }
        public string Hora_cierre
        {
            get
            {
                return hora_cierre;
            }

            set
            {
                hora_cierre = value;
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
        public static DataTable datosHorarios(string id)
        {
            DataTable datos = null;
            persisencia per = new persisencia();
            datos = per.datos_horarios(id);

            return datos;
        }
    }
}
