using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace conexionBD
{
    public class conexion
    {
        string CadenaConexion;
        protected OleDbConnection cnn;
        protected OleDbDataAdapter Adaptador;
        protected OleDbCommandBuilder Constructor;

        public OleDbConnection conectar()
        {
            try
            {

                CadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=clinica_2.mdb;Persist Security Info=True;";
                cnn = new OleDbConnection(CadenaConexion);
                cnn.Open();
                return cnn;
            }
            catch
            {
                return cnn = null;
            }
        }
        public void cerrar()
        {
                cnn.Close();  
        }

    }
}
