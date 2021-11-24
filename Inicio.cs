using System;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            lblhora.Text = String.Format("{0:G}", DateTime.Now);
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
            frmresumenVentas resumenventas = new frmresumenVentas();
            resumenventas.Show();
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
            timer1.Enabled = true;
            timer2.Enabled = true;

            timer3.Enabled = true;


            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
            this.Hide();
        }

        private void btnproveedor_Click(object sender, EventArgs e)
        {
            frmproveedores proveedor = new frmproveedores();
            proveedor.Show();
            this.Hide();
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            frmresumencompras compras = new frmresumencompras();
            compras.Show();
            this.Hide();
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            frmnuevo_usuario usuario = new frmnuevo_usuario();
            usuario.Show();
            this.Close();
        }

        private void btncliente_Click_1(object sender, EventArgs e)
        {
            frmCliente clientescliene = new frmCliente();
            clientescliene.Show();
            this.Hide();
        }
    }
}
