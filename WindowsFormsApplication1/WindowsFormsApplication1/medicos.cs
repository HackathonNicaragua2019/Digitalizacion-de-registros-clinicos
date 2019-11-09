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
    public partial class medicos : Form
    {
        public medicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void medicos_Load(object sender, EventArgs e)
        {
            string solicitud = string.Format("select * from usuarios where n_usuario='{0}'", inicio.global);
            DataSet carrito = utilidades.ejecutar(solicitud);
            lblusuario.Text = carrito.Tables[0].Rows[0]["n_usuario"].ToString();
            lblnombre.Text = carrito.Tables[0].Rows[0]["nombre"].ToString();
            lblfuncion.Text = carrito.Tables[0].Rows[0]["funcion"].ToString();
            lblespecialidad.Text = carrito.Tables[0].Rows[0]["especialidad"].ToString();
            lbldireccion.Text = carrito.Tables[0].Rows[0]["direccion"].ToString();
            lblcodigo.Text = carrito.Tables[0].Rows[0]["cod_minsa"].ToString();
            lbltelefono.Text = carrito.Tables[0].Rows[0]["n_telefono"].ToString();
        }
    }
}
