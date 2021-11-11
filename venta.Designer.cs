
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
            this.btnbuscar_cliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbcodigo_cliente = new System.Windows.Forms.TextBox();
            this.txbNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbvalorUnitario = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnbuscarProducto = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlitems = new System.Windows.Forms.Panel();
            this.btnagregar_producto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbuscar_cliente
            // 
            this.btnbuscar_cliente.Location = new System.Drawing.Point(542, 55);
            this.btnbuscar_cliente.Name = "btnbuscar_cliente";
            this.btnbuscar_cliente.Size = new System.Drawing.Size(156, 29);
            this.btnbuscar_cliente.TabIndex = 0;
            this.btnbuscar_cliente.Text = "BUSCAR ";
            this.btnbuscar_cliente.UseVisualStyleBackColor = true;
            this.btnbuscar_cliente.Click += new System.EventHandler(this.btnbuscar_cliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbcodigo_cliente
            // 
            this.txbcodigo_cliente.Location = new System.Drawing.Point(146, 55);
            this.txbcodigo_cliente.Name = "txbcodigo_cliente";
            this.txbcodigo_cliente.Size = new System.Drawing.Size(84, 27);
            this.txbcodigo_cliente.TabIndex = 2;
            this.txbcodigo_cliente.Text = "2";
            this.txbcodigo_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_cliente_KeyPress);
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.Location = new System.Drawing.Point(313, 55);
            this.txbNombreCliente.Multiline = true;
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.Size = new System.Drawing.Size(182, 27);
            this.txbNombreCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "COD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.BackColor = System.Drawing.SystemColors.Info;
            this.lblcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcantidad.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcantidad.Location = new System.Drawing.Point(585, 135);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(102, 27);
            this.lblcantidad.TabIndex = 7;
            this.lblcantidad.Text = "CANTIDAD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(170, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "PRODUCTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(402, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "VALOR UNITARIO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(23, 186);
            this.txbcodigo.Multiline = true;
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(84, 33);
            this.txbcodigo.TabIndex = 14;
            this.txbcodigo.TextChanged += new System.EventHandler(this.txbcodigo_TextChanged);
            this.txbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_KeyPress);
            this.txbcodigo.Leave += new System.EventHandler(this.txbcodigo_Leave);
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(585, 186);
            this.txbCantidad.Multiline = true;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(102, 33);
            this.txbCantidad.TabIndex = 15;
            // 
            // txbProducto
            // 
            this.txbProducto.Location = new System.Drawing.Point(170, 186);
            this.txbProducto.Multiline = true;
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.Size = new System.Drawing.Size(201, 33);
            this.txbProducto.TabIndex = 16;
            // 
            // txbvalorUnitario
            // 
            this.txbvalorUnitario.Location = new System.Drawing.Point(402, 186);
            this.txbvalorUnitario.Multiline = true;
            this.txbvalorUnitario.Name = "txbvalorUnitario";
            this.txbvalorUnitario.Size = new System.Drawing.Size(153, 33);
            this.txbvalorUnitario.TabIndex = 17;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(733, 485);
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(118, 48);
            this.textBox28.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(624, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 30);
            this.label6.TabIndex = 44;
            this.label6.Text = "TOTAL";
            // 
            // btnbuscarProducto
            // 
            this.btnbuscarProducto.Location = new System.Drawing.Point(122, 184);
            this.btnbuscarProducto.Name = "btnbuscarProducto";
            this.btnbuscarProducto.Size = new System.Drawing.Size(30, 29);
            this.btnbuscarProducto.TabIndex = 46;
            this.btnbuscarProducto.Text = "...";
            this.btnbuscarProducto.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Nombre";
            // 
            // pnlitems
            // 
            this.pnlitems.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlitems.Location = new System.Drawing.Point(23, 239);
            this.pnlitems.Name = "pnlitems";
            this.pnlitems.Size = new System.Drawing.Size(828, 240);
            this.pnlitems.TabIndex = 54;
            // 
            // btnagregar_producto
            // 
            this.btnagregar_producto.Location = new System.Drawing.Point(733, 135);
            this.btnagregar_producto.Name = "btnagregar_producto";
            this.btnagregar_producto.Size = new System.Drawing.Size(101, 84);
            this.btnagregar_producto.TabIndex = 56;
            this.btnagregar_producto.Text = "AGREGAR";
            this.btnagregar_producto.UseVisualStyleBackColor = true;
            this.btnagregar_producto.Click += new System.EventHandler(this.btnagregar_producto_Click);
            // 
            // frmventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 562);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.btnagregar_producto);
            this.Controls.Add(this.pnlitems);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnbuscarProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.txbvalorUnitario);
            this.Controls.Add(this.txbProducto);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbcodigo_cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbuscar_cliente);
            this.Name = "frmventa";
            this.Text = "venta";
            this.Load += new System.EventHandler(this.frmventa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbuscar_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbcodigo_cliente;
        private System.Windows.Forms.TextBox txbNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbvalorUnitario;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnbuscarProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlitems;
        private System.Windows.Forms.Button btnagregar_producto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
    }
}