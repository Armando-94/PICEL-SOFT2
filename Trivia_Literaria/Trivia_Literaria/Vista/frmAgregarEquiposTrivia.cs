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
            try
            {
                objD.AgregarEquipo_Trivia(cmbTrivia.Text, cmbEquipos.Text);
                MessageBox.Show("Se ha agregado el equipo " + cmbEquipos.Text + " a la " + cmbTrivia.Text);
            }catch(Exception ex){
                MessageBox.Show("No se pudo agregar");
            }
        }
    }
}
