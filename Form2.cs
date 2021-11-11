using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
           

            frmproductos inicio = new frmproductos();
            inicio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EV SOFTWARE DE GESTIÓN \nDesarrolladores: \n" +
                "Clara Leal, Santiago Dupontt, Nicole Jorge, Braian Corrales, Franco Fernandez \nUTU Catalina Harriague de Castaños \nEMT informática 2021 " +
                "\n EVOCORP MANAGEMENT SOFTWARE \n Developers: " +
                "\n Clara Leal, Franco Fernandez, Santiago Dupont, Nicole Jorge, Braian Corrales \n UTU Catalina Harriague de Castaños \n EMT Computing(IT) 2021");

        }

        private void btnventa_Click(object sender, EventArgs e)
        {
            frmventa venta = new frmventa();
            venta.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btncambiar_usuario_Click(object sender, EventArgs e)
        {
            frmlogin usuario = new frmlogin();
            usuario.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void frminicio_Load(object sender, EventArgs e)
        {
           
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            frmingreso_clientes cliente = new frmingreso_clientes();
            cliente.Show();
            this.Hide();
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            frmproveedores proveedor = new frmproveedores();
            proveedor.Show();
            this.Hide();
        }
    }
}
