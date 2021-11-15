using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmproveedores : Form
    {
        string id;
        public frmproveedores()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproveedores, "SELECT id as ID, nombre AS NOMBRE, razon_social, rut AS RUT, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO  FROM proveedor WHERE oculto!= 1");
        }
       
        private void frmproveedores_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnañadircliente_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            conexiones consultar = new conexiones();
          

            string sql = "INSERT INTO proveedor (nombre, razon_social, rut, direccion, telefono, comentario) VALUES ('" + txbnombre.Text + "','" + txbrazonsocial.Text + "', " + txbdocumento.Text + ",'" + txbdireccion.Text + "','" + txbtelefono.Text + "', '" + txbcomentario.Text + "');";

            MessageBox.Show(sql);
            consultar.consultar(sql);

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproveedores, "SELECT id AS ID, nombre AS NOMBRE, razon_social, rut AS RUT, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO  FROM proveedor WHERE oculto!= 1");

            txbnombre.Text = ""; txbcomentario.Text = ""; txbdireccion.Text = ""; txbdocumento.Text = ""; txbrazonsocial.Text = ""; txbtelefono.Text = "";
        }

        private void rbtbuscarproveedor_CheckedChanged(object sender, EventArgs e)
        {
            txbdocumento.Enabled = true;
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Close();
        }

        private void autocompletar()
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT nombre, razon_social, rut, direccion, telefono, comentario FROM proveedor WHERE id = " + id + ";";

            DataTable consulta = conectar.consultarsql(sql);


            foreach (DataRow fila in consulta.Rows)
            {
                txbnombre.Text = fila[0].ToString();
                txbrazonsocial.Text = fila[1].ToString();
                txbdocumento.Text = fila[2].ToString();
                txbdireccion.Text = fila[3].ToString();
                txbtelefono.Text = fila[4].ToString();
                txbcomentario.Text = fila[5].ToString();

            }



            conexiones consultar = new conexiones();

            consultar.consultar(sql);
        }

        private void btnmodificarproveedor_Click(object sender, EventArgs e)
        {
           
                conexiones conectar = new conexiones();

                conectar.conectar();

                string sql = "UPDATE proveedor SET  nombre ='" + txbnombre.Text +"', rut =" + txbdocumento.Text + ", razon_social = '" + txbrazonsocial.Text+ "', telefono = '" + txbtelefono.Text + "', direccion = '" + txbdireccion.Text + "', comentario = '" + txbcomentario.Text + "'  WHERE rut="+txbdocumento.Text +" or id =" + id + ";";


                MessageBox.Show(sql);
                conexiones consultar = new conexiones();

                consultar.consultar(sql);

                conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproveedores, "SELECT id AS ID, nombre AS NOMBRE, razon_social, rut AS RUT, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO  FROM proveedor WHERE oculto!= 1");

            txbnombre.Text = ""; txbcomentario.Text = ""; txbdireccion.Text = ""; txbdocumento.Text = ""; txbrazonsocial.Text = ""; txbtelefono.Text = "";




            
        }

        private void dgvproveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvproveedores.CurrentRow.Cells[0].Value.ToString();
            autocompletar();
        }

        private void btneliminarproveedor_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "UPDATE proveedor SET oculto = 1 WHERE id =" + id + ";";

            conexiones consultar = new conexiones();

            consultar.consultar(sql);

            txbnombre.Text = ""; txbcomentario.Text = ""; txbdireccion.Text = ""; txbdocumento.Text = ""; txbrazonsocial.Text = ""; txbtelefono.Text = "";

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvproveedores, "SELECT id AS ID, nombre AS NOMBRE, razon_social, rut AS RUT, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO  FROM proveedor WHERE oculto!= 1");

        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string buscar = txbbuscar.Text;

            if (txbbuscar.Text == "")
            {

                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvproveedores, "SELECT id AS ID, nombre AS NOMBRE, razon_social, rut AS RUT, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO  FROM proveedor WHERE oculto!= 1");

            }

            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvproveedores, "SELECT id AS ID, nombre AS NOMBRE, razon_social, rut AS RUT, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO  FROM proveedor WHERE oculto!= 1 AND nombre REGEXP'" + buscar + "' ");
            }
        }

        private void dgvproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
