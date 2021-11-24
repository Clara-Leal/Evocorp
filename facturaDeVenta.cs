using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace EvoCorp
{
    public partial class frmFacturaDeVenta : Form
    {
        
        public frmFacturaDeVenta(string codigo, string cliente)
        {
            InitializeComponent();
            conexiones actualizar = new conexiones();
            actualizar.actualizar(dgvfacturaventa, "SELECT codigo_producto AS CODIGO, producto AS DESCRIPCION, precio_unitario AS UNITARIO, cantidad AS CANTIDAD, total AS TOTAL FROM factura WHERE numero_venta = "+codigo+"");
            lblnombrecliente.Text = cliente;
            lblnumeroventa.Text = codigo;
        }

        private void frmFacturaDeVenta_Load(object sender, EventArgs e)
        {

        }

        private void dgvfacturaventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = lblnombrecliente.Text + " " + lblnumeroventa.Text + ".PDF";
            guardar.ShowDialog();

            String paginahtml_texto = Properties.Resources.plantilla.ToString();
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using FileStream stream = new FileStream(guardar.FileName, FileMode.Create);
                {
                Document pdfDoc = new Document(PageSize.A5, 5, 5, 5, 5);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));
                    using(StreamReader sr = new StreamReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }


                    pdfDoc.Close();
                    stream.Close();
              

                }

            }

            
        }
    }
}
