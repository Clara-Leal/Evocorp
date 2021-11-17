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
        string cod;
        frmventa ventas;
        string id;
        public frmclientes(string cod, frmventa ventas)
        {
            InitializeComponent();
           
           inicializar_cliente();      /////////////////////////////
            // this.cod = cod;
            // this.ventas = ventas;
        }
       
        public frmclientes()
        {
            InitializeComponent();
        }

        private void frmclientes_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            inicializar_cliente();
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }
        string consultasql = "SELECT codigo as ID, nombre AS NOMBRE, documento AS DOCUMENTO, saldo AS SALDO, direccion AS DIRECCION, telefono AS TELEFONO, comentario AS COMENTARIO  FROM cliente WHERE oculto!= 1";
        public void inicializar_cliente()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            conexiones actualizar = new conexiones();
            actualizar.actualizar(dgvclientes, consultasql);

        }

        private void btnañadircliente_Click(object sender, EventArgs e)
        {
            conexiones conectar = new conexiones();

            conectar.conectar();

            conexiones consultar = new conexiones();


            string sql = "INSERT INTO cliente (nombre, documento, direccion, telefono, comentario) VALUES ('" + txbnombre.Text + "', " + txbdocumento.Text + ",'" + txbdireccion.Text + "','" + txbtelefono.Text + "', '" + txbcomentario.Text + "');";

            
            consultar.consultar(sql);

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvclientes, consultasql);

            txbnombre.Text = ""; txbcomentario.Text = ""; txbdireccion.Text = ""; txbdocumento.Text = ""; txbtelefono.Text = "";
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

            string sql = "SELECT codigo, nombre, documento, direccion, telefono, comentario FROM cliente WHERE codigo= " + id + ";";

            DataTable consulta = conectar.consultarsql(sql);


            foreach (DataRow fila in consulta.Rows)
            {
                txbnombre.Text = fila[1].ToString();
                txbdocumento.Text = fila[2].ToString();
                txbdireccion.Text = fila[3].ToString();
                txbtelefono.Text = fila[4].ToString();
                txbcomentario.Text = fila[5].ToString();

            }



            conexiones consultar = new conexiones();

            consultar.consultar(sql);
        }
    }
}
