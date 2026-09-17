using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace TPWinForm_equipo_8
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public frmArticulos()
        {
            InitializeComponent();
        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar() { 
            CatalogoNegocio negocio  = new CatalogoNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmArticulo ventana = new frmArticulo();
            ventana.Show();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmArticulo ventana = new frmArticulo(seleccionado);
            ventana.ShowDialog();

            cargar();
        }
        private void btnDetalle_Click(object sender, EventArgs e)
        {
            
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmDetalleArticulo ventana = new frmDetalleArticulo(seleccionado);
            ventana.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CatalogoNegocio Neg = new CatalogoNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres Eliminar?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    Neg.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


    }
}
