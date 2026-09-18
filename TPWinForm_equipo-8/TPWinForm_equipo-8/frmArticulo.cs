using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_8
{
    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;
        private List<Imagen> imagenesAEliminar = new List<Imagen>();
        
        public frmArticulo()
        {
            InitializeComponent();
        }
        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            if(articulo == null)
                articulo = new Articulo();

            MarcaNegocio marcaNeg = new MarcaNegocio();
            CategoriaNegocio categoriaNeg = new CategoriaNegocio();
            try
            {
                cbxMarca.DataSource = marcaNeg.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                cbxCategoria.DataSource = categoriaNeg.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";


            if (articulo != null)
            {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    nudPrecio.Value = articulo.Precio;
                    if(articulo.Marca != null)
                        cbxMarca.SelectedValue = articulo.Marca.Id;
                    if(articulo.Categoria != null)
                        cbxCategoria.SelectedValue = articulo.Categoria.Id;

                    ImagenNegocio negImagen = new ImagenNegocio();

                    articulo.Imagenes.Clear();
                    lvUrlImagen.Items.Clear();

                    List<Imagen> imagenes = negImagen.ListarPorArticulo(articulo.Id);

                    foreach (Imagen imagen in imagenes)
                    {
                        articulo.Imagenes.Add(imagen);
                        lvUrlImagen.Items.Add(imagen.ImagenUrl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CatalogoNegocio negocio = new CatalogoNegocio();
            ImagenNegocio negImagen = new ImagenNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.Precio = nudPrecio.Value;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                //agregar url 

                if(articulo.Id == 0)
                {
                    articulo.Id = negocio.agregar(articulo);
  
                }
                else
                {
                    negocio.modificar(articulo);
                    negImagen.EliminarXArticulo(articulo.Id);
                }
                foreach (Imagen imagen in articulo.Imagenes)
                {
                    imagen.IdArticulo = articulo.Id;
                    negImagen.Agregar(imagen);
                }
                MessageBox.Show("Guardado Exitosamente :) ");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxUrlImagen.Text))
            {
                MessageBox.Show("Ingrese una URL");
                return;
            }
            Imagen imagen = new Imagen();

            imagen.ImagenUrl = tbxUrlImagen.Text;
            articulo.Imagenes.Add(imagen);
            lvUrlImagen.Items.Add(imagen.ImagenUrl);

            tbxUrlImagen.Clear();

        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if(lvUrlImagen.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una imagen ");
                return;
            }
            string url = lvUrlImagen.SelectedItems[0].Text;
            Imagen imagen = articulo.Imagenes.Find(x => x.ImagenUrl == url);

            if (imagen != null)
            {
                if(imagen.Id != 0)
                {
                    imagenesAEliminar.Add(imagen);
                }
                articulo.Imagenes.Remove(imagen);
            }
            lvUrlImagen.Items.Remove(lvUrlImagen.SelectedItems[0]);

            pbImagen.Image = null;

        }

        private void lvUrlImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUrlImagen.SelectedItems.Count == 0)
                return;

            string url = lvUrlImagen.SelectedItems[0].Text;
            try
            {
                pbImagen.Load(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("La imagen no existe o no se puede acceder a ella.", "Imagen no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
