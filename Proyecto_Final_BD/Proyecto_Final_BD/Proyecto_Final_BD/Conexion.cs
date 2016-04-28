using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Final_BD
{
    class Conexion
    {
        public string cadenaconexion;
        protected string sql;
        protected SqlConnection cnn;
        protected SqlCommand comandosql;

        public Conexion()
        {
            this.cadenaconexion = (@"Data Source=CARRILLO; Initial Catalog =Final_BD; integrated security =true ");
            this.cnn = new SqlConnection(this.cadenaconexion);

        }
    }
}
