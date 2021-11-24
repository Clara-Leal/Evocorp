
namespace EvoCorp
{
    partial class frmresumenVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmresumenVentas));
            this.dgvtodaslasventas = new System.Windows.Forms.DataGridView();
            this.txbbuscarventa = new System.Windows.Forms.TextBox();
            this.rbtbuscrapornombrecliente = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.datedesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datehasta = new System.Windows.Forms.DateTimePicker();
            this.btnnuevaventa = new System.Windows.Forms.Button();
            this.rbtbuscarporventa = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbinicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodaslasventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtodaslasventas
            // 
            this.dgvtodaslasventas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvtodaslasventas.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvtodaslasventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvtodaslasventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtodaslasventas.Location = new System.Drawing.Point(87, 104);
            this.dgvtodaslasventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvtodaslasventas.Name = "dgvtodaslasventas";
            this.dgvtodaslasventas.RowHeadersWidth = 51;
            this.dgvtodaslasventas.RowTemplate.Height = 29;
            this.dgvtodaslasventas.Size = new System.Drawing.Size(625, 405);
            this.dgvtodaslasventas.TabIndex = 0;
            this.dgvtodaslasventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtodaslasventas_CellClick);
            this.dgvtodaslasventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtodaslasventas_CellContentClick);
            // 
            // txbbuscarventa
            // 
            this.txbbuscarventa.Location = new System.Drawing.Point(227, 57);
            this.txbbuscarventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbbuscarventa.Name = "txbbuscarventa";
            this.txbbuscarventa.Size = new System.Drawing.Size(420, 26);
            this.txbbuscarventa.TabIndex = 1;
            this.txbbuscarventa.TextChanged += new System.EventHandler(this.txbbuscarventa_TextChanged);
            this.txbbuscarventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbbuscarventa_KeyPress);
            // 
            // rbtbuscrapornombrecliente
            // 
            this.rbtbuscrapornombrecliente.AutoSize = true;
            this.rbtbuscrapornombrecliente.BackColor = System.Drawing.Color.Transparent;
            this.rbtbuscrapornombrecliente.Location = new System.Drawing.Point(300, 11);
            this.rbtbuscrapornombrecliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtbuscrapornombrecliente.Name = "rbtbuscrapornombrecliente";
            this.rbtbuscrapornombrecliente.Size = new System.Drawing.Size(167, 24);
            this.rbtbuscrapornombrecliente.TabIndex = 2;
            this.rbtbuscrapornombrecliente.TabStop = true;
            this.rbtbuscrapornombrecliente.Text = "Nombre de cliente";
            this.rbtbuscrapornombrecliente.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(470, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desde";
            // 
            // datedesde
            // 
            this.datedesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedesde.Location = new System.Drawing.Point(540, 11);
            this.datedesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datedesde.Name = "datedesde";
            this.datedesde.Size = new System.Drawing.Size(86, 26);
            this.datedesde.TabIndex = 9;
            this.datedesde.ValueChanged += new System.EventHandler(this.datedesde_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(632, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta";
            // 
            // datehasta
            // 
            this.datehasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datehasta.Location = new System.Drawing.Point(698, 11);
            this.datehasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datehasta.Name = "datehasta";
            this.datehasta.Size = new System.Drawing.Size(86, 26);
            this.datehasta.TabIndex = 11;
            // 
            // btnnuevaventa
            // 
            this.btnnuevaventa.BackColor = System.Drawing.Color.White;
            this.btnnuevaventa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnnuevaventa.Location = new System.Drawing.Point(464, 517);
            this.btnnuevaventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnuevaventa.Name = "btnnuevaventa";
            this.btnnuevaventa.Size = new System.Drawing.Size(226, 33);
            this.btnnuevaventa.TabIndex = 12;
            this.btnnuevaventa.Text = "Ingresar nueva venta";
            this.btnnuevaventa.UseVisualStyleBackColor = false;
            this.btnnuevaventa.Click += new System.EventHandler(this.btnnuevaventa_Click);
            // 
            // rbtbuscarporventa
            // 
            this.rbtbuscarporventa.AutoSize = true;
            this.rbtbuscarporventa.BackColor = System.Drawing.Color.Transparent;
            this.rbtbuscarporventa.Location = new System.Drawing.Point(114, 10);
            this.rbtbuscarporventa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtbuscarporventa.Name = "rbtbuscarporventa";
            this.rbtbuscarporventa.Size = new System.Drawing.Size(160, 24);
            this.rbtbuscarporventa.TabIndex = 13;
            this.rbtbuscarporventa.TabStop = true;
            this.rbtbuscarporventa.Text = "Número de venta";
            this.rbtbuscarporventa.UseVisualStyleBackColor = false;
            this.rbtbuscarporventa.CheckedChanged += new System.EventHandler(this.rbtbuscarporventa_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(8, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buscar por:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(54, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Buscar ventas";
            // 
            // txbinicio
            // 
            this.txbinicio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbinicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbinicio.BackgroundImage")));
            this.txbinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txbinicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txbinicio.Location = new System.Drawing.Point(30, 513);
            this.txbinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbinicio.Name = "txbinicio";
            this.txbinicio.Size = new System.Drawing.Size(45, 36);
            this.txbinicio.TabIndex = 37;
            this.txbinicio.UseVisualStyleBackColor = false;
            this.txbinicio.Click += new System.EventHandler(this.txbinicio_Click);
            // 
            // frmresumenVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvoCorp.Properties.Resources.wallpaperbetter__1_3;
            this.ClientSize = new System.Drawing.Size(794, 560);
            this.Controls.Add(this.txbinicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtbuscarporventa);
            this.Controls.Add(this.btnnuevaventa);
            this.Controls.Add(this.datehasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datedesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtbuscrapornombrecliente);
            this.Controls.Add(this.txbbuscarventa);
            this.Controls.Add(this.dgvtodaslasventas);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmresumenVentas";
            this.Text = "Resumen de ventas ";
            this.Load += new System.EventHandler(this.frmresumenVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodaslasventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtodaslasventas;
        private System.Windows.Forms.TextBox txbbuscarventa;
        private System.Windows.Forms.RadioButton rbtbuscrapornombrecliente;
        private System.Windows.Forms.RadioButton rbtbuscarporproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datedesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datehasta;
        private System.Windows.Forms.Button btnnuevaventa;
        private System.Windows.Forms.RadioButton rbtbuscarporventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblprobarfecha;
        private System.Windows.Forms.CheckBox chbordenarporfecha;
        private System.Windows.Forms.CheckBox chbordenarportotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbordenarporcliente;
        private System.Windows.Forms.Button txbinicio;
    }
}