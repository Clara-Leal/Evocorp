
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
            this.lblprobarfecha = new System.Windows.Forms.Label();
            this.chbordenarporfecha = new System.Windows.Forms.CheckBox();
            this.chbordenarportotal = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbordenarporcliente = new System.Windows.Forms.CheckBox();
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
            this.dgvtodaslasventas.Location = new System.Drawing.Point(56, 145);
            this.dgvtodaslasventas.Name = "dgvtodaslasventas";
            this.dgvtodaslasventas.RowHeadersWidth = 51;
            this.dgvtodaslasventas.RowTemplate.Height = 29;
            this.dgvtodaslasventas.Size = new System.Drawing.Size(732, 443);
            this.dgvtodaslasventas.TabIndex = 0;
            this.dgvtodaslasventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtodaslasventas_CellContentClick);
            // 
            // txbbuscarventa
            // 
            this.txbbuscarventa.Location = new System.Drawing.Point(184, 67);
            this.txbbuscarventa.Name = "txbbuscarventa";
            this.txbbuscarventa.Size = new System.Drawing.Size(604, 27);
            this.txbbuscarventa.TabIndex = 1;
            this.txbbuscarventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbbuscarventa_KeyPress);
            // 
            // rbtbuscrapornombrecliente
            // 
            this.rbtbuscrapornombrecliente.AutoSize = true;
            this.rbtbuscrapornombrecliente.Location = new System.Drawing.Point(266, 12);
            this.rbtbuscrapornombrecliente.Name = "rbtbuscrapornombrecliente";
            this.rbtbuscrapornombrecliente.Size = new System.Drawing.Size(154, 24);
            this.rbtbuscrapornombrecliente.TabIndex = 2;
            this.rbtbuscrapornombrecliente.TabStop = true;
            this.rbtbuscrapornombrecliente.Text = "Nombre de cliente";
            this.rbtbuscrapornombrecliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Desde";
            // 
            // datedesde
            // 
            this.datedesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedesde.Location = new System.Drawing.Point(595, 9);
            this.datedesde.Name = "datedesde";
            this.datedesde.Size = new System.Drawing.Size(98, 27);
            this.datedesde.TabIndex = 9;
            this.datedesde.ValueChanged += new System.EventHandler(this.datedesde_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasta";
            // 
            // datehasta
            // 
            this.datehasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datehasta.Location = new System.Drawing.Point(763, 11);
            this.datehasta.Name = "datehasta";
            this.datehasta.Size = new System.Drawing.Size(98, 27);
            this.datehasta.TabIndex = 11;
            // 
            // btnnuevaventa
            // 
            this.btnnuevaventa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnnuevaventa.Location = new System.Drawing.Point(530, 594);
            this.btnnuevaventa.Name = "btnnuevaventa";
            this.btnnuevaventa.Size = new System.Drawing.Size(258, 39);
            this.btnnuevaventa.TabIndex = 12;
            this.btnnuevaventa.Text = "Ingresar nueva venta";
            this.btnnuevaventa.UseVisualStyleBackColor = true;
            this.btnnuevaventa.Click += new System.EventHandler(this.btnnuevaventa_Click);
            // 
            // rbtbuscarporventa
            // 
            this.rbtbuscarporventa.AutoSize = true;
            this.rbtbuscarporventa.Location = new System.Drawing.Point(101, 12);
            this.rbtbuscarporventa.Name = "rbtbuscarporventa";
            this.rbtbuscarporventa.Size = new System.Drawing.Size(145, 24);
            this.rbtbuscarporventa.TabIndex = 13;
            this.rbtbuscarporventa.TabStop = true;
            this.rbtbuscarporventa.Text = "Número de venta";
            this.rbtbuscarporventa.UseVisualStyleBackColor = true;
            this.rbtbuscarporventa.CheckedChanged += new System.EventHandler(this.rbtbuscarporventa_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Buscar por:";
            // 
            // lblprobarfecha
            // 
            this.lblprobarfecha.AutoSize = true;
            this.lblprobarfecha.Location = new System.Drawing.Point(468, 14);
            this.lblprobarfecha.Name = "lblprobarfecha";
            this.lblprobarfecha.Size = new System.Drawing.Size(50, 20);
            this.lblprobarfecha.TabIndex = 16;
            this.lblprobarfecha.Text = "label4";
            this.lblprobarfecha.Click += new System.EventHandler(this.lblprobarfecha_Click);
            // 
            // chbordenarporfecha
            // 
            this.chbordenarporfecha.AutoSize = true;
            this.chbordenarporfecha.Location = new System.Drawing.Point(60, 115);
            this.chbordenarporfecha.Name = "chbordenarporfecha";
            this.chbordenarporfecha.Size = new System.Drawing.Size(152, 24);
            this.chbordenarporfecha.TabIndex = 17;
            this.chbordenarporfecha.Text = "Ordenar por fecha";
            this.chbordenarporfecha.UseVisualStyleBackColor = true;
            this.chbordenarporfecha.CheckedChanged += new System.EventHandler(this.chbordenarporfecha_CheckedChanged);
            // 
            // chbordenarportotal
            // 
            this.chbordenarportotal.AutoSize = true;
            this.chbordenarportotal.Location = new System.Drawing.Point(283, 115);
            this.chbordenarportotal.Name = "chbordenarportotal";
            this.chbordenarportotal.Size = new System.Drawing.Size(147, 24);
            this.chbordenarportotal.TabIndex = 18;
            this.chbordenarportotal.Text = "Ordenar por total";
            this.chbordenarportotal.UseVisualStyleBackColor = true;
            this.chbordenarportotal.CheckedChanged += new System.EventHandler(this.chbordenarportotal_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Buscar ventas";
            // 
            // chbordenarporcliente
            // 
            this.chbordenarporcliente.AutoSize = true;
            this.chbordenarporcliente.Location = new System.Drawing.Point(506, 115);
            this.chbordenarporcliente.Name = "chbordenarporcliente";
            this.chbordenarporcliente.Size = new System.Drawing.Size(160, 24);
            this.chbordenarporcliente.TabIndex = 20;
            this.chbordenarporcliente.Text = "Ordenar por cliente";
            this.chbordenarporcliente.UseVisualStyleBackColor = true;
            // 
            // txbinicio
            // 
            this.txbinicio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbinicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbinicio.BackgroundImage")));
            this.txbinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txbinicio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txbinicio.Location = new System.Drawing.Point(56, 604);
            this.txbinicio.Name = "txbinicio";
            this.txbinicio.Size = new System.Drawing.Size(74, 43);
            this.txbinicio.TabIndex = 37;
            this.txbinicio.UseVisualStyleBackColor = false;
            this.txbinicio.Click += new System.EventHandler(this.txbinicio_Click);
            // 
            // frmresumenVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 659);
            this.Controls.Add(this.txbinicio);
            this.Controls.Add(this.chbordenarporcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbordenarportotal);
            this.Controls.Add(this.chbordenarporfecha);
            this.Controls.Add(this.lblprobarfecha);
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