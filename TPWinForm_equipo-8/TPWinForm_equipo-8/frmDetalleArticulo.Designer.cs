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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxImagenes = new System.Windows.Forms.GroupBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNomb = new System.Windows.Forms.Label();
            this.lblMarc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxImagenes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(32, 56);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(32, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(32, 151);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 20);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(32, 201);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 20);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(32, 251);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(14, 298);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 276);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // gbxImagenes
            // 
            this.gbxImagenes.Controls.Add(this.btnSiguiente);
            this.gbxImagenes.Controls.Add(this.btnAnterior);
            this.gbxImagenes.Controls.Add(this.pictureBox1);
            this.gbxImagenes.Location = new System.Drawing.Point(388, 48);
            this.gbxImagenes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxImagenes.Name = "gbxImagenes";
            this.gbxImagenes.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxImagenes.Size = new System.Drawing.Size(308, 362);
            this.gbxImagenes.TabIndex = 13;
            this.gbxImagenes.TabStop = false;
            this.gbxImagenes.Text = "Imágenes";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(176, 310);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(110, 40);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "&Siguiente >";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(24, 310);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(106, 40);
            this.btnAnterior.TabIndex = 0;
            this.btnAnterior.Text = "< &Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(591, 418);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(106, 40);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // lblCod
            // 
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCod.Location = new System.Drawing.Point(116, 48);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(245, 34);
            this.lblCod.TabIndex = 14;
            // 
            // lblNomb
            // 
            this.lblNomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNomb.Location = new System.Drawing.Point(116, 95);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(245, 36);
            this.lblNomb.TabIndex = 15;
            // 
            // lblMarc
            // 
            this.lblMarc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMarc.Location = new System.Drawing.Point(116, 144);
            this.lblMarc.Name = "lblMarc";
            this.lblMarc.Size = new System.Drawing.Size(245, 36);
            this.lblMarc.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(116, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(116, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 36);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(116, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 116);
            this.label3.TabIndex = 19;
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMarc);
            this.Controls.Add(this.lblNomb);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.gbxImagenes);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Artículo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxImagenes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxImagenes;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblNomb;
        private System.Windows.Forms.Label lblMarc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}