using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace conexionBD
{
    public class persisencia: conexion
    {
        OleDbCommand cmd;
        

        public int guardarDatosMedico(clases.medicos med)
        {
            int retorno= 0;

            try
            {
                String sentencia;
                sentencia = "INSERT INTO DOCTORES(nombres, apellidos, numero_junta, telefono, correo) VALUES(@no, @ape, @numero, @tel, @cor);";
                cmd = new OleDbCommand(sentencia, base.conectar());
                cmd.Parameters.AddWithValue("@no", med.Nombres);
                cmd.Parameters.AddWithValue("@ape", med.Apellidos);
                cmd.Parameters.AddWithValue("@numero", med.Numero_junta);
                cmd.Parameters.AddWithValue("@tel", med.Telefono);
                cmd.Parameters.AddWithValue("@cor", med.Correo);

                Console.WriteLine(med.Nombres);

                cmd.ExecuteNonQuery();
                retorno = 1;
            }
            catch
            {
                retorno = 0;
            }



            base.cerrar();
            return retorno;
        }
        private int guardarDatosUsuario(clases.usuarios usu)
        {
            int retorno = 0;

            try
            {
                String sentencia;
                sentencia = @"INSERT INTO USUARIOS(nombre, contraseña, iddoctor, fecha, comentarios, activo) 
                    VALUES(@no, @con, @idd, @fecha, @come, @acti);";
                cmd = new OleDbCommand(sentencia, base.conectar());
                cmd.Parameters.AddWithValue("@no", usu.Nombre);
                cmd.Parameters.AddWithValue("@con", usu.Contra);
                cmd.Parameters.AddWithValue("@idd", usu.Iddoc);
                cmd.Parameters.AddWithValue("@fecha", usu.Fecha);
                cmd.Parameters.AddWithValue("@come", usu.Comen);
                cmd.Parameters.AddWithValue("@acti", usu.Activo);

                Console.WriteLine(usu.Nombre);

                cmd.ExecuteNonQuery();
                retorno = 1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                retorno = 0;
            }

            base.cerrar();
            return retorno;
        }
        private int guardarDatosClinica(clases.clinica clini)
        {
            int retorno = 0;
            try
            {
                String sentencia;
                sentencia = @"INSERT INTO CLINICA(nombre, email) 
                    VALUES(@no, @em);";
                cmd = new OleDbCommand(sentencia, base.conectar());
                cmd.Parameters.AddWithValue("@no", clini.Nombre);
                cmd.Parameters.AddWithValue("@em", clini.Email);
                cmd.ExecuteNonQuery();

 
                cmd.CommandText = "SELECT @@Identity";
                retorno = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                retorno = 0;
            }

            base.cerrar();
            return retorno;
        }
        public DataTable datosMedicos()
        {
            DataTable datos = null;
            try
            {
                base.Adaptador = new OleDbDataAdapter();
                DataSet data = new DataSet();
                string sentencia = "SELECT * FROM DOCTORES";
                base.Adaptador.SelectCommand = new OleDbCommand(sentencia, base.conectar());
                base.Constructor = new OleDbCommandBuilder(Adaptador);

                base.Adaptador.Fill(data);
                datos = data.Tables[0];
            }
            catch
            {
                datos = null;
            }

            base.cerrar();
            return datos;
        }
        private DataTable datosHorarios(string id)
        {
            DataTable datos = null;
            try
            {
                base.Adaptador = new OleDbDataAdapter();
                DataSet data = new DataSet();
                string sentencia = "SELECT * FROM CLINICA_HORARIO WHERE idclinica="+id+";";
                base.Adaptador.SelectCommand = new OleDbCommand(sentencia, base.conectar());
                base.Constructor = new OleDbCommandBuilder(Adaptador);

                base.Adaptador.Fill(data);
                datos = data.Tables[0];
            }
            catch
            {
                datos = null;
            }

            base.cerrar();
            return datos;
        }
        public DataTable datostelefonos_clinicas(string id_clinica)
        {
            DataTable datos = null;
            try
            {
                base.Adaptador = new OleDbDataAdapter();
                DataSet data = new DataSet();
                string sentencia = @"SELECT telefonos_clinicas.Id_telefono_clinica, telefonos.Idtelefono, clinica.Idclinica, telefonos.estado, telefonos.tipo_telefono, telefonos.numero, telefonos.estado
                                    FROM telefonos INNER JOIN (clinica INNER JOIN telefonos_clinicas ON clinica.Idclinica = telefonos_clinicas.idclinica) ON telefonos.Idtelefono = telefonos_clinicas.idtelefono
                                    WHERE ((clinica.Idclinica)="+id_clinica+");";
                base.Adaptador.SelectCommand = new OleDbCommand(sentencia, base.conectar());
                base.Constructor = new OleDbCommandBuilder(Adaptador);

                base.Adaptador.Fill(data);
                datos = data.Tables[0];
            }
            catch
            {
                datos = null;
            }

            base.cerrar();
            return datos;
        }
        private int guardandoHorarios(clases.clinica_horario clini)
        {
            int retorno = 0;
            try
            {
                String sentencia;
                sentencia = @"INSERT INTO CLINICA_HORARIO(idclinica, dia, hora_apertura, hora_cierre, activo) 
                    VALUES(@idcl, @dia, ha, hc, ac);";
                cmd = new OleDbCommand(sentencia, base.conectar());
                cmd.Parameters.AddWithValue("@idcl", clini.Idclinica);
                cmd.Parameters.AddWithValue("@dia", clini.Dia);
                cmd.Parameters.AddWithValue("@ha", clini.Hora_aper);
                cmd.Parameters.AddWithValue("@hc", clini.Hora_cierre);
                cmd.Parameters.AddWithValue("@ac", clini.Activo);
                cmd.ExecuteNonQuery();


                cmd.CommandText = "SELECT @@Identity";
                retorno = (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                retorno = 0;
            }

            base.cerrar();
            return retorno;
        }


        /*Metodos de transacciones*/
        private int guardando_clinica_telefono(clases.clinica clini, clases.telefonos tel)
        {
            int retorno = 0;
            OleDbTransaction trans = null;
            try
            {
                trans = base.conectar().BeginTransaction();
                String sentencia;
                sentencia = @"INSERT INTO CLINICA(nombre, email) 
                    VALUES(@no, @em);";
                cmd = new OleDbCommand(sentencia, base.cnn, trans);
                cmd.Parameters.AddWithValue("@no", clini.Nombre);
                cmd.Parameters.AddWithValue("@em", clini.Email);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@Identity";

                int idcli = (int)cmd.ExecuteScalar();

                sentencia = @"INSERT INTO TELEFONOS(tipo_telefono, numero, estado) 
                    VALUES(@tt, @num, @es);";
                cmd = new OleDbCommand(sentencia, base.cnn, trans);
                cmd.Parameters.AddWithValue("@tt", tel.Tipo);
                cmd.Parameters.AddWithValue("@num", tel.Numero);
                cmd.Parameters.AddWithValue("@es", tel.Estado);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@Identity";

                int idtele = (int)cmd.ExecuteScalar();

                sentencia = @"INSERT INTO TELEFONOS_CLINICAS (idclinica, idtelefono) 
                    VALUES(@idc, @idt);";
                cmd = new OleDbCommand(sentencia, base.cnn, trans);
                cmd.Parameters.AddWithValue("@idc", idcli);
                cmd.Parameters.AddWithValue("@idt", idtele);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@Identity";

                retorno = idcli;

                trans.Commit();
                base.cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                trans.Rollback();
                retorno = 0;
                base.cerrar();
            }

            base.cerrar();

            return retorno;
        }
        private int guardando_telefonos(clases.telefonos tel, string idcli)
        {
            int retorno = 0;
            OleDbTransaction trans = null;

            try
            {
                trans = base.conectar().BeginTransaction();
                String sentencia;
                sentencia = @"INSERT INTO TELEFONOS(tipo_telefono, numero, estado) 
                    VALUES(@tt, @num, @es);";
                cmd = new OleDbCommand(sentencia, base.cnn, trans);
                cmd.Parameters.AddWithValue("@tt", tel.Tipo);
                cmd.Parameters.AddWithValue("@num", tel.Numero);
                cmd.Parameters.AddWithValue("@es", tel.Estado);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@Identity";

                int idtele = (int)cmd.ExecuteScalar();

                sentencia = @"INSERT INTO TELEFONOS_CLINICAS (idclinica, idtelefono) 
                    VALUES(@idc, @idt);";
                cmd = new OleDbCommand(sentencia, base.cnn, trans);
                cmd.Parameters.AddWithValue("@idc", idcli);
                cmd.Parameters.AddWithValue("@idt", idtele);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@Identity";

                retorno = (int)cmd.ExecuteScalar();

                trans.Commit();
                base.cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                trans.Rollback();
                retorno = 0;
                base.cerrar();
            }

            base.cerrar();

            return retorno;
        }

        /*Metodos de creacion, modificacion, eliminacion y retorno*/
        public DataTable datosClinica()
        {
            DataTable datos = null;
            try
            {
                base.Adaptador = new OleDbDataAdapter();
                DataSet data = new DataSet();
                string sentencia = "SELECT * FROM CLINICA";
                base.Adaptador.SelectCommand = new OleDbCommand(sentencia, base.conectar());
                base.Constructor = new OleDbCommandBuilder(Adaptador);

                base.Adaptador.Fill(data);
                datos = data.Tables[0];
            }
            catch
            {
                datos = null;
            }

            base.cerrar();
            return datos;
        }
        public DataTable consultar(string sent)
        {
            DataTable datos = null;
            try
            {
                Adaptador = new OleDbDataAdapter();
                DataSet data = new DataSet();
                string sentencia = sent;
                Adaptador.SelectCommand = new OleDbCommand(sentencia, base.conectar());
                Constructor = new OleDbCommandBuilder(Adaptador);

                Adaptador.Fill(data);
                datos = data.Tables[0];
            }
            catch
            {
                datos = null;
            }

            base.cerrar();
            return datos;
        }
        private bool existencias_doctores()
        {
            if(this.consultar("select * from doctores").Rows.Count>0)
            {
                cerrar();
                return true;
            }
            else
            {
                cerrar();
                return false;
            }
            
        }
        private bool actualizar_telefono(clases.telefonos tel)
        {
            try
            {
                String sentencia;
                sentencia = @"UPDATE TELEFONOS SET tipo_telefono=@tele, numero=@num, estado=@est where idtelefono=@id;";
                cmd = new OleDbCommand(sentencia, base.conectar());
                cmd.Parameters.AddWithValue("@tele", tel.Tipo);
                cmd.Parameters.AddWithValue("@num", tel.Numero);
                cmd.Parameters.AddWithValue("@est", tel.Estado);
                cmd.Parameters.AddWithValue("@id", tel.Id);
                cmd.ExecuteNonQuery();
                base.cerrar();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                base.cerrar();
                return false;
            }

            
        }
        private bool actualizar_clinica(clases.clinica cli)
        {
            try
            {
                String sentencia;
                sentencia = @"UPDATE CLINICA SET nombre=@nom, email=@ema where idclinica=@id;";
                cmd = new OleDbCommand(sentencia, base.conectar());
                cmd.Parameters.AddWithValue("@nom", cli.Nombre);
                cmd.Parameters.AddWithValue("@ema", cli.Email);
                cmd.Parameters.AddWithValue("@id", cli.Id);
                cmd.ExecuteNonQuery();
                base.cerrar();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                base.cerrar();
                return false;

            }
        }
        private bool actualizar_horarios(List<clases.clinica_horario> cli)
        {
            try
            {
                String sentencia;
                sentencia = @"UPDATE CLINICA_HORARIO SET idclinica=@idcli, dia=@dia,
                            hora_apertura=@ha, hora_cierre=@hc, activo=@act where id=@id;";
                foreach (clases.clinica_horario clin in cli )
                { 
                    cmd = new OleDbCommand(sentencia, base.conectar());
                    cmd.Parameters.AddWithValue("@idcli", clin.Idclinica);
                    cmd.Parameters.AddWithValue("@dia", clin.Dia);
                    cmd.Parameters.AddWithValue("@ha", clin.Hora_aper);
                    cmd.Parameters.AddWithValue("@hc", clin.Hora_cierre);
                    cmd.Parameters.AddWithValue("@act", clin.Activo);
                    cmd.Parameters.AddWithValue("@id", clin.Id);
                    cmd.ExecuteNonQuery();

                    Console.WriteLine(cmd.Parameters[5].Value.ToString());
                    base.cerrar();
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                base.cerrar();
                return false;

            }
        }

        /*Encapsuladores publicos*/
        public bool exis_doctores()
        {
            return existencias_doctores();
        }
        public int guarda_usuarios(clases.usuarios u)
        {
            return guardarDatosUsuario(u);
        }
        public int guarda_clinica(clases.clinica cli)
        {
            return guardarDatosClinica(cli);
        }
        public int transaccion_telefonos_clinica(clases.clinica c, clases.telefonos tel)
        {
            return guardando_clinica_telefono(c, tel);
        }
        public int transaccion_agrega_telefono_clinica(clases.telefonos tel, string idcli)
        {
            return guardando_telefonos(tel, idcli);
        }
        public bool actualiza_telefono(clases.telefonos tel)
        {
            return actualizar_telefono(tel);
        }
        public bool actualiza_horarios(List<clases.clinica_horario> cli)
        {
            return actualizar_horarios(cli);
        }
        public bool actualiza_clinica(clases.clinica cli)
        {
            return actualizar_clinica(cli);
        }
        public DataTable datos_horarios(string id)
        {
            return datosHorarios(id);
        }
        public int guardando_horarios(clases.clinica_horario cli)
        {
            return guardandoHorarios(cli);
        }

    }
}
