namespace TPWinForm_equipo_8
{
    partial class frmArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.gbxArticulos = new System.Windows.Forms.GroupBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarCategoria = new System.Windows.Forms.Label();
            this.lblBuscarMarca = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbxArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(9, 80);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(563, 156);
            this.dgvArticulos.TabIndex = 0;
            // 
            // gbxArticulos
            // 
            this.gbxArticulos.Controls.Add(this.lblFiltro);
            this.gbxArticulos.Controls.Add(this.txbFiltro);
            this.gbxArticulos.Controls.Add(this.cbxCategoria);
            this.gbxArticulos.Controls.Add(this.cbxMarca);
            this.gbxArticulos.Controls.Add(this.btnBuscar);
            this.gbxArticulos.Controls.Add(this.lblBuscarCategoria);
            this.gbxArticulos.Controls.Add(this.lblBuscarMarca);
            this.gbxArticulos.Location = new System.Drawing.Point(9, 11);
            this.gbxArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxArticulos.Name = "gbxArticulos";
            this.gbxArticulos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxArticulos.Size = new System.Drawing.Size(563, 63);
            this.gbxArticulos.TabIndex = 21;
            this.gbxArticulos.TabStop = false;
            this.gbxArticulos.Text = "Buscar Artículos";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(308, 32);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(35, 13);
            this.lblFiltro.TabIndex = 28;
            this.lblFiltro.Text = "Filtro: ";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(344, 29);
            this.txbFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(133, 20);
            this.txbFiltro.TabIndex = 27;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(204, 28);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(92, 21);
            this.cbxCategoria.TabIndex = 26;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(48, 28);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(92, 21);
            this.cbxMarca.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(480, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 21);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
            this.lblBuscarCategoria.Location = new System.Drawing.Point(146, 31);
            this.lblBuscarCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblBuscarCategoria.TabIndex = 1;
            this.lblBuscarCategoria.Text = "Categoría:";
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Location = new System.Drawing.Point(5, 31);
            this.lblBuscarMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(40, 13);
            this.lblBuscarMarca.TabIndex = 0;
            this.lblBuscarMarca.Text = "Marca:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(9, 251);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 32);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(158, 251);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 32);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(454, 251);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 32);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(306, 251);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(110, 32);
            this.btnDetalle.TabIndex = 25;
            this.btnDetalle.Text = "Ver &Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 302);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Artículo";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbxArticulos.ResumeLayout(false);
            this.gbxArticulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox gbxArticulos;
        private System.Windows.Forms.Label lblBuscarCategoria;
        private System.Windows.Forms.Label lblBuscarMarca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txbFiltro;
    }
}