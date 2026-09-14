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
    public partial class frmAdmCategoria : Form
    {
        private List<Categoria> listaCategorias;
        public frmAdmCategoria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAdmCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                listaCategorias = categoria.listar();
                dgvAdmCategoria.DataSource = listaCategorias;
                dgvAdmCategoria.Columns["Id"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarDescripcion categorias = new frmAgregarDescripcion();
            categorias.ShowDialog();
            cargar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            seleccionado = (Categoria)dgvAdmCategoria.CurrentRow.DataBoundItem;

            frmAgregarDescripcion modificar = new frmAgregarDescripcion(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio neg = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad queres Eliminar?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvAdmCategoria.CurrentRow.DataBoundItem;
                    neg.eliminar(seleccionado.Id);
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
