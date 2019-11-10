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
    public partial class consultar_pacientes : Form
    {
        public consultar_pacientes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0) { return; }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void consultar_pacientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = utilidades.llenarDTW("pacientes").Tables[0];
            string solicitud = string.Format("select * from usuarios where n_usuario='{0}'", inicio.global);
            DataSet carrito = utilidades.ejecutar(solicitud);
            lblusuario.Text = carrito.Tables[0].Rows[0]["nombre"].ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            enfermeria enfermero = new enfermeria();
            enfermero.Show();
        }
    }
}
