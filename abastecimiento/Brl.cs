using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace abastecimiento
{
   
   public static class Brl
    {
        public static int logearUsuario(string usuario, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Logeo_buscarUsuario_q_sp", Comun.establecer_conexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);
                SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
                existe.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(existe);
                Comun.establecer_conexion.Open();
                cmd.ExecuteReader().Close();
                Comun.establecer_conexion.Close();
                return (int)existe.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
