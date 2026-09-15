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
    public partial class frmDescripcionCategoria : Form
    {
        private Categoria categoria = null;

        public frmDescripcionCategoria()
        {
            InitializeComponent();
        }
        public frmDescripcionCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }


        private void frmAgregarDescripcion_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    tbxDescripcion.Text = categoria.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                    categoria = new Categoria();
                categoria.Descripcion = tbxDescripcion.Text;

                if (categoria.Id != 0)
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("MODIFICADO EXITOSAMENTE ");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("AGREGADO EXITOSAMENTE ");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
