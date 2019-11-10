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
    public partial class entradas : Form
    {
        public entradas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string solicitud = string.Format("insert into entradas(Fecha_de_salida,Nombre_medicamento,cantidad) values('{0}','{1}'.'{2}'", textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim());
                utilidades.ejecutar(solicitud);
                MessageBox.Show("Agregado a Existencias");
                string sol = string.Format("UPDATE existencia SET Existencias +'{1}' WHERE Nombre_de_Medicamento = '{0}'", textBox1.Text.Trim(), textBox2.Text.Trim());
                utilidades.ejecutar(sol);
                MessageBox.Show("Agregado Correctamente");
            }
            catch (Exception error) { MessageBox.Show("No se ha podido agregar, verifique el nombre del medicamento sea correcto"+ error); } 
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
