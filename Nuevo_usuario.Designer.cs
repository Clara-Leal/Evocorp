
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
            this.SuspendLayout();
            // 
            // btnregistrarse
            // 
            this.btnregistrarse.Location = new System.Drawing.Point(125, 336);
            this.btnregistrarse.Name = "btnregistrarse";
            this.btnregistrarse.Size = new System.Drawing.Size(244, 29);
            this.btnregistrarse.TabIndex = 0;
            this.btnregistrarse.Text = "Registrarse";
            this.btnregistrarse.UseVisualStyleBackColor = true;
            this.btnregistrarse.Click += new System.EventHandler(this.btnregistrarse_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(35, 50);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(64, 20);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(33, 92);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(66, 20);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "Apellido";
            this.lblapellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblcedula
            // 
            this.lblcedula.AutoSize = true;
            this.lblcedula.Location = new System.Drawing.Point(63, 145);
            this.lblcedula.Name = "lblcedula";
            this.lblcedula.Size = new System.Drawing.Size(25, 20);
            this.lblcedula.TabIndex = 3;
            this.lblcedula.Text = "C.I";
            this.lblcedula.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(40, 199);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(59, 20);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "Usuario";
            this.lblusuario.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(16, 249);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(83, 20);
            this.lblcontraseña.TabIndex = 5;
            this.lblcontraseña.Text = "Contraseña";
            this.lblcontraseña.Click += new System.EventHandler(this.label5_Click);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(125, 50);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(339, 27);
            this.txbnombre.TabIndex = 6;
            // 
            // txbapellido
            // 
            this.txbapellido.Location = new System.Drawing.Point(125, 92);
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(339, 27);
            this.txbapellido.TabIndex = 7;
            // 
            // txbcedula
            // 
            this.txbcedula.Location = new System.Drawing.Point(125, 145);
            this.txbcedula.Name = "txbcedula";
            this.txbcedula.Size = new System.Drawing.Size(339, 27);
            this.txbcedula.TabIndex = 8;
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(125, 199);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(339, 27);
            this.txbusuario.TabIndex = 9;
            // 
            // txbcontraseña
            // 
            this.txbcontraseña.Location = new System.Drawing.Point(125, 249);
            this.txbcontraseña.Name = "txbcontraseña";
            this.txbcontraseña.Size = new System.Drawing.Size(339, 27);
            this.txbcontraseña.TabIndex = 10;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(458, 366);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(94, 29);
            this.btningresar.TabIndex = 11;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmnuevo_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 407);
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
            this.Name = "frmnuevo_usuario";
            this.Text = "Nuevo_usuario";
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
    }
}