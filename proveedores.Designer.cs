
namespace EvoCorp
{
    partial class frmproveedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproveedores));
            this.dgvproveedores = new System.Windows.Forms.DataGridView();
            this.txbbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscarproveedor = new System.Windows.Forms.Button();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.txbdocumento = new System.Windows.Forms.TextBox();
            this.txbrazonsocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnañadircliente = new System.Windows.Forms.Button();
            this.btnmodificarproveedor = new System.Windows.Forms.Button();
            this.btneliminarproveedor = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbtelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbdireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbcomentario = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproveedores
            // 
            this.dgvproveedores.AllowUserToAddRows = false;
            this.dgvproveedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedores.Location = new System.Drawing.Point(351, 71);
            this.dgvproveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvproveedores.Name = "dgvproveedores";
            this.dgvproveedores.RowHeadersWidth = 51;
            this.dgvproveedores.RowTemplate.Height = 29;
            this.dgvproveedores.Size = new System.Drawing.Size(778, 418);
            this.dgvproveedores.TabIndex = 0;
            this.dgvproveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproveedores_CellClick);
            this.dgvproveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproveedores_CellContentClick);
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(480, 27);
            this.txbbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(387, 26);
            this.txbbuscar.TabIndex = 3;
            this.txbbuscar.TextChanged += new System.EventHandler(this.txbbuscar_TextChanged);
            // 
            // btnbuscarproveedor
            // 
            this.btnbuscarproveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnbuscarproveedor.Location = new System.Drawing.Point(888, 26);
            this.btnbuscarproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscarproveedor.Name = "btnbuscarproveedor";
            this.btnbuscarproveedor.Size = new System.Drawing.Size(101, 25);
            this.btnbuscarproveedor.TabIndex = 4;
            this.btnbuscarproveedor.Text = "Buscar";
            this.btnbuscarproveedor.UseVisualStyleBackColor = true;
            this.btnbuscarproveedor.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(11, 116);
            this.txbnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(149, 26);
            this.txbnombre.TabIndex = 5;
            // 
            // txbdocumento
            // 
            this.txbdocumento.Location = new System.Drawing.Point(187, 116);
            this.txbdocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbdocumento.Name = "txbdocumento";
            this.txbdocumento.Size = new System.Drawing.Size(124, 26);
            this.txbdocumento.TabIndex = 6;
            // 
            // txbrazonsocial
            // 
            this.txbrazonsocial.Location = new System.Drawing.Point(11, 190);
            this.txbrazonsocial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbrazonsocial.Name = "txbrazonsocial";
            this.txbrazonsocial.Size = new System.Drawing.Size(149, 26);
            this.txbrazonsocial.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(187, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Razón social";
            // 
            // btnañadircliente
            // 
            this.btnañadircliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btnañadircliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnañadircliente.Location = new System.Drawing.Point(10, 380);
            this.btnañadircliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadircliente.Name = "btnañadircliente";
            this.btnañadircliente.Size = new System.Drawing.Size(299, 35);
            this.btnañadircliente.TabIndex = 16;
            this.btnañadircliente.Text = "Añadir";
            this.btnañadircliente.UseVisualStyleBackColor = false;
            this.btnañadircliente.Click += new System.EventHandler(this.btnañadircliente_Click);
            // 
            // btnmodificarproveedor
            // 
            this.btnmodificarproveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmodificarproveedor.Location = new System.Drawing.Point(10, 419);
            this.btnmodificarproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodificarproveedor.Name = "btnmodificarproveedor";
            this.btnmodificarproveedor.Size = new System.Drawing.Size(299, 33);
            this.btnmodificarproveedor.TabIndex = 17;
            this.btnmodificarproveedor.Text = "Modificar";
            this.btnmodificarproveedor.UseVisualStyleBackColor = true;
            this.btnmodificarproveedor.Click += new System.EventHandler(this.btnmodificarproveedor_Click);
            // 
            // btneliminarproveedor
            // 
            this.btneliminarproveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneliminarproveedor.Location = new System.Drawing.Point(11, 457);
            this.btneliminarproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminarproveedor.Name = "btneliminarproveedor";
            this.btneliminarproveedor.Size = new System.Drawing.Size(299, 33);
            this.btneliminarproveedor.TabIndex = 18;
            this.btneliminarproveedor.Text = "Eliminar";
            this.btneliminarproveedor.UseVisualStyleBackColor = true;
            this.btneliminarproveedor.Click += new System.EventHandler(this.btneliminarproveedor_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Transparent;
            this.btnvolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolver.BackgroundImage")));
            this.btnvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvolver.Location = new System.Drawing.Point(13, 503);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(42, 37);
            this.btnvolver.TabIndex = 19;
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(186, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Teléfono";
            // 
            // txbtelefono
            // 
            this.txbtelefono.Location = new System.Drawing.Point(187, 190);
            this.txbtelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtelefono.Name = "txbtelefono";
            this.txbtelefono.Size = new System.Drawing.Size(123, 26);
            this.txbtelefono.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dirección";
            // 
            // txbdireccion
            // 
            this.txbdireccion.Location = new System.Drawing.Point(10, 256);
            this.txbdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbdireccion.Name = "txbdireccion";
            this.txbdireccion.Size = new System.Drawing.Size(298, 26);
            this.txbdireccion.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Comentario";
            // 
            // txbcomentario
            // 
            this.txbcomentario.Location = new System.Drawing.Point(12, 312);
            this.txbcomentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcomentario.Multiline = true;
            this.txbcomentario.Name = "txbcomentario";
            this.txbcomentario.Size = new System.Drawing.Size(298, 46);
            this.txbcomentario.TabIndex = 24;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfecha.ForeColor = System.Drawing.Color.Transparent;
            this.lblfecha.Location = new System.Drawing.Point(351, 503);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(60, 21);
            this.lblfecha.TabIndex = 26;
            this.lblfecha.Text = "label7";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblhora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblhora.Location = new System.Drawing.Point(887, 503);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(60, 21);
            this.lblhora.TabIndex = 27;
            this.lblhora.Text = "label8";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(76, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 44);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ingreso de informacion de\r\nproveedores";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1142, 561);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbcomentario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbtelefono);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btneliminarproveedor);
            this.Controls.Add(this.btnmodificarproveedor);
            this.Controls.Add(this.btnañadircliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbrazonsocial);
            this.Controls.Add(this.txbdocumento);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.btnbuscarproveedor);
            this.Controls.Add(this.txbbuscar);
            this.Controls.Add(this.dgvproveedores);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmproveedores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "proveedores";
            this.Load += new System.EventHandler(this.frmproveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproveedores;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbuscarproveedor;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.TextBox txbdocumento;
        private System.Windows.Forms.TextBox txbrazonsocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtbuscarproveedor;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnañadircliente;
        private System.Windows.Forms.Button btnmodificarproveedor;
        private System.Windows.Forms.Button btneliminarproveedor;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbtelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbdireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbcomentario;
        private System.Windows.Forms.TextBox txbbuscar;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chbproveedores;
        private System.Windows.Forms.CheckBox chbclientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}