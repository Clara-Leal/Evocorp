
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
            this.btnbuscarcliente = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproveedores
            // 
            this.dgvproveedores.AllowUserToAddRows = false;
            this.dgvproveedores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproveedores.Location = new System.Drawing.Point(401, 84);
            this.dgvproveedores.Name = "dgvproveedores";
            this.dgvproveedores.RowHeadersWidth = 51;
            this.dgvproveedores.RowTemplate.Height = 29;
            this.dgvproveedores.Size = new System.Drawing.Size(889, 492);
            this.dgvproveedores.TabIndex = 0;
            this.dgvproveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproveedores_CellClick);
            this.dgvproveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproveedores_CellContentClick);
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(549, 32);
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(442, 27);
            this.txbbuscar.TabIndex = 3;
            // 
            // btnbuscarcliente
            // 
            this.btnbuscarcliente.Location = new System.Drawing.Point(1015, 31);
            this.btnbuscarcliente.Name = "btnbuscarcliente";
            this.btnbuscarcliente.Size = new System.Drawing.Size(115, 29);
            this.btnbuscarcliente.TabIndex = 4;
            this.btnbuscarcliente.Text = "Buscar";
            this.btnbuscarcliente.UseVisualStyleBackColor = true;
            this.btnbuscarcliente.Click += new System.EventHandler(this.btnbuscarcliente_Click);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(13, 136);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(170, 27);
            this.txbnombre.TabIndex = 5;
            // 
            // txbdocumento
            // 
            this.txbdocumento.Location = new System.Drawing.Point(230, 136);
            this.txbdocumento.Name = "txbdocumento";
            this.txbdocumento.Size = new System.Drawing.Size(124, 27);
            this.txbdocumento.TabIndex = 6;
            // 
            // txbrazonsocial
            // 
            this.txbrazonsocial.Location = new System.Drawing.Point(13, 220);
            this.txbrazonsocial.Name = "txbrazonsocial";
            this.txbrazonsocial.Size = new System.Drawing.Size(170, 27);
            this.txbrazonsocial.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Razón social";
            // 
            // btnañadircliente
            // 
            this.btnañadircliente.Location = new System.Drawing.Point(12, 447);
            this.btnañadircliente.Name = "btnañadircliente";
            this.btnañadircliente.Size = new System.Drawing.Size(342, 26);
            this.btnañadircliente.TabIndex = 16;
            this.btnañadircliente.Text = "Añadir";
            this.btnañadircliente.UseVisualStyleBackColor = true;
            this.btnañadircliente.Click += new System.EventHandler(this.btnañadircliente_Click);
            // 
            // btnmodificarproveedor
            // 
            this.btnmodificarproveedor.Location = new System.Drawing.Point(12, 493);
            this.btnmodificarproveedor.Name = "btnmodificarproveedor";
            this.btnmodificarproveedor.Size = new System.Drawing.Size(342, 26);
            this.btnmodificarproveedor.TabIndex = 17;
            this.btnmodificarproveedor.Text = "Modificar";
            this.btnmodificarproveedor.UseVisualStyleBackColor = true;
            this.btnmodificarproveedor.Click += new System.EventHandler(this.btnmodificarproveedor_Click);
            // 
            // btneliminarproveedor
            // 
            this.btneliminarproveedor.Location = new System.Drawing.Point(13, 537);
            this.btneliminarproveedor.Name = "btneliminarproveedor";
            this.btneliminarproveedor.Size = new System.Drawing.Size(342, 26);
            this.btneliminarproveedor.TabIndex = 18;
            this.btneliminarproveedor.Text = "Eliminar";
            this.btneliminarproveedor.UseVisualStyleBackColor = true;
            this.btneliminarproveedor.Click += new System.EventHandler(this.btneliminarproveedor_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnvolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvolver.BackgroundImage")));
            this.btnvolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnvolver.Location = new System.Drawing.Point(13, 574);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(91, 38);
            this.btnvolver.TabIndex = 19;
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Teléfono";
            // 
            // txbtelefono
            // 
            this.txbtelefono.Location = new System.Drawing.Point(214, 220);
            this.txbtelefono.Name = "txbtelefono";
            this.txbtelefono.Size = new System.Drawing.Size(140, 27);
            this.txbtelefono.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Dirección";
            // 
            // txbdireccion
            // 
            this.txbdireccion.Location = new System.Drawing.Point(12, 302);
            this.txbdireccion.Name = "txbdireccion";
            this.txbdireccion.Size = new System.Drawing.Size(340, 27);
            this.txbdireccion.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Comentario";
            // 
            // txbcomentario
            // 
            this.txbcomentario.Location = new System.Drawing.Point(15, 364);
            this.txbcomentario.Multiline = true;
            this.txbcomentario.Name = "txbcomentario";
            this.txbcomentario.Size = new System.Drawing.Size(340, 53);
            this.txbcomentario.TabIndex = 24;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(401, 592);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(50, 20);
            this.lblfecha.TabIndex = 26;
            this.lblfecha.Text = "label7";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Location = new System.Drawing.Point(1014, 592);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(50, 20);
            this.lblhora.TabIndex = 27;
            this.lblhora.Text = "label8";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // frmproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 629);
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
            this.Controls.Add(this.btnbuscarcliente);
            this.Controls.Add(this.txbbuscar);
            this.Controls.Add(this.dgvproveedores);
            this.Name = "frmproveedores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "proveedores";
            this.Load += new System.EventHandler(this.frmproveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproveedores;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbuscarcliente;
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
    }
}