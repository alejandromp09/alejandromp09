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
    public partial class Mostrar_Registro : Form
    {
        public Mostrar_Registro()
        {
            InitializeComponent();
        }

        private void alumno_admin_citaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alumno_admin_citaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.final_BDDataSet);

        }

        private void Mostrar_Registro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final_BDDataSet.alumno_admin_cita' table. You can move, or remove it, as needed.
            this.alumno_admin_citaTableAdapter.Fill(this.final_BDDataSet.alumno_admin_cita);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio x = new Inicio();
            x.Show();
            this.Close();
        }
    }
}
