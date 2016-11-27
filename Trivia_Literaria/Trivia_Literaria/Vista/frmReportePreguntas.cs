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
    public partial class frmReportePreguntas : Form
    {
        public frmReportePreguntas()
        {
            InitializeComponent();
        }

        private void frmReportePreguntas_Load(object sender, EventArgs e)
        {
            Datos.clsDatos objD=new Datos.clsDatos();
            dgvReporte.DataSource = objD.ReportePreguntas();
        }
    }
}
