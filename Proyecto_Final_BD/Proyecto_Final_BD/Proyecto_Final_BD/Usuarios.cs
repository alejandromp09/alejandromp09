using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_Final_BD
{
    class Usuarios : Conexion
    {
        private string usuario;
        private string contrasena;

        public Usuarios()
        {
            usuario = string.Empty;
            contrasena = string.Empty;
            this.sql = string.Empty;
        }

        public string Usuario
        {
            get {return this.usuario;}
            set {this.usuario = value;}
        }

        public string Contrasena
        {
            get { return this.contrasena; }
            set { this.contrasena = value; }
        }

        public bool buscar()
        {
            bool busqueda = false;
            this.sql = String.Format(@"SELECT matricula FROM alumno WHERE matricula = '{0}' AND contrasena = '{1}'", this.usuario, this.contrasena);
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
