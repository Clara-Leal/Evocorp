using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmclientes : Form
    {
        string id = "";
        public frmclientes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvclientes, busqueda_general);


        }
        string busqueda_general = "SELECT codigo AS ID, nombre AS NOMBRE, documento AS DOCUMENTO, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO, saldo AS SALDO  FROM cliente WHERE oculto!= 1";

        private void autocompletar()
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "SELECT nombre, documento, direccion, telefono, comentario FROM cliente WHERE codigo= " + id + ";";

            DataTable consulta = conectar.consultarsql(sql);


            foreach (DataRow fila in consulta.Rows)
            {
                txbnombre.Text = fila[0].ToString();
                txbdocumento.Text = fila[1].ToString();
                txbdireccion.Text = fila[2].ToString();
                txbtelefono.Text = fila[3].ToString();
                txbcomentario.Text = fila[4].ToString();

            }



            conexiones consultar = new conexiones();

            consultar.consultar(sql);
        }
        public void buscarcliente(string buscar)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            

            if (txbbuscar.Text == "")
            {

                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvclientes, busqueda_general);

            }

            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvclientes, "SELECT codigo AS ID, nombre AS NOMBRE, documento AS DOCUMENTO, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO, saldo AS SALDO  FROM cliente WHERE oculto!= 1 AND nombre REGEXP'" + buscar + "' ");
            }
        }

        private void dgvclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvclientes.CurrentRow.Cells[0].Value.ToString();

            autocompletar();
        }
        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            buscarcliente(txbbuscar.Text);
        }

        private void btnañadircliente_Click(object sender, EventArgs e)
        {
            try
            {
                conexiones conectar = new conexiones();

                conectar.conectar();

                conexiones consultar = new conexiones();
                string agregarCliente = "INSERT INTO cliente (nombre,documento, direccion, telefono, comentario) VALUES ('" + txbnombre.Text + "', '" + txbdocumento.Text + "','" + txbdireccion.Text + "', '" + txbtelefono.Text + "', '" + txbcomentario.Text + "');";


                consultar.consultar(agregarCliente);

                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvclientes, busqueda_general);

                txbnombre.Text = ""; txbcomentario.Text = ""; txbdireccion.Text = ""; txbdocumento.Text = ""; txbtelefono.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void txbdocumento_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txbdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbtelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnmodificarproveedor_Click(object sender, EventArgs e)
        {

            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "UPDATE cliente SET nombre ='" + txbnombre.Text + "', documento ='" + txbdocumento.Text + "', telefono = '" + txbtelefono.Text + "', direccion = '" + txbdireccion.Text+ "', comentario = '" + txbcomentario.Text + "'  WHERE codigo =" + id + ";";

            MessageBox.Show("UPDATE cliente SET  nombre ='" + txbnombre.Text + "', documento =" + txbdocumento.Text + "', telefono = '" + txbtelefono.Text + "', direccion = '" + txbdireccion.Text + "', comentario = '" + txbcomentario.Text + "'  WHERE codigo =" + id + "");
            conexiones consultar = new conexiones();

            consultar.consultar(sql);

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvclientes, busqueda_general);

            txbnombre.Text = ""; txbcomentario.Text = ""; txbdireccion.Text = ""; txbdocumento.Text = ""; txbtelefono.Text = "";

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void btneliminarcliente_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            string sql = "UPDATE cliente SET oculto = 1 WHERE codigo =" + id + ";";

            conexiones consultar = new conexiones();

            consultar.consultar(sql);

            txbnombre.Text = ""; txbcomentario.Text = ""; txbdireccion.Text = ""; txbdocumento.Text = "";  txbtelefono.Text = "";

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvclientes, busqueda_general);

        }
    }
}