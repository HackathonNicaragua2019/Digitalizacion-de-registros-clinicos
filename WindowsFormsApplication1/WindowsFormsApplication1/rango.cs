using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cconectar;

namespace WindowsFormsApplication1
{
    public partial class rango : Form
    {
        public rango()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = string.Format("Select * from pacientes where f_inicio betwen '{0}' and '{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
            dataGridView1.DataSource = utilidades.ejecutar(cadena);
        }

        private void rango_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = utilidades.llenarDTW("atenciones").Tables[0];

        }
    }
}
