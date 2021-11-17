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

        string id, cod;
        frmventa ventas;
        public frmproductos (string cod, frmventa ventas)
        {
            InitializeComponent();
            inicializar();
            this.cod = cod;
            this.ventas = ventas;
        }
        public frmproductos()
        {
            InitializeComponent();
            inicializar();
            
        }
        private void inicializar()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1");

        }
        private void Productos_Load(object sender, EventArgs e)
        {
            DataTable resultado = conexion.consultarsql ("SELECT  nombre, id FROM categoria order by nombre");


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
           // MessageBox.Show(cbxcategoria.SelectedValue.ToString());
            
            string sql = "INSERT INTO productos (nombre, codigo, precio, categoria) VALUES ('" + txbnombre.Text + "','" + txbcodigo.Text + "', '" + txbprecio.Text + "', '" + cbxcategoria.SelectedValue+ "');";

            consultar.consultar(sql);

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto != 1");

            txbcodigo.Text = "";  txbnombre.Text = ""; txbprecio.Text = ""; 

          
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

           // txbcodigo.Text ="SELECT codigo FROM productos WHERE id = " + id + ";";
            

            string sql = "UPDATE productos SET  codigo ='" + txbcodigo.Text + "', nombre ='" + txbnombre.Text +
                "', precio =" + txbprecio.Text + ", categoria = '" + cbxcategoria.SelectedValue + "' WHERE id =" +id + ";";


            MessageBox.Show(sql);
            conexiones consultar = new conexiones();

           consultar.consultar(sql);
            
            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1");

           txbcodigo.Text = ""; txbnombre.Text = ""; txbprecio.Text = ""; 

                   


        }

        private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*//Valor reservado
            string valorCelda = dgvproductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //Nombre columna
            string nombrecolumna = dgvproductos.Columns[e.ColumnIndex].HeaderText;

            Valor de la primer columna*/
          
            string valorcelda1 = dgvproductos.Rows[e.RowIndex].Cells[0].Value.ToString();
           


           
           //string sql = "SELECT * FROM productos WHERE id = " + valorcelda1 + ";
            
           

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar(); 

            string sql = "UPDATE productos SET oculto = 1 WHERE id =" + id + ";";

            conexiones consultar = new conexiones();

            consultar.consultar(sql);


            txbcodigo.Text = ""; txbnombre.Text = ""; txbprecio.Text = "";

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1");

        }

        private void txbinicio_Click(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Close();
        }

        private void txbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string buscar = txbbuscar.Text;

            if (txbbuscar.Text == "")
            {

           
            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1");


            }

            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1 AND productos.nombre REGEXP'" + buscar +"' ");
            }


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
                txbcodigo.Text = fila[0].ToString();
                txbprecio.Text = fila[2].ToString();
               
            }

           

            conexiones consultar = new conexiones();

            consultar.consultar(sql);
        }

        public void dgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvproductos.CurrentRow.Cells[0].Value.ToString();
            autocompletar();
            
            ventas.setPasarcodigo(dgvproductos.CurrentRow.Cells[1].Value.ToString());

            ventas.consultar_producto();

         }

        private void txbcodigo_TextChanged(object sender, EventArgs e)
        {
           
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
                    MessageBox.Show(fila[1].ToString());

                    txbnombre.Text = fila[1].ToString();
                    txbprecio.Text = fila[2].ToString();

                }

                
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            /*frmventa padre = Owner as frmventa;
            padre.Pasarcodigo.Text = txbcodigo.Text;

            frmventa ventas = new frmventa();
            ventas.Show();*/
        }
    }
}
