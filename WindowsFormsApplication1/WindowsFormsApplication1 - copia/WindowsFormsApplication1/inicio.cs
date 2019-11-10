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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();

        }
        public static string global = "";


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { if (string.IsNullOrEmpty(textBox2.Text.Trim())==false) {
                try
                {
                    string solicitud = string.Format("SELECT * FROM usuarios where n_usuario='{0}'and pasword='{1}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                    DataSet carrito = utilidades.ejecutar(solicitud);
                    string txt1 = carrito.Tables[0].Rows[0]["n_usuario"].ToString();
                    string txt2 = carrito.Tables[0].Rows[0]["pasword"].ToString();
                    string caso = carrito.Tables[0].Rows[0]["funcion"].ToString();
                    global = carrito.Tables[0].Rows[0]["n_usuario"].ToString();

                    if (txt1 == textBox1.Text.Trim() && txt2 == textBox2.Text.Trim())
                    {
                        switch (caso)
                        {
                            case "medico":
                                medicos medico = new medicos();
                                this.Hide();
                                medico.Show();
                                ; break;
                            case "enfermeria":
                                enfermeria enfermero = new enfermeria();
                                this.Hide();
                                enfermero.Show();
                                ; break;
                            case "administrador":
                                administracion admon = new administracion();
                                this.Hide();
                                admon.Show();
                                ; break;
                            case "farmacia":
                                farmacia balance = new farmacia();
                                this.Hide();
                                balance.Show();
                                ; break;
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("usuario o contraseña incorrecta ");//saco vacio se dobla
                    textBox1.ResetText();
                    textBox2.ResetText();//ya comi ahora puedo seguir

                }

            } else { textBox2.Focus(); } }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.ResetText();
            textBox2.ResetText();
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void medicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            inicio h = new inicio();
            h.Close();
        }
    }
}