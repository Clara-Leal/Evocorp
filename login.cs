using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;



namespace EvoCorp

{
    public partial class frmlogin : Form
    {
        int intentos = 0;


        public frmlogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }


        public void enviarCorreo(string emisor, string contrasenia, string receptor, string mensaje)
        {
            SmtpClient cliente = new SmtpClient();
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.Port = 587; //465
            cliente.EnableSsl = false;
            cliente.Credentials = new NetworkCredential(emisor, contrasenia);
            cliente.Host = "mail.edusalto.uy";

            MailMessage correo = new MailMessage();

            correo.To.Add(receptor);
            correo.CC.Add("jferreira@docente.ceibal.edu.uy");

            correo.Subject = "Mensaje de " + emisor;
            correo.SubjectEncoding = Encoding.UTF8;

            correo.Body = mensaje;
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
            private void logo_inicio_Click(object sender, EventArgs e)
        {

        }

        private void txbcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    ingreso();
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

                this.ActiveControl = txbcontraseña;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void txbusuario_Leave(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmcambiarcontraseña inicio = new frmcambiarcontraseña();
            inicio.Show();
            this.Hide();
        }

        private void btnusuario_nuevo_Click(object sender, EventArgs e)
        {
            frmcambiarcontraseña inicio = new frmcambiarcontraseña();
            inicio.Show();
            this.Hide();

        }
        public void ingreso()
        {
            if (intentos < 2)
            {

                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=la_rubia; Uid=general1; Pwd=larubia2021;");
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand();

                consulta.Connection = conexion;
                consulta.CommandText = ("SELECT documento FROM usuarios where usuario = '" + txbusuario.Text + "' AND contraseña = '" + txbcontraseña.Text + "' ");
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

                    intentos++;
                }

            }

            else
            {
                frmcompras nuevo = new frmcompras();
                nuevo.Show();
                this.Hide();
            }
        }
        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                ingreso();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txbusuario;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}


