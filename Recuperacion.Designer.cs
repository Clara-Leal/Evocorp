
namespace EvoCorp
{
    partial class frmrecuperacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnenviarCodigo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.btnrecuperarContraseña = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese información de  correo de recuperación";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(22, 87);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(230, 27);
            this.txbusuario.TabIndex = 1;
            this.txbusuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 428);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 10);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // btnenviarCodigo
            // 
            this.btnenviarCodigo.Location = new System.Drawing.Point(270, 87);
            this.btnenviarCodigo.Name = "btnenviarCodigo";
            this.btnenviarCodigo.Size = new System.Drawing.Size(123, 29);
            this.btnenviarCodigo.TabIndex = 4;
            this.btnenviarCodigo.Text = "Enviar código";
            this.btnenviarCodigo.UseVisualStyleBackColor = true;
            this.btnenviarCodigo.Click += new System.EventHandler(this.btnenviarCodigo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar código";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(142, 206);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(121, 27);
            this.txbcodigo.TabIndex = 6;
            // 
            // btnrecuperarContraseña
            // 
            this.btnrecuperarContraseña.Location = new System.Drawing.Point(12, 253);
            this.btnrecuperarContraseña.Name = "btnrecuperarContraseña";
            this.btnrecuperarContraseña.Size = new System.Drawing.Size(251, 29);
            this.btnrecuperarContraseña.TabIndex = 7;
            this.btnrecuperarContraseña.Text = "Recuperar contraseña";
            this.btnrecuperarContraseña.UseVisualStyleBackColor = true;
            this.btnrecuperarContraseña.Click += new System.EventHandler(this.btnrecuperarContraseña_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "usuario";
            // 
            // frmrecuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnrecuperarContraseña);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnenviarCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txbusuario);
            this.Controls.Add(this.label1);
            this.Name = "frmrecuperacion";
            this.Text = "Recuperacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenviarCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btncodigoderecuperacion;
        private System.Windows.Forms.Button btnrecuperarContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbcodigo;
    }
}