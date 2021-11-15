using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmventa : Form
    {
        int posicionY = 0, elemento = 0, total = 0;
        string textos = "";

        string cliente;


        public frmventa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


            this.ActiveControl = txbcodigo_cliente;

          

            DataTable resultado = conexion.consultarsql("SELECT documento, nombre, codigo FROM cliente WHERE nombre = '" + txbnombreCliente.Text + "'");




            /* foreach (DataRow fila in resultado.Rows)
             {
                 cbxclientes.DisplayMember = fila[0].ToString() + " - " + fila[1].ToString(); ;
                 cbxclientes.ValueMember = fila[0].ToString();


             }
             cliente = cbxclientes.Text;

             MessageBox.Show(cliente);*/
        }
        conexiones conexion = new conexiones();

        public void agregar_producto()


        {

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

            //lbltotal.Text= "$" ++ ""
            


        }

        private void label4_Click(object sender, EventArgs e)
        {

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



        private void txbcodigo_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (Char.IsDigit(e.KeyChar))
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conexiones conectar = new conexiones();

                conectar.conectar();

                string sql = "SELECT Codigo, nombre, precio FROM productos WHERE Codigo = '" + txbcodigo.Text + "';";

                DataTable consulta = conectar.consultarsql(sql);

                foreach (DataRow fila in consulta.Rows)
                {
                    txbProducto.Text = fila[1].ToString();
                    txbvalorUnitario.Text = fila[2].ToString();
                    txbcodigo.Text = fila[0].ToString();

                }
                this.ActiveControl = txbCantidad;
            }


        }

        private void pnlitems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbuscar_cliente_Click(object sender, EventArgs e)
        {
            conexiones conexion = new conexiones();
            conexiones conectar = new conexiones();

            conectar.conectar();

            DataTable resultado = conexion.consultarsql("SELECT documento, nombre, codigo FROM cliente WHERE nombre = '" + txbnombreCliente.Text + "'");


            foreach (DataRow fila in resultado.Rows)
            {
                // cbxclientes.DisplayMember = fila[0].ToString() + " - " + fila[1].ToString(); ;
                //cbxclientes.ValueMember = fila[1].ToString();

                // cbxclientes.Items.Insert(int.Parse(fila[0].ToString()), fila[0] + "- " + fila[1]);


                // cbxclientes.Items.Add(new { Text = "report A", Value = "reportA" });

            }

            //  cbxclientes.DataSource = resultado;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Hide();
        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
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
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar la cantidad del producto");
                    }

                    txbCantidad.Text = ""; txbcodigo.Text = ""; txbProducto.Text = ""; txbvalorUnitario.Text = "";

                    this.ActiveControl = txbcodigo;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        

        private void btnbuscarProducto_Click(object sender, EventArgs e)
        {
            frmproductos productos = new frmproductos();
            AddOwnedForm(productos);
            productos.Show();
        }

        private void chbcliente_CheckedChanged(object sender, EventArgs e)
        {
            cbxproveedor.AutoCheck = false;
            
                txbdocumento.Enabled = false;
            
           
        }

        int final;



        private void btnagregar_producto_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();
            conectar.conectar();

            try
            {

                /* if ((txbCantidad.Text != "") && (txbvalorUnitario.Text != ""))
                 {
                     var codigo = new Label();
                     var cantidad = new Label();
                     var producto = new Label();
                     var valor_unit = new Label();
                     var total = new Label();

                     total.Location = new Point(710, posicionY);
                     total.Name = "Texto" + elemento;
                     total.Width = 500;
                     total.Text = ((int.Parse(txbvalorUnitario.Text)) * (int.Parse(txbCantidad.Text))).ToString();
                     total.Size = new Size(130, 33);

                     codigo.Location = new Point(23, posicionY);
                     codigo.Name = "Texto" + elemento;
                     codigo.Width = 500;
                     codigo.Text = txbcodigo.Text;
                     codigo.Size = new Size(84, 33);

                     cantidad.Location = new Point(585, posicionY);
                     cantidad.Name = "Texto" + elemento;
                     cantidad.Width = 500;
                     cantidad.Text = txbCantidad.Text;
                     cantidad.Size = new Size(100, 33);

                     producto.Location = new Point(170, posicionY);
                     producto.Name = "Texto" + elemento;
                     producto.Width = 500;
                     producto.Text = txbProducto.Text;
                     producto.Size = new Size(190, 33);

                     valor_unit.Location = new Point(402, posicionY);
                     valor_unit.Name = "Texto" + elemento;
                     valor_unit.Width = 500;
                     valor_unit.Text = txbvalorUnitario.Text;
                     cantidad.Size = new Size(153, 33);

                     posicionY += 30;
                     elemento++;

                     pnlitems.Controls.Add(codigo);
                     pnlitems.Controls.Add(cantidad);
                     pnlitems.Controls.Add(producto);
                     pnlitems.Controls.Add(valor_unit);
                     pnlitems.Controls.Add(total);

                     final += (int.Parse(txbvalorUnitario.Text)) * (int.Parse(txbCantidad.Text));

                     txbtotal.Text = final.ToString();


                     this.ActiveControl = txbcodigo;

                 }
                 else
                 {
                     MessageBox.Show("Vacíos");
                 }*/

                int indice_fila = dgvventa.Rows.Add();
                DataGridViewRow fila = dgvventa.Rows[indice_fila];

                fila.Cells["CODIGO"].Value = txbcodigo.Text;
                fila.Cells["CANTIDAD"].Value = txbCantidad.Text;
                fila.Cells["PRODUCTO"].Value = txbProducto.Text;
                fila.Cells["V.UNIT"].Value = txbvalorUnitario.Text;
                fila.Cells["TOTAL"].Value = ((int.Parse(txbvalorUnitario.Text) * int.Parse(txbCantidad.Text)).ToString());

                txbCantidad.Text = ""; txbcodigo.Text = ""; txbProducto.Text = ""; txbvalorUnitario.Text = "";
                this.ActiveControl = txbcodigo;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
        
        

        private TextBox pasarcodigo;

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

        private void dgvventa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public TextBox Pasarcodigo { get => Pasarcodigo; set => Pasarcodigo = value; }

        private void objetos()
        {
            pasarcodigo = txbcodigo;
        }
    }

    
}
