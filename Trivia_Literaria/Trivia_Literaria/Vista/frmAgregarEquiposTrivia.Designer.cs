namespace Trivia_Literaria.Vista
{
    partial class frmAgregarEquiposTrivia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTrivia = new System.Windows.Forms.ComboBox();
            this.cmbEquipos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trivia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Equipos";
            // 
            // cmbTrivia
            // 
            this.cmbTrivia.AutoCompleteCustomSource.AddRange(new string[] {
            "Trivia A",
            "Trivia B"});
            this.cmbTrivia.FormattingEnabled = true;
            this.cmbTrivia.Items.AddRange(new object[] {
            "Trivia A",
            "Trivia B"});
            this.cmbTrivia.Location = new System.Drawing.Point(80, 13);
            this.cmbTrivia.Name = "cmbTrivia";
            this.cmbTrivia.Size = new System.Drawing.Size(121, 21);
            this.cmbTrivia.TabIndex = 2;
            // 
            // cmbEquipos
            // 
            this.cmbEquipos.AutoCompleteCustomSource.AddRange(new string[] {
            "CHICOS QUE LLORAN",
            "CAZADORES DE LIBROS",
            "ATMAN",
            "EL INTENTO SE HIZO \"THE RETURN\"",
            "BIRDS",
            "2^2+1",
            "THE CORE",
            "CDS-SILVER",
            "REMEDIAL SQUAD",
            "LITERATOS"});
            this.cmbEquipos.FormattingEnabled = true;
            this.cmbEquipos.Items.AddRange(new object[] {
            "CHICOS QUE LLORAN",
            "CAZADORES DE LIBROS",
            "ATMAN",
            "EL INTENTO SE HIZO \"THE RETURN\"",
            "BIRDS",
            "2^2+1",
            "THE CORE",
            "CDS-SILVER",
            "REMEDIAL SQUAD",
            "LITERATOS"});
            this.cmbEquipos.Location = new System.Drawing.Point(80, 44);
            this.cmbEquipos.Name = "cmbEquipos";
            this.cmbEquipos.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipos.TabIndex = 3;
            this.cmbEquipos.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(232, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAgregarEquiposTrivia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 81);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbEquipos);
            this.Controls.Add(this.cmbTrivia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarEquiposTrivia";
            this.Text = "frmAgregarEquiposTrivia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTrivia;
        private System.Windows.Forms.ComboBox cmbEquipos;
        private System.Windows.Forms.Button btnAgregar;
    }
}