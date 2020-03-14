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
    public partial class pacientes : Form
    {
        utilitarios.cargar_tablas tabla;
        bool modificar = false;
        string idpaciente = "0";
        public pacientes()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (txtDireccion.Text.Length == 0)
            {
                error.SetError(txtDireccion, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }
            if (txtTelefono.Text.Length == 0)
            {
                error.SetError(txtTelefono, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }
            if (txtEdad.Value == 0)
            {
                error.SetError(txtEdad, utilitarios.mensajes.mensajeError(4));
                valido = true;
            }
            if (txtExpediente.Text.Length == 0)
            {
                error.SetError(txtExpediente, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }
            if (txtObservacion.Text.Length == 0)
            {
                error.SetError(txtObservacion, utilitarios.mensajes.mensajeError(1));
                valido = true;
            }


            return valido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                conexionBD.clases.pacientes paciente = new conexionBD.clases.pacientes(
                    txtNombres.Text,
                    txtApellidos.Text,
                    txtDireccion.Text,
                    txtTelefono.Text,
                    txtEdad.Value.ToString(),
                    txtExpediente.Text,
                    txtObservacion.Text);

                conexionBD.persisencia per = new conexionBD.persisencia();

                if (!modificar)
                {
                    if (per.guarda_pacientes(paciente) > 0)
                    {
                        MessageBox.Show("Paciente ingresado con exíto", "Paciente ingresado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        recargandoTabla();
                        vaciandoCampos();
                    }else
                    {
                        MessageBox.Show("El paciente no se pudo ingresar", "Paciente no ingresado", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }else
                {
                    paciente.Id = idpaciente;
                    if (per.modificar_paciente(paciente))
                    {
                        MessageBox.Show("El paciente se modifico con exíto", "Paciente modificado", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        recargandoTabla();
                        modificar = false;
                        vaciandoCampos();
                    }
                    else
                    {
                        MessageBox.Show("El paciente no se pudo modificar", "El paciente no se puede modificar", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void vaciandoCampos()
        {
            btnGuardar.Text = "Guardar paciente";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEdad.Value = 0;
            txtExpediente.Text = "";
            txtObservacion.Text = "";
        }

        private void pacientes_Load(object sender, EventArgs e)
        {
            tabla = new utilitarios.cargar_tablas(tabla_pacientes, txtBuscar, conexionBD.clases.pacientes.datosPacientes(), "nombres", lblCantRegistros);
            tabla.cargar();      
        }

        private void recargandoTabla()
        {
            tabla.TablaDatos = conexionBD.clases.pacientes.datosPacientes();
            tabla.cargar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            tabla.FiltrarLocalmente();
        }

        private void tabla_pacientes_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int posicion_mouse = tabla_pacientes.HitTest(e.X, e.Y).RowIndex;
                if (posicion_mouse >= 0)
                {
                    opciones_tabla.Show(tabla_pacientes, new Point(e.X, e.Y));
                }
            }
        }

        private void btnBorra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el paciente?", "Eliminar paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow fila = tabla_pacientes.CurrentRow;
                conexionBD.persisencia per = new conexionBD.persisencia();
                if (per.elimina_paciente(fila.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("El paciente se elimino correctamente", "Paciente eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    recargandoTabla();
                } else
                {
                    MessageBox.Show("No se pudo eliminar el paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar el paciente?","Modificación del paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow fila = tabla_pacientes.CurrentRow;
                idpaciente = fila.Cells[0].Value.ToString();
                txtNombres.Text = fila.Cells[1].Value.ToString();
                txtApellidos.Text = fila.Cells[2].Value.ToString();
                txtDireccion.Text = fila.Cells[3].Value.ToString();
                txtTelefono.Text = fila.Cells[4].Value.ToString();
                txtEdad.Value = Convert.ToDecimal(fila.Cells[5].Value.ToString());
                txtExpediente.Text = fila.Cells[6].Value.ToString();
                txtObservacion.Text = fila.Cells[7].Value.ToString();
                btnGuardar.Text = "Modificar paciente";
                modificar = true;
            }
        }
    }
}
