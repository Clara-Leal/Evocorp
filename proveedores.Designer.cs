
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ckbnuevo_proveedor = new System.Windows.Forms.CheckBox();
            this.ckbbuscar_proveedor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(544, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // ckbnuevo_proveedor
            // 
            this.ckbnuevo_proveedor.AutoSize = true;
            this.ckbnuevo_proveedor.Location = new System.Drawing.Point(12, 12);
            this.ckbnuevo_proveedor.Name = "ckbnuevo_proveedor";
            this.ckbnuevo_proveedor.Size = new System.Drawing.Size(147, 24);
            this.ckbnuevo_proveedor.TabIndex = 1;
            this.ckbnuevo_proveedor.Text = "Nuevo proveedor";
            this.ckbnuevo_proveedor.UseVisualStyleBackColor = true;
            // 
            // ckbbuscar_proveedor
            // 
            this.ckbbuscar_proveedor.AutoSize = true;
            this.ckbbuscar_proveedor.Location = new System.Drawing.Point(12, 58);
            this.ckbbuscar_proveedor.Name = "ckbbuscar_proveedor";
            this.ckbbuscar_proveedor.Size = new System.Drawing.Size(147, 24);
            this.ckbbuscar_proveedor.TabIndex = 2;
            this.ckbbuscar_proveedor.Text = "Buscar proveedor";
            this.ckbbuscar_proveedor.UseVisualStyleBackColor = true;
            // 
            // frmproveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ckbbuscar_proveedor);
            this.Controls.Add(this.ckbnuevo_proveedor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmproveedores";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox ckbnuevo_proveedor;
        private System.Windows.Forms.CheckBox ckbbuscar_proveedor;
    }
}