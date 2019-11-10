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
    public partial class salidas : Form
    {
        public salidas()
        {
            InitializeComponent();
        }

        private void salidas_Load(object sender, EventArgs e)
        {
           
            this.existenciaTableAdapter1.Fill(this.depositoDataSet1.existencia);
             string solicitud = string.Format("select * from usuarios where n_usuario='{0}'", inicio.global);
            DataSet carrito = utilidades.ejecutar(solicitud);
            nombre.Text = carrito.Tables[0].Rows[0]["nombre"].ToString();
           
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
