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
using negocio;

namespace TPWinForm_equipo_8
{
    public partial class frmDetalleArticulo : Form
    {
        private Articulo articulo;
        private List<Imagen> imagenes;
        private int indiceImagen = 0;
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

            ImagenNegocio negocioImagen = new ImagenNegocio();

            imagenes = negocioImagen.ListarPorArticulo(articulo.Id);

            if (imagenes.Count > 0)
            {
                indiceImagen = 0;
                cargarImagen();
            }
            else
            {
                pctbxImagenes.Image = null;
            }
        }

        private void cargarImagen()
        {
            try
            {
                pctbxImagenes.Load(imagenes[indiceImagen].ImagenUrl);
                pctbxImagenes.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                pctbxImagenes.Image = null;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenes == null || imagenes.Count == 0)
                return;

            indiceImagen++;

            if (indiceImagen >= imagenes.Count)
                indiceImagen = 0;

            cargarImagen();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenes == null || imagenes.Count == 0)
                return;

            indiceImagen--;

            if (indiceImagen < 0)
                indiceImagen = imagenes.Count - 1;

            cargarImagen();
        }
    }
}
