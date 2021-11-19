
namespace EvoCorp
{
    partial class frmnuevo_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnuevo_usuario));
            this.btnregistrarse = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblcedula = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.txbapellido = new System.Windows.Forms.TextBox();
            this.txbcedula = new System.Windows.Forms.TextBox();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.txbcontraseña = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.Location = new System.Drawing.Point(181, 284);
            this.btnregistrarse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(97, 39);
            this.btnregistrarse.TabIndex = 0;
            this.btnregistrarse.Text = "Registrarse";
            this.btnregistrarse.UseVisualStyleBackColor = true;
            this.btnregistrarse.Click += new System.EventHandler(this.btnregistrarse_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Location = new System.Drawing.Point(38, 86);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(56, 17);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.BackColor = System.Drawing.Color.Transparent;
            this.lblapellido.Location = new System.Drawing.Point(31, 128);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(58, 17);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "Apellido";
            this.lblapellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.BackColor = System.Drawing.Color.Transparent;
            this.lblcedula.Location = new System.Drawing.Point(66, 169);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(23, 17);
            this.lblcedula.TabIndex = 3;
            this.lblcedula.Text = "C.I";
            this.lblcedula.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.Transparent;
            this.lblusuario.Location = new System.Drawing.Point(38, 212);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(51, 17);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "Usuario";
            this.lblusuario.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblcontraseña.Location = new System.Drawing.Point(12, 246);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(77, 17);
            this.lblcontraseña.TabIndex = 5;
            this.lblcontraseña.Text = "Contraseña";
            this.lblcontraseña.Click += new System.EventHandler(this.label5_Click);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(109, 86);
            this.txbnombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(341, 22);
            this.txbnombre.TabIndex = 6;
            // 
            // txbapellido
            // 
            this.txbapellido.Location = new System.Drawing.Point(109, 128);
            this.txbapellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(341, 22);
            this.txbapellido.TabIndex = 7;
            // 
            // txbcedula
            // 
            this.txbcedula.Location = new System.Drawing.Point(109, 169);
            this.txbcedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcedula.Name = "txbcedula";
            this.txbcedula.Size = new System.Drawing.Size(136, 22);
            this.txbcedula.TabIndex = 8;
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(109, 209);
            this.txbusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(187, 22);
            this.txbusuario.TabIndex = 9;
            this.txbusuario.TextChanged += new System.EventHandler(this.txbusuario_TextChanged);
            // 
            // txbcontraseña
            // 
            this.txbcontraseña.Location = new System.Drawing.Point(109, 246);
            this.txbcontraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbcontraseña.Name = "txbcontraseña";
            this.txbcontraseña.Size = new System.Drawing.Size(341, 22);
            this.txbcontraseña.TabIndex = 10;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(307, 284);
            this.btningresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(87, 39);
            this.btningresar.TabIndex = 11;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::EvoCorp.Properties.Resources.descarga__3_;
            this.pictureBox1.Location = new System.Drawing.Point(242, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmnuevo_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(526, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txbcontraseña);
            this.Controls.Add(this.txbusuario);
            this.Controls.Add(this.txbcedula);
            this.Controls.Add(this.txbapellido);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcedula);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnregistrarse);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmnuevo_usuario";
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.frmnuevo_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnregistrarse;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblcedula;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.TextBox txbapellido;
        private System.Windows.Forms.TextBox txbcedula;
        private System.Windows.Forms.TextBox txbusuario;
        private System.Windows.Forms.TextBox txbcontraseña;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}