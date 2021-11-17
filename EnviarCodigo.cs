using MySql.Data.MySqlClient;
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

		public void enviarCorreo(string nom)
		{
			

			conexiones conectar = new conexiones();
			conectar.conectar();

			conexiones conexion = new conexiones();
			
			DataTable consulta = conectar.consultarsql("SELECT 'usuario', 'correo', 'documento' from usuarios WHERE usuario ='" + nom +"'");

			string nombre;

			foreach (DataRow fila in consulta.Rows)
			{
				nombre = fila[2].ToString();

				MessageBox.Show(fila[2].ToString());

				Random r = new Random();
			int codigo = r.Next(1000, 10000);


				//string nombre;

				//&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

			conexiones conectar = new conexiones();
			conectar.conectar();

			conexiones conexion = new conexiones();

			DataTable consulta = conectar.consultarsql("SELECT 'usuario', 'correo', 'documento' from usuarios WHERE usuario ='" + txbnombredeusuario + "'");


			foreach (DataRow fila in consulta.Rows)
			{


				MessageBox.Show(fila[0].ToString());
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int codigo = r.Next(100000, 1000000);
         
            string emisor= "consultas.EvoCorp@gmailcom", receptor=txbcorreo.Text, mensaje= ("Su còdigo de verificación es:" + codigo);
            

             

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 578);
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;   
                //cliente.Port = 587; //465
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential(emisor, "evocorps.r.l.");
               // cliente.Host = "smtp.gmail.com";

          

            MailMessage correo = new MailMessage();

                correo.To.Add(receptor);
                //correo.CC.Add("jferreira@docente.ceibal.edu.uy");

                correo.Subject = "Recuperación de contraseña";
                //correo.SubjectEncoding = Encoding.UTF8;
                correo.Body = mensaje;
                //correo.BodyEncoding = Encoding.UTF8;
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
    }
}
