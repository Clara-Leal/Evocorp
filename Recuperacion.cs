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
            enviar_email email = new enviar_email();
            numero = email.enviar("consultas.evocorp@gmail.com", "EvoCorp2021", txbusuario.Text);
            DialogResult result = DialogResult.OK;
            
            MessageBox.Show("Se ha enviado un código de vrificación al mail indicado, ingréselo para cambiar la contraseña");

           
         
            
            /*  if (numero != 0)
            {


                try
                {
                   resultado = Convert.ToInt32(Interaction.InputBox("Ingresa el digito", "Restaurar contraseña"));
                }
                catch (Exception)
                {
                    MessageBox.Show("caractaeres no válidos");
                   
                }
                if (numero == resultado)
                {
                    MessageBox.Show
                }
            }
            else
            {
               result = MessageBox.Show("No se puedo enviar email", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnrecuperarContraseña_Click(object sender, EventArgs e)
        {
            if (txbcodigo.Text == numero.ToString())
            {
                frmcambiarcontraseña cambiar = new frmcambiarcontraseña();
                cambiar.Show();

            }
        }
    }
}
