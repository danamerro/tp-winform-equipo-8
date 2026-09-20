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
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
<<<<<<< HEAD
            this.dgvArticulos.Location = new System.Drawing.Point(14, 123);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dgvArticulos.MultiSelect = false;
=======
            this.dgvArticulos.Location = new System.Drawing.Point(12, 98);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
<<<<<<< HEAD
            this.dgvArticulos.Size = new System.Drawing.Size(1071, 568);
=======
            this.dgvArticulos.Size = new System.Drawing.Size(952, 454);
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.dgvArticulos.TabIndex = 0;
            // 
            // gbxArticulos
            // 
            this.gbxArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxArticulos.Controls.Add(this.lblFiltro);
            this.gbxArticulos.Controls.Add(this.txbFiltro);
            this.gbxArticulos.Controls.Add(this.cbxCategoria);
            this.gbxArticulos.Controls.Add(this.cbxMarca);
            this.gbxArticulos.Controls.Add(this.btnBuscar);
            this.gbxArticulos.Controls.Add(this.lblBuscarCategoria);
            this.gbxArticulos.Controls.Add(this.lblBuscarMarca);
<<<<<<< HEAD
            this.gbxArticulos.Location = new System.Drawing.Point(14, 17);
            this.gbxArticulos.Name = "gbxArticulos";
            this.gbxArticulos.Size = new System.Drawing.Size(1312, 97);
=======
            this.gbxArticulos.Location = new System.Drawing.Point(12, 14);
            this.gbxArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxArticulos.Name = "gbxArticulos";
            this.gbxArticulos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxArticulos.Size = new System.Drawing.Size(952, 78);
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.gbxArticulos.TabIndex = 21;
            this.gbxArticulos.TabStop = false;
            this.gbxArticulos.Text = "Buscar Artículos";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
<<<<<<< HEAD
            this.lblFiltro.Location = new System.Drawing.Point(570, 48);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(52, 20);
=======
            this.lblFiltro.Location = new System.Drawing.Point(507, 38);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(42, 16);
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.lblFiltro.TabIndex = 28;
            this.lblFiltro.Text = "Filtro: ";
            // 
            // txbFiltro
            // 
<<<<<<< HEAD
            this.txbFiltro.Location = new System.Drawing.Point(624, 43);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(198, 26);
            this.txbFiltro.TabIndex = 27;
=======
            this.txbFiltro.Location = new System.Drawing.Point(555, 34);
            this.txbFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(176, 22);
            this.txbFiltro.TabIndex = 3;
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
<<<<<<< HEAD
            this.cbxCategoria.Location = new System.Drawing.Point(368, 42);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(136, 28);
            this.cbxCategoria.TabIndex = 26;
=======
            this.cbxCategoria.Location = new System.Drawing.Point(327, 33);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbxCategoria.TabIndex = 2;
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
<<<<<<< HEAD
            this.cbxMarca.Location = new System.Drawing.Point(93, 43);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(136, 28);
=======
            this.cbxMarca.Location = new System.Drawing.Point(83, 34);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 24);
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.cbxMarca.TabIndex = 1;
            // 
            // btnBuscar
            // 
<<<<<<< HEAD
            this.btnBuscar.Location = new System.Drawing.Point(936, 43);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 32);
            this.btnBuscar.TabIndex = 25;
=======
            this.btnBuscar.Location = new System.Drawing.Point(773, 32);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 27);
            this.btnBuscar.TabIndex = 4;
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarCategoria
            // 
            this.lblBuscarCategoria.AutoSize = true;
<<<<<<< HEAD
            this.lblBuscarCategoria.Location = new System.Drawing.Point(280, 46);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(82, 20);
=======
            this.lblBuscarCategoria.Location = new System.Drawing.Point(249, 37);
            this.lblBuscarCategoria.Name = "lblBuscarCategoria";
            this.lblBuscarCategoria.Size = new System.Drawing.Size(69, 16);
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.lblBuscarCategoria.TabIndex = 1;
            this.lblBuscarCategoria.Text = "Categoría:";
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
<<<<<<< HEAD
            this.lblBuscarMarca.Location = new System.Drawing.Point(28, 48);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(57, 20);
=======
            this.lblBuscarMarca.Location = new System.Drawing.Point(25, 38);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(48, 16);
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.lblBuscarMarca.TabIndex = 0;
            this.lblBuscarMarca.Text = "Marca:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.btnNuevo.Location = new System.Drawing.Point(1113, 202);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 49);
            this.btnNuevo.TabIndex = 22;
=======
            this.btnNuevo.Location = new System.Drawing.Point(989, 161);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(147, 39);
            this.btnNuevo.TabIndex = 1;
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.btnModificar.Location = new System.Drawing.Point(1113, 260);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(165, 49);
            this.btnModificar.TabIndex = 23;
=======
            this.btnModificar.Location = new System.Drawing.Point(989, 208);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 39);
            this.btnModificar.TabIndex = 2;
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.btnEliminar.Location = new System.Drawing.Point(1113, 318);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 49);
            this.btnEliminar.TabIndex = 24;
=======
            this.btnEliminar.Location = new System.Drawing.Point(989, 255);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 39);
            this.btnEliminar.TabIndex = 3;
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
            this.btnDetalle.Location = new System.Drawing.Point(1113, 143);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(165, 49);
            this.btnDetalle.TabIndex = 25;
=======
            this.btnDetalle.Location = new System.Drawing.Point(989, 114);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(147, 39);
            this.btnDetalle.TabIndex = 0;
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.btnDetalle.Text = "Ver &Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // frmArticulos
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 709);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 567);
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxArticulos);
            this.Controls.Add(this.dgvArticulos);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
=======
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
>>>>>>> 4d34fc9748b6f6760d1904018405b4b7415ee8ca
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