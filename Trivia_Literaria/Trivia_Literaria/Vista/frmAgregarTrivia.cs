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
    public partial class frmAgregarTrivia : Form
    {
        public frmAgregarTrivia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            #region Cierra la ventana sin guardar lo realizado
                this.Close();
            #endregion
        }

        private void cmbTrivia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbLibros_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbTrivia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            Pojos.clsLibros_Trivia objLT = new Pojos.clsLibros_Trivia();
            Datos.clsDatos objD =new Datos.clsDatos();
            for (int i = 0; i < dgvTrivia.RowCount - 1;i++ )
            {
                objLT.Libros_idLibro = objD.getId_Libro(dgvTrivia.Rows[i].Cells[0].Value.ToString());
                objLT.Trivias_idTrivias = objD.getId_Trivia(cmbTrivia.Text);
                objLT.combo = dgvTrivia.Rows[i].Cells[1].Value.ToString().ElementAt(0);
                objD.AgregarLibrosTrivia(objLT);
            }
            MessageBox.Show("Listo");
            this.Close();
        }

        private void cmbTrivia_TextChanged(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos = new Datos.clsDatos();
            int c;
            c = objDatos.getId_Trivia(cmbTrivia.Text);
            if (objDatos.VerificarTriviaExistente(c))
            {
                MessageBox.Show("Esta trivia ya fue agregada");
            }
            else
            {
                MessageBox.Show("La trivia" + cmbTrivia.Text + " no ha sido agregada");
                cmbTrivia.Enabled = false;
                cmbLibros.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            string libro = cmbLibros.Text;
            string c;
            if(dgvTrivia.RowCount>1){
                for (int i = 0; i < dgvTrivia.RowCount-1; i++)
                {
                    c = dgvTrivia.Rows[i].Cells[0].Value.ToString();
                    if (c.Equals(libro))
                    {
                        bandera = true;
                        MessageBox.Show("El libro \"" + libro + "\" ya está registrado para esta trivia");
                        cmbLibros.SelectedItem = null;
                        rdbTriviaA.Checked = false;
                        rdbTriviaB.Checked = false;
                        gbTrivia.Enabled = false;
                        btnAgregar.Enabled = false;
                        break;
                    }
                }
            }
            if(!bandera){
                dgvTrivia.Rows.Add(libro, rdbTriviaA.Checked ? 'A' : 'B');
                cmbLibros.SelectedItem = null;
                rdbTriviaA.Checked = false;
                rdbTriviaB.Checked = false;
                gbTrivia.Enabled = false;
                btnAgregar.Enabled = false;
                if(dgvTrivia.RowCount==8){
                    cmbLibros.Enabled = false;
                    MessageBox.Show("Ya se han seleccionado los 7 libros necesarios, procede a dar aceptar");
                    btnAcept.Visible = true;
                    btnAcept.Focus();
                }
            }
        }

        private void frmAgregarTrivia_Load(object sender, EventArgs e)
        {
            Datos.clsDatos objDatos=new Datos.clsDatos();
            cmbLibros.DataSource = objDatos.getLibros();
            dgvTrivia.ColumnCount=2;
            dgvTrivia.Columns[0].Name = "Libro";
            dgvTrivia.Columns[1].Name = "Combo";
            cmbLibros.SelectedItem = null;
        }

        private void rdbTriviaA_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void cmbLibros_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbTriviaB_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void cmbLibros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gbTrivia.Enabled = true;
        }
    }
}
