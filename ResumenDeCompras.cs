using System;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmCompras : Form
    {
        string tabla = "SELECT numero AS NUMERO, proveedor AS PROVEEDOR, total AS IMPORTE, fecha AS FECHA  FROM compras WHERE oculto!= 1";
        public frmCompras()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void frmcompras_Load(object sender, EventArgs e)
        {
            rbtbuscarporcompra.Checked = true;

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvtodaslascompras, tabla);

        }

        private void dgvtodaslasventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbtbuscarporventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbbuscarventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbbuscarventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (rbtbuscarporcompra.Checked)
                {
                    if (txbbuscarcompra.Text == "")
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslascompras, tabla);
                    }
                    else
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslascompras, "SELECT numero AS NUMERO, proveedor AS PROVEEDOR, total AS IMPORTE, fecha AS FECHA  FROM compras WHERE oculto!= 1 and numero REGEXP  '" + txbbuscarcompra.Text + "'");
                    }
                }
                else if (rbtbuscrapornombrecliente.Checked)
                {
                    if (txbbuscarcompra.Text == "")
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslascompras, tabla);
                    }
                    else
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslascompras, "SELECT numero AS NUMERO, proveedor AS PROVEEDOR, total AS IMPORTE, fecha AS FECHA  FROM compras WHERE oculto!= 1 and proveedor REGEXP '" + txbbuscarcompra.Text + "'");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el criterio de búsqueda");
                }
            }
        }

        private void btnnuevacompra_Click(object sender, EventArgs e)
        {
            frmventa ventas = new frmventa();
            ventas.Show();
            this.Hide();
        }

        private void chbordenarporfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbordenarporfecha.Checked == true)
            {


                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslascompras, "SELECT numero AS NUMERO, proveedor AS PROVEEDOR, total AS IMPORTE, fecha AS FECHA  FROM compras WHERE oculto != 1 ORDER BY fecha");

            }
            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslascompras, tabla);
            }
        }

        private void chbordenarportotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbordenarportotal.Checked == true)
            {


                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslascompras, "SELECT numero AS NUMERO, proveedor AS PROVEEDOR, total AS IMPORTE, fecha AS FECHA  FROM compras WHERE oculto != 1 ORDER BY total DESC");

            }

            else if (chbordenarportotal.Checked == true && chbordenarporfecha.Checked == true)
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslascompras, "SELECT numero AS NUMERO, proveedor AS PROVEEDOR, total AS IMPORTE, fecha AS FECHA  FROM compras WHERE oculto != 1 fecha, ventas ORDER BY total DESC");


            }

            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslascompras, tabla);
            }

        }

        private void txbinicio_Click(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Close();

        }

        private void datedesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
