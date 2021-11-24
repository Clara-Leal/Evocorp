
namespace EvoCorp
{
    partial class frminicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminicio));
            this.label1 = new System.Windows.Forms.Label();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btncompra = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.btnproveedor = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btncambiar_usuario = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(465, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 112);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimarket\r\nLa Rubia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.AutoEllipsis = true;
            this.btnproductos.BackColor = System.Drawing.Color.White;
            this.btnproductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnproductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnproductos.Location = new System.Drawing.Point(30, 276);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(117, 43);
            this.btnproductos.TabIndex = 3;
            this.btnproductos.Text = "Productos";
            this.btnproductos.UseVisualStyleBackColor = false;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btncompra
            // 
            this.btncompra.AutoEllipsis = true;
            this.btncompra.BackColor = System.Drawing.Color.White;
            this.btncompra.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btncompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncompra.Location = new System.Drawing.Point(30, 161);
            this.btncompra.Name = "btncompra";
            this.btncompra.Size = new System.Drawing.Size(117, 41);
            this.btncompra.TabIndex = 4;
            this.btncompra.Text = "Compra";
            this.btncompra.UseVisualStyleBackColor = false;
            this.btncompra.Click += new System.EventHandler(this.btncompra_Click);
            // 
            // btnventa
            // 
            this.btnventa.AutoEllipsis = true;
            this.btnventa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnventa.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnventa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnventa.Location = new System.Drawing.Point(30, 60);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(117, 41);
            this.btnventa.TabIndex = 5;
            this.btnventa.Text = "Venta";
            this.btnventa.UseVisualStyleBackColor = false;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btnproveedor
            // 
            this.btnproveedor.AutoEllipsis = true;
            this.btnproveedor.BackColor = System.Drawing.Color.White;
            this.btnproveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnproveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnproveedor.Location = new System.Drawing.Point(30, 384);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(117, 43);
            this.btnproveedor.TabIndex = 6;
            this.btnproveedor.Text = "Proveedor";
            this.btnproveedor.UseVisualStyleBackColor = false;
            this.btnproveedor.Click += new System.EventHandler(this.btnproveedor_Click);
            // 
            // btncliente
            // 
            this.btncliente.AutoEllipsis = true;
            this.btncliente.BackColor = System.Drawing.Color.White;
            this.btncliente.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btncliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncliente.Location = new System.Drawing.Point(30, 489);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(117, 43);
            this.btncliente.TabIndex = 7;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.AutoEllipsis = true;
            this.btnsalir.BackColor = System.Drawing.Color.White;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnsalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnsalir.ForeColor = System.Drawing.Color.Indigo;
            this.btnsalir.Location = new System.Drawing.Point(922, 587);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(115, 45);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnSalir);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1022, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 57);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btncambiar_usuario
            // 
            this.btncambiar_usuario.AutoEllipsis = true;
            this.btncambiar_usuario.BackColor = System.Drawing.Color.Transparent;
            this.btncambiar_usuario.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btncambiar_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncambiar_usuario.ForeColor = System.Drawing.Color.Black;
            this.btncambiar_usuario.Location = new System.Drawing.Point(489, 584);
            this.btncambiar_usuario.Name = "btncambiar_usuario";
            this.btncambiar_usuario.Size = new System.Drawing.Size(203, 45);
            this.btncambiar_usuario.TabIndex = 12;
            this.btncambiar_usuario.Text = "Cambiar usuario";
            this.btncambiar_usuario.UseVisualStyleBackColor = false;
            this.btncambiar_usuario.Click += new System.EventHandler(this.btncambiar_usuario_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(745, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(99, 62);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 13;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfecha.Location = new System.Drawing.Point(30, 11);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(51, 23);
            this.lblfecha.TabIndex = 14;
            this.lblfecha.Text = "fecha";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblhora.Location = new System.Drawing.Point(328, 9);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(53, 22);
            this.lblhora.TabIndex = 15;
            this.lblhora.Text = "hora";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EvoCorp.Properties.Resources.descarga__4_;
            this.pictureBox1.Location = new System.Drawing.Point(547, 397);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnusuario
            // 
            this.btnusuario.AutoEllipsis = true;
            this.btnusuario.BackColor = System.Drawing.Color.White;
            this.btnusuario.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnusuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnusuario.Location = new System.Drawing.Point(30, 584);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(117, 43);
            this.btnusuario.TabIndex = 17;
            this.btnusuario.Text = "Usuarios";
            this.btnusuario.UseVisualStyleBackColor = false;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // btninfo
            // 
            this.btninfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btninfo.BackgroundImage")));
            this.btninfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninfo.Location = new System.Drawing.Point(1022, 9);
            this.btninfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(53, 57);
            this.btninfo.TabIndex = 11;
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 655);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btncambiar_usuario);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.btnproveedor);
            this.Controls.Add(this.btnventa);
            this.Controls.Add(this.btncompra);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frminicio";
            this.Text = "Inicio";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.frminicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btncompra;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button btnproveedor;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncambiar_usuario;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnusuario;
    }
}