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
    public partial class frmConsultarTrivia : Form
    {
        public frmConsultarTrivia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salir
            this.Close();
        }

        private void cmbTrivia_TextChanged(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            int id_trivia = objDatos.getId_Trivia(cmbTrivia.Text);
            //Parchazo buscado de Internet, si solo se coloca hasta aquí \/, regresa la longitud.
            dgvEquipos.DataSource = objDatos.getEquiposByTrivia(id_trivia).Select(x => new { EQUIPOS = x }).ToList();
            dgvLibros_Combo.DataSource = objDatos.getLibroComboByTrivia(id_trivia);
        }

        private void frmConsultarTrivia_Load(object sender, EventArgs e)
        {
        }
    }
}
