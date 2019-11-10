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
using cconectar;

namespace WindowsFormsApplication1
{
    public partial class cambiar_usuario : Form
    {
        public cambiar_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambiar_usuario_Load(object sender, EventArgs e)
        {
            string solicitud = string.Format("select * from usuarios where n_usuario='{0}'", inicio.global);
            DataSet carrito = utilidades.ejecutar(solicitud);
            lblok.Text = carrito.Tables[0].Rows[0]["n_usuario"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == textBox2.Text.Trim())
            {
                string solicitud1 = string.Format("update usuarios set n_usuario='{0}'  where n_usuario = '{1}'", textBox2.Text.Trim(), lblok.Text.Trim());
                DataSet carrito1 = utilidades.ejecutar(solicitud1);

                MessageBox.Show("Cambio de contraseña exitoso");
                this.Close();
            }
            else
            {
                MessageBox.Show("verfifique  que ambos nombres sean iguales ");
                textBox1.ResetText();
                textBox2.ResetText();
                textBox1.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
