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
    public partial class frmAdmMarca : Form
    {
        private List<Marca> listaMarcas;

        public frmAdmMarca()
        {
            InitializeComponent();
        }

        private void frmAdmMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            MarcaNegocio marca = new MarcaNegocio();
            try
            {
                listaMarcas = marca.listar();
                dgvMarcas.DataSource = listaMarcas;
                dgvMarcas.Columns["Id"].Visible = false;
                dgvMarcas.RowHeadersVisible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDescripcionMarca marca = new frmDescripcionMarca();
            marca.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            frmDescripcionMarca modificar = new frmDescripcionMarca(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarAdmMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio neg = new MarcaNegocio();
            Marca seleccionado;
            try
            {
               DialogResult respuesta = MessageBox.Show("¿De verdad queres Eliminar?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
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
