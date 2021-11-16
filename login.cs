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
using System.Net; //Necesario al crear credenciales
using System.Net.Mail;



namespace EvoCorp

{
	public partial class frmlogin : Form
	{
		
		
		public frmlogin()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;

		}
		
	
		

		private void logo_inicio_Click(object sender, EventArgs e)
		{

		}

		private void txbcontraseña_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
			{
				try
				{
					MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=la_rubia; Uid=general1; Pwd=larubia2021;");
					conexion.Open();
					MySqlCommand consulta = new MySqlCommand();
					MySqlConnection conectarnos = new MySqlConnection();
					consulta.Connection = conexion;
					consulta.CommandText = ("select * from usuarios where usuario= '" + txbusuario.Text + "' AND contraseña= '" + txbcontraseña.Text + "' ");
					MySqlDataReader datos = consulta.ExecuteReader();
					if (datos.Read())
					{

						frminicio inicio = new frminicio();
						inicio.Show();
						this.Hide();


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

		}

		private void txbcontraseña_TextChanged(object sender, EventArgs e)
		{

		}

		private void txbusuario_TextChanged(object sender, EventArgs e)
		{

		}

		private void txbusuario_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
			{
				
				
				try
				{
					MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=la_rubia; Uid=general1; Pwd=larubia2021;");
					conexion.Open();
					MySqlCommand consulta = new MySqlCommand();
					MySqlConnection conectarnos = new MySqlConnection();
					consulta.Connection = conexion;
					consulta.CommandText = ("select *from login where usuario= '" + txbusuario.Text + "' AND contraseña= '" + txbcontraseña.Text + "' ");
					MySqlDataReader datos = consulta.ExecuteReader();
					if (datos.Read())
					{

						frminicio inicio = new frminicio();
						inicio.Show();
						this.Hide();


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
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			/*Random codigo = new Random();
			int numero = codigo.Next(100000, 1000000);
			MailMessage msg = new MailMessage();
			msg.To.Add("jerealcain@gmail.com");
			msg.Subject = "Correo de Verificacion";
			msg.SubjectEncoding = Encoding.UTF8;
			msg.Body = "Su codigo de verificaion es " + numero + " porfavor ingreselo";
			msg.BodyEncoding = Encoding.UTF8;
			msg.IsBodyHtml = true;
			msg.From = new MailAddress("udesoftware@gmail.com");
			SmtpClient client = new SmtpClient();
			client.Credentials = new NetworkCredential("udesoftware@gmail.com", "udesoftware2021!");
			client.Port = 587;
			client.EnableSsl = true;
			client.Host = "smtp.gmail.com";

			try
			{
				client.Send(msg);
				MessageBox.Show("¡Mensaje enviado!");
			}
			catch (Exception error)
			{
				MessageBox.Show("No se ha podido enviar el correo\n\n" + error.ToString());
				numero = 0;
			}

			DialogResult result = DialogResult.No;

			do
			{
				int resultado = 0;
				if (numero != 0)
				{

					resultado = Convert.ToInt32(Interaction.InputBox("Ingrese el codigo de verificacion ", "Verificacion"));
				}

				if (numero == resultado)
				{

					MessageBox.Show("Acceso permitido, su contraseña es Uruguay1101");

					result = DialogResult.No;
					new Main().Show();
					this.Hide();

				}

				else
				{
					MessageBox.Show("Acceso Denegado");
					result = MessageBox.Show("¿Desea reenviar el correo?", "CODIGO INCORRECTO!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

				}

			} while (result == DialogResult.Yes);*/
		}

        private void txbusuario_Leave(object sender, EventArgs e)
        {
			

		}
    }
}


