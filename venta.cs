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

            pnlitems.AutoScroll = true;

            DataTable resultado = conexion.consultarsql("SELECT documento, nombre, codigo FROM cliente WHERE nombre = '" + txbNombreCliente.Text+"'");


            

           /* foreach (DataRow fila in resultado.Rows)
            {
                cbxclientes.DisplayMember = fila[0].ToString() + " - " + fila[1].ToString(); ;
                cbxclientes.ValueMember = fila[0].ToString();
               

            }
            cliente = cbxclientes.Text;

            MessageBox.Show(cliente);*/
            }
            conexiones conexion = new conexiones();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmventa_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT codigo, nombre FROM cliente WHERE codigo= " +txbcodigo_cliente.Text+ ";";

            DataTable consulta = conectar.consultarsql(sql);

            foreach (DataRow fila in consulta.Rows)
            {
                txbNombreCliente.Text = fila[1].ToString();


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

            // MessageBox.Show(sql);

            foreach (DataRow fila in consulta.Rows)
            {
                MessageBox.Show("FUNCIONA");
               
                txbProducto.Text = fila[1].ToString();
               // txbcodigo.Text = fila[0].ToString();
                txbvalorUnitario.Text = fila[2].ToString();
               
            }

            conexiones consultar = new conexiones();

            consultar.consultar(sql);

        }

       

        private void txbcodigo_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conexiones conectar = new conexiones();

                conectar.conectar();

                string sql = "SELECT codigo, nombre FROM cliente WHERE codigo = " + txbcodigo_cliente.Text + ";";

                DataTable consulta = conectar.consultarsql(sql);

                foreach (DataRow fila in consulta.Rows)
                {
                    MessageBox.Show(fila[1].ToString());

                    txbNombreCliente.Text = fila[1].ToString();
                }
            }
        }
        private void txbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conexiones conectar = new conexiones();

                conectar.conectar();

                string sql = "SELECT Codigo, nombre FROM productos WHERE Codigo = '" + txbcodigo.Text + "';";

                DataTable consulta2 = conectar.consultarsql(sql);

                foreach (DataRow fila in consulta2.Rows)
                {
                    MessageBox.Show(fila[1].ToString());

                    txbProducto.Text = fila[1].ToString();
                    //txbvalorUnitario.Text = fila[2].ToString();
                }
            }
        }

        private void btnbuscar_cliente_Click(object sender, EventArgs e)
        {
            conexiones conexion = new conexiones();
            conexiones conectar = new conexiones();

            conectar.conectar();

            DataTable resultado = conexion.consultarsql("SELECT documento, nombre, codigo FROM cliente WHERE nombre = '" + txbNombreCliente.Text + "'");


            foreach (DataRow fila in resultado.Rows)
            {
                // cbxclientes.DisplayMember = fila[0].ToString() + " - " + fila[1].ToString(); ;
                //cbxclientes.ValueMember = fila[1].ToString();

                // cbxclientes.Items.Insert(int.Parse(fila[0].ToString()), fila[0] + "- " + fila[1]);

                
               // cbxclientes.Items.Add(new { Text = "report A", Value = "reportA" });

            }

          //  cbxclientes.DataSource = resultado;

            
        }

        private void btnagregar_producto_Click(object sender, EventArgs e)
        {


            var codigo = new Label();
            var cantidad = new Label();
            var producto = new Label();
            var valor_unit = new Label();



            codigo.Location = new Point(3, posicionY);
            codigo.Name = "Texto" + elemento;
            codigo.Width = 500;
            codigo.Text = txbcodigo.Text;
            codigo.Size = new Size(84, 33);

            cantidad.Location = new Point(149, posicionY);
            cantidad.Name = "Texto" + elemento;
            cantidad.Width = 500;
            cantidad.Text = txbCantidad.Text;
            cantidad.Size = new Size(100, 33);

            producto.Location = new Point(290, posicionY);
            producto.Name = "Texto" + elemento;
            producto.Width = 500;
            producto.Text = txbProducto.Text;
            producto.Size = new Size(201, 33);

            valor_unit.Location = new Point(522,posicionY);
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

        }
    }
}
