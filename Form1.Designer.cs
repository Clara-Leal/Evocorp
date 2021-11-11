
namespace EvoCorp
{
	partial class frmlogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.btningresar = new System.Windows.Forms.Button();
            this.txbcontraseña = new System.Windows.Forms.TextBox();
            this.txbusuario = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.logo_inicio = new System.Windows.Forms.PictureBox();
            this.btnusuario_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(24, 301);
            this.btningresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(86, 31);
            this.btningresar.TabIndex = 0;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // txbcontraseña
            // 
            this.txbcontraseña.Location = new System.Drawing.Point(24, 248);
            this.txbcontraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbcontraseña.Name = "txbcontraseña";
            this.txbcontraseña.PasswordChar = '*';
            this.txbcontraseña.Size = new System.Drawing.Size(236, 27);
            this.txbcontraseña.TabIndex = 1;
            this.txbcontraseña.TextChanged += new System.EventHandler(this.txbcontraseña_TextChanged);
            this.txbcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbcontraseña_KeyPress);
            // 
            // txbusuario
            // 
            this.txbusuario.Location = new System.Drawing.Point(24, 173);
            this.txbusuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbusuario.Name = "txbusuario";
            this.txbusuario.Size = new System.Drawing.Size(236, 27);
            this.txbusuario.TabIndex = 2;
            this.txbusuario.TextChanged += new System.EventHandler(this.txbusuario_TextChanged);
            this.txbusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbusuario_KeyPress);
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.Location = new System.Drawing.Point(24, 220);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(83, 20);
            this.lblcontraseña.TabIndex = 3;
            this.lblcontraseña.Text = "Contraseña";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(24, 149);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(59, 20);
            this.lblusuario.TabIndex = 4;
            this.lblusuario.Text = "Usuario";
            // 
            // logo_inicio
            // 
            this.logo_inicio.Image = ((System.Drawing.Image)(resources.GetObject("logo_inicio.Image")));
            this.logo_inicio.Location = new System.Drawing.Point(24, 6);
            this.logo_inicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logo_inicio.Name = "logo_inicio";
            this.logo_inicio.Size = new System.Drawing.Size(218, 139);
            this.logo_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_inicio.TabIndex = 5;
            this.logo_inicio.TabStop = false;
            this.logo_inicio.Click += new System.EventHandler(this.logo_inicio_Click);
            // 
            // btnusuario_nuevo
            // 
            this.btnusuario_nuevo.Location = new System.Drawing.Point(137, 301);
            this.btnusuario_nuevo.Name = "btnusuario_nuevo";
            this.btnusuario_nuevo.Size = new System.Drawing.Size(123, 31);
            this.btnusuario_nuevo.TabIndex = 6;
            this.btnusuario_nuevo.Text = "Nuevo usuario";
            this.btnusuario_nuevo.UseVisualStyleBackColor = true;
            this.btnusuario_nuevo.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 348);
            this.Controls.Add(this.btnusuario_nuevo);
            this.Controls.Add(this.logo_inicio);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcontraseña);
            this.Controls.Add(this.txbusuario);
            this.Controls.Add(this.txbcontraseña);
            this.Controls.Add(this.btningresar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmlogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_inicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btningresar;
		private System.Windows.Forms.TextBox txbcontraseña;
		private System.Windows.Forms.TextBox txbusuario;
		private System.Windows.Forms.Label lblcontraseña;
		private System.Windows.Forms.Label lblusuario;
		private System.Windows.Forms.PictureBox logo_inicio;
        private System.Windows.Forms.Button btnusuario_nuevo;
    }
}

