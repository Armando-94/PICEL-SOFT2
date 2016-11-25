namespace Trivia_Literaria
{
    partial class frmConsultarTrivia
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
            this.lblTrivia = new System.Windows.Forms.Label();
            this.cmbTrivia = new System.Windows.Forms.ComboBox();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.Equipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEquipos_Combo = new System.Windows.Forms.DataGridView();
            this.Libros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Combo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos_Combo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrivia
            // 
            this.lblTrivia.AutoSize = true;
            this.lblTrivia.BackColor = System.Drawing.Color.Transparent;
            this.lblTrivia.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblTrivia.ForeColor = System.Drawing.Color.White;
            this.lblTrivia.Location = new System.Drawing.Point(13, 13);
            this.lblTrivia.Name = "lblTrivia";
            this.lblTrivia.Size = new System.Drawing.Size(60, 26);
            this.lblTrivia.TabIndex = 0;
            this.lblTrivia.Text = "Trivia";
            // 
            // cmbTrivia
            // 
            this.cmbTrivia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrivia.FormattingEnabled = true;
            this.cmbTrivia.Items.AddRange(new object[] {
            "Trivia A",
            "Trivia B"});
            this.cmbTrivia.Location = new System.Drawing.Point(72, 12);
            this.cmbTrivia.Name = "cmbTrivia";
            this.cmbTrivia.Size = new System.Drawing.Size(121, 26);
            this.cmbTrivia.TabIndex = 1;
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Equipos});
            this.dgvEquipos.Location = new System.Drawing.Point(16, 55);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(244, 123);
            this.dgvEquipos.TabIndex = 2;
            // 
            // Equipos
            // 
            this.Equipos.HeaderText = "Equipos";
            this.Equipos.Name = "Equipos";
            // 
            // dgvEquipos_Combo
            // 
            this.dgvEquipos_Combo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos_Combo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Libros,
            this.Combo});
            this.dgvEquipos_Combo.Location = new System.Drawing.Point(16, 211);
            this.dgvEquipos_Combo.Name = "dgvEquipos_Combo";
            this.dgvEquipos_Combo.Size = new System.Drawing.Size(244, 123);
            this.dgvEquipos_Combo.TabIndex = 2;
            // 
            // Libros
            // 
            this.Libros.HeaderText = "Libros";
            this.Libros.Name = "Libros";
            // 
            // Combo
            // 
            this.Combo.HeaderText = "Combo";
            this.Combo.Name = "Combo";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Trivia_Literaria.Properties.Resources.black_glossy_button_hi;
            this.btnSalir.Location = new System.Drawing.Point(167, 340);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultarTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivia_Literaria.Properties.Resources._12504403_cortinas_luminosas_en_el_concepto_de_teatro;
            this.ClientSize = new System.Drawing.Size(276, 394);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvEquipos_Combo);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.cmbTrivia);
            this.Controls.Add(this.lblTrivia);
            this.Name = "frmConsultarTrivia";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos_Combo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrivia;
        private System.Windows.Forms.ComboBox cmbTrivia;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipos;
        private System.Windows.Forms.DataGridView dgvEquipos_Combo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Combo;
    }
}