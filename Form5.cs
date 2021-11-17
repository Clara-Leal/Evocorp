using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmusuario : Form
    {
        public frmusuario()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            conexiones consultar = new conexiones();

            consultar.consultar("INSERT INTO usuarios (nombre, usuario, apellido, contraseña, documento, correo ) VALUES ('" + txbnombre.Text + "','" + txbnombreusuario.Text + "', '" + txbapellido.Text + "', SHA('" + txbcontraseña.Text+ "'), '" + txbdocumento.Text + "', '" + txbcorreoelectronico.Text + "');");

            txbnombre.Text = ""; txbnombreusuario.Text = ""; txbapellido.Text = ""; txbcontraseña.Text = ""; txbdocumento.Text = ""; txbcorreoelectronico.Text = "";

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            frmlogin ingreso = new frmlogin();
            ingreso.Show();
            this.Close();
        }
    }
}
