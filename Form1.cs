using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace EvoCorp

{
	public partial class frmlogin : Form
	{
		public frmlogin()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btningresar_Click(object sender, EventArgs e)
		{

			try
			{
				MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=la_rubia; Uid=general1; Pwd=larubia2021;");
				conexion.Open();
				MySqlCommand consulta = new MySqlCommand();
				MySqlConnection conectarnos = new MySqlConnection();
				consulta.Connection = conexion;
				consulta.CommandText = ("select *from login where usuario= '" +txbusuario.Text + "' AND contraseña= '" + txbcontraseña.Text + "' ");
				MySqlDataReader datos = consulta.ExecuteReader();
				if (datos.Read())
				{
					
					frminicio inicio = new frminicio();
					inicio.Show();
					this.Hide();

					MessageBox.Show("FUNCIONA SOLO EL BOTON DE PRODUCTOS ;) \n PROGRAMA EN DESARROLLO");
				}
				else
				{
					MessageBox.Show("Acceso denegado");
				}

			}
			catch (Exception ex)

			{
				MessageBox.Show(ex.ToString());


			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			frmnuevo_usuario usuario = new frmnuevo_usuario();
			usuario.Show();
			this.Hide();
		}

        private void logo_inicio_Click(object sender, EventArgs e)
        {

        }
    }
}

