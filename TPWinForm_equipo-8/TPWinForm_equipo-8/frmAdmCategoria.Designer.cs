namespace TPWinForm_equipo_8
{
    partial class frmAdmCategoria
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevoArdCategoria = new System.Windows.Forms.Button();
            this.btnModificarAdmCategoria = new System.Windows.Forms.Button();
            this.btnEliminarAdmCategoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(645, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNuevoArdCategoria
            // 
            this.btnNuevoArdCategoria.Location = new System.Drawing.Point(48, 341);
            this.btnNuevoArdCategoria.Name = "btnNuevoArdCategoria";
            this.btnNuevoArdCategoria.Size = new System.Drawing.Size(143, 49);
            this.btnNuevoArdCategoria.TabIndex = 1;
            this.btnNuevoArdCategoria.Text = "Nuevo";
            this.btnNuevoArdCategoria.UseVisualStyleBackColor = true;
            // 
            // btnModificarAdmCategoria
            // 
            this.btnModificarAdmCategoria.Location = new System.Drawing.Point(267, 341);
            this.btnModificarAdmCategoria.Name = "btnModificarAdmCategoria";
            this.btnModificarAdmCategoria.Size = new System.Drawing.Size(142, 49);
            this.btnModificarAdmCategoria.TabIndex = 2;
            this.btnModificarAdmCategoria.Text = "Modificar";
            this.btnModificarAdmCategoria.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAdmCategoria
            // 
            this.btnEliminarAdmCategoria.Location = new System.Drawing.Point(481, 341);
            this.btnEliminarAdmCategoria.Name = "btnEliminarAdmCategoria";
            this.btnEliminarAdmCategoria.Size = new System.Drawing.Size(143, 49);
            this.btnEliminarAdmCategoria.TabIndex = 3;
            this.btnEliminarAdmCategoria.Text = "Eliminar";
            this.btnEliminarAdmCategoria.UseVisualStyleBackColor = true;
            // 
            // frmAdmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 412);
            this.Controls.Add(this.btnEliminarAdmCategoria);
            this.Controls.Add(this.btnModificarAdmCategoria);
            this.Controls.Add(this.btnNuevoArdCategoria);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAdmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevoArdCategoria;
        private System.Windows.Forms.Button btnModificarAdmCategoria;
        private System.Windows.Forms.Button btnEliminarAdmCategoria;
    }
}