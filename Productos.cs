using System;
using System.Data;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmproductos : Form
    {

        string id, cod;
        frmcompra compra;
        frmventa ventas;
      public frmproductos(frmcompra compra)
        {
            InitializeComponent();
            inicializar();
           // this.cod = cod;
            this.compra = compra;
        }
       
        public frmproductos(frmventa ventas)
        {
            InitializeComponent();
            inicializar();
          //  this.cod = cod;
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
            DataTable resultado = conexion.consultarsql("SELECT  nombre, id FROM categoria order by nombre");


            cbxcategoria.DisplayMember = "nombre";
            cbxcategoria.ValueMember = "id";

            cbxcategoria.DataSource = resultado;
        }

        conexiones conexion = new conexiones();


        private void button1_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            conexiones consultar = new conexiones();

            string sql = "INSERT INTO productos (nombre, codigo, precio, categoria) VALUES ('" + txbnombre.Text + "','" + txbcodigo.Text + "', '" + txbprecio.Text + "', '" + cbxcategoria.SelectedValue + "');";

            consultar.consultar(sql);

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto != 1");

            txbcodigo.Text = ""; txbnombre.Text = ""; txbprecio.Text = "";


        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "UPDATE productos SET  codigo ='" + txbcodigo.Text + "', nombre ='" + txbnombre.Text +
                "', precio =" + txbprecio.Text + ", categoria = '" + cbxcategoria.SelectedValue + "' WHERE id =" + id + ";";


            conexiones consultar = new conexiones();

            consultar.consultar(sql);

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1");

            txbcodigo.Text = ""; txbnombre.Text = ""; txbprecio.Text = "";




        }

        private void dvgproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                actualizar.actualizar(dgvproductos, "SELECT  productos.id AS ID, Codigo AS CODIGO, productos.nombre AS NOMBRE, precio AS PRECIO, categoria.nombre AS CATEGORIA FROM productos JOIN categoria on categoria.id = productos.categoria WHERE oculto!= 1 AND productos.nombre REGEXP'" + buscar + "' ");
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


        }

        private void txbcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnañadirproducto_Click(object sender, EventArgs e)
        {
            ventas.setPasarcodigo(dgvproductos.CurrentRow.Cells[1].Value.ToString());

            ventas.consultar_producto();

            this.Close();
        }

        private void btnañadiracompra_Click(object sender, EventArgs e)
        {
            compra.setPasarcodigo(dgvproductos.CurrentRow.Cells[1].Value.ToString());

            compra.consultar_p();

            this.Close();
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
                   // MessageBox.Show(fila[1].ToString());

                    txbnombre.Text = fila[1].ToString();
                    txbprecio.Text = fila[2].ToString();

                }


            }
        }

      

            
        
    }
}
