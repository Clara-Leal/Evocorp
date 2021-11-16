using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmcambiarcontraseña : Form
    {
        public frmcambiarcontraseña()
        {
            InitializeComponent();
        }

        private void frmcambiarcontraseña_Load(object sender, EventArgs e)
        {

        }

		public void enviarCorreo(string emisor, string contrasenia, string receptor, string mensaje)
		{

			conexiones conectar = new conexiones();
			conectar.conectar();

			DataTable consulta = conectar.consultarsql("SELECT 'usuario', 'correo', 'documento' from usuarios");


			Random r = new Random();
			int codigo = r.Next(1000, 10000);

			SmtpClient cliente = new SmtpClient();
			cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
			cliente.Port = 587; //465
			cliente.EnableSsl = false;
			cliente.Credentials = new NetworkCredential(emisor, contrasenia);
			cliente.Host = "smtp.gmail.com";

			MailMessage correo = new MailMessage();

			correo.To.Add(receptor;
			correo.CC.Add("claralealzamit@gmail.com");

			correo.Subject = "Login del sistema";
			correo.SubjectEncoding = Encoding.UTF8;

			correo.Body = "su codigo de verificación es " + codigo;
			correo.BodyEncoding = Encoding.UTF8;
			correo.IsBodyHtml = true;

			correo.From = new MailAddress(emisor);

			try
			{
				cliente.Send(correo);
				MessageBox.Show("¡Mensaje enviado!");
			}
			catch (Exception error)
			{
				MessageBox.Show("No se ha podido enviar el correo\n\n" + error.ToString());
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			frminicio inicio = new frminicio();
			inicio.Show();
			this.Hide();
			//txbusuario.Text = "Nombre de usuario";

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
				consulta.CommandText = ("select * from usuarios where usuario= '" + txbusuario.Text + "' AND contraseña= sha('" + txbcontraseña.Text + "'); ");
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

		private void button1_Click(object sender, EventArgs e)
		{


			private void btnEnviar_Click(object sender, EventArgs e)
			{
				enviarCorreo(txbEmisor.Text, txbContraseña.Text, txbReceptor.Text, txbMensaje.Text);
			}

			private void btnVer_Click(object sender, EventArgs e)
			{
				if (btnVer.Text == "Mostrar")
				{
					txbContraseña.PasswordChar = '\0'; // \0 = Char vacío
					btnVer.Text = "Ocultar";
				}
				else
				{
					txbContraseña.PasswordChar = '*';
					btnVer.Text = "Mostrar";
				}
			}
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
