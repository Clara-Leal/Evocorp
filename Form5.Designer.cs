
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
            this.btnvolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.SkyBlue;
            this.btncrear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncrear.Location = new System.Drawing.Point(252, 271);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(77, 25);
            this.btncrear.TabIndex = 0;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(101, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Quieres registrarte?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(11, 99);
            this.txbnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(142, 22);
            this.txbnombre.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Location = new System.Drawing.Point(11, 79);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(56, 17);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // txbcontraseña
            // 
            this.txbcontraseña.Location = new System.Drawing.Point(207, 168);
            this.txbcontraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcontraseña.Name = "txbcontraseña";
            this.txbcontraseña.Size = new System.Drawing.Size(192, 22);
            this.txbcontraseña.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "C.I";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbdocumento
            // 
            this.txbdocumento.Location = new System.Drawing.Point(11, 236);
            this.txbdocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbdocumento.Name = "txbdocumento";
            this.txbdocumento.Size = new System.Drawing.Size(142, 22);
            this.txbdocumento.TabIndex = 6;
            this.txbdocumento.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(207, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Correo electrónico";
            // 
            // txbcorreoelectronico
            // 
            this.txbcorreoelectronico.Location = new System.Drawing.Point(207, 236);
            this.txbcorreoelectronico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcorreoelectronico.Name = "txbcorreoelectronico";
            this.txbcorreoelectronico.Size = new System.Drawing.Size(192, 22);
            this.txbcorreoelectronico.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(207, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Apellido";
            // 
            // txbapellido
            // 
            this.txbapellido.Location = new System.Drawing.Point(207, 99);
            this.txbapellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(192, 22);
            this.txbapellido.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre de usuario";
            // 
            // txbnombreusuario
            // 
            this.txbnombreusuario.Location = new System.Drawing.Point(11, 168);
            this.txbnombreusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnombreusuario.Name = "txbnombreusuario";
            this.txbnombreusuario.Size = new System.Drawing.Size(142, 22);
            this.txbnombreusuario.TabIndex = 12;
            // 
            // btnvolver
            // 
            this.btnvolver.BackColor = System.Drawing.Color.SkyBlue;
            this.btnvolver.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnvolver.Location = new System.Drawing.Point(37, 271);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(78, 25);
            this.btnvolver.TabIndex = 14;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = false;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(146, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ingresa los datos.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvoCorp.Properties.Resources.wallpaperbetter__1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(411, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvolver);
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
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmusuario";
            this.Text = "Registrar nuevo usuario";
            this.Load += new System.EventHandler(this.frmusuario_Load);
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
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Label label2;
    }
}