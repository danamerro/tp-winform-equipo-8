using dominio;
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

namespace TPWinForm_equipo_8
{
    public partial class frmDescripcionMarca : Form
    {
        private Marca marca = null;
        public frmDescripcionMarca()
        {
            InitializeComponent();
        }
        public frmDescripcionMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void frmDescripcionMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                {
                    tbxMarca.Text = marca.Descripcion;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
             
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio neg = new MarcaNegocio();
            try
            {
                if (string.IsNullOrEmpty(tbxMarca.Text))
                {
                    MessageBox.Show("Debe ingresar una Marca");
                    return;
                }

                if (marca == null)
                    marca = new Marca();
                marca.Descripcion = tbxMarca.Text;

                if(marca.Id != 0)
                {
                    neg.modificar(marca);
                    MessageBox.Show("MODIFICADO EXITOSAMENTE");
                }
                else
                {
                    neg.agregar(marca);
                    MessageBox.Show("AGREGADO EXITOSAMENTE");
                }

                Close();
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
    }
}
