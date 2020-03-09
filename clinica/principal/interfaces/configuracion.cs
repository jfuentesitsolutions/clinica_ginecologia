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

    public partial class configuracion : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        string[] tipo_te = { "Fijo", "Celular", "Fax"};
        string id_clinica;
        bool actualiza=false;

        public string Id_clinica
        {
            get
            {
                return id_clinica;
            }

            set
            {
                id_clinica = value;
            }
        }

        public configuracion()
        {
            InitializeComponent();
            lista_tipo.Items.AddRange(Enumerable.Repeat<string>("", img_combo.Images.Count).ToArray());
            lista_tipo.SelectedIndex = 0;
        }

        private void cargandoValores()
        {
            tabla_horarios.Rows.Add("1", "Lunes mañana", false, "00:00 AM", "00:00 AM");
            tabla_horarios.Rows.Add("2", "Martes mañana", false, "00:00 AM", "00:00 AM");
            tabla_horarios.Rows.Add("3", "Miercoles mañana", false, "00:00 AM", "00:00 AM");
            tabla_horarios.Rows.Add("4", "Jueves mañana", false, "00:00 AM", "00:00 AM");
            tabla_horarios.Rows.Add("5", "Viernes mañana", false, "00:00 AM", "00:00 AM");
            tabla_horarios.Rows.Add("6", "Sabado mañana", false, "00:00 AM", "00:00 AM");
            tabla_horarios.Rows.Add("7", "Domingo mañana", false, "00:00 AM", "00:00 AM");

            tabla_horarios.Rows.Add("8", "Lunes tarde", false, "00:00 PM", "00:00 PM");
            tabla_horarios.Rows.Add("9", "Martes tarde", false, "00:00 PM", "00:00 PM");
            tabla_horarios.Rows.Add("10", "Miercoles tarde", false, "00:00 PM", "00:00 PM");
            tabla_horarios.Rows.Add("11", "Jueves tarde", false, "00:00 PM", "00:00 PM");
            tabla_horarios.Rows.Add("12", "Viernes tarde", false, "00:00 PM", "00:00 PM");
            tabla_horarios.Rows.Add("13", "Sabado tarde", false, "00:00 PM", "00:00 PM");
            tabla_horarios.Rows.Add("14", "Domingo tarde", false, "00:00 PM", "00:00 PM");


            foreach (DataGridViewRow fila in tabla_horarios.Rows)
            {
                if ((bool)fila.Cells[2].Value)
                {
                    fila.Cells[3].ReadOnly = false;
                    fila.Cells[4].ReadOnly = false;
                }
                else
                {
                    fila.Cells[3].ReadOnly = true;
                    fila.Cells[4].ReadOnly = true;
                }
            }

        }

        private void configuracion_Load(object sender, EventArgs e)
        {
            if (id_clinica.Equals("0"))
            {
                cargandoValores();
            }else
            {
                cargando_valores();
            }
            cargandoDatosTelefonos();
        }

        private void cargando_valores()
        {
            DataTable datos = conexionBD.clases.clinica_horario.datosHorarios(id_clinica);

            if (datos.Rows.Count>0)
            {
                tabla_horarios.Rows.Clear();
                foreach(DataRow fila in datos.Rows)
                {
                    tabla_horarios.Rows.Add(fila[0], fila[2], fila[5], fila[3], fila[4]);  
                }

                foreach (DataGridViewRow fila in tabla_horarios.Rows)
                {
                    if ((bool)fila.Cells[2].Value)
                    {
                        fila.Cells[3].ReadOnly = false;
                        fila.Cells[4].ReadOnly = false;
                    }
                }
            }
            else
            {
                cargandoValores();
            }
        }

        private void tabla_horarios_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (tabla_horarios.IsCurrentCellDirty)
            {
                tabla_horarios.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void tabla_horarios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                if (e.RowIndex>=7)
                {
                    if (e.ColumnIndex == 2)
                    {
                        if ((bool)tabla_horarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                        {
                            tabla_horarios.Rows[e.RowIndex].Cells[3].Value = "02:00 PM";
                            tabla_horarios.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                            tabla_horarios.Rows[e.RowIndex].Cells[4].Value = "05:00 PM";
                            tabla_horarios.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                        }
                        else
                        {
                            tabla_horarios.Rows[e.RowIndex].Cells[3].Value = "00:00 PM";
                            tabla_horarios.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                            tabla_horarios.Rows[e.RowIndex].Cells[4].Value = "00:00 PM";
                            tabla_horarios.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                        }
                    }

                }
                else
                {
                    if (e.ColumnIndex == 2)
                    {
                        if ((bool)tabla_horarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                        {
                            tabla_horarios.Rows[e.RowIndex].Cells[3].Value = "08:00 AM";
                            tabla_horarios.Rows[e.RowIndex].Cells[3].ReadOnly = false;
                            tabla_horarios.Rows[e.RowIndex].Cells[4].Value = "12:00 PM";
                            tabla_horarios.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                        }
                        else
                        {
                            tabla_horarios.Rows[e.RowIndex].Cells[3].Value = "00:00 AM";
                            tabla_horarios.Rows[e.RowIndex].Cells[3].ReadOnly = true;
                            tabla_horarios.Rows[e.RowIndex].Cells[4].Value = "00:00 PM";
                            tabla_horarios.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                        }
                    }
                }

                
                
            }
            
        }

        private void lista_tipo_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if(e.Index >= 0)
            {
                if(e.Index < img_combo.Images.Count)
                {
                    Image img = new Bitmap(img_combo.Images[e.Index]);
                    e.Graphics.DrawImage(img, new PointF(e.Bounds.Left, e.Bounds.Top));
                }

                e.Graphics.DrawString(tipo_te[e.Index],
                    e.Font, new SolidBrush(e.ForeColor),
                    e.Bounds.Left + 32, e.Bounds.Top);
            }
        }

        private void lista_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex >= 0)
            {
                Console.WriteLine(combo.SelectedIndex);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!actualiza)
            {
                if (!validar())
                {
                    if (id_clinica.Equals("0"))
                    {
                        conexionBD.clases.clinica c = new conexionBD.clases.clinica(txtNombre.Text, txtCorreo.Text);
                        conexionBD.clases.telefonos t = new conexionBD.clases.telefonos(tipo(lista_tipo.SelectedIndex), txtNumero.Text, Convert.ToString(Convert.ToInt32(swEstado.Value)));
                        conexionBD.persisencia per = new conexionBD.persisencia();
                        int id = per.transaccion_telefonos_clinica(c, t);

                        if (id > 0)
                        {
                            id_clinica = id.ToString();
                            sesion.Datos.Add(conexionBD.clases.clinica.datosClinica().Rows[0][1].ToString());
                            sesion.Datos.Add(conexionBD.clases.clinica.datosClinica().Rows[0][2].ToString());
                            txtNumero.Text = "";
                            cargandoDatosTelefonos();
                        }
                    }
                    else
                    {
                        conexionBD.clases.telefonos t = new conexionBD.clases.telefonos(tipo(lista_tipo.SelectedIndex), txtNumero.Text, Convert.ToString(Convert.ToInt32(swEstado.Value)));
                        conexionBD.persisencia per = new conexionBD.persisencia();

                        if (per.transaccion_agrega_telefono_clinica(t, id_clinica) > 0)
                        {
                            txtNumero.Text = "";
                            cargandoDatosTelefonos();
                        }
                    }
                }
            }
            else
            {
                conexionBD.clases.telefonos te = new conexionBD.clases.telefonos(
                    tipo(lista_tipo.SelectedIndex), txtNumero.Text, Convert.ToString(Convert.ToInt32(swEstado.Value))
                    );
                te.Id = tabla_telefonos.CurrentRow.Cells[5].Value.ToString();

                Console.WriteLine("numero de id: "+te.Id);

                conexionBD.persisencia per = new conexionBD.persisencia();

                if (per.actualiza_telefono(te))
                {
                    actualiza = false;
                    txtNumero.Text = "";
                    swEstado.Value = true;
                    lista_tipo.SelectedIndex = 0;
                    btnAgregar.Image = Properties.Resources.plus;
                    cargandoDatosTelefonos();
                }

            }
              
        }

        private string tipo(int index)
        {
            switch (index)
            {
                case 0:
                    return "Fijo";
                case 1:
                    return "Celular";
                case 2:
                    return "Fax";
                default:
                    return "Ninguno";
            }
        }

        private int tipo_indes(string tipo)
        {
            switch (tipo)
            {
                case "Fijo":
                    return 0;
                case "Celular":
                    return 1;
                case "Fax":
                    return 2;
                default:
                    return -1;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargandoDatosTelefonos()
        {
            if (!id_clinica.Equals("0"))
            {
                txtNombre.Text = sesion.Datos[3];
                txtCorreo.Text = sesion.Datos[4];
                pantalla_principal principal = (pantalla_principal)this.ParentForm;
                principal.lblTitulo.Text = sesion.Datos[3] + " \n" + sesion.Datos[4];
                DataTable tel = conexionBD.clases.telefonos_clinica.tel_clinica(id_clinica);
                int correl = 1;
                if (tabla_telefonos.RowCount == 0)
                {
                    if (tel.Rows.Count > 0)
                    {
                        foreach(DataRow fila in tel.Rows)
                        {
                            tabla_telefonos.Rows.Add(fila[0].ToString(), Convert.ToString(correl), fila[5].ToString(), fila[4].ToString(), Convert.ToBoolean(fila[6].ToString()), fila[1].ToString());
                            correl++;
                        }
                    }
                }
                else
                {
                    tabla_telefonos.Rows.Clear();
                    correl = 1;
                    if (tel.Rows.Count > 0)
                    {
                        foreach (DataRow fila in tel.Rows)
                        {
                            tabla_telefonos.Rows.Add(fila[0].ToString(), Convert.ToString(correl), fila[5].ToString(), fila[4].ToString(), Convert.ToBoolean(fila[6].ToString()), fila[1].ToString());
                            correl++;
                        }
                    }
                }
            }
        }

        private bool validar()
        {
            bool valido = false;
            error.Clear();

            if (id_clinica.Equals("0"))
            {
                if (txtNombre.Text.Length==0)
                {
                    valido = true;
                    error.SetError(txtNombre, "No puedes dejar este campo en blanco");
                }

                if (txtCorreo.Text.Length==0)
                {
                    valido = true;
                    error.SetError(txtCorreo, "No puedes dejar este campo en blanco");
                }

                if (txtNumero.Text.Length == 0)
                {
                    valido = true;
                    error.SetError(txtNumero, "No puedes dejar este campo en blanco");
                }

            }
            else
            {
                if (txtNumero.Text.Length == 0)
                {
                    valido = true;
                    error.SetError(txtNumero, "No puedes dejar este campo en blanco");
                }
            }

            return valido;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (tabla_telefonos.RowCount>0)
            {

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!id_clinica.Equals("0"))
            {
                conexionBD.clases.clinica cli = new conexionBD.clases.clinica(
                    txtNombre.Text,
                    txtCorreo.Text);
                cli.Id = id_clinica;
                conexionBD.persisencia per = new conexionBD.persisencia();

                if (per.actualiza_clinica(cli))
                {
                    MessageBox.Show("Los datos de la clinica fueron actualizados", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pantalla_principal pp = (pantalla_principal)this.ParentForm;
                    sesion.Datos[3] = txtNombre.Text;
                    sesion.Datos[4] = txtCorreo.Text;
                    pp.lblTitulo.Text = txtNombre.Text+"\n"+txtCorreo.Text;
                }
            }
        }

        private void tabla_telefonos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tabla_telefonos.RowCount>0)
            {
                actualiza = true;
                btnAgregar.Image = Properties.Resources.refresh;
                txtNumero.Text = tabla_telefonos.CurrentRow.Cells[2].Value.ToString();
                lista_tipo.SelectedIndex = tipo_indes(tabla_telefonos.CurrentRow.Cells[3].Value.ToString());
                swEstado.Value = (bool)tabla_telefonos.CurrentRow.Cells[4].Value;
            }
        }

        private void chk_todos_OnChange(object sender, EventArgs e)
        {
            if (chk_todos.Checked)
            {
                mensajes.definicion_horarios frm = new mensajes.definicion_horarios();
                frm.ShowDialog();
                if (frm.Aprovado)
                {
                    string hma = frm.txthoramaa.Text;
                    string hmc = frm.horamaci.Text;
                    tabla_horarios.Rows.Clear();
                    tabla_horarios.Rows.Add("1", "Lunes mañana", true, hma, hmc);
                    tabla_horarios.Rows.Add("2", "Martes mañana", true, hma, hmc);
                    tabla_horarios.Rows.Add("3", "Miercoles mañana", true, hma, hmc);
                    tabla_horarios.Rows.Add("4", "Jueves mañana", true, hma, hmc);
                    tabla_horarios.Rows.Add("5", "Viernes mañana", true, hma, hmc);
                    tabla_horarios.Rows.Add("6", "Sabado mañana", false, "00:00 AM", "00:00 AM");
                    tabla_horarios.Rows.Add("7", "Domingo mañana", false, "00:00 AM", "00:00 AM");

                    string hta = frm.horamata.Text;
                    string htc = frm.horataci.Text;
                    tabla_horarios.Rows.Add("8", "Lunes tarde", true, hta, htc);
                    tabla_horarios.Rows.Add("9", "Martes tarde", true, hta, htc);
                    tabla_horarios.Rows.Add("10", "Miercoles tarde", true, hta, htc);
                    tabla_horarios.Rows.Add("11", "Jueves tarde", true, hta, htc);
                    tabla_horarios.Rows.Add("12", "Viernes tarde", true, hta, htc);
                    tabla_horarios.Rows.Add("13", "Sabado tarde", false, "00:00 PM", "00:00 PM");
                    tabla_horarios.Rows.Add("14", "Domingo tarde", false, "00:00 PM", "00:00 PM");

                    foreach(DataGridViewRow fila in tabla_horarios.Rows)
                    {
                        if ((bool)fila.Cells[2].Value)
                        {
                            fila.Cells[3].ReadOnly = false;
                            fila.Cells[4].ReadOnly = false;
                        }
                        else
                        {
                            fila.Cells[3].ReadOnly = true;
                            fila.Cells[4].ReadOnly = true;
                        }
                    }
                    
                }
            }else
            {
                tabla_horarios.Rows.Clear();
                cargandoValores();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (id_clinica.Equals("0"))
            {
                MessageBox.Show("Agrega una clinica a la base", "Clinica inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DataTable datos = conexionBD.clases.clinica_horario.datosHorarios(id_clinica);
                if (datos.Rows.Count==0)
                {
                    if (MessageBox.Show("No exíste horarios definidos \n ¿Desea crear los horarios en este momento?", "No hay horarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        int res = 0;
                        conexionBD.persisencia per = new conexionBD.persisencia();
                        foreach(DataGridViewRow fila in tabla_horarios.Rows)
                        {
                            res = per.guardando_horarios(new conexionBD.clases.clinica_horario(id_clinica, 
                                fila.Cells[1].Value.ToString(),
                                fila.Cells[3].Value.ToString(), 
                                fila.Cells[4].Value.ToString(), 
                                Convert.ToString(Convert.ToInt32(fila.Cells[2].Value))));                             
                        }


                        if (res > 0)
                        {
                            MessageBox.Show("Horarios ingresados", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }else
                {
                    if (tabla_horarios.Rows.Count>0)
                    {
                        conexionBD.persisencia per = new conexionBD.persisencia();
                        bool guardado = false;
                        List<conexionBD.clases.clinica_horario> lista = new List<conexionBD.clases.clinica_horario>();

                        foreach(DataGridViewRow fila in tabla_horarios.Rows)
                        {
                            conexionBD.clases.clinica_horario ch = new conexionBD.clases.clinica_horario(
                                id_clinica,
                                fila.Cells[1].Value.ToString(),
                                fila.Cells[3].Value.ToString(),
                                fila.Cells[4].Value.ToString(),
                                Convert.ToString(Convert.ToInt32(fila.Cells[2].Value)),
                                fila.Cells[0].Value.ToString());
                            lista.Add(ch);     
                        }

                        guardado = per.actualiza_horarios(lista);

                        

                        if (guardado)
                        {
                            MessageBox.Show("Horarios actualizados", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargando_valores();
                        }
                    }
                }
            }
        }
    }
}
