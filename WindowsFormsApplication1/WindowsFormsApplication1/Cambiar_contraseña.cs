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
    public partial class Cambiar_contraseña : Form
    {
        public Cambiar_contraseña()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void Cambiar_contraseña_Load(object sender, EventArgs e)
        {
            string solicitud = string.Format("select * from usuarios where n_usuario='{0}'", inicio.global);
            DataSet carrito = utilidades.ejecutar(solicitud);
            lblusuarios.Text = carrito.Tables[0].Rows[0]["n_usuario"].ToString();
            lblnombre.Text = carrito.Tables[0].Rows[0]["nombre"].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string solicitud = string.Format("select * from usuarios where n_usuario='{0}'", inicio.global);
                DataSet carrito = utilidades.ejecutar(solicitud);
                string contraseña = carrito.Tables[0].Rows[0]["pasword"].ToString();
                {
                    if (textBox1.Text.Trim() == contraseña && textBox2.Text.Trim() == textBox3.Text.Trim())
                    {
                        string solicitud1 = string.Format("update usuarios set pasword='{0}'  where n_usuario = '{1}'", textBox2.Text.Trim(), lblusuarios.Text.Trim());
                        DataSet carrito1 = utilidades.ejecutar(solicitud1);
                     
                        MessageBox.Show("Cambio de contraseña exitoso");
                        this.Close();
                    }else {MessageBox.Show("verfifique que la contraseña se correcta o coincida");
                        textBox1.ResetText();
                        textBox2.ResetText();
                        textBox3.ResetText();
                        textBox1.Focus();
                    }

                }
            }
            catch (Exception) { MessageBox.Show("verfifique que la contraseña se correcta o coincida");
                textBox1.ResetText();
                textBox2.ResetText();
                textBox3.ResetText();
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
