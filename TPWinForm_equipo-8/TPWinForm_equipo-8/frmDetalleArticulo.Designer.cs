namespace TPWinForm_equipo_8
{
    partial class frmDetalleArticulo
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
            this.lblCodigoTitulo = new System.Windows.Forms.Label();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.lblMarcaTitulo = new System.Windows.Forms.Label();
            this.lblCategoriaTitulo = new System.Windows.Forms.Label();
            this.lblPrecioTitulo = new System.Windows.Forms.Label();
            this.lblDescripcionTitulo = new System.Windows.Forms.Label();
            this.pctbxImagenes = new System.Windows.Forms.PictureBox();
            this.gbxImagenes = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCodigoValor = new System.Windows.Forms.Label();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblMarcaValor = new System.Windows.Forms.Label();
            this.lblPrecioValor = new System.Windows.Forms.Label();
            this.lblCategoriaValor = new System.Windows.Forms.Label();
            this.lblDescripcionValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxImagenes)).BeginInit();
            this.gbxImagenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigoTitulo
            // 
            this.lblCodigoTitulo.AutoSize = true;
            this.lblCodigoTitulo.Location = new System.Drawing.Point(28, 46);
            this.lblCodigoTitulo.Name = "lblCodigoTitulo";
            this.lblCodigoTitulo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigoTitulo.TabIndex = 0;
            this.lblCodigoTitulo.Text = "Código:";
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.AutoSize = true;
            this.lblNombreTitulo.Location = new System.Drawing.Point(28, 82);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(59, 16);
            this.lblNombreTitulo.TabIndex = 1;
            this.lblNombreTitulo.Text = "Nombre:";
            // 
            // lblMarcaTitulo
            // 
            this.lblMarcaTitulo.AutoSize = true;
            this.lblMarcaTitulo.Location = new System.Drawing.Point(28, 121);
            this.lblMarcaTitulo.Name = "lblMarcaTitulo";
            this.lblMarcaTitulo.Size = new System.Drawing.Size(48, 16);
            this.lblMarcaTitulo.TabIndex = 2;
            this.lblMarcaTitulo.Text = "Marca:";
            // 
            // lblCategoriaTitulo
            // 
            this.lblCategoriaTitulo.AutoSize = true;
            this.lblCategoriaTitulo.Location = new System.Drawing.Point(28, 161);
            this.lblCategoriaTitulo.Name = "lblCategoriaTitulo";
            this.lblCategoriaTitulo.Size = new System.Drawing.Size(69, 16);
            this.lblCategoriaTitulo.TabIndex = 3;
            this.lblCategoriaTitulo.Text = "Categoría:";
            // 
            // lblPrecioTitulo
            // 
            this.lblPrecioTitulo.AutoSize = true;
            this.lblPrecioTitulo.Location = new System.Drawing.Point(28, 201);
            this.lblPrecioTitulo.Name = "lblPrecioTitulo";
            this.lblPrecioTitulo.Size = new System.Drawing.Size(49, 16);
            this.lblPrecioTitulo.TabIndex = 4;
            this.lblPrecioTitulo.Text = "Precio:";
            // 
            // lblDescripcionTitulo
            // 
            this.lblDescripcionTitulo.AutoSize = true;
            this.lblDescripcionTitulo.Location = new System.Drawing.Point(12, 238);
            this.lblDescripcionTitulo.Name = "lblDescripcionTitulo";
            this.lblDescripcionTitulo.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcionTitulo.TabIndex = 5;
            this.lblDescripcionTitulo.Text = "Descripción:";
            // 
            // pctbxImagenes
            // 
            this.pctbxImagenes.Location = new System.Drawing.Point(5, 21);
            this.pctbxImagenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbxImagenes.Name = "pctbxImagenes";
            this.pctbxImagenes.Size = new System.Drawing.Size(257, 222);
            this.pctbxImagenes.TabIndex = 6;
            this.pctbxImagenes.TabStop = false;
            // 
            // gbxImagenes
            // 
            this.gbxImagenes.Controls.Add(this.btnSiguiente);
            this.gbxImagenes.Controls.Add(this.btnAnterior);
            this.gbxImagenes.Controls.Add(this.pctbxImagenes);
            this.gbxImagenes.Location = new System.Drawing.Point(345, 38);
            this.gbxImagenes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxImagenes.Name = "gbxImagenes";
            this.gbxImagenes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxImagenes.Size = new System.Drawing.Size(275, 290);
            this.gbxImagenes.TabIndex = 13;
            this.gbxImagenes.TabStop = false;
            this.gbxImagenes.Text = "Imágenes";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(156, 249);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(99, 32);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "&Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(21, 249);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(93, 32);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "< &Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(525, 334);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 32);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblCodigoValor
            // 
            this.lblCodigoValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodigoValor.Location = new System.Drawing.Point(103, 38);
            this.lblCodigoValor.Name = "lblCodigoValor";
            this.lblCodigoValor.Size = new System.Drawing.Size(218, 28);
            this.lblCodigoValor.TabIndex = 14;
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreValor.Location = new System.Drawing.Point(103, 76);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(218, 29);
            this.lblNombreValor.TabIndex = 15;
            // 
            // lblMarcaValor
            // 
            this.lblMarcaValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMarcaValor.Location = new System.Drawing.Point(103, 114);
            this.lblMarcaValor.Name = "lblMarcaValor";
            this.lblMarcaValor.Size = new System.Drawing.Size(218, 29);
            this.lblMarcaValor.TabIndex = 16;
            // 
            // lblPrecioValor
            // 
            this.lblPrecioValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecioValor.Location = new System.Drawing.Point(103, 193);
            this.lblPrecioValor.Name = "lblPrecioValor";
            this.lblPrecioValor.Size = new System.Drawing.Size(218, 29);
            this.lblPrecioValor.TabIndex = 17;
            // 
            // lblCategoriaValor
            // 
            this.lblCategoriaValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCategoriaValor.Location = new System.Drawing.Point(103, 154);
            this.lblCategoriaValor.Name = "lblCategoriaValor";
            this.lblCategoriaValor.Size = new System.Drawing.Size(218, 29);
            this.lblCategoriaValor.TabIndex = 18;
            // 
            // lblDescripcionValor
            // 
            this.lblDescripcionValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcionValor.Location = new System.Drawing.Point(103, 231);
            this.lblDescripcionValor.Name = "lblDescripcionValor";
            this.lblDescripcionValor.Size = new System.Drawing.Size(218, 93);
            this.lblDescripcionValor.TabIndex = 19;
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 370);
            this.Controls.Add(this.lblDescripcionValor);
            this.Controls.Add(this.lblCategoriaValor);
            this.Controls.Add(this.lblPrecioValor);
            this.Controls.Add(this.lblMarcaValor);
            this.Controls.Add(this.lblNombreValor);
            this.Controls.Add(this.lblCodigoValor);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxImagenes);
            this.Controls.Add(this.lblDescripcionTitulo);
            this.Controls.Add(this.lblPrecioTitulo);
            this.Controls.Add(this.lblCategoriaTitulo);
            this.Controls.Add(this.lblMarcaTitulo);
            this.Controls.Add(this.lblNombreTitulo);
            this.Controls.Add(this.lblCodigoTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Artículo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxImagenes)).EndInit();
            this.gbxImagenes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoTitulo;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.Label lblMarcaTitulo;
        private System.Windows.Forms.Label lblCategoriaTitulo;
        private System.Windows.Forms.Label lblPrecioTitulo;
        private System.Windows.Forms.Label lblDescripcionTitulo;
        private System.Windows.Forms.PictureBox pctbxImagenes;
        private System.Windows.Forms.GroupBox gbxImagenes;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCodigoValor;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblMarcaValor;
        private System.Windows.Forms.Label lblPrecioValor;
        private System.Windows.Forms.Label lblCategoriaValor;
        private System.Windows.Forms.Label lblDescripcionValor;
    }
}