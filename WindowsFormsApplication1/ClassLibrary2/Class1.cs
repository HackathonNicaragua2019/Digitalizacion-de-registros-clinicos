using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace cconectar
{
    public class utilidades
    {
        public static DataSet ejecutar(string instruccion)
        {
            SqlConnection abrir = new SqlConnection(@"Data Source=DESKTOP-S9OPL2R\SQLEXPRESS;Initial Catalog=deposito;Integrated Security=True");
            abrir.Open();
            DataSet carrito = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(instruccion, abrir);
            adaptador.Fill(carrito);
            abrir.Close();

            return (carrito);
        }
        public static DataSet llenarDTW(string tabla)
        {
            DataSet llenado;
            string solicitud = string.Format("Select * from "+tabla);
            llenado = utilidades.ejecutar(solicitud);
            return llenado;
        }
        public static DateTime fecha= DateTime.Now;

    }
    
}

