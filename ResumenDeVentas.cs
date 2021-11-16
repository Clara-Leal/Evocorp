using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmresumenVentas : Form
    {
        
        string tabla = "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE oculto!= 1";
        string fechadesde, fechahasta;
        public frmresumenVentas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }



        private void frmresumenVentas_Load(object sender, EventArgs e)
        {
            string fecha = "SELECT fecha AS FECHA  FROM ventas";
           
                MessageBox.Show(fecha);

            conexiones actualizar = new conexiones();

            actualizar.actualizar(dgvtodaslasventas, tabla);

           

            lblprobarfecha.Text = datedesde.Value.ToString("yyyy-MM-dd");

            fechadesde= datedesde.Value.ToString("yyyy-MM-dd");
            fechahasta= datehasta.Value.ToString("yyyy-MM-dd");

        }

        private void btnnuevaventa_Click(object sender, EventArgs e)
        {
            frmventa ventas = new frmventa();
            ventas.Show();
            this.Hide();
        }

        private void txbbuscarventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (rbtbuscarporventa.Checked)
                {


                    if (txbbuscarventa.Text == "")
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslasventas, tabla);
                    }
                    else
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslasventas, "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE DATE(fecha) BETWEEN '" + fechahasta + "' AND '" + fechadesde + "' AND oculto!= 1 and numero REGEXP  '" + txbbuscarventa.Text + "' ");
                    }
                }
                                                                                                                                                                                                            //  SELECT* FROM ventas WHERE date(fecha) BETWEEN '2021-09-01' AND '2021-10-30'
                else if (rbtbuscrapornombrecliente.Checked)
                {
                    if (txbbuscarventa.Text == "")
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslasventas, tabla);
                    }
                    else
                    {
                        conexiones actualizar = new conexiones();

                        actualizar.actualizar(dgvtodaslasventas, "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE DATE(fecha) BETWEEN '" + fechahasta + "' AND '" + fechadesde + "' AND oculto!= 1 and cliente REGEXP  '" + txbbuscarventa.Text + "' ");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione el criterio de búsqueda");
                }
            }

           
        }

        private void lblprobarfecha_Click(object sender, EventArgs e)
        {

        }

        private void chbordenarporfecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbordenarporfecha.Checked == true)
            {
                

                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, "SELECT  numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA FROM ventas ORDER BY fecha");

            }
            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, tabla);
            }
        }

        private void chbordenarportotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chbordenarportotal.Checked == true)
            {
               

                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, "SELECT  numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA FROM ventas ORDER BY total DESC");

            }

            else if(chbordenarportotal.Checked == true && chbordenarporfecha.Checked == true)
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, "SELECT  numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA FROM fecha, ventas ORDER BY total DESC");


            }

            else
            {
                conexiones actualizar = new conexiones();

                actualizar.actualizar(dgvtodaslasventas, tabla);
            }

        }

        private void dgvtodaslasventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rbtbuscarporventa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbinicio_Click(object sender, EventArgs e)
        {
            frminicio inicio = new frminicio();
            inicio.Show();
            this.Close();
           
        }

        private void datedesde_ValueChanged(object sender, EventArgs e)
        {

        }

        /* private void btnbuscar_Click(object sender, EventArgs e)
         {

             conexiones conectar = new conexiones();

             conectar.conectar();


             if (rbtbuscarporventa.Checked)
             {
                 if (txbbuscarventa.Text != "")
                 {
                     conexiones actualizar = new conexiones();

                     actualizar.actualizar(dgvtodaslasventas, buscarpornumero);
                 }

                 else
                 {
                     conexiones actualizar = new conexiones();

                     actualizar.actualizar(dgvtodaslasventas, "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE oculto!= 1");
                 }

                  else if (rbtbu.Checked)
                 {
                     conexiones actualizar = new conexiones();

                     actualizar.actualizar(dgvtodaslasventas, "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE oculto!= 1 and numero = '" + txbbuscarventa.Text + "'");

                 }
                 else if (rbtbuscarporproducto.Checked)
                 {
                     conexiones actualizar = new conexiones();

                     actualizar.actualizar(dgvtodaslasventas, "SELECT numero AS NUMERO, cliente AS CLIENTE, total AS IMPORTE, fecha AS FECHA  FROM ventas WHERE oculto!= 1 and numero = '" + txbbuscarventa.Text + "'");

                 }
             }

             else
             {
                 MessageBox.Show("Seleccione el criterio de búsqueda");
             }
         }*/
    }
}
