
namespace EvoCorp
{
    partial class frmcompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcompra));
            this.btnexportarPDF = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.dgvcompras = new System.Windows.Forms.DataGridView();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnagregar_producto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnbuscarProducto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbvalorUnitario = new System.Windows.Forms.TextBox();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbnombreproveedor = new System.Windows.Forms.TextBox();
            this.txbcodigo_proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar_proveedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexportarPDF
            // 
            this.btnexportarPDF.Location = new System.Drawing.Point(118, 486);
            this.btnexportarPDF.Name = "btnexportarPDF";
            this.btnexportarPDF.Size = new System.Drawing.Size(130, 36);
            this.btnexportarPDF.TabIndex = 91;
            this.btnexportarPDF.Text = "Exportar a PDF";
            this.btnexportarPDF.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(757, 306);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 57);
            this.btnEliminar.TabIndex = 90;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotal.Location = new System.Drawing.Point(589, 486);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(78, 36);
            this.lbltotal.TabIndex = 89;
            this.lbltotal.Text = "total";
            // 
            // dgvcompras
            // 
            this.dgvcompras.AllowUserToAddRows = false;
            this.dgvcompras.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvcompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcompras.Location = new System.Drawing.Point(22, 211);
            this.dgvcompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvcompras.Name = "dgvcompras";
            this.dgvcompras.RowHeadersWidth = 51;
            this.dgvcompras.RowTemplate.Height = 29;
            this.dgvcompras.Size = new System.Drawing.Size(712, 250);
            this.dgvcompras.TabIndex = 88;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(440, 45);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(127, 27);
            this.dtpfecha.TabIndex = 87;
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.Location = new System.Drawing.Point(726, 490);
            this.btnfinalizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(119, 32);
            this.btnfinalizar.TabIndex = 86;
            this.btnfinalizar.Text = "FINALIZAR";
            this.btnfinalizar.UseVisualStyleBackColor = true;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnvolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolver.BackgroundImage")));
            this.btnvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvolver.Location = new System.Drawing.Point(22, 486);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(45, 39);
            this.btnvolver.TabIndex = 85;
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcantidad.Location = new System.Drawing.Point(638, 122);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(112, 24);
            this.lblcantidad.TabIndex = 74;
            this.lblcantidad.Text = "CANTIDAD";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(638, 166);
            this.txbCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(97, 27);
            this.txbCantidad.TabIndex = 78;
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // btnagregar_producto
            // 
            this.btnagregar_producto.BackColor = System.Drawing.Color.White;
            this.btnagregar_producto.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnagregar_producto.Location = new System.Drawing.Point(757, 230);
            this.btnagregar_producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar_producto.Name = "btnagregar_producto";
            this.btnagregar_producto.Size = new System.Drawing.Size(88, 57);
            this.btnagregar_producto.TabIndex = 84;
            this.btnagregar_producto.Text = "AGREGAR";
            this.btnagregar_producto.UseVisualStyleBackColor = false;
            this.btnagregar_producto.Click += new System.EventHandler(this.btnagregar_producto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(171, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 83;
            this.label9.Text = "Nombre";
            // 
            // btnbuscarProducto
            // 
            this.btnbuscarProducto.Location = new System.Drawing.Point(118, 167);
            this.btnbuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscarProducto.Name = "btnbuscarProducto";
            this.btnbuscarProducto.Size = new System.Drawing.Size(26, 25);
            this.btnbuscarProducto.TabIndex = 82;
            this.btnbuscarProducto.Text = "...";
            this.btnbuscarProducto.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(431, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 81;
            this.label6.Text = "TOTAL";
            // 
            // txbvalorUnitario
            // 
            this.txbvalorUnitario.Location = new System.Drawing.Point(431, 167);
            this.txbvalorUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbvalorUnitario.Name = "txbvalorUnitario";
            this.txbvalorUnitario.Size = new System.Drawing.Size(136, 27);
            this.txbvalorUnitario.TabIndex = 80;
            this.txbvalorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbvalorUnitario_KeyPress);
            // 
            // txbProducto
            // 
            this.txbProducto.Location = new System.Drawing.Point(171, 168);
            this.txbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(218, 27);
            this.txbProducto.TabIndex = 79;
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(26, 166);
            this.txbcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(74, 27);
            this.txbcodigo.TabIndex = 77;
            this.txbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(431, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 76;
            this.label4.Text = "VALOR UNITARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(171, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 75;
            this.label7.Text = "PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "COD";
            // 
            // txbnombreproveedor
            // 
            this.txbnombreproveedor.Location = new System.Drawing.Point(171, 47);
            this.txbnombreproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnombreproveedor.Multiline = true;
            this.txbnombreproveedor.Name = "txbnombreproveedor";
            this.txbnombreproveedor.Size = new System.Drawing.Size(160, 23);
            this.txbnombreproveedor.TabIndex = 72;
            // 
            // txbcodigo_proveedor
            // 
            this.txbcodigo_proveedor.ForeColor = System.Drawing.Color.Black;
            this.txbcodigo_proveedor.Location = new System.Drawing.Point(24, 47);
            this.txbcodigo_proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcodigo_proveedor.Name = "txbcodigo_proveedor";
            this.txbcodigo_proveedor.Size = new System.Drawing.Size(74, 27);
            this.txbcodigo_proveedor.TabIndex = 71;
            this.txbcodigo_proveedor.Text = "2";
            this.txbcodigo_proveedor.TextChanged += new System.EventHandler(this.txbcodigo_cliente_TextChanged);
            this.txbcodigo_proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_proveedor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 70;
            this.label1.Text = "Código ";
            // 
            // btnbuscar_proveedor
            // 
            this.btnbuscar_proveedor.Location = new System.Drawing.Point(104, 45);
            this.btnbuscar_proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar_proveedor.Name = "btnbuscar_proveedor";
            this.btnbuscar_proveedor.Size = new System.Drawing.Size(33, 25);
            this.btnbuscar_proveedor.TabIndex = 69;
            this.btnbuscar_proveedor.Text = "...";
            this.btnbuscar_proveedor.UseVisualStyleBackColor = true;
            this.btnbuscar_proveedor.Click += new System.EventHandler(this.btnbuscar_proveedor_Click);
            // 
            // frmcompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 545);
            this.Controls.Add(this.btnexportarPDF);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dgvcompras);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.btnagregar_producto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnbuscarProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbvalorUnitario);
            this.Controls.Add(this.txbProducto);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbnombreproveedor);
            this.Controls.Add(this.txbcodigo_proveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar_proveedor);
            this.Name = "frmcompra";
            this.Text = "compra";
            this.Load += new System.EventHandler(this.frmcompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridView dgvventa;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnagregar_producto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnbuscarProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbvalorUnitario;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbnombreCliente;
        private System.Windows.Forms.TextBox txbcodigo_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbuscar_cliente;
        private System.Windows.Forms.TextBox txbcodigo_;
        private System.Windows.Forms.Button btnexportarPDF;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.TextBox txbnombreproveedor;
        private System.Windows.Forms.TextBox txbcodigo_proveedor;
        private System.Windows.Forms.Button btnbuscar_proveedor;
        private System.Windows.Forms.DataGridView dgvcompras;
    }
}