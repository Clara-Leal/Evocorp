
namespace EvoCorp
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.chbordenarporcliente = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbordenarportotal = new System.Windows.Forms.CheckBox();
            this.chbordenarporfecha = new System.Windows.Forms.CheckBox();
            this.lblprobarfecha = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodaslascompras)).BeginInit();
            this.SuspendLayout();
            // 
            // chbordenarporcliente
            // 
            this.chbordenarporcliente.AutoSize = true;
            this.chbordenarporcliente.Location = new System.Drawing.Point(504, 114);
            this.chbordenarporcliente.Name = "chbordenarporcliente";
            this.chbordenarporcliente.Size = new System.Drawing.Size(160, 24);
            this.chbordenarporcliente.TabIndex = 35;
            this.chbordenarporcliente.Text = "Ordenar por cliente";
            this.chbordenarporcliente.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Buscar ventas";
            // 
            // chbordenarportotal
            // 
            this.chbordenarportotal.AutoSize = true;
            this.chbordenarportotal.Location = new System.Drawing.Point(281, 114);
            this.chbordenarportotal.Name = "chbordenarportotal";
            this.chbordenarportotal.Size = new System.Drawing.Size(147, 24);
            this.chbordenarportotal.TabIndex = 33;
            this.chbordenarportotal.Text = "Ordenar por total";
            this.chbordenarportotal.UseVisualStyleBackColor = true;
            this.chbordenarportotal.CheckedChanged += new System.EventHandler(this.chbordenarportotal_CheckedChanged);
            // 
            // chbordenarporfecha
            // 
            this.chbordenarporfecha.AutoSize = true;
            this.chbordenarporfecha.Location = new System.Drawing.Point(58, 114);
            this.chbordenarporfecha.Name = "chbordenarporfecha";
            this.chbordenarporfecha.Size = new System.Drawing.Size(152, 24);
            this.chbordenarporfecha.TabIndex = 32;
            this.chbordenarporfecha.Text = "Ordenar por fecha";
            this.chbordenarporfecha.UseVisualStyleBackColor = true;
            this.chbordenarporfecha.CheckedChanged += new System.EventHandler(this.chbordenarporfecha_CheckedChanged);
            // 
            // lblprobarfecha
            // 
            this.lblprobarfecha.AutoSize = true;
            this.lblprobarfecha.Location = new System.Drawing.Point(443, 20);
            this.lblprobarfecha.Name = "lblprobarfecha";
            this.lblprobarfecha.Size = new System.Drawing.Size(50, 20);
            this.lblprobarfecha.TabIndex = 31;
            this.lblprobarfecha.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Buscar por:";
            // 
            // rbtbuscarporcompra
            // 
            this.rbtbuscarporcompra.AutoSize = true;
            this.rbtbuscarporcompra.Location = new System.Drawing.Point(96, 17);
            this.rbtbuscarporcompra.Name = "rbtbuscarporcompra";
            this.rbtbuscarporcompra.Size = new System.Drawing.Size(160, 24);
            this.rbtbuscarporcompra.TabIndex = 29;
            this.rbtbuscarporcompra.TabStop = true;
            this.rbtbuscarporcompra.Text = "Número de compra";
            this.rbtbuscarporcompra.UseVisualStyleBackColor = true;
            this.rbtbuscarporcompra.CheckedChanged += new System.EventHandler(this.rbtbuscarporventa_CheckedChanged);
            // 
            // btnnuevacompra
            // 
            this.btnnuevacompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnnuevacompra.Location = new System.Drawing.Point(507, 611);
            this.btnnuevacompra.Name = "btnnuevacompra";
            this.btnnuevacompra.Size = new System.Drawing.Size(258, 39);
            this.btnnuevacompra.TabIndex = 28;
            this.btnnuevacompra.Text = "Ingresar nueva compra";
            this.btnnuevacompra.UseVisualStyleBackColor = true;
            this.btnnuevacompra.Click += new System.EventHandler(this.btnnuevacompra_Click);
            // 
            // datehasta
            // 
            this.datehasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datehasta.Location = new System.Drawing.Point(724, 14);
            this.datehasta.Name = "datehasta";
            this.datehasta.Size = new System.Drawing.Size(98, 27);
            this.datehasta.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hasta";
            // 
            // datedesde
            // 
            this.datedesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datedesde.Location = new System.Drawing.Point(556, 12);
            this.datedesde.Name = "datedesde";
            this.datedesde.Size = new System.Drawing.Size(98, 27);
            this.datedesde.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Desde";
            // 
            // rbtbuscrapornombrecliente
            // 
            this.rbtbuscrapornombrecliente.AutoSize = true;
            this.rbtbuscrapornombrecliente.Location = new System.Drawing.Point(261, 17);
            this.rbtbuscrapornombrecliente.Name = "rbtbuscrapornombrecliente";
            this.rbtbuscrapornombrecliente.Size = new System.Drawing.Size(154, 24);
            this.rbtbuscrapornombrecliente.TabIndex = 23;
            this.rbtbuscrapornombrecliente.TabStop = true;
            this.rbtbuscrapornombrecliente.Text = "Nombre de cliente";
            this.rbtbuscrapornombrecliente.UseVisualStyleBackColor = true;
            // 
            // txbbuscarcompra
            // 
            this.txbbuscarcompra.Location = new System.Drawing.Point(170, 62);
            this.txbbuscarcompra.Name = "txbbuscarcompra";
            this.txbbuscarcompra.Size = new System.Drawing.Size(595, 27);
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
            this.dgvtodaslascompras.Location = new System.Drawing.Point(48, 144);
            this.dgvtodaslascompras.Name = "dgvtodaslascompras";
            this.dgvtodaslascompras.RowHeadersWidth = 51;
            this.dgvtodaslascompras.RowTemplate.Height = 29;
            this.dgvtodaslascompras.Size = new System.Drawing.Size(717, 443);
            this.dgvtodaslascompras.TabIndex = 21;
            this.dgvtodaslascompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtodaslasventas_CellContentClick);
            // 
            // txbinicio
            // 
            this.txbinicio.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbinicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txbinicio.BackgroundImage")));
            this.txbinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txbinicio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txbinicio.Location = new System.Drawing.Point(48, 611);
            this.txbinicio.Name = "txbinicio";
            this.txbinicio.Size = new System.Drawing.Size(74, 43);
            this.txbinicio.TabIndex = 36;
            this.txbinicio.UseVisualStyleBackColor = false;
            this.txbinicio.Click += new System.EventHandler(this.txbinicio_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 662);
            this.Controls.Add(this.txbinicio);
            this.Controls.Add(this.chbordenarporcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbordenarportotal);
            this.Controls.Add(this.chbordenarporfecha);
            this.Controls.Add(this.lblprobarfecha);
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
            this.Name = "frmCompras";
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
    }
}