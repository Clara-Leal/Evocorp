using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
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


          
            public void consultar(string sql)
            {

            try
            {
                conexion.Open();

                MySqlCommand consulta = new MySqlCommand(sql, conexion);
                consulta.ExecuteNonQuery(); //Sin retorno de datos

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
            }
                
            }

            public void actualizar()
              {
          
            try
                  {
                      MySqlCommand consulta = new MySqlCommand("SELECT * FROM productos;", conexion);

                      MySqlDataAdapter adaptador = new MySqlDataAdapter();
                      adaptador.SelectCommand = consulta; //Obtiene retorno de datos

                      DataTable tabla = new DataTable();
                      adaptador.Fill(tabla);

                     
            }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Error al actualizar: " + ex.ToString());
                  }
              }
        
    }
}
