using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_BD
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarioOb = new Usuarios();
            usuarioOb.Usuario = this.textBox1.Text;
            usuarioOb.Contrasena = this.textBox2.Text;
            Admin adminOb = new Admin();
            adminOb.Admini = this.textBox1.Text;
            adminOb.Contrasena = this.textBox2.Text;

            if (usuarioOb.buscar() == true)
            {
                this.Hide();
                Cita x = new Cita();
                x.Show();
            }
            else if (adminOb.buscar() == true)
            {
                this.Hide();
                Mostrar_Citas x = new Mostrar_Citas();
                x.Show();
            }
            else
            {
                Log_Error x = new Log_Error();
                x.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
