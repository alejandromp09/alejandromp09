using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Final_BD
{
    public partial class Cita : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=CARRILLO; Initial Catalog =Final_BD; integrated security =true ");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader read;
        public string id_ad;
        public int id_c;

        public Cita()
        {
            InitializeComponent();
        }

        private void Cita_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final_BDDataSet.horarios' table. You can move, or remove it, as needed.
            this.horariosTableAdapter.Fill(this.final_BDDataSet.horarios);
            cmd.Connection = con;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio x = new Inicio();
            x.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (horaComboBox.Text == "11:00:00" || horaComboBox.Text == "15:00:00")
            {
                id_ad = "L01010202";
                if (horaComboBox.Text == "11:00:00")
                {
                    id_c = 1;
                }
                else if (horaComboBox.Text == "15:00:00")
                {
                    id_c = 3;
                }
            }
            else if (horaComboBox.Text == "12:00:00" || horaComboBox.Text == "16:00:00")
            {
                id_ad = "L02020101";
                if (horaComboBox.Text == "12:00:00")
                {
                    id_c = 2;
                }
                else if (horaComboBox.Text == "16:00:00")
                {
                    id_c = 4;
                }
            }
            if (textBox1.Text != "" & textBox2.Text != "")
            {
                con.Open();
                cmd.CommandText = "INSERT INTO alumno_admin_cita (matricula, nomina, id_cita, fecha) VALUES ('" + textBox1.Text+ "', '"+id_ad+ "', '" + id_c + "', '" + textBox2.Text + "')";
                //cmd.CommandText = "DELETE FROM alumno_admin_cita WHERE matricula = 'A19403217'";
                cmd.ExecuteNonQuery();
                cmd.Clone();
                con.Close();
                //textBox1.Text = "";
            }
            Registro_Exitoso x = new Registro_Exitoso();
            x.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
