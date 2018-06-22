using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;    

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand _comando;
        private static SqlConnection _conexion;

        static PaqueteDAO()
        {
            _conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            _comando = new SqlCommand();
            _comando.CommandType = CommandType.Text;//tipo de comando
            _comando.Connection = _conexion;//hago conexion
        }

        public static bool Insertar(Paquete p)
        {
            bool retValue = false;
            string sql = "INSERT into Paquetes (direccionEntrega, trackingID, alumno) VALUES(";
            sql += "'" + p.DireccionEntrega + "','" + p.TrackingID + "', 'Moreno.Samantha')";
            try
            {
                _comando.CommandText = sql;
                _conexion.Open();
                int data = _comando.ExecuteNonQuery();
                if (data == 1)
                {
                    retValue = true;
                }
                _conexion.Close();
            }
            catch(Exception e)
            {
                retValue = false;
                throw e;
            }
            finally
            {
                _conexion.Close();
            }
            return retValue;
        }
    }
}
