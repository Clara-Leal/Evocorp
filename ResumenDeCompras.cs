using System;
using System.Windows.Forms;


namespace EvoCorp
{
    public partial class frmresumencompras : Form
    {
        string tabla = "SELECT numero AS NUMERO, proveedor AS PROVEEDOR, total AS IMPORTE, fecha AS FECHA  FROM compras WHERE oculto!= 1";
        public frmresumencompras()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvtodaslascompras, tabla);
        }

      /*  private void ExportarDatos(DataGridView datalistado)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in datalistado.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in datalistado.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No hay Registros a Exportar.");
            }
        }*/

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
            frmcompra compra = new frmcompra();
            compra.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rbtbuscrapornombrecliente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
