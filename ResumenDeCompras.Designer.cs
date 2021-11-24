
namespace EvoCorp
{
    partial class frmresumencompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmresumencompras));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtbuscarporcompra = new System.Windows.Forms.RadioButton();
            this.btnnuevacompra = new System.Windows.Forms.Button();
            this.datehasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datedesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtbuscrapornombrecliente = new System.Windows.Forms.RadioButton();
            this.txbbuscarcompra = new System.Windows.Forms.TextBox();
            this.dgvtodaslascompras = new System.Windows.Forms.DataGridView();
            this.txbinicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodaslascompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Buscar ventas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Buscar por:";
            // 
            // rbtbuscarporcompra
            // 
            this.rbtbuscarporcompra.AutoSize = true;
            this.rbtbuscarporcompra.BackColor = System.Drawing.Color.Transparent;
            this.rbtbuscarporcompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtbuscarporcompra.Location = new System.Drawing.Point(112, 14);
            this.rbtbuscarporcompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtbuscarporcompra.Name = "rbtbuscarporcompra";
            this.rbtbuscarporcompra.Size = new System.Drawing.Size(174, 24);
            this.rbtbuscarporcompra.TabIndex = 29;
            this.rbtbuscarporcompra.TabStop = true;
            this.rbtbuscarporcompra.Text = "Número de compra";
            this.rbtbuscarporcompra.UseVisualStyleBackColor = false;
            this.rbtbuscarporcompra.CheckedChanged += new System.EventHandler(this.rbtbuscarporventa_CheckedChanged);
            // 
            // btnnuevacompra
            // 
            this.btnnuevacompra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnnuevacompra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnnuevacompra.Location = new System.Drawing.Point(537, 515);
            this.btnnuevacompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnuevacompra.Name = "btnnuevacompra";
            this.btnnuevacompra.Size = new System.Drawing.Size(226, 33);
            this.btnnuevacompra.TabIndex = 28;
            this.btnnuevacompra.Text = "Ingresar nueva compra";
            this.btnnuevacompra.UseVisualStyleBackColor = false;
            this.btnnuevacompra.Click += new System.EventHandler(this.btnnuevacompra_Click);
            // 
            // datehasta
            // 
            this.datehasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datehasta.Location = new System.Drawing.Point(774, 14);
            this.datehasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datehasta.Name = "datehasta";
            this.datehasta.Size = new System.Drawing.Size(86, 26);
            this.datehasta.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(703, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hasta";
            // 
            // datedesde
            // 
            this.datedesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedesde.Location = new System.Drawing.Point(599, 10);
            this.datedesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datedesde.Name = "datedesde";
            this.datedesde.Size = new System.Drawing.Size(86, 26);
            this.datedesde.TabIndex = 25;
            this.datedesde.ValueChanged += new System.EventHandler(this.datedesde_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(517, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Desde";
            // 
            // rbtbuscrapornombrecliente
            // 
            this.rbtbuscrapornombrecliente.AutoSize = true;
            this.rbtbuscrapornombrecliente.BackColor = System.Drawing.Color.Transparent;
            this.rbtbuscrapornombrecliente.Location = new System.Drawing.Point(292, 13);
            this.rbtbuscrapornombrecliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtbuscrapornombrecliente.Name = "rbtbuscrapornombrecliente";
            this.rbtbuscrapornombrecliente.Size = new System.Drawing.Size(197, 24);
            this.rbtbuscrapornombrecliente.TabIndex = 23;
            this.rbtbuscrapornombrecliente.TabStop = true;
            this.rbtbuscrapornombrecliente.Text = "Nombre de proveedor";
            this.rbtbuscrapornombrecliente.UseVisualStyleBackColor = false;
            this.rbtbuscrapornombrecliente.CheckedChanged += new System.EventHandler(this.rbtbuscrapornombrecliente_CheckedChanged);
            // 
            // txbbuscarcompra
            // 
            this.txbbuscarcompra.Location = new System.Drawing.Point(193, 50);
            this.txbbuscarcompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbbuscarcompra.Name = "txbbuscarcompra";
            this.txbbuscarcompra.Size = new System.Drawing.Size(424, 26);
            this.txbbuscarcompra.TabIndex = 22;
            this.txbbuscarcompra.TextChanged += new System.EventHandler(this.txbbuscarventa_TextChanged);
            this.txbbuscarcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbbuscarventa_KeyPress);
            // 
            // dgvtodaslascompras
            // 
            this.dgvtodaslascompras.AllowUserToAddRows = false;
            this.dgvtodaslascompras.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvtodaslascompras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvtodaslascompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtodaslascompras.Location = new System.Drawing.Point(42, 96);
            this.dgvtodaslascompras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvtodaslascompras.Name = "dgvtodaslascompras";
            this.dgvtodaslascompras.RowHeadersWidth = 51;
            this.dgvtodaslascompras.RowTemplate.Height = 29;
            this.dgvtodaslascompras.Size = new System.Drawing.Size(721, 402);
            this.dgvtodaslascompras.TabIndex = 21;
            this.dgvtodaslascompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtodaslasventas_CellContentClick);
            // 
            // txbinicio
            // 
            this.txbinicio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbinicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbinicio.BackgroundImage")));
            this.txbinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txbinicio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txbinicio.Location = new System.Drawing.Point(42, 515);
            this.txbinicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbinicio.Name = "txbinicio";
            this.txbinicio.Size = new System.Drawing.Size(43, 36);
            this.txbinicio.TabIndex = 36;
            this.txbinicio.UseVisualStyleBackColor = false;
            this.txbinicio.Click += new System.EventHandler(this.txbinicio_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(217, 517);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 37;
            this.button1.Text = "Exportar a Excell";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmresumencompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvoCorp.Properties.Resources.wallpaperbetter__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(872, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbinicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtbuscarporcompra);
            this.Controls.Add(this.btnnuevacompra);
            this.Controls.Add(this.datehasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datedesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtbuscrapornombrecliente);
            this.Controls.Add(this.txbbuscarcompra);
            this.Controls.Add(this.dgvtodaslascompras);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmresumencompras";
            this.Text = "Resumen de compras";
            this.Load += new System.EventHandler(this.frmcompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodaslascompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbordenarporcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbordenarportotal;
        private System.Windows.Forms.CheckBox chbordenarporfecha;
        private System.Windows.Forms.Label lblprobarfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtbuscarporcompra;
        private System.Windows.Forms.Button btnnuevacompra;
        private System.Windows.Forms.DateTimePicker datehasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datedesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtbuscrapornombrecliente;
        private System.Windows.Forms.TextBox txbbuscarcompra;
        private System.Windows.Forms.DataGridView dgvtodaslascompras;
        private System.Windows.Forms.Button txbinicio;
        private System.Windows.Forms.Button button1;
    }
}