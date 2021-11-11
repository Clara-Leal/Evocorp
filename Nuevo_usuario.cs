using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmnuevo_usuario : Form
    {
        public frmnuevo_usuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            conexiones consultar = new conexiones();


            string sql = "INSERT INTO login (usuario, contraseña, nombre, apellido, cedula) " +
               
                "VALUES ('" + txbusuario.Text + "','" + txbcontraseña.Text + "', '" + txbnombre.Text + "', '" + txbapellido.Text + "', '" + txbcedula.Text + "');";

            consultar.consultar(sql);
            MessageBox.Show("Usuario Agregado");

            conexiones actualizar = new conexiones();

           // actualizar.actualizar();
            try
            {
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM productos;");

                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = consulta; //Obtiene retorno de datos

               /* DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                dgvproductos.DataSource = "";
                dgvproductos.DataSource = tabla;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.ToString());
            }



            MessageBox.Show("Usuario registrado con éxito.");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }
    }
}
