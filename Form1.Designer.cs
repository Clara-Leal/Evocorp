
namespace EvoCorp
{
    partial class frmclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmclientes));
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbcomentario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbdireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbtelefono = new System.Windows.Forms.TextBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btneliminarcliente = new System.Windows.Forms.Button();
            this.btnmodificarproveedor = new System.Windows.Forms.Button();
            this.btnañadircliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbdocumento = new System.Windows.Forms.TextBox();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.btnbuscarcliente = new System.Windows.Forms.Button();
            this.txbbuscar = new System.Windows.Forms.TextBox();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(80, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 44);
            this.label7.TabIndex = 52;
            this.label7.Text = "Ingreso de informacion de\r\n clientes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblhora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblhora.Location = new System.Drawing.Point(892, 501);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(60, 21);
            this.lblhora.TabIndex = 50;
            this.lblhora.Text = "label8";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfecha.ForeColor = System.Drawing.Color.Transparent;
            this.lblfecha.Location = new System.Drawing.Point(355, 501);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(60, 21);
            this.lblfecha.TabIndex = 49;
            this.lblfecha.Text = "label7";
            this.lblfecha.Click += new System.EventHandler(this.lblfecha_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Comentario";
            // 
            // txbcomentario
            // 
            this.txbcomentario.Location = new System.Drawing.Point(12, 294);
            this.txbcomentario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcomentario.Multiline = true;
            this.txbcomentario.Name = "txbcomentario";
            this.txbcomentario.Size = new System.Drawing.Size(298, 46);
            this.txbcomentario.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(17, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Dirección";
            // 
            // txbdireccion
            // 
            this.txbdireccion.Location = new System.Drawing.Point(14, 238);
            this.txbdireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbdireccion.Name = "txbdireccion";
            this.txbdireccion.Size = new System.Drawing.Size(298, 27);
            this.txbdireccion.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(190, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Teléfono";
            // 
            // txbtelefono
            // 
            this.txbtelefono.Location = new System.Drawing.Point(191, 171);
            this.txbtelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbtelefono.Name = "txbtelefono";
            this.txbtelefono.Size = new System.Drawing.Size(119, 27);
            this.txbtelefono.TabIndex = 43;
            this.txbtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbtelefono_KeyPress);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.Transparent;
            this.btnvolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolver.BackgroundImage")));
            this.btnvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvolver.Location = new System.Drawing.Point(17, 485);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(42, 37);
            this.btnvolver.TabIndex = 42;
            this.btnvolver.UseVisualStyleBackColor = false;
            // 
            // btneliminarcliente
            // 
            this.btneliminarcliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneliminarcliente.Location = new System.Drawing.Point(15, 439);
            this.btneliminarcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminarcliente.Name = "btneliminarcliente";
            this.btneliminarcliente.Size = new System.Drawing.Size(299, 33);
            this.btneliminarcliente.TabIndex = 41;
            this.btneliminarcliente.Text = "Eliminar";
            this.btneliminarcliente.UseVisualStyleBackColor = true;
            this.btneliminarcliente.Click += new System.EventHandler(this.btneliminarcliente_Click);
            // 
            // btnmodificarproveedor
            // 
            this.btnmodificarproveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmodificarproveedor.Location = new System.Drawing.Point(14, 401);
            this.btnmodificarproveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodificarproveedor.Name = "btnmodificarproveedor";
            this.btnmodificarproveedor.Size = new System.Drawing.Size(299, 33);
            this.btnmodificarproveedor.TabIndex = 40;
            this.btnmodificarproveedor.Text = "Modificar";
            this.btnmodificarproveedor.UseVisualStyleBackColor = true;
            this.btnmodificarproveedor.Click += new System.EventHandler(this.btnmodificarproveedor_Click);
            // 
            // btnañadircliente
            // 
            this.btnañadircliente.BackColor = System.Drawing.Color.Gainsboro;
            this.btnañadircliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnañadircliente.Location = new System.Drawing.Point(14, 362);
            this.btnañadircliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadircliente.Name = "btnañadircliente";
            this.btnañadircliente.Size = new System.Drawing.Size(299, 35);
            this.btnañadircliente.TabIndex = 39;
            this.btnañadircliente.Text = "Añadir";
            this.btnañadircliente.UseVisualStyleBackColor = false;
            this.btnañadircliente.Click += new System.EventHandler(this.btnañadircliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nombre";
            // 
            // txbdocumento
            // 
            this.txbdocumento.Location = new System.Drawing.Point(17, 171);
            this.txbdocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbdocumento.Name = "txbdocumento";
            this.txbdocumento.Size = new System.Drawing.Size(124, 27);
            this.txbdocumento.TabIndex = 34;
            this.txbdocumento.TextChanged += new System.EventHandler(this.txbdocumento_TextChanged);
            this.txbdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbdocumento_KeyPress);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(15, 98);
            this.txbnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(295, 27);
            this.txbnombre.TabIndex = 33;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnbuscarcliente.Location = new System.Drawing.Point(892, 8);
            this.btnbuscarcliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(101, 25);
            this.btnbuscarcliente.TabIndex = 32;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(484, 9);
            this.txbbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(387, 27);
            this.txbbuscar.TabIndex = 31;
            // 
            // dgvclientes
            // 
            this.dgvclientes.AllowUserToAddRows = false;
            this.dgvclientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(355, 53);
            this.dgvclientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.RowHeadersWidth = 51;
            this.dgvclientes.RowTemplate.Height = 29;
            this.dgvclientes.Size = new System.Drawing.Size(778, 430);
            this.dgvclientes.TabIndex = 30;
            this.dgvclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientes_CellClick);
            // 
            // frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 542);
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
            this.Controls.Add(this.btneliminarcliente);
            this.Controls.Add(this.btnmodificarproveedor);
            this.Controls.Add(this.btnañadircliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbdocumento);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.txbbuscar);
            this.Controls.Add(this.dgvclientes);
            this.Name = "frmclientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbcomentario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbdireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbtelefono;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btneliminarcliente;
        private System.Windows.Forms.Button btnmodificarproveedor;
        private System.Windows.Forms.Button btnañadircliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbrazonsocial;
        private System.Windows.Forms.TextBox txbdocumento;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.Button btnbuscarcliente;
        private System.Windows.Forms.TextBox txbbuscar;
        private System.Windows.Forms.DataGridView dgvclientes;
    }
}