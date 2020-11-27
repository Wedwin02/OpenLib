using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataManager.CLS
{
    public class DBOperacion : DBConexion
    {
        public Int32 Insertar(String pSentence)
        {
            return EjecutarSentencia(pSentence);
        }

        public Int32 Actualizar(String pSentence)
        {
            return EjecutarSentencia(pSentence);
        }

        public Int32 Eliminar(String pSentence)
        {
            return EjecutarSentencia(pSentence);
        }

       
        private Int32 EjecutarSentencia(String pSentencia)
        {
            Int32 FilasAfectadas = 0;
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                if (base.Conectar())
                {
                    cmd.Connection = base._CONEXION;
                    cmd.CommandText = pSentencia;
                    FilasAfectadas = cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                FilasAfectadas = -1;
            }
            finally
            {
                base.Desconectar();
            }

            return FilasAfectadas;
        }

        public DataTable Consultar(String pConsulta)
        {
            DataTable result = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            try
            {
                if (base.Conectar())
                {
                    cmd.Connection = base._CONEXION;
                    cmd.CommandText = pConsulta;
                    Adapter.SelectCommand = cmd;
                    Adapter.Fill(result);
                  
                }
            }
            catch
            {
                result = new DataTable();
            }
            finally
            {
                base.Desconectar();
            }

            return result;
        }
    }
}
