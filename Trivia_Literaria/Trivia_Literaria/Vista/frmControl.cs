using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Trivia_Literaria
{
    public partial class frmControl : Form
    {
        public frmControl()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Llamado al Form Agregar Trivia
                frmAgregarTrivia objAgregarTrivia = new frmAgregarTrivia();
                this.Hide();
                objAgregarTrivia.ShowDialog();
                this.Show();
            #endregion
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Llamado al Form Consultar Trivia
                frmConsultarTrivia objConsultarTrivia = new frmConsultarTrivia();
                this.Hide();
                objConsultarTrivia.ShowDialog();
                this.Show();
            #endregion
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region Llamado al Form Agregar Equipo
                frmAgregarEquipos objAgregarEquipo = new frmAgregarEquipos();
                this.Hide();
                objAgregarEquipo.ShowDialog();
                this.Show();
            #endregion
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Llamado al Form Eliminar Equipo
                frmEliminarEquipo objEliminarEquipo = new frmEliminarEquipo();
                this.Hide();
                objEliminarEquipo.ShowDialog();
                this.Show();
            #endregion
        }

        /*private void agregarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmAgregarEquiposTrivia objAET = new Vista.frmAgregarEquiposTrivia();
            objAET.MdiParent = this.MdiParent;
            this.Hide();
            objAET.ShowDialog();
            this.Show();
        }*/

        private void triviaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manualDeUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Abrir manual en el navegador
            Console.WriteLine(Environment.NewLine);
            string rutaActual = @"..\";
            Directory.SetCurrentDirectory(rutaActual);
            // Muestra la ruta actual:
            //Console.WriteLine("El directorio de trabajo actual es: {0}", Directory.GetCurrentDirectory());
            //Console.WriteLine();
            // Cambiamos la ruta actual:
            Directory.SetCurrentDirectory(@"..\Manual");
            // Muestra la nueva ruta de trabajo:
            //Console.WriteLine("El directorio de trabajo actual es: {0}", Directory.GetCurrentDirectory());
            Console.WriteLine(Environment.NewLine);

            try
            {
                string url = Directory.GetCurrentDirectory();
                url += @"\" + "index.html";
                Console.WriteLine("URL: {0}",url);
                System.Diagnostics.Process.Start(url);
            }
            catch {
                MessageBox.Show("Contacte al administrador, archivo no encontrado","Error 404",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
#endregion
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software realizado por:            \nSky Software Systems\n®2016 Todos los derechos reservados", "Acerca de");
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista.frmReportePreguntas objRP = new Vista.frmReportePreguntas();
            this.Hide();
            objRP.ShowDialog();
            this.Show();
        }
    }
}
