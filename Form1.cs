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

			//String usuarioEncriptado = encriptacion.((txbcontraseña.Text);
			try
			{

				MySqlConnection conexion = new MySqlConnection("server=localhost; database=la_rubia;Uid=usuario1; pwd = evocorp;");

				conexion.Open();

				MySqlCommand consulta = new MySqlCommand();

				MySqlConnection conectarnos = new MySqlConnection();

				consulta.Connection = conexion;

				consulta.CommandText = ("select *from login where usuario= '" + txbusuario.Text + "' AND contraseña= '" + txbcontraseña.Text + "' ");

				MySqlDataReader datos = consulta.ExecuteReader();

				if (datos.Read())
				{
					MessageBox.Show("Acceso correcto" + txbusuario.Text);
					/*frmlogin inicio = new frmlogin();
					inicio.Show();
					this.Hide();*/
				}
				else
				{
					MessageBox.Show("Acceso denegado");
				}

			}catch (Exception ex)
			
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
