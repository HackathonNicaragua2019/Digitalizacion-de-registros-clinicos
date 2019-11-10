using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class entradas_salidas : Form
    {
        public entradas_salidas()
        {
            InitializeComponent();
        }

        private void salidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            salidas o = new salidas();
            o.MdiParent = this;
            o.Show();
            

        }
        
private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entradas i = new entradas();
            i.MdiParent = this;
            i.Show();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultar_medicamentos cm = new consultar_medicamentos();
            cm.Show();
            this.Show();
           
        }

        private void verPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            farmacia far = new farmacia();
            far.Show();
            this.Hide();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            inicio init = new inicio();
            init.Show();

        }
    }
}
