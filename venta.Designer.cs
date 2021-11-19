
namespace EvoCorp
{
    partial class frmventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmventa));
            this.btnbuscar_cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbcodigo_cliente = new System.Windows.Forms.TextBox();
            this.txbnombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbvalorUnitario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscarProducto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnagregar_producto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.dgvventa = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar_cliente
            // 
            this.btnbuscar_cliente.Location = new System.Drawing.Point(342, 44);
            this.btnbuscar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar_cliente.Name = "btnbuscar_cliente";
            this.btnbuscar_cliente.Size = new System.Drawing.Size(52, 25);
            this.btnbuscar_cliente.TabIndex = 0;
            this.btnbuscar_cliente.Text = "...";
            this.btnbuscar_cliente.UseVisualStyleBackColor = true;
            this.btnbuscar_cliente.Click += new System.EventHandler(this.btnbuscar_cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código ";
            // 
            // txbcodigo_cliente
            // 
            this.txbcodigo_cliente.Location = new System.Drawing.Point(10, 45);
            this.txbcodigo_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcodigo_cliente.Name = "txbcodigo_cliente";
            this.txbcodigo_cliente.Size = new System.Drawing.Size(74, 26);
            this.txbcodigo_cliente.TabIndex = 2;
            this.txbcodigo_cliente.Text = "2";
            this.txbcodigo_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_cliente_KeyPress);
            // 
            // txbnombreCliente
            // 
            this.txbnombreCliente.Location = new System.Drawing.Point(157, 45);
            this.txbnombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnombreCliente.Multiline = true;
            this.txbnombreCliente.Name = "txbnombreCliente";
            this.txbnombreCliente.Size = new System.Drawing.Size(160, 23);
            this.txbnombreCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "COD";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcantidad.Location = new System.Drawing.Point(624, 120);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(112, 24);
            this.lblcantidad.TabIndex = 7;
            this.lblcantidad.Text = "CANTIDAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(157, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "PRODUCTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(417, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "VALOR UNITARIO";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(12, 164);
            this.txbcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(74, 26);
            this.txbcodigo.TabIndex = 14;
            this.txbcodigo.TextChanged += new System.EventHandler(this.txbcodigo_TextChanged);
            this.txbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_KeyPress);
            this.txbcodigo.Leave += new System.EventHandler(this.txbcodigo_Leave);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(624, 164);
            this.txbCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(97, 26);
            this.txbCantidad.TabIndex = 15;
            this.txbCantidad.TextChanged += new System.EventHandler(this.txbCantidad_TextChanged);
            this.txbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantidad_KeyPress);
            // 
            // txbProducto
            // 
            this.txbProducto.Location = new System.Drawing.Point(157, 166);
            this.txbProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(218, 26);
            this.txbProducto.TabIndex = 16;
            // 
            // txbvalorUnitario
            // 
            this.txbvalorUnitario.Location = new System.Drawing.Point(417, 165);
            this.txbvalorUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbvalorUnitario.Name = "txbvalorUnitario";
            this.txbvalorUnitario.Size = new System.Drawing.Size(136, 26);
            this.txbvalorUnitario.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(317, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "TOTAL";
            // 
            // btnbuscarProducto
            // 
            this.btnbuscarProducto.Location = new System.Drawing.Point(104, 165);
            this.btnbuscarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscarProducto.Name = "btnbuscarProducto";
            this.btnbuscarProducto.Size = new System.Drawing.Size(26, 25);
            this.btnbuscarProducto.TabIndex = 46;
            this.btnbuscarProducto.Text = "...";
            this.btnbuscarProducto.UseVisualStyleBackColor = true;
            this.btnbuscarProducto.Click += new System.EventHandler(this.btnbuscarProducto_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(157, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 21);
            this.label9.TabIndex = 53;
            this.label9.Text = "Nombre";
            // 
            // btnagregar_producto
            // 
            this.btnagregar_producto.BackColor = System.Drawing.Color.White;
            this.btnagregar_producto.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnagregar_producto.Location = new System.Drawing.Point(762, 133);
            this.btnagregar_producto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar_producto.Name = "btnagregar_producto";
            this.btnagregar_producto.Size = new System.Drawing.Size(88, 57);
            this.btnagregar_producto.TabIndex = 56;
            this.btnagregar_producto.Text = "AGREGAR";
            this.btnagregar_producto.UseVisualStyleBackColor = false;
            this.btnagregar_producto.Click += new System.EventHandler(this.btnagregar_producto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(12, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 39);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(601, 478);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 59;
            this.button2.Text = "FINALIZAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(426, 43);
            this.dtpfecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(96, 26);
            this.dtpfecha.TabIndex = 64;
            // 
            // dgvventa
            // 
            this.dgvventa.AllowUserToAddRows = false;
            this.dgvventa.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventa.Location = new System.Drawing.Point(8, 209);
            this.dgvventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvventa.Name = "dgvventa";
            this.dgvventa.RowHeadersWidth = 51;
            this.dgvventa.RowTemplate.Height = 29;
            this.dgvventa.Size = new System.Drawing.Size(712, 250);
            this.dgvventa.TabIndex = 65;
           // this.dgvventa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvventa_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(762, 209);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 57);
            this.button3.TabIndex = 67;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotal.Location = new System.Drawing.Point(444, 484);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(78, 36);
            this.lbltotal.TabIndex = 66;
            this.lbltotal.Text = "total";
            // 
            // frmventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvoCorp.Properties.Resources.wallpaperbetter__1_1;
            this.ClientSize = new System.Drawing.Size(874, 529);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.dgvventa);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.txbnombreCliente);
            this.Controls.Add(this.txbcodigo_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar_cliente);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmventa";
            this.Text = "venta";
            this.Load += new System.EventHandler(this.frmventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbcodigo_cliente;
        private System.Windows.Forms.TextBox txbnombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbvalorUnitario;
        private System.Windows.Forms.TextBox txbtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnbuscarProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnagregar_producto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbdocumento;
        private System.Windows.Forms.CheckBox cbxcliente;
        private System.Windows.Forms.CheckBox cbxproveedor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvventa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label lbltotal;
    }
}