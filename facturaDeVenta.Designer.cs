
namespace EvoCorp
{
    partial class frmFacturaDeVenta
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
            this.btnPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombrecliente = new System.Windows.Forms.Label();
            this.dgvfacturaventa = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblnumeroventa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacturaventa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(453, 484);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(162, 29);
            this.btnPDF.TabIndex = 0;
            this.btnPDF.Text = "Exportar a PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // lblnombrecliente
            // 
            this.lblnombrecliente.AutoSize = true;
            this.lblnombrecliente.Location = new System.Drawing.Point(88, 41);
            this.lblnombrecliente.Name = "lblnombrecliente";
            this.lblnombrecliente.Size = new System.Drawing.Size(15, 20);
            this.lblnombrecliente.TabIndex = 3;
            this.lblnombrecliente.Text = "-";
            // 
            // dgvfacturaventa
            // 
            this.dgvfacturaventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfacturaventa.Location = new System.Drawing.Point(13, 110);
            this.dgvfacturaventa.Name = "dgvfacturaventa";
            this.dgvfacturaventa.RowHeadersWidth = 51;
            this.dgvfacturaventa.RowTemplate.Height = 29;
            this.dgvfacturaventa.Size = new System.Drawing.Size(602, 354);
            this.dgvfacturaventa.TabIndex = 5;
            this.dgvfacturaventa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfacturaventa_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Venta";
            // 
            // lblnumeroventa
            // 
            this.lblnumeroventa.AutoSize = true;
            this.lblnumeroventa.Location = new System.Drawing.Point(337, 41);
            this.lblnumeroventa.Name = "lblnumeroventa";
            this.lblnumeroventa.Size = new System.Drawing.Size(15, 20);
            this.lblnumeroventa.TabIndex = 7;
            this.lblnumeroventa.Text = "-";
            // 
            // frmFacturaDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 525);
            this.Controls.Add(this.lblnumeroventa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvfacturaventa);
            this.Controls.Add(this.lblnombrecliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPDF);
            this.Name = "frmFacturaDeVenta";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frmFacturaDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfacturaventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombrecliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvfacturaventa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblnumeroventa;
    }
}