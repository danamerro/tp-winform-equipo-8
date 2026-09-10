namespace TPWinForm_equipo_8
{
    partial class frmAdministracionMarca
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
            this.btnNuevoArtMarca = new System.Windows.Forms.Button();
            this.btnModificarAdmMarca = new System.Windows.Forms.Button();
            this.btnEliminarAdmMarca = new System.Windows.Forms.Button();
            this.dgvAdmCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoArtMarca
            // 
            this.btnNuevoArtMarca.Location = new System.Drawing.Point(65, 282);
            this.btnNuevoArtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoArtMarca.Name = "btnNuevoArtMarca";
            this.btnNuevoArtMarca.Size = new System.Drawing.Size(123, 40);
            this.btnNuevoArtMarca.TabIndex = 0;
            this.btnNuevoArtMarca.Text = "&Nuevo";
            this.btnNuevoArtMarca.UseVisualStyleBackColor = true;
            // 
            // btnModificarAdmMarca
            // 
            this.btnModificarAdmMarca.Location = new System.Drawing.Point(239, 282);
            this.btnModificarAdmMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarAdmMarca.Name = "btnModificarAdmMarca";
            this.btnModificarAdmMarca.Size = new System.Drawing.Size(123, 40);
            this.btnModificarAdmMarca.TabIndex = 1;
            this.btnModificarAdmMarca.Text = "&Modificar";
            this.btnModificarAdmMarca.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAdmMarca
            // 
            this.btnEliminarAdmMarca.Location = new System.Drawing.Point(416, 282);
            this.btnEliminarAdmMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarAdmMarca.Name = "btnEliminarAdmMarca";
            this.btnEliminarAdmMarca.Size = new System.Drawing.Size(123, 40);
            this.btnEliminarAdmMarca.TabIndex = 2;
            this.btnEliminarAdmMarca.Text = "&Eliminar";
            this.btnEliminarAdmMarca.UseVisualStyleBackColor = true;
            // 
            // dgvAdmCategoria
            // 
            this.dgvAdmCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmCategoria.Location = new System.Drawing.Point(12, 20);
            this.dgvAdmCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAdmCategoria.MinimumSize = new System.Drawing.Size(587, 250);
            this.dgvAdmCategoria.Name = "dgvAdmCategoria";
            this.dgvAdmCategoria.RowHeadersWidth = 62;
            this.dgvAdmCategoria.RowTemplate.Height = 28;
            this.dgvAdmCategoria.Size = new System.Drawing.Size(587, 250);
            this.dgvAdmCategoria.TabIndex = 3;
            // 
            // frmAdministracionMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 342);
            this.Controls.Add(this.dgvAdmCategoria);
            this.Controls.Add(this.btnEliminarAdmMarca);
            this.Controls.Add(this.btnModificarAdmMarca);
            this.Controls.Add(this.btnNuevoArtMarca);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAdministracionMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Marca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoArtMarca;
        private System.Windows.Forms.Button btnModificarAdmMarca;
        private System.Windows.Forms.Button btnEliminarAdmMarca;
        private System.Windows.Forms.DataGridView dgvAdmCategoria;
    }
}