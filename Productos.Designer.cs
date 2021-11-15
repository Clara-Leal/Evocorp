
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(28, 30);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(65, 20);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "CÓDIGO";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(23, 99);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(70, 20);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(35, 162);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(58, 20);
            this.lblprecio.TabIndex = 3;
            this.lblprecio.Text = "PRECIO";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(103, 27);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(223, 27);
            this.txbcodigo.TabIndex = 5;
            this.txbcodigo.TextChanged += new System.EventHandler(this.txbcodigo_TextChanged);
            this.txbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcodigo_KeyPress);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(103, 96);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(223, 27);
            this.txbnombre.TabIndex = 6;
            // 
            // txbprecio
            // 
            this.txbprecio.Location = new System.Drawing.Point(103, 159);
            this.txbprecio.Name = "txbprecio";
            this.txbprecio.Size = new System.Drawing.Size(223, 27);
            this.txbprecio.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.Info;
            this.btnagregar.Location = new System.Drawing.Point(10, 289);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(94, 29);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.SystemColors.Info;
            this.btnmodificar.Location = new System.Drawing.Point(119, 289);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(94, 29);
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
            this.dgvproductos.Location = new System.Drawing.Point(388, 27);
            this.dgvproductos.Name = "dgvproductos";
            this.dgvproductos.RowHeadersWidth = 51;
            this.dgvproductos.RowTemplate.Height = 29;
            this.dgvproductos.Size = new System.Drawing.Size(737, 426);
            this.dgvproductos.TabIndex = 12;
            this.dgvproductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproductos_CellClick);
            this.dgvproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgproductos_CellContentClick);
            // 
            // btneliminiar
            // 
            this.btneliminiar.BackColor = System.Drawing.SystemColors.Info;
            this.btneliminiar.Location = new System.Drawing.Point(232, 289);
            this.btneliminiar.Name = "btneliminiar";
            this.btneliminiar.Size = new System.Drawing.Size(94, 29);
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
            this.txbinicio.Location = new System.Drawing.Point(10, 469);
            this.txbinicio.Name = "txbinicio";
            this.txbinicio.Size = new System.Drawing.Size(74, 43);
            this.txbinicio.TabIndex = 16;
            this.txbinicio.UseVisualStyleBackColor = false;
            this.txbinicio.Click += new System.EventHandler(this.txbinicio_Click);
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(35, 224);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(291, 28);
            this.cbxcategoria.TabIndex = 18;
            this.cbxcategoria.Text = "Categoría";
            this.cbxcategoria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txbbuscar
            // 
            this.txbbuscar.Location = new System.Drawing.Point(12, 358);
            this.txbbuscar.Multiline = true;
            this.txbbuscar.Name = "txbbuscar";
            this.txbbuscar.Size = new System.Drawing.Size(316, 44);
            this.txbbuscar.TabIndex = 19;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.SystemColors.Info;
            this.btnbuscar.Location = new System.Drawing.Point(12, 424);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(316, 29);
            this.btnbuscar.TabIndex = 17;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnañadirproducto
            // 
            this.btnañadirproducto.Location = new System.Drawing.Point(646, 473);
            this.btnañadirproducto.Name = "btnañadirproducto";
            this.btnañadirproducto.Size = new System.Drawing.Size(298, 29);
            this.btnañadirproducto.TabIndex = 20;
            this.btnañadirproducto.Text = "Añadir producto";
            this.btnañadirproducto.UseVisualStyleBackColor = true;
            this.btnañadirproducto.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // frmproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 514);
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
    }
}