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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmArticulo ventana = new frmArticulo();
            ventana.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmArticulo ventana = new frmArticulo();
            ventana.Show();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalleArticulo ventana = new frmDetalleArticulo();
            ventana.Show();
        }

        // La eliminación se implementará en la Etapa 2 con la conexión a la base de datos.
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
