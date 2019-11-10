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
    public partial class administracion : Form
    {
        public administracion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string solicitud = string.Format("select * from usuarios where n_usuario='{0}'", inicio.global);
            DataSet carrito = utilidades.ejecutar(solicitud);
            lblusuario.Text = carrito.Tables[0].Rows[0]["n_usuario"].ToString();
            lblnombre.Text = carrito.Tables[0].Rows[0]["nombre"].ToString();
            lblfuncion.Text = carrito.Tables[0].Rows[0]["funcion"].ToString();
            lblespecialidad.Text = carrito.Tables[0].Rows[0]["especialialidad"].ToString();
            lbldireccion.Text = carrito.Tables[0].Rows[0]["direccion"].ToString();
            lbltelefono.Text = carrito.Tables[0].Rows[0]["n_telefono"].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inicio login = new inicio();
            this.Close();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cambiar_contraseña chance = new Cambiar_contraseña();
            chance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cambiar_usuario username = new cambiar_usuario();
            username.Show();
        }
    }
}
