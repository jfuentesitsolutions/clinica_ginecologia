using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica.principal
{
    public partial class pantalla_principal : Form
    {
        sessionManager.secion session = sessionManager.secion.Instancia;
        public pantalla_principal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void cheCarForm(Form frmhijo, Form frmpapa, bool maximizado)
        {
            Int32 c = 0;
            bool cargado = false;

            foreach (Form llamado in frmpapa.MdiChildren)
            {
                c++;
            }

            if (c > 0)
            {
                cargado = true;
            }

            if (!cargado)
            {
                frmhijo.MdiParent = frmpapa;
                //frmhijo.Location = new Point(0, 0);
                if (maximizado)
                {
                    frmhijo.Width = frmpapa.Width - (panel_lateral.Width);
                    frmhijo.Height = frmpapa.Height-(panel_encabezado.Height*2);
                }
                
                frmhijo.Show();
            }
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            interfaces.configuracion frm = new interfaces.configuracion();
            frm.Id_clinica = session.Idclinica;
            cheCarForm(frm, this, false);
        }

        private void pantalla_principal_Load(object sender, EventArgs e)
        {
            if (!session.Idclinica.Equals("0"))
            {
                lblTitulo.Text = session.Datos[3]+" \n"+session.Datos[4];
            }
            else
            {
                lblTitulo.Text = "Nombre de la clinica no definido";
            }
        }
    }
}
