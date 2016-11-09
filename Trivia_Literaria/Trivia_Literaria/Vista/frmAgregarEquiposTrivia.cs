using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia_Literaria.Vista
{
    public partial class frmAgregarEquiposTrivia : Form
    {
        public frmAgregarEquiposTrivia()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Datos.clsDatos objD = new Datos.clsDatos();
            objD.AgregarEquipo_Trivia(cmbTrivia.Text,cmbEquipos.Text);
        }
    }
}
