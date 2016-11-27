using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Literaria
{
    public partial class frmEliminarEquipo : Form
    {
        public frmEliminarEquipo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cancelar
            this.Close();
        }

        private void frmEliminarEquipo_Load(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            cmbEquipo.DataSource = objDatos.getEquipos();
            cmbEquipo.SelectedItem = null;
            btnEliminar.Visible = false;
        }

        private void cmbEquipo_TextChanged(object sender, EventArgs e)
        {
            btnEliminar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            objDatos.Eliminar_Equipo(cmbEquipo.Text);
            MessageBox.Show("Listo, equipo eliminado");
            this.Close();
        }
    }
}
