using MySql.Data.MySqlClient;
using System;
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


            string sql = "INSERT INTO usuarios (usuario, contraseña, nombre, apellido, documento, correo) VALUES ('" + txbusuario.Text + "', sha2('" + txbcontraseña.Text + "', 256), '" + txbnombre.Text + "', '" + txbapellido.Text + "', " + txbcedula.Text + ", '" +txbcorreo.Text+"' );";

            consultar.consultar(sql);
            MessageBox.Show("Usuario Agregado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmlogin login = new frmlogin();
            login.Show();
            this.Hide();
        }

        private void frmnuevo_usuario_Load(object sender, EventArgs e)
        {

        }

        private void txbusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
