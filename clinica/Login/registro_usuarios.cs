using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utilitarios;

namespace clinica.Login
{
    public partial class registro_usuarios : Form
    {

        conexionBD.persisencia conexiones = new conexionBD.persisencia();
        public registro_usuarios()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            if (pnDoctor.Visible==true && pnUsuarios.Visible==false)
            {
                if (!validarDatosMedico())
                {
                    if (guardarDoctor())
                    {
                        this.llenarListaDoctor();
                        pnDoctor.Visible = false;
                        pnUsuarios.Visible = true;
                        lblPasos.Text = "Paso 2: Ingreso de la información del medico";
                        btnSiguiente.ButtonText = "Finalizar";
                        

                    }
                }
            }else if(pnDoctor.Visible==false && pnUsuarios.Visible == true)
            {
                if (!validarDatosUsuario())
                {

                    guardandoUsuario();
                }
            }

        }

        private bool validarDatosMedico()
        {
            bool valido = false;
            error1.Clear();

            if (txtNombres.Text.Length==0)
            {
                valido = true;
                error1.SetError(txtNombres, mensajes.mensajeError(1));
                
            }

            if (txtapellidos.Text.Length == 0)
            {
                valido = true;
                error1.SetError(txtapellidos, mensajes.mensajeError(1));
            }

            if (txtNumeroJunta.Text.Length == 0)
            {
                valido = true;
                error1.SetError(txtNumeroJunta, mensajes.mensajeError(1));
            }

            if (txtTelefono.Text.Length == 0)
            {
                valido = true;
                error1.SetError(txtTelefono, mensajes.mensajeError(1));
            }

            if (txtCorreo.Text.Length == 0)
            {
                valido = true;
                error1.SetError(txtCorreo, mensajes.mensajeError(1));
            }

            return valido;
        }

        private bool validarDatosUsuario()
        {
            bool valido = false;
            error2.Clear();

            if (txtUsuario.Text.Length==0)
            {
                valido = true;
                error2.SetError(txtUsuario, mensajes.mensajeError(1));
            }

            if (txtContrase.Text.Length == 0)
            {
                valido = true;
                error2.SetError(txtContrase, mensajes.mensajeError(1));
            }

            if (listaMedicos.SelectedIndex == -1)
            {
                valido = true;
                error2.SetError(listaMedicos, mensajes.mensajeError(2));
            }

            if (txtComentarios.Text.Length == 0)
            {
                valido = true;
                error2.SetError(txtComentarios, mensajes.mensajeError(1));
            }

            return valido;
        }

        private bool guardarDoctor()
        {
            bool guardado = false;
            conexionBD.clases.medicos medi = new conexionBD.clases.medicos(txtNombres.Text, txtapellidos.Text, txtNumeroJunta.Text, txtTelefono.Text, txtCorreo.Text);
            conexionBD.persisencia per = new conexionBD.persisencia();

            if (per.guardarDatosMedico(medi) > 0)
            {
                guardado = true;
                MessageBox.Show("Registro ingresado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                guardado = false;
                MessageBox.Show("No se pudo guardar el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return guardado;
        }

        private bool guardandoUsuario()
        {
            conexionBD.clases.usuarios usu = new conexionBD.clases.usuarios(
                txtUsuario.Text,
                txtContrase.Text,
                listaMedicos.SelectedValue.ToString(),
                fecha.Value.ToString("dd/MM/yyyy"),
                txtComentarios.Text,
                Convert.ToString(Convert.ToInt32(swEstado.Value))
                );

            if (conexiones.guarda_usuarios(usu)>0)
            {
                MessageBox.Show("Usuario ingresado correctamente", "Usuario ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo ingresar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            return true;
        }

        private void llenarListaDoctor()
        {
            cargandoListas.cargarLista(conexionBD.clases.medicos.datosMedicos(), listaMedicos, "nombres", "iddoctor");
        }

        private void registro_usuarios_Load(object sender, EventArgs e)
        {
            if (conexiones.exis_doctores())
            {
                lblPasos.Text = "Paso 2: Ingreso de la información del usuario";
                pnDoctor.Visible = false;
                pnUsuarios.Visible = true;
                this.llenarListaDoctor();
            }
            else
            {
                lblPasos.Text = "Paso 1: Ingreso de la información del medico";
                pnDoctor.Visible = true;
                pnUsuarios.Visible = true;
            }
        }
    }
}
