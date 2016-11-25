namespace Trivia_Literaria
{
    partial class frmAgregarTrivia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarTrivia));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTrivia = new System.Windows.Forms.ComboBox();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTrivia = new System.Windows.Forms.GroupBox();
            this.rdbTriviaB = new System.Windows.Forms.RadioButton();
            this.rdbTriviaA = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTrivia = new System.Windows.Forms.DataGridView();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbTrivia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrivia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la trivia";
            // 
            // cmbTrivia
            // 
            this.cmbTrivia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrivia.FormattingEnabled = true;
            this.cmbTrivia.Items.AddRange(new object[] {
            "Trivia A",
            "Trivia B"});
            this.cmbTrivia.Location = new System.Drawing.Point(209, 24);
            this.cmbTrivia.Name = "cmbTrivia";
            this.cmbTrivia.Size = new System.Drawing.Size(178, 26);
            this.cmbTrivia.TabIndex = 1;
            this.cmbTrivia.SelectionChangeCommitted += new System.EventHandler(this.cmbTrivia_SelectionChangeCommitted);
            this.cmbTrivia.TextChanged += new System.EventHandler(this.cmbTrivia_TextChanged);
            this.cmbTrivia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTrivia_KeyPress);
            // 
            // cmbLibros
            // 
            this.cmbLibros.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Items.AddRange(new object[] {
            "1984",
            "Ángeles y Demonios",
            "Doctor Sueño",
            "Fausto",
            "La chica del tren",
            "Memorias de una Geisha",
            "Yo antes de ti"});
            this.cmbLibros.Location = new System.Drawing.Point(209, 68);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(178, 26);
            this.cmbLibros.TabIndex = 2;
            this.cmbLibros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbLibros_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libros";
            // 
            // gbTrivia
            // 
            this.gbTrivia.BackColor = System.Drawing.Color.Transparent;
            this.gbTrivia.Controls.Add(this.rdbTriviaB);
            this.gbTrivia.Controls.Add(this.rdbTriviaA);
            this.gbTrivia.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic);
            this.gbTrivia.ForeColor = System.Drawing.Color.White;
            this.gbTrivia.Location = new System.Drawing.Point(33, 107);
            this.gbTrivia.Name = "gbTrivia";
            this.gbTrivia.Size = new System.Drawing.Size(222, 76);
            this.gbTrivia.TabIndex = 4;
            this.gbTrivia.TabStop = false;
            this.gbTrivia.Text = "Combo de preguntas";
            // 
            // rdbTriviaB
            // 
            this.rdbTriviaB.AutoSize = true;
            this.rdbTriviaB.ForeColor = System.Drawing.Color.White;
            this.rdbTriviaB.Location = new System.Drawing.Point(89, 28);
            this.rdbTriviaB.Name = "rdbTriviaB";
            this.rdbTriviaB.Size = new System.Drawing.Size(41, 30);
            this.rdbTriviaB.TabIndex = 1;
            this.rdbTriviaB.TabStop = true;
            this.rdbTriviaB.Text = "B";
            this.rdbTriviaB.UseVisualStyleBackColor = true;
            // 
            // rdbTriviaA
            // 
            this.rdbTriviaA.AutoSize = true;
            this.rdbTriviaA.ForeColor = System.Drawing.Color.White;
            this.rdbTriviaA.Location = new System.Drawing.Point(40, 28);
            this.rdbTriviaA.Name = "rdbTriviaA";
            this.rdbTriviaA.Size = new System.Drawing.Size(43, 30);
            this.rdbTriviaA.TabIndex = 0;
            this.rdbTriviaA.TabStop = true;
            this.rdbTriviaA.Text = "A";
            this.rdbTriviaA.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(274, 126);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 39);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTrivia
            // 
            this.dgvTrivia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrivia.Location = new System.Drawing.Point(33, 203);
            this.dgvTrivia.Name = "dgvTrivia";
            this.dgvTrivia.Size = new System.Drawing.Size(354, 169);
            this.dgvTrivia.TabIndex = 6;
            // 
            // btnAcept
            // 
            this.btnAcept.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnAcept.ForeColor = System.Drawing.Color.White;
            this.btnAcept.Image = ((System.Drawing.Image)(resources.GetObject("btnAcept.Image")));
            this.btnAcept.Location = new System.Drawing.Point(73, 390);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(113, 39);
            this.btnAcept.TabIndex = 5;
            this.btnAcept.Text = "&Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(238, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 39);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAgregarTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(403, 441);
            this.Controls.Add(this.dgvTrivia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbTrivia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbLibros);
            this.Controls.Add(this.cmbTrivia);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarTrivia";
            this.Text = "Agregar Trivia";
            this.gbTrivia.ResumeLayout(false);
            this.gbTrivia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrivia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTrivia;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTrivia;
        private System.Windows.Forms.RadioButton rdbTriviaB;
        private System.Windows.Forms.RadioButton rdbTriviaA;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTrivia;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancelar;
    }
}