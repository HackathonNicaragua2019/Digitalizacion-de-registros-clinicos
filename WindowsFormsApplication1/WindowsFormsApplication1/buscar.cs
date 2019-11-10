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
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }
        public static string variable = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                variable = textBox1.Text.Trim();
                string solicitud = string.Format("select * from pacientes where expediente='{0}'", buscar.variable);
                DataSet carrito = utilidades.ejecutar(solicitud);
                perfil_paciente h = new perfil_paciente();
                h.Show();
                this.Hide();
            }
            catch (Exception error) { MessageBox.Show("paciente no encontrado"+error.Message); }
        }

        private void buscar_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medicos m = new medicos();
            m.Show();
            this.Hide();
        }

        private void buscar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
