using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica.principal.mensajes
{
    public partial class definicion_horarios : Form
    {
        bool aprovado = false;

        public bool Aprovado
        {
            get
            {
                return aprovado;
            }

            set
            {
                aprovado = value;
            }
        }

        public definicion_horarios()
        {
            InitializeComponent();
        }

        private void definicion_horarios_Load(object sender, EventArgs e)
        {
            txthoramaa.Text="08:00 AM";
            horamata.Text = "02:00 PM";
            horamaci.Text = "12:00 PM";
            horataci.Text = "05:00 PM";
        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                Aprovado = true;
                this.Close();
            }
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();

            if (txthoramaa.Text.Length == 0)
            {
                error.SetError(txthoramaa, "No puede quedar en blanco este campo");
                txthoramaa.Text = "08:00 AM";
                valido = true;
            }

            if (horamata.Text.Length == 0)
            {
                error.SetError(horamata, "No puede quedar en blanco este campo");
                txthoramaa.Text = "02:00 PM";
                valido = true;
            }

            if (horamaci.Text.Length == 0)
            {
                error.SetError(horamaci, "No puede quedar en blanco este campo");
                txthoramaa.Text = "12:00 PM";
                valido = true;
            }

            if (horataci.Text.Length == 0)
            {
                error.SetError(horataci, "No puede quedar en blanco este campo");
                txthoramaa.Text = "05:00 PM";
                valido = true;
            }

            return valido;
        }

    }
}
