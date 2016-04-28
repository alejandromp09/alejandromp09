﻿using System;
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
    public partial class Info_Alumnos : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=CARRILLO; Initial Catalog =Final_BD; integrated security =true ");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader read;

        public Info_Alumnos()
        {
            InitializeComponent();
        }

        private void Info_Alumnos_Load(object sender, EventArgs e)
        {
            cmd.Connection = con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio x = new Inicio();
            x.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                //textBox1.Text = "";
                loadlist();
            }
        }

        private void loadlist()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            con.Open();
            cmd.CommandText = "SELECT nombre, promedio, nivel_e FROM alumno WHERE matricula IN(SELECT matricula FROM alumno_admin_cita WHERE nomina = '" + textBox1.Text + "')";
            read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                while (read.Read())
                {
                    listBox1.Items.Add(read[0].ToString());
                    listBox2.Items.Add(read[1].ToString());
                    listBox3.Items.Add(read[2].ToString());
                }
            }
            con.Close();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {
                listBox1.SelectedIndex = l.SelectedIndex;
                listBox2.SelectedIndex = l.SelectedIndex;
                listBox3.SelectedIndex = l.SelectedIndex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostrar_Citas x = new Mostrar_Citas();
            x.Show();
            this.Close();
        }
    }
}
