using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoCorp
{
    public partial class frmFacturaDeVenta : Form
    {
        
        public frmFacturaDeVenta(string codigo)
        {
            InitializeComponent();
            conexiones actualizar = new conexiones();
            MessageBox.Show("SELECT (codigo_producto AS CODIGO, producto AS DESCRIPCION, precio_unitario AS PRECIO UNIT, cantidad AS CANTIDAD, total AS TOTAL) FROM factura WHERE numero_venta = '" + codigo + "'");
            actualizar.actualizar(dgvfacturaventa, "SELECT codigo_producto AS CODIGO, producto AS DESCRIPCION, precio_unitario AS UNITARIO, cantidad AS CANTIDAD, total AS TOTAL FROM factura WHERE numero_venta = "+codigo+"");
        }

        private void frmFacturaDeVenta_Load(object sender, EventArgs e)
        {

        }

        private void dgvfacturaventa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
