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
    public partial class consultar_medicamentos : Form
    {
        public consultar_medicamentos()
        {
            InitializeComponent();
        }

        private void consultar_medicamentos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = utilidades.llenarDTW("existencia").Tables[0];
            string solicitud = string.Format("select * from usuarios where n_usuario='{0}'", inicio.global);
            DataSet carrito = utilidades.ejecutar(solicitud);
            lblusuario.Text = carrito.Tables[0].Rows[0]["nombre"].ToString();
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

        private void consultar_medicamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                DataSet consulta;
                string cmd = "select * from medicamentos where nombre like ('%" + textBox1.Text.Trim() + "%')";
                consulta = utilidades.ejecutar(cmd);
                dataGridView1.DataSource = consulta.Tables[0];
            }
        }
    }
}
