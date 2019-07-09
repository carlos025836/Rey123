namespace AdministradorCalificaciones
{
    partial class frmAgregarCarrera
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
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.txtSiglasCarrera = new System.Windows.Forms.TextBox();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.seleccionarAreacomboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nonbre de la carrera: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Siglas";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(147, 37);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(264, 20);
            this.txtNombreCarrera.TabIndex = 2;
            // 
            // txtSiglasCarrera
            // 
            this.txtSiglasCarrera.Location = new System.Drawing.Point(121, 86);
            this.txtSiglasCarrera.Name = "txtSiglasCarrera";
            this.txtSiglasCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtSiglasCarrera.TabIndex = 3;
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.Location = new System.Drawing.Point(147, 225);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(133, 27);
            this.btnAgregarCarrera.TabIndex = 4;
            this.btnAgregarCarrera.Text = "Agregar Carrera";
            this.btnAgregarCarrera.UseVisualStyleBackColor = true;
            this.btnAgregarCarrera.Click += new System.EventHandler(this.BtnAgregarCarrera_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Area";
            // 
            // seleccionarAreacomboBox1
            // 
            this.seleccionarAreacomboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarAreacomboBox1.FormattingEnabled = true;
            this.seleccionarAreacomboBox1.Items.AddRange(new object[] {
            "Economia y Negocios",
            "Ciencias Sociales y Humanidades",
            "Ciencias Basicas y Ambientales",
            "Ingenierias"});
            this.seleccionarAreacomboBox1.Location = new System.Drawing.Point(87, 141);
            this.seleccionarAreacomboBox1.Name = "seleccionarAreacomboBox1";
            this.seleccionarAreacomboBox1.Size = new System.Drawing.Size(175, 21);
            this.seleccionarAreacomboBox1.TabIndex = 12;
            // 
            // frmAgergarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 283);
            this.Controls.Add(this.seleccionarAreacomboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarCarrera);
            this.Controls.Add(this.txtSiglasCarrera);
            this.Controls.Add(this.txtNombreCarrera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgergarCarrera";
            this.Text = "frmAgergarCarrera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.TextBox txtSiglasCarrera;
        private System.Windows.Forms.Button btnAgregarCarrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox seleccionarAreacomboBox1;
    }
}