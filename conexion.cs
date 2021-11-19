using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EvoCorp
{
    class conexiones
    {
        MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=la_rubia; Uid=general1; Pwd=larubia2021;");




        public void conectar()
        {


            try
            {
                conexion.Open();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.ToString());
            }

        }

        public void abrirConexion()
        {
            try
            {
                conexion.Open();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.ToString());
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.ToString());
            }
        }


        public void consultar(string sql)
        {

            try
            {
                conexion.Open();

                MySqlCommand consulta = new MySqlCommand(sql, conexion);
                consulta.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }

        }

        public DataTable consultarsql(string consultasql)
        {
            DataTable tabla = new DataTable();
            try
            {
                MySqlCommand consulta = new MySqlCommand(consultasql, conexion);

                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = consulta;


                adaptador.Fill(tabla);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.ToString());

            }
            return tabla; //reubicar
        }





        public void actualizar(DataGridView mitabla, string con)
        {
            try
            {
                MySqlCommand consulta = new MySqlCommand(con, conexion);   //"SELECT * FROM productos;"

                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = consulta;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                mitabla.DataSource = tabla;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.ToString());
            }
        }








    }
}
