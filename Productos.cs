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
        public frmproductos()
        {
            InitializeComponent();
        }
        
        private void Productos_Load(object sender, EventArgs e)
        {

         


            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            conexiones consultar = new conexiones();


            string sql = "INSERT INTO productos (nombre, codigo, precio, categoria) VALUES ('" + txbnombre.Text + "','" + txbcodigo.Text + "', '" + txbprecio.Text + "', '" + txbcategoria.Text + "');";

            consultar.consultar(sql);

            /* conexiones actualizar = new conexiones();

             actualizar.actualizar();*/

            try
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
            }



            MessageBox.Show("Producto agregado.");



        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "UPDATE productos SET id =" + txbid.Text+ ", codigo =" + txbcodigo.Text + "', nombre ='" + txbnombre.Text +
                ", precio =" + txbprecio.Text + ", categoria = '" + txbcategoria.Text + "' WHERE id =" +txbid.Text + ";";

            conexiones consultar = new conexiones();

            consultar.consultar(sql);

            

            MessageBox.Show("Producto modificado");

            



        }

        private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Valor reservado
            string valorCelda = dgvproductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            //Nombre columna
            string nombrecolumna = dgvproductos.Columns[e.ColumnIndex].HeaderText;

            //Valor de la primer columna
            string valorPrimerCelda = dgvproductos.Rows[e.RowIndex].Cells[0].Value.ToString();

            string sql = "UPDATE productos SET " + nombrecolumna + " = '" + valorCelda + "' WHERE id = " + valorPrimerCelda + ";";
            
           

            MessageBox.Show("Cambios guardados.");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "DELETE FROM productos WHERE id =" + txbid.Text + ";";

            conexiones consultar = new conexiones();

            consultar.consultar(sql);



            MessageBox.Show("PRODUCTO ELIMINADO");

        }

        private void txbinicio_Click(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Hide();
        }
    }
}
