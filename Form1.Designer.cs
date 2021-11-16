
namespace EvoCorp
{
    partial class frmcambiarcontraseña
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
            this.button1 = new System.Windows.Forms.Button();
            this.txbnombredeusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbcorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txbnombredeusuario
            // 
            this.txbnombredeusuario.Location = new System.Drawing.Point(44, 50);
            this.txbnombredeusuario.Name = "txbnombredeusuario";
            this.txbnombredeusuario.Size = new System.Drawing.Size(125, 27);
            this.txbnombredeusuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbcorreo
            // 
            this.txbcorreo.Location = new System.Drawing.Point(221, 50);
            this.txbcorreo.Name = "txbcorreo";
            this.txbcorreo.Size = new System.Drawing.Size(234, 27);
            this.txbcorreo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Correo de recuperación";
            // 
            // frmcambiarcontraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbcorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbnombredeusuario);
            this.Controls.Add(this.button1);
            this.Name = "frmcambiarcontraseña";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmcambiarcontraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbnombredeusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbcorreo;
        private System.Windows.Forms.Label label2;
    }
}