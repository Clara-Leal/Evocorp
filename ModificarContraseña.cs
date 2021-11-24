using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmcambiarcontraseña : Form
    {
        public frmcambiarcontraseña(string usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblusuario.Text = usuario;
        }

        private void frmcambiarcontraseña_Load(object sender, EventArgs e)
        {

        }

 
        private void button2_Click(object sender, EventArgs e)
        {
            if (txbcontraseña.Text != "")
            {
                if (txbcontraseña.Text == txbconfirmarcontraseña.Text)
                {
                    conexiones conectar = new conexiones();

                    conectar.conectar();

                    string sql = "UPDATE usuarios SET contraseña = '" + txbcontraseña.Text + "' WHERE usuario ='" + lblusuario.Text + "';";


                    conexiones consultar = new conexiones();

                    consultar.consultar(sql);

                    MessageBox.Show("La contraseña se modificó correctamente");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }

            else
            {
                MessageBox.Show("Debe ingresar una neva contraseña");
            }
            

            
        }
    }
}
