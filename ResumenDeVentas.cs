using System;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmresumenVentas : Form
    {

        string tabla = "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE oculto!= 1";
        string fechadesde, fechahasta;
        public string numeroventa;
        public string cliente;
        public frmresumenVentas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void frmresumenVentas_Load(object sender, EventArgs e)
        {


            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvtodaslasventas, tabla);

            fechadesde = datedesde.Value.ToString("yyyy-MM-dd");
            fechahasta = datehasta.Value.ToString("yyyy-MM-dd");
        }

        private void btnnuevaventa_Click(object sender, EventArgs e)
        {
          frmventa ventas = new frmventa();
            ventas.Show();
            this.Hide();
        }

        private void txbbuscarventa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (rbtbuscarporventa.Checked)
                {


                    if (txbbuscarventa.Text == "")
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslasventas, tabla);
                    }
                    else
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslasventas, "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE oculto!= 1 and numero REGEXP  '" + txbbuscarventa.Text + "' ");
                    }
                }
                //  (fecha) BETWEEN '" + fechahasta + "' AND '" + fechadesde +
                else if (rbtbuscrapornombrecliente.Checked)
                {
                    if (txbbuscarventa.Text == "")
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslasventas, tabla);
                    }
                    else
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslasventas, "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE oculto!= 1 and cliente REGEXP  '" + txbbuscarventa.Text + "' ");
                    }
                }  ///*DATE(fecha) BETWEEN '" + fechahasta + "' AND '" + fechadesde + "' ANd *
                else
                {
                    MessageBox.Show("Seleccione el criterio de búsqueda");
                }
            }


        }

        private void lblprobarfecha_Click(object sender, EventArgs e)
        {

        }

        private void chbordenarporfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbordenarporfecha.Checked == true)
            {


                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, "SELECT  numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA FROM ventas WHERE oculto!= 1 and cliente REGEXP  '" + txbbuscarventa.Text + "' ORDER BY fecha ");

            }
            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, "SELECT  numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA FROM ventas WHERE oculto!= 1 and  REGEXP  '" + txbbuscarventa.Text + "' ORDER BY fceha DESC");
            }
        }

        private void chbordenarportotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbordenarportotal.Checked == true)
            {


                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, "SELECT  numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA FROM ventas WHERE oculto!= 1 and total REGEXP  '" + txbbuscarventa.Text + "'ORDER BY total DESC");

            }

            else if (chbordenarportotal.Checked == true && chbordenarporfecha.Checked == true)
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, "SELECT  numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA FROM ventas WHERE oculto!= 1 and fecha, total REGEXP  '" + txbbuscarventa.Text + "'ORDER BY total DESC");


            }

            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, tabla);
            }

        }

        private void dgvtodaslasventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbtbuscarporventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbinicio_Click(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Close();

        }

        private void txbbuscarventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvtodaslasventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                numeroventa = dgvtodaslasventas.CurrentRow.Cells[0].Value.ToString();
                cliente= dgvtodaslasventas.CurrentRow.Cells[1].Value.ToString();
              
                frmFacturaDeVenta factura = new frmFacturaDeVenta(numeroventa, cliente);
                factura.Show();
            }

        }

        private void datedesde_ValueChanged(object sender, EventArgs e)
        {

        }

      
    }
}
