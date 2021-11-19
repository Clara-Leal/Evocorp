using MySql.Data.MySqlClient;
using System;
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




        private void logo_inicio_Click(object sender, EventArgs e)
        {

        }

        private void txbcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {

                    if (intentos < 2)
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

                            intentos++;
                        }

                    }

                    else
                    {
                        frmusuario nuevo = new frmusuario();
                        nuevo.Show();
                        this.Hide();
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

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {

                if (intentos < 2)
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

                        intentos++;
                    }

                }

                else
                {
                    frmusuario nuevo = new frmusuario();
                    nuevo.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}


