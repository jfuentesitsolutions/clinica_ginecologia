using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica.principal.interfaces
{
    public partial class medicos : Form
    {
        bool modificar = false;
        utilitarios.cargar_tablas tabla;
        string idmedico = "0";
        public medicos()
        {
            InitializeComponent();
        }

        private void cargarTabla()
        {
            tabla = new utilitarios.cargar_tablas(tabla_medicos, txtBuscar, conexionBD.clases.medicos.datosMedicos(), "nombres", lblCantRegistros);
            tabla.cargar();
        }

        private void recargarTabla()
        {
            tabla.TablaDatos = conexionBD.clases.medicos.datosMedicos();
            tabla.cargar();
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();

            if (txtNombres.Text.Length == 0)
            {
                error.SetError(txtNombres, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }
            if (txtApellidos.Text.Length == 0)
            {
                error.SetError(txtApellidos, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }
            if (txtJunta.Text.Length == 0)
            {
                error.SetError(txtJunta, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }
            if (txtTelefono.Text.Length == 0)
            {
                error.SetError(txtTelefono, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }
            if (txtCorreo.Text.Length == 0)
            {
                error.SetError(txtCorreo, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }

            return valido;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                conexionBD.clases.medicos medico = new conexionBD.clases.medicos(
                        txtNombres.Text,
                        txtApellidos.Text,
                        txtJunta.Text,
                        txtTelefono.Text,
                        txtCorreo.Text);

                conexionBD.persisencia per = new conexionBD.persisencia();

                if (modificar)
                {
                    medico.Id = idmedico;

                    if (per.modificar_medico(medico))
                    {
                        MessageBox.Show("Los datos se modificarón con exíto", "Modificación exítosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciandoDatos();
                        modificar = false;
                        btnGuardar.Text = "Guardar medico";
                        recargarTabla();
                    }else
                    {
                        MessageBox.Show("Los datos no se pudierón modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    if (per.guardarDatosMedico(medico) > 0)
                    {
                        MessageBox.Show("Los datos se ingresarón con exíto", "Datos ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        vaciandoDatos();
                        recargarTabla();
                    }else
                    {
                        MessageBox.Show("Los datos no se pudierón ingresar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void vaciandoDatos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtJunta.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void medicos_Load(object sender, EventArgs e)
        {
            this.cargarTabla();
        }

        private void tabla_medicos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int posicion_mouse = tabla_medicos.HitTest(e.X, e.Y).RowIndex;
                if (posicion_mouse >= 0)
                {
                    opciones_tabla.Show(tabla_medicos, new Point(e.X, e.Y));
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar el registro?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow fila = tabla_medicos.CurrentRow;
                modificar = true;
                idmedico = fila.Cells[0].Value.ToString();
                txtNombres.Text = fila.Cells[1].Value.ToString();
                txtApellidos.Text = fila.Cells[2].Value.ToString();
                txtJunta.Text = fila.Cells[3].Value.ToString();
                txtTelefono.Text = fila.Cells[4].Value.ToString();
                txtCorreo.Text = fila.Cells[5].Value.ToString();
                btnGuardar.Text = "Modificar medico";
            }

        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Desea eliminar el registro?","Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow fila = tabla_medicos.CurrentRow;
                conexionBD.persisencia per = new conexionBD.persisencia();
                if (per.elimina_medico(fila.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Medico eliminado correctamente", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    recargarTabla();
                }
                else
                {
                    MessageBox.Show("El medico no se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }
    }
}
