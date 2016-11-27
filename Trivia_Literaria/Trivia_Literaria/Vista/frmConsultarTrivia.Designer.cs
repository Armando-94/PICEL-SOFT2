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
            this.dgvLibros_Combo = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros_Combo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTrivia
            // 
            this.lblTrivia.AutoSize = true;
            this.lblTrivia.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrivia.Location = new System.Drawing.Point(13, 13);
            this.lblTrivia.Name = "lblTrivia";
            this.lblTrivia.Size = new System.Drawing.Size(48, 18);
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
            this.cmbTrivia.TextChanged += new System.EventHandler(this.cmbTrivia_TextChanged);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Location = new System.Drawing.Point(16, 55);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.Size = new System.Drawing.Size(244, 123);
            this.dgvEquipos.TabIndex = 2;
            // 
            // dgvLibros_Combo
            // 
            this.dgvLibros_Combo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros_Combo.Location = new System.Drawing.Point(16, 211);
            this.dgvLibros_Combo.Name = "dgvLibros_Combo";
            this.dgvLibros_Combo.Size = new System.Drawing.Size(244, 123);
            this.dgvLibros_Combo.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(180, 355);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 27);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultarTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Trivia_Literaria.Properties.Resources.libro_mágico2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(276, 394);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvLibros_Combo);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.cmbTrivia);
            this.Controls.Add(this.lblTrivia);
            this.Name = "frmConsultarTrivia";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.frmConsultarTrivia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros_Combo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrivia;
        private System.Windows.Forms.ComboBox cmbTrivia;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.DataGridView dgvLibros_Combo;
        private System.Windows.Forms.Button btnSalir;
    }
}