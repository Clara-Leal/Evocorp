
namespace EvoCorp
{
    partial class frmusuario
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
            this.btncrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbcontraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbdocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbcorreoelectronico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbapellido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbnombreusuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(13, 319);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(142, 29);
            this.btncrear.TabIndex = 0;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los datos del nuevo usuario";
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(13, 87);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(162, 27);
            this.txbnombre.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(13, 64);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(64, 20);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // txbcontraseña
            // 
            this.txbcontraseña.Location = new System.Drawing.Point(203, 168);
            this.txbcontraseña.Name = "txbcontraseña";
            this.txbcontraseña.Size = new System.Drawing.Size(167, 27);
            this.txbcontraseña.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "C.I";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbdocumento
            // 
            this.txbdocumento.Location = new System.Drawing.Point(13, 248);
            this.txbdocumento.Name = "txbdocumento";
            this.txbdocumento.Size = new System.Drawing.Size(162, 27);
            this.txbdocumento.TabIndex = 6;
            this.txbdocumento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correo electrónico";
            // 
            // txbcorreoelectronico
            // 
            this.txbcorreoelectronico.Location = new System.Drawing.Point(203, 248);
            this.txbcorreoelectronico.Name = "txbcorreoelectronico";
            this.txbcorreoelectronico.Size = new System.Drawing.Size(167, 27);
            this.txbcorreoelectronico.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Apellido";
            // 
            // txbapellido
            // 
            this.txbapellido.Location = new System.Drawing.Point(203, 87);
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(167, 27);
            this.txbapellido.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre de usuario";
            // 
            // txbnombreusuario
            // 
            this.txbnombreusuario.Location = new System.Drawing.Point(13, 168);
            this.txbnombreusuario.Name = "txbnombreusuario";
            this.txbnombreusuario.Size = new System.Drawing.Size(162, 27);
            this.txbnombreusuario.TabIndex = 12;
            // 
            // frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 373);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbnombreusuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbapellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbcorreoelectronico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbdocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbcontraseña);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncrear);
            this.Name = "frmusuario";
            this.Text = "Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbcontraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbdocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbcorreoelectronico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbapellido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbnombreusuario;
    }
}