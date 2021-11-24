using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EvoCorp
{
    public partial class frmrecuperacion : Form
    {
        int numero;
        public frmrecuperacion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnenviarCodigo_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT usuario, correo FROM usuarios WHERE usuario  = '" + txbusuario.Text+ "';";

            DataTable consulta = conectar.consultarsql(sql);


            foreach (DataRow fila in consulta.Rows)
            {
                if(txbcorreo.Text == fila[1].ToString())
                {
                    enviar_email email = new enviar_email();
                    numero = email.enviar("consultas.evocorp@gmail.com", "EvoCorp2021", txbcorreo.Text);
                    DialogResult result = DialogResult.OK;

                    MessageBox.Show("Se ha enviado un código de vrificación al mail indicado, ingréselo para cambiar la contraseña");
                }
                else
                {
                    MessageBox.Show("Dirección de correo inválida, " + txbcorreo.Text + " no pertenece a ningún usuario");
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnrecuperarContraseña_Click(object sender, EventArgs e)
        {
            if (txbcodigo.Text == numero.ToString())
            {
                string usuario = txbusuario.Text;

                frmcambiarcontraseña cambiar = new frmcambiarcontraseña(usuario);
                cambiar.Show();

                this.Close();

            }
            else
            {
                MessageBox.Show("El código ingresado no es válido");
            }

            
        }

        private void frmrecuperacion_Load(object sender, EventArgs e)
        {

        }
    }
}
