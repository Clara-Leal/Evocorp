using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmcompra : Form
    {
        int total;
        string productoeliminado = "", fecha;
        private string pasarcodigo;

        private void sumatotal(DataGridView compra, int total, int productoeliminado)
        {

        }
        public void setPasarcodigo(string codigo)
        {
            pasarcodigo = codigo;
            txbcodigo_proveedor.Text = pasarcodigo;
        }
        public frmcompra()
        {
            InitializeComponent();
            fecha = dtpfecha.Value.ToString("yyyy-MM-dd");
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ActiveControl = txbcodigo_proveedor;

        }

        private void consultar_producto()
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT codigo, nombre, precio FROM productos WHERE oculto=0 AND codigo = '" + txbcodigo.Text + "';";

            DataTable consulta = conectar.consultarsql(sql);
            foreach (DataRow fila in consulta.Rows)
            {
                txbProducto.Text = fila[1].ToString();
                txbcodigo.Text = fila[0].ToString();
                
            }

            conexiones consultar = new conexiones();

            consultar.consultar(sql);
        }
        private void cargar()
        {
            try
            {
                if (txbcodigo.Text != "" && txbProducto.Text != "")
                {
                    if (txbCantidad.Text != "" && txbCantidad.Text != "0")
                    {
                        int indice_fila = dgvcompras.Rows.Add();
                        DataGridViewRow fila = dgvcompras.Rows[indice_fila];

                        fila.Cells["CODIGO"].Value = txbcodigo.Text;
                        fila.Cells["CANTIDAD"].Value = txbCantidad.Text;
                        fila.Cells["PRODUCTO"].Value = txbProducto.Text;
                        fila.Cells["V.UNIT"].Value = txbvalorUnitario.Text;
                        fila.Cells["TOTAL"].Value = ((int.Parse(txbvalorUnitario.Text) * int.Parse(txbCantidad.Text)).ToString());

                        total += int.Parse(fila.Cells["TOTAL"].Value.ToString());

                        lbltotal.Text = total.ToString();
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
        private void txbcodigo_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnagregar_producto_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productoeliminado = dgvcompras.CurrentRow.Cells[4].Value.ToString();

            dgvcompras.Rows.RemoveAt(dgvcompras.CurrentRow.Index);


            total = (total) - (int.Parse(productoeliminado));


            lbltotal.Text = total.ToString();
        }

        private void txbcodigo_proveedor_KeyPress(object sender, KeyPressEventArgs e)
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

                string sql = "SELECT id, nombre FROM proveedor WHERE id = " +txbcodigo_proveedor.Text + ";";

                DataTable consulta = conectar.consultarsql(sql);

                foreach (DataRow fila in consulta.Rows)
                {

                    txbnombreproveedor.Text = fila[1].ToString();
                }

                this.ActiveControl = txbcodigo;

            }
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            frmresumencompras resumen_compras = new frmresumencompras();
            resumen_compras.Show();
            this.Close();
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

                txbvalorUnitario.Focus();
            }
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

        private void btnbuscar_proveedor_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txbcodigo_proveedor;
            frmproveedores proveedor = new frmproveedores (this);
            AddOwnedForm(proveedor);
            proveedor.Show();
        }

        public void consultar_p()
        {

            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT codigo, nombre, precio FROM productos WHERE oculto=0 AND codigo = '" + txbcodigo.Text + "';";

            DataTable consulta = conectar.consultarsql(sql);
            foreach (DataRow fila in consulta.Rows)
            {
                txbProducto.Text = fila[1].ToString();
                txbcodigo.Text = fila[0].ToString();

            }

            
        }

            private void frmcompra_Load(object sender, EventArgs e)
        {
            //objetos();

            dgvcompras.Columns.Add("CODIGO", "CODIGO");
            dgvcompras.Columns.Add("PRODUCTO", "PRODUCTO");
            dgvcompras.Columns.Add("V.UNIT", "V.UNIT");
            dgvcompras.Columns.Add("CANTIDAD", "CANTIDAD");
            dgvcompras.Columns.Add("TOTAL", "TOTAL");
        }

        private void txbvalorUnitario_KeyPress(object sender, KeyPressEventArgs e)
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
                this.ActiveControl = txbCantidad;
            }
        }

        private void btnbuscarProducto_Click(object sender, EventArgs e)
        {
            this.ActiveControl = txbCantidad;
            frmproductos productos = new frmproductos(this);
            AddOwnedForm(productos);
            productos.Show();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            string numero_compra = "";

            conexiones conectar = new conexiones();

            conectar.conectar();

            conexiones consultar = new conexiones();
            consultar.consultar("INSERT INTO compras (id_proveedor,total,fecha,proveedor) VALUES (" + txbcodigo_proveedor.Text + "," + lbltotal.Text + ",'" + fecha + "','" + txbnombreproveedor.Text + "')");



            foreach (DataGridViewRow row in dgvcompras.Rows)
            {

                DataTable consulta = conectar.consultarsql("SELECT MAX(numero) as numero_compra From compras");


                foreach (DataRow fila in consulta.Rows)
                {

                    numero_compra = fila[0].ToString();

                }
                MessageBox.Show("INSERT INTO factura_compra (numero_compra,codigo_producto, producto, precio_unitario, cantidad, total) VALUES (" + numero_compra + ", '" + row.Cells[0].Value + "', '" + Convert.ToString(row.Cells["PRODUCTO"].Value) + "', " + Convert.ToString(row.Cells["V.UNIT"].Value) + ", " + Convert.ToString(row.Cells["CANTIDAD"].Value) + ", " + Convert.ToString(row.Cells["TOTAL"].Value) + " )");
                consultar.consultar("INSERT INTO factura_compra (numero_compra,codigo_producto, producto, precio_unitario, cantidad, total) VALUES (" + numero_compra + ", " + Convert.ToString(row.Cells[0].Value) + ", '" + Convert.ToString(row.Cells["PRODUCTO"].Value) + "', " + Convert.ToString(row.Cells["V.UNIT"].Value) + ", " + Convert.ToString(row.Cells["CANTIDAD"].Value) + ", " + Convert.ToString(row.Cells["TOTAL"].Value) + " )");

               
            }

        }
    }
}
