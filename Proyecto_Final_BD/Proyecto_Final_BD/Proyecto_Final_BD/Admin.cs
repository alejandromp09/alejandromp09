using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Final_BD
{
    class Admin : Conexion
    {
        private string admin;
        private string contrasena;

        public Admin()
        {
            admin = string.Empty;
            contrasena = string.Empty;
            this.sql = string.Empty;
        }

        public string Admini
        {
            get { return this.admin; }
            set { this.admin = value; }
        }

        public string Contrasena
        {
            get { return this.contrasena; }
            set { this.contrasena = value; }
        }

        public bool buscar()
        {
            bool busqueda = false;
            this.sql = String.Format(@"SELECT nomina FROM administrador WHERE nomina = '{0}' AND contrasena = '{1}'", this.admin, this.contrasena);
            this.comandosql = new SqlCommand(this.sql, this.cnn);
            this.cnn.Open();
            SqlDataReader reg = null;
            reg = this.comandosql.ExecuteReader();
            if (reg.Read())
            {
                busqueda = true;
            }

            this.cnn.Close();
            return busqueda;
        }
    }
}
