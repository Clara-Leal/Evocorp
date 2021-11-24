
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnenviarCodigo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbcodigo = new System.Windows.Forms.TextBox();
            this.btnrecuperarContraseña = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbcorreo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // btnenviarCodigo
            // 
            this.btnenviarCodigo.Location = new System.Drawing.Point(90, 182);
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
            this.label3.Location = new System.Drawing.Point(50, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar código";
            // 
            // txbcodigo
            // 
            this.txbcodigo.Location = new System.Drawing.Point(180, 307);
            this.txbcodigo.Name = "txbcodigo";
            this.txbcodigo.Size = new System.Drawing.Size(121, 27);
            this.txbcodigo.TabIndex = 6;
            // 
            // btnrecuperarContraseña
            // 
            this.btnrecuperarContraseña.Location = new System.Drawing.Point(50, 354);
            this.btnrecuperarContraseña.Name = "btnrecuperarContraseña";
            this.btnrecuperarContraseña.Size = new System.Drawing.Size(251, 29);
            this.btnrecuperarContraseña.TabIndex = 7;
            this.btnrecuperarContraseña.Text = "Recuperar contraseña";
            this.btnrecuperarContraseña.UseVisualStyleBackColor = true;
            this.btnrecuperarContraseña.Click += new System.EventHandler(this.btnrecuperarContraseña_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbusuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbcorreo);
            this.groupBox1.Controls.Add(this.btnenviarCodigo);
            this.groupBox1.Location = new System.Drawing.Point(46, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 241);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese datos de usuario a recuperar";
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(25, 59);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(230, 27);
            this.txbusuario.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Correo electrónico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "usuario";
            // 
            // txbcorreo
            // 
            this.txbcorreo.Location = new System.Drawing.Point(25, 150);
            this.txbcorreo.Name = "txbcorreo";
            this.txbcorreo.Size = new System.Drawing.Size(230, 27);
            this.txbcorreo.TabIndex = 9;
            // 
            // frmrecuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnrecuperarContraseña);
            this.Controls.Add(this.txbcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmrecuperacion";
            this.Text = "Recuperacion";
            this.Load += new System.EventHandler(this.frmrecuperacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnenviarCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btncodigoderecuperacion;
        private System.Windows.Forms.Button btnrecuperarContraseña;
        private System.Windows.Forms.TextBox txbcodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbcorreo;
    }
}