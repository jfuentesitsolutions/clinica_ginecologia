using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace utilitarios
{
    public class mensajes
    {

        public static string mensajeError(int tipo)
        {
            switch (tipo)
            {
                case 1:
                    return "No puedes dejar este campo vacio";
                case 2:
                    return "Tienes que elegir una opción de la lista";
                case 3:
                    return "No se pudo guardar el registro";
                case 4:
                    return "La cantidad no puede quedar a cero";
            }

            return "";
        }
    }
}
