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
    public partial class Atender_consultas : Form
    {
        public Atender_consultas()
        {
            InitializeComponent();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicos med = new medicos();
            med.Show();
            this.Hide();


        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inicio init = new inicio();
            init.Show();
            this.Hide();
        }

        private void Atender_consultas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
