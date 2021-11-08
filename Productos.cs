using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmproductos : Form
    {

        string id;
        public frmproductos()
        {
            InitializeComponent();

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CÓDIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1");

            
        }

        
        private void Productos_Load(object sender, EventArgs e)
        {
            DataTable resultado = conexion.consultarsql ("SELECT  productos.id AS ID, Codigo AS CÓDIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1");


            cbxcategoria.DisplayMember = "nombre";
            cbxcategoria.ValueMember = "id";

            cbxcategoria.DataSource = resultado;
        }

        conexiones conexion = new conexiones();

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            conexiones consultar = new conexiones();

            
            string sql = "INSERT INTO productos (nombre, codigo, precio, categoria) VALUES ('" + txbnombre.Text + "','" + txbcodigo.Text + "', '" + txbprecio.Text + "', '" + cbxcategoria.SelectedIndex+ "');";

            consultar.consultar(sql);

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT * FROM productos");

            /*  try
              {
                  MySqlCommand consulta = new MySqlCommand("SELECT * FROM productos;");

                  MySqlDataAdapter adaptador = new MySqlDataAdapter();
                  adaptador.SelectCommand = consulta; //Obtiene retorno de datos

                  DataTable tabla = new DataTable();
                  adaptador.Fill(tabla);

                  dgvproductos.DataSource = "";
                  dgvproductos.DataSource = tabla;
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error al actualizar: " + ex.ToString());
              }*/

            txbcodigo.Text = "";  txbnombre.Text = ""; txbprecio.Text = ""; 

            MessageBox.Show("Producto agregado.");



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            txbcodigo.Text ="SELECT codigo FROM productos WHERE id = " + id + ";";
            

            string sql = "UPDATE productos SET  codigo =" + txbcodigo.Text + "', nombre ='" + txbnombre.Text +
                ", precio =" + txbprecio.Text + ", categoria = '" + cbxcategoria.SelectedIndex + "' WHERE id =" +id + ";";

            conexiones consultar = new conexiones();

           consultar.consultar(sql);
            
            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT * FROM productos");

           // txbcodigo.Text = ""; txbnombre.Text = ""; txbprecio.Text = ""; txbid.Text = "";

            MessageBox.Show("Producto modificado");

            



        }

        private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*//Valor reservado
            string valorCelda = dgvproductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //Nombre columna
            string nombrecolumna = dgvproductos.Columns[e.ColumnIndex].HeaderText;

            Valor de la primer columna*/
          
            string valorcelda1 = dgvproductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show("valor: "+ valorcelda1);


           
           //string sql = "SELECT * FROM productos WHERE id = " + valorcelda1 + ";
            
           

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar(); 

            string sql = "UPDATE productos SET oculto = 1 WHERE id =" + id + ";";

            conexiones consultar = new conexiones();

            consultar.consultar(sql);



            MessageBox.Show("PRODUCTO ELIMINADO");
            
            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT id AS ID, Codigo AS CÓDIGO, nombre AS NOMBRE, precio AS PRECIO, categoria AS CATEGORIA FROM productos WHERE oculto!= 1");
        
    }

        private void txbinicio_Click(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Hide();
        }

        private void txbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            conexiones ver = new conexiones();




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void autocompletar()
        {
            conexiones conectar = new conexiones();

            conectar.conectar();
            
            string sql = "SELECT codigo, nombre, precio, categoria FROM productos WHERE id = " + id + ";";

            DataTable consulta = conectar.consultarsql(sql);

            foreach (DataRow fila in consulta.Rows)
            {
                txbnombre.Text = fila[1].ToString();
            }

           

            conexiones consultar = new conexiones();

            consultar.consultar(sql);
        }

        private void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvproductos.CurrentRow.Cells[0].Value.ToString();
            autocompletar();

         }
    }
}
