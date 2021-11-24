
namespace EvoCorp
{
    partial class frmproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproductos));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.txbprecio = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.dgvproductos = new System.Windows.Forms.DataGridView();
            this.btneliminiar = new System.Windows.Forms.Button();
            this.txbinicio = new System.Windows.Forms.Button();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.txbbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnañadirproducto = new System.Windows.Forms.Button();
            this.btnañadiracompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblcodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcodigo.Location = new System.Drawing.Point(24, 25);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(76, 20);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "CÓDIGO";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnombre.Location = new System.Drawing.Point(20, 84);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(74, 20);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.BackColor = System.Drawing.Color.Transparent;
            this.lblprecio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblprecio.Location = new System.Drawing.Point(31, 138);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(65, 20);
            this.lblprecio.TabIndex = 3;
            this.lblprecio.Text = "PRECIO";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbcodigo.Location = new System.Drawing.Point(117, 23);
            this.txbcodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(196, 26);
            this.txbcodigo.TabIndex = 5;
            this.txbcodigo.TextChanged += new System.EventHandler(this.txbcodigo_TextChanged);
            this.txbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_KeyPress);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(117, 81);
            this.txbnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(196, 26);
            this.txbnombre.TabIndex = 6;
            // 
            // txbprecio
            // 
            this.txbprecio.Location = new System.Drawing.Point(117, 135);
            this.txbprecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbprecio.Name = "txbprecio";
            this.txbprecio.Size = new System.Drawing.Size(196, 26);
            this.txbprecio.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnagregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnagregar.Location = new System.Drawing.Point(9, 246);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(82, 25);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnmodificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmodificar.Location = new System.Drawing.Point(108, 246);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(100, 25);
            this.btnmodificar.TabIndex = 9;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // dgvproductos
            // 
            this.dgvproductos.AllowUserToAddRows = false;
            this.dgvproductos.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproductos.Location = new System.Drawing.Point(340, 23);
            this.dgvproductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.Height = 29;
            this.dgvproductos.Size = new System.Drawing.Size(645, 363);
            this.dgvproductos.TabIndex = 12;
            this.dgvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellClick);
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproductos_CellContentClick);
            // 
            // btneliminiar
            // 
            this.btneliminiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btneliminiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btneliminiar.Location = new System.Drawing.Point(231, 246);
            this.btneliminiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminiar.Name = "btneliminiar";
            this.btneliminiar.Size = new System.Drawing.Size(82, 25);
            this.btneliminiar.TabIndex = 15;
            this.btneliminiar.Text = "ELIMINAR";
            this.btneliminiar.UseVisualStyleBackColor = false;
            this.btneliminiar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txbinicio
            // 
            this.txbinicio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbinicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbinicio.BackgroundImage")));
            this.txbinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txbinicio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txbinicio.Location = new System.Drawing.Point(9, 399);
            this.txbinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbinicio.Name = "txbinicio";
            this.txbinicio.Size = new System.Drawing.Size(45, 36);
            this.txbinicio.TabIndex = 16;
            this.txbinicio.UseVisualStyleBackColor = false;
            this.txbinicio.Click += new System.EventHandler(this.txbinicio_Click);
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(20, 190);
            this.cbxcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(293, 28);
            this.cbxcategoria.TabIndex = 18;
            this.cbxcategoria.Text = "Categoría";
            this.cbxcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(10, 296);
            this.txbbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbbuscar.Multiline = true;
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(303, 46);
            this.txbbuscar.TabIndex = 19;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnbuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnbuscar.Location = new System.Drawing.Point(10, 360);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(303, 35);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnañadirproducto
            // 
            this.btnañadirproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnañadirproducto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnañadirproducto.ForeColor = System.Drawing.Color.Black;
            this.btnañadirproducto.Location = new System.Drawing.Point(385, 399);
            this.btnañadirproducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadirproducto.Name = "btnañadirproducto";
            this.btnañadirproducto.Size = new System.Drawing.Size(223, 36);
            this.btnañadirproducto.TabIndex = 20;
            this.btnañadirproducto.Text = "Añadir a venta";
            this.btnañadirproducto.UseVisualStyleBackColor = false;
            this.btnañadirproducto.Click += new System.EventHandler(this.btnañadirproducto_Click);
            // 
            // btnañadiracompra
            // 
            this.btnañadiracompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnañadiracompra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnañadiracompra.ForeColor = System.Drawing.Color.Black;
            this.btnañadiracompra.Location = new System.Drawing.Point(720, 399);
            this.btnañadiracompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnañadiracompra.Name = "btnañadiracompra";
            this.btnañadiracompra.Size = new System.Drawing.Size(223, 36);
            this.btnañadiracompra.TabIndex = 21;
            this.btnañadiracompra.Text = "Añadir a compra";
            this.btnañadiracompra.UseVisualStyleBackColor = false;
            this.btnañadiracompra.Click += new System.EventHandler(this.btnañadiracompra_Click);
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1001, 446);
            this.Controls.Add(this.btnañadiracompra);
            this.Controls.Add(this.btnañadirproducto);
            this.Controls.Add(this.txbbuscar);
            this.Controls.Add(this.cbxcategoria);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txbinicio);
            this.Controls.Add(this.btneliminiar);
            this.Controls.Add(this.dgvproductos);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txbprecio);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmproductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.TextBox txbprecio;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.DataGridView dgvproductos;
        private System.Windows.Forms.Button btneliminiar;
        private System.Windows.Forms.Button txbinicio;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.TextBox txbbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnañadirproducto;
        private System.Windows.Forms.Button btnañadiracompra;
    }
}