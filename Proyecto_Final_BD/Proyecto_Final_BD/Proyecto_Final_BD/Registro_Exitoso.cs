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
    public partial class Registro_Exitoso : Form
    {
        public Registro_Exitoso()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mostrar_Registro x = new Mostrar_Registro();
            x.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio x = new Inicio();
            x.Show();
            this.Close();
        }
    }
}
