namespace Sistema
{
    partial class Tarjeta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.picTitulo = new Sistema.PctureBox();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.pnlCuerpo = new System.Windows.Forms.Panel();
            this.lblLinea3 = new System.Windows.Forms.Label();
            this.lblLinea2 = new System.Windows.Forms.Label();
            this.lblLinea1 = new System.Windows.Forms.Label();
            this.picCuerpo = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.pnlCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCuerpo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.picTitulo);
            this.pnlTitulo.Controls.Add(this.lblContenido);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(271, 45);
            this.pnlTitulo.TabIndex = 0;
            this.pnlTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTitulo_Paint);
            // 
            // picTitulo
            // 
            this.picTitulo.BackColor = System.Drawing.Color.SeaGreen;
            this.picTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picTitulo.ExtendedSizeMode = Sistema.ExtendedPictureBoxSizeMode.Fit;
            this.picTitulo.Image = global::Sistema.Properties.Resources.invoice__2_;
            this.picTitulo.Location = new System.Drawing.Point(0, 0);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Padding = new System.Windows.Forms.Padding(4);
            this.picTitulo.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.picTitulo.Size = new System.Drawing.Size(46, 45);
            this.picTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitulo.TabIndex = 7;
            this.picTitulo.TabStop = false;
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(51, 25);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(65, 13);
            this.lblContenido.TabIndex = 2;
            this.lblContenido.Text = "lblContenido";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(48, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "lblTitulo";
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 45);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(271, 13);
            this.pnlSeparador.TabIndex = 2;
            // 
            // pnlCuerpo
            // 
            this.pnlCuerpo.Controls.Add(this.lblLinea3);
            this.pnlCuerpo.Controls.Add(this.lblLinea2);
            this.pnlCuerpo.Controls.Add(this.lblLinea1);
            this.pnlCuerpo.Controls.Add(this.picCuerpo);
            this.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCuerpo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCuerpo.Location = new System.Drawing.Point(0, 58);
            this.pnlCuerpo.Name = "pnlCuerpo";
            this.pnlCuerpo.Size = new System.Drawing.Size(271, 229);
            this.pnlCuerpo.TabIndex = 3;
            this.pnlCuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCuerpo_Paint);
            // 
            // lblLinea3
            // 
            this.lblLinea3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea3.Location = new System.Drawing.Point(21, 192);
            this.lblLinea3.Name = "lblLinea3";
            this.lblLinea3.Size = new System.Drawing.Size(49, 20);
            this.lblLinea3.TabIndex = 3;
            this.lblLinea3.Text = "lblLinea3";
            // 
            // lblLinea2
            // 
            this.lblLinea2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea2.Location = new System.Drawing.Point(21, 169);
            this.lblLinea2.Name = "lblLinea2";
            this.lblLinea2.Size = new System.Drawing.Size(49, 20);
            this.lblLinea2.TabIndex = 2;
            this.lblLinea2.Text = "lblLinea2";
            // 
            // lblLinea1
            // 
            this.lblLinea1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea1.Location = new System.Drawing.Point(21, 146);
            this.lblLinea1.Name = "lblLinea1";
            this.lblLinea1.Size = new System.Drawing.Size(49, 20);
            this.lblLinea1.TabIndex = 1;
            this.lblLinea1.Text = "lblLinea1";
            // 
            // picCuerpo
            // 
            this.picCuerpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCuerpo.Image = global::Sistema.Properties.Resources.invoice__2_;
            this.picCuerpo.Location = new System.Drawing.Point(54, 6);
            this.picCuerpo.Name = "picCuerpo";
            this.picCuerpo.Size = new System.Drawing.Size(155, 137);
            this.picCuerpo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCuerpo.TabIndex = 0;
            this.picCuerpo.TabStop = false;
            // 
            // Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCuerpo);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "Tarjeta";
            this.Size = new System.Drawing.Size(271, 287);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            this.pnlCuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCuerpo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.Panel pnlCuerpo;
        private System.Windows.Forms.PictureBox picCuerpo;
        private PctureBox picTitulo;
        private System.Windows.Forms.Label lblLinea3;
        private System.Windows.Forms.Label lblLinea2;
        private System.Windows.Forms.Label lblLinea1;
    }
}
