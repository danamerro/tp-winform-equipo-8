using System.Windows.Forms;
using dominio;

namespace TPWinForm_equipo_8
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void articulosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmArticulos ventana = new frmArticulos();
            ventana.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAdministracionMarca ventana = new frmAdministracionMarca();
            ventana.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmAdmCategoria ventana = new frmAdmCategoria();
            ventana.Show();
        }
    }
}
