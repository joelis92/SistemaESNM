using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace abastecimiento
{
   public static class Comun
    {
        public static SqlConnection establecer_conexion = new SqlConnection("data source= oclockserver.database.windows.net; initial catalog = Abastecimiento; user id = Joel_is92; password = Crusta36");
    }
}
