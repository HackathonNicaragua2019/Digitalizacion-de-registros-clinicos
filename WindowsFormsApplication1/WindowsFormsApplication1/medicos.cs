﻿using System;
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
            lblespecialidad.Text = carrito.Tables[0].Rows[0]["especialialidad"].ToString();
            lbldireccion.Text = carrito.Tables[0].Rows[0]["direccion"].ToString();
            lblcodigo.Text = carrito.Tables[0].Rows[0]["cod_minsa"].ToString();
            lbltelefono.Text = carrito.Tables[0].Rows[0]["n_telefono"].ToString();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            inicio login = new inicio();
            this.Hide();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            consulta_atenciones at = new consulta_atenciones();
            at.Show();

        }

        private void medicos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Atender_consultas atc = new Atender_consultas();
            atc.Show();
        }
    }
}
