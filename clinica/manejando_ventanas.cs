using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica
{
    class manejando_ventanas: ApplicationContext
    {

        public manejando_ventanas()
        {       
                if (login())
                {
                    principal.pantalla_principal nu = new principal.pantalla_principal();
                    nu.ShowDialog();
                }       
        }

        private Boolean login()
        {
            Boolean verificado = false;

            Login.login_inicio lo = new Login.login_inicio();
            lo.ShowDialog();
            verificado = lo.Autorizado;
            return verificado;
        }
    }
}
