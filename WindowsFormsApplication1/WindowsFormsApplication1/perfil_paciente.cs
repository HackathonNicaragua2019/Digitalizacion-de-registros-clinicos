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
    public partial class perfil_paciente : Form
    {
        public perfil_paciente()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void perfil_paciente_Load(object sender, EventArgs e)

        { 
            string solicitud = string.Format("select * from pacientes where expediente="+buscar.variable);
            DataSet carrito = utilidades.ejecutar(solicitud);
            nombrel.Text = carrito.Tables[0].Rows[0]["nombre"].ToString();
          direccionl.Text = carrito.Tables[0].Rows[0]["direccion"].ToString();
            telefonol.Text = carrito.Tables[0].Rows[0]["n_telefono"].ToString();
            string hr = carrito.Tables[0].Rows[0]["id"].ToString();
            nacl.Text = carrito.Tables[0].Rows[0]["f_nac"].ToString();
            expedientel.Text = carrito.Tables[0].Rows[0]["expediente"].ToString();
            

            DataSet consulta;
            string cmd = ("select * from alergias where expediente="+buscar.variable);
            consulta = utilidades.ejecutar(cmd);
            dataGridView1.DataSource = consulta.Tables[0];

          /*  DataSet alone;
            string sol2 = ("select * from incidencias where expediente ="+buscar.variable);
            alone = utilidades.ejecutar(sol2);
            dataGridView2.DataSource = alone.Tables[0];*/
            


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void expedientel_Click(object sender, EventArgs e)
        {

        }

        private void telefonol_Click(object sender, EventArgs e)
        {

        }

        private void direccionl_Click(object sender, EventArgs e)
        {

        }

        private void nombrel_Click(object sender, EventArgs e)
        {

        }
    }
}
