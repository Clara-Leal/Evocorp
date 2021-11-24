using MySql.Data.MySqlClient;
using System;
using System.Data;
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
        public void ingreso2(string usuario, string contraseña)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT usuario, contraseña, FROM usuarios WHERE usuario  = '" + txbusuario.Text + "';";

            DataTable consulta = conectar.consultarsql(sql);


            foreach (DataRow fila in consulta.Rows)
            {
                string a = fila[1].ToString();
                MessageBox.Show(txbcontraseña.Text + a);
              
                if (txbcontraseña.Text == fila[1].ToString())
                {
                    frminicio inicio = new frminicio();
                }
                else
                {
                    MessageBox.Show("usuario o contraseña invalidos");
                }
            }
            }
            
        public void ingreso()
        {
            if (intentos <= 3)
            {

                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=la_rubia; Uid=general1; Pwd=larubia2021;");
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand();

                consulta.Connection = conexion;
                consulta.CommandText = ("SELECT documento FROM usuarios where usuario = '" + txbusuario.Text + "' AND contraseña = SHA2('" + txbcontraseña.Text + "',256) ");
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
            frmrecuperacion recuperacion = new frmrecuperacion();
            recuperacion.Show();
            this.Hide();
           
        }
    }
}


