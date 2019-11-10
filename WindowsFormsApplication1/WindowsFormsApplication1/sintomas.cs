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
    public partial class sintomas : Form
    {
        public sintomas()
        {
            InitializeComponent();
        }

        private void sintomas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = utilidades.llenarDTW("pacientes").Tables[0];
        }
    }
}
