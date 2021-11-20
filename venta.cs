using System;
using System.Data;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmventa : Form
    {
        string textos = "";

        string cliente;

       int total2 = 0;
        string fecha;

        private String Pasarcodigo;

        private void sumatotal(DataGridView venta, int total2, int productoeliminado)
        {
            int indice_fila = dgvventa.Rows.Add();
            DataGridViewRow fila = dgvventa.Rows[indice_fila];

            fila.Cells["CODIGO"].Value = txbcodigo.Text;
            fila.Cells["CANTIDAD"].Value = txbCantidad.Text;
            fila.Cells["PRODUCTO"].Value = txbProducto.Text;
            fila.Cells["V.UNIT"].Value = txbvalorUnitario.Text;
            fila.Cells["TOTAL"].Value = ((int.Parse(txbvalorUnitario.Text) * int.Parse(txbCantidad.Text)).ToString());

            total2 += int.Parse(fila.Cells["TOTAL"].Value.ToString());

            lbltotal.Text = total2.ToString();

           
        }

        private void cargar()
        {
            try
            {
                if (txbcodigo.Text != "" && txbProducto.Text!="")
                {
                    if (txbCantidad.Text != "" && txbCantidad.Text != "0")
                    {
                       int indice_fila = dgvventa.Rows.Add();
                        DataGridViewRow fila = dgvventa.Rows[indice_fila];

                        fila.Cells["CODIGO"].Value = txbcodigo.Text;
                        fila.Cells["CANTIDAD"].Value = txbCantidad.Text;
                        fila.Cells["PRODUCTO"].Value = txbProducto.Text;
                        fila.Cells["V.UNIT"].Value = txbvalorUnitario.Text;
                        fila.Cells["TOTAL"].Value = ((int.Parse(txbvalorUnitario.Text) * int.Parse(txbCantidad.Text)).ToString());

                        total2 += int.Parse(fila.Cells["TOTAL"].Value.ToString());

                        lbltotal.Text = total2.ToString();

                       

                        txbCantidad.Text = ""; txbcodigo.Text = ""; txbProducto.Text = ""; txbvalorUnitario.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar la cantidad del producto");
                    }

                }
                else
                {
                    MessageBox.Show("Debe ingresar el código del producto para realizar la carga");
                }


                // txbCantidad.Text = ""; txbcodigo.Text = ""; txbProducto.Text = ""; txbvalorUnitario.Text = "";

                this.ActiveControl = txbcodigo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        public frmventa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txbcodigo_cliente;

            DataTable resultado = conexion.consultarsql("SELECT documento, nombre, codigo FROM cliente WHERE nombre = '" + txbnombreCliente.Text + "'");

            fecha = dtpfecha.Value.ToString("yyyy-MM-dd");

            /* foreach (DataRow fila in resultado.Rows)
             {
                 cbxclientes.DisplayMember = fila[0].ToString() + " - " + fila[1].ToString(); ;
                 cbxclientes.ValueMember = fila[0].ToString();


             }
             cliente = cbxclientes.Text;

             MessageBox.Show(cliente);*/
        }

        conexiones conexion = new conexiones();
        public void consultar_cliente()
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT codigo, nombre FROM cliente WHERE oculto!=0 AND codigo = '" + txbcodigo.Text + "';";

            DataTable consulta = conectar.consultarsql(sql);
        }
        public void consultar_producto()
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT codigo, nombre, precio FROM productos WHERE oculto=0 AND codigo = '" + txbcodigo.Text + "';";

            DataTable consulta = conectar.consultarsql(sql);



            foreach (DataRow fila in consulta.Rows)
            {


                txbProducto.Text = fila[1].ToString();
                txbcodigo.Text = fila[0].ToString();
                txbvalorUnitario.Text = fila[2].ToString();

            }

            conexiones consultar = new conexiones();

            consultar.consultar(sql);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmventa_Load(object sender, EventArgs e)
        {
            objetos();

            dgvventa.Columns.Add("CODIGO", "CODIGO");
            dgvventa.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvventa.Columns.Add("V.UNIT", "V.UNIT");
            dgvventa.Columns.Add("CANTIDAD", "CANTIDAD");
            dgvventa.Columns.Add("TOTAL", "TOTAL");

        }


        private void button1_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT codigo, nombre FROM cliente WHERE codigo= " + txbcodigo_cliente.Text + ";";

            DataTable consulta = conectar.consultarsql(sql);

            foreach (DataRow fila in consulta.Rows)
            {
                txbnombreCliente.Text = fila[1].ToString();


            }


        }

        private void txbcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbcodigo_Leave(object sender, EventArgs e)
        {

            consultar_producto();

        }
        private void txbcodigo_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }


            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conexiones conectar = new conexiones();

                conectar.conectar();

                string sql = "SELECT codigo, nombre FROM cliente WHERE codigo = " + txbcodigo_cliente.Text + ";";

                DataTable consulta = conectar.consultarsql(sql);

                foreach (DataRow fila in consulta.Rows)
                {

                    txbnombreCliente.Text = fila[1].ToString();
                }

                this.ActiveControl = txbcodigo;

            }



        }
        private void txbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                consultar_producto();

                txbCantidad.Focus();
            }

        }
        private void pnlitems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbuscar_cliente_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txbcodigo_cliente;
            frmclientes cliente = new frmclientes (Pasarcodigo, this);
            AddOwnedForm(cliente);
            cliente.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Close();
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar) == true)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cargar();
            }

        }



        private void btnbuscarProducto_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txbCantidad;
            frmproductos productos = new frmproductos(Pasarcodigo, this);
            AddOwnedForm(productos);
            productos.Show();

        }

        private void chbcliente_CheckedChanged(object sender, EventArgs e)
        {
            cbxproveedor.AutoCheck = false;

            txbdocumento.Enabled = false;


        }



        private void btnagregar_producto_Click(object sender, EventArgs e)
        {
            cargar();

        }

        private void cbxproveedor_CheckedChanged(object sender, EventArgs e)
        {
            cbxcliente.AutoCheck = false;

            txbdocumento.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txbdocumento.Enabled = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txbdocumento.Enabled = false;
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            int eliminado=0;
            eliminado = int.Parse( dgvventa.CurrentRow.Cells[4].Value.ToString());
            MessageBox.Show(eliminado.ToString());
            dgvventa.Rows.RemoveAt(dgvventa.CurrentRow.Index);
        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void finalizar_Click(object sender, EventArgs e)
        {

            string numero_venta = "";
            conexiones conectar = new conexiones();
            conectar.conectar();

            conexiones consultar = new conexiones();

            consultar.consultar("INSERT INTO ventas (id_producto,id_cliente,cantidad,producto,total,valor_unitario,fecha,cliente) VALUES (" + txbcodigo.Text + ", " + txbcodigo_cliente.Text + "," + txbCantidad.Text + ",'" + txbProducto.Text + "'," + lbltotal.Text + "," + txbvalorUnitario.Text + ",'" + fecha + "','" + txbnombreCliente.Text + "')");

            MessageBox.Show("producto agregado");

            foreach (DataGridViewRow row in dgvventa.Rows)
            {

                DataTable consulta = conectar.consultarsql("SELECT MAX(numero) as numero_venta From ventas");


                foreach (DataRow fila in consulta.Rows)
                {

                    numero_venta = fila[0].ToString();

                }
                consultar.consultar("INSERT INTO factura (numero_venta,codigo_producto, producto, precio_unitario, cantidad, total) VALUES (" + numero_venta + "," + (row.Cells["CODIGO"].Value) + ", '" + (Convert.ToString(row.Cells["PRODUCTO"].Value)) + "', " + (Convert.ToString(row.Cells["V.UNIT"].Value)) + ", " + (Convert.ToString(row.Cells["CANTIDAD"].Value)) + "," + (Convert.ToString(row.Cells["TOTAL"].Value)) + " )");

               
            }

          
        }


        private void txbcodigo_KeyDown(object sender, KeyEventArgs e)
        {

        }
       string productoeliminado= "";
        private void button3_Click_1(object sender, EventArgs e)
        {
            productoeliminado = dgvventa.CurrentRow.Cells[4].Value.ToString();

            dgvventa.Rows.RemoveAt(dgvventa.CurrentRow.Index);
           
            MessageBox.Show(productoeliminado);
            
            total2 =( total2 - (int.Parse(productoeliminado)));

            MessageBox.Show(total2.ToString());
            
            lbltotal.Text = total2.ToString();
        }

        private void dgvventa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void setPasarcodigo(string codigo)
        {
            Pasarcodigo = codigo;
            txbcodigo.Text = Pasarcodigo;
        }

        private void objetos()
        {

        }

        private void lbltotal_Click_1(object sender, EventArgs e)
        {

        }
    }


}
