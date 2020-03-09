using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica.Login
{
    public partial class login_inicio : Form
    {
        sessionManager.secion sesion = sessionManager.secion.Instancia;
        bool autorizado = false;

        public bool Autorizado
        {
            get
            {
                return autorizado;
            }

            set
            {
                autorizado = value;
            }
        }

        public login_inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            conexionBD.persisencia cn = new conexionBD.persisencia();
            DataTable datos = conexionBD.clases.usuarios.validar(txtUsuario.Text, txtcontra.Text);
            if (datos!=null)
            {
                if (datos.Rows.Count>0)
                {
                    sesion.Datos.Add(datos.Rows[0][0].ToString());
                    sesion.Datos.Add(datos.Rows[0][1].ToString());
                    sesion.Datos.Add(datos.Rows[0][3].ToString());
                    DataTable clinica = conexionBD.clases.clinica.datosClinica();
                    if (clinica.Rows.Count > 0)
                    {
                        sesion.Idclinica = clinica.Rows[0][0].ToString();
                        sesion.Datos.Add(clinica.Rows[0][1].ToString());
                        sesion.Datos.Add(clinica.Rows[0][2].ToString());
                    }
                    else
                    {
                        sesion.Idclinica = "0";
                    }
                    guardarConfiguracion();
                    autorizado = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se encuentra ningun registro en la base de datos,\nde clic en registrar para agregar un usuario", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                
            }
        }

        private void guardarConfiguracion()
        {
            RegistryKey rk = Registry.CurrentUser.CreateSubKey(@"clinica\configuracion");
   
            if (chkGuarda.Checked)
            {
                rk.SetValue("guarda", "1");
                rk.SetValue("usuario", txtUsuario.Text);
                rk.SetValue("password", txtcontra.Text);
            }
            else
            {
                rk.SetValue("guarda", "0");
            }
            
            rk.Close();  
        }

        private List<string> leerConfiguracion()
        {
            List<string> datos = new List<string>();
            try
            {
                string lectura = (string)Registry.GetValue("HKEY_CURRENT_USER\\clinica\\configuracion", "guarda", "NE");
                if (!lectura.Equals("NE"))
                {
                    datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\clinica\\configuracion", "usuario", "NE"));
                    datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\clinica\\configuracion", "password", "NE"));
                    datos.Add((string)Registry.GetValue("HKEY_CURRENT_USER\\clinica\\configuracion", "guarda", "0"));
                }
            }
            catch
            {
                Console.WriteLine("No se encuentra el registro");
            }
            

            return datos;
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            registro_usuarios reg = new registro_usuarios();
            reg.ShowDialog();
        }

        private void login_inicio_Load(object sender, EventArgs e)
        {
            List<String> datos = leerConfiguracion();
            if (datos.Count>0)
            {
                if (datos[2].Equals("1"))
                {
                    conexionBD.persisencia cn = new conexionBD.persisencia();
                    DataTable dato = conexionBD.clases.usuarios.validar(datos[0], datos[1]);
                    if (dato != null)
                    {
                        if (dato.Rows.Count > 0)
                        {

                            sesion.Datos.Add(dato.Rows[0][0].ToString());
                            sesion.Datos.Add(dato.Rows[0][1].ToString());
                            sesion.Datos.Add(dato.Rows[0][3].ToString());
                            DataTable clinica = conexionBD.clases.clinica.datosClinica();
                            if (clinica.Rows.Count > 0)
                            {
                                sesion.Idclinica = clinica.Rows[0][0].ToString();
                                sesion.Datos.Add(clinica.Rows[0][1].ToString());
                                sesion.Datos.Add(clinica.Rows[0][2].ToString());
                            }
                            else
                            {
                                sesion.Idclinica = "0";
                            }
                            autorizado = true;
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("No se encuentra ningun registro en la base de datos,\nde clic en registrar para agregar un usuario", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
        }

       
    }
}
