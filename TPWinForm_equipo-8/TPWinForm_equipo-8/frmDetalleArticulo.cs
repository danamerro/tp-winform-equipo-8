using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace TPWinForm_equipo_8
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
        public frmDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {
            lblCodigoValor.Text = articulo.Codigo;
            lblNombreValor.Text = articulo.Nombre;
            lblMarcaValor.Text = articulo.Marca.Descripcion;
            lblCategoriaValor.Text = articulo.Categoria.Descripcion;
            lblPrecioValor.Text = articulo.Precio.ToString("0.00");
            lblDescripcionValor.Text = articulo.Descripcion;
        }
    }
}
