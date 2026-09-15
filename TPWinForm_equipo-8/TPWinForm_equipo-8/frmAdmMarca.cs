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
    }
}
