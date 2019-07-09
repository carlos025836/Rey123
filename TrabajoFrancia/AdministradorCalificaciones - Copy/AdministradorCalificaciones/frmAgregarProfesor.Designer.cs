namespace AdministradorCalificaciones
{
    partial class frmAgregarProfesor
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
            this.txtNombreProfesor = new System.Windows.Forms.TextBox();
            this.seleccionarAreacomboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seleccionarAsigComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seleccionarCarreracomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Profesor:";
            // 
            // txtNombreProfesor
            // 
            this.txtNombreProfesor.Location = new System.Drawing.Point(167, 55);
            this.txtNombreProfesor.Name = "txtNombreProfesor";
            this.txtNombreProfesor.Size = new System.Drawing.Size(164, 20);
            this.txtNombreProfesor.TabIndex = 1;
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
            this.seleccionarAreacomboBox1.Location = new System.Drawing.Point(167, 96);
            this.seleccionarAreacomboBox1.Name = "seleccionarAreacomboBox1";
            this.seleccionarAreacomboBox1.Size = new System.Drawing.Size(175, 21);
            this.seleccionarAreacomboBox1.TabIndex = 9;
            this.seleccionarAreacomboBox1.SelectedIndexChanged += new System.EventHandler(this.SeleccionarAreacomboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Area";
            // 
            // seleccionarAsigComboBox
            // 
            this.seleccionarAsigComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarAsigComboBox.Enabled = false;
            this.seleccionarAsigComboBox.FormattingEnabled = true;
            this.seleccionarAsigComboBox.Location = new System.Drawing.Point(167, 184);
            this.seleccionarAsigComboBox.Name = "seleccionarAsigComboBox";
            this.seleccionarAsigComboBox.Size = new System.Drawing.Size(196, 21);
            this.seleccionarAsigComboBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Carrera de la materia:";
            // 
            // seleccionarCarreracomboBox
            // 
            this.seleccionarCarreracomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarCarreracomboBox.Enabled = false;
            this.seleccionarCarreracomboBox.FormattingEnabled = true;
            this.seleccionarCarreracomboBox.Location = new System.Drawing.Point(167, 142);
            this.seleccionarCarreracomboBox.Name = "seleccionarCarreracomboBox";
            this.seleccionarCarreracomboBox.Size = new System.Drawing.Size(186, 21);
            this.seleccionarCarreracomboBox.TabIndex = 13;
            this.seleccionarCarreracomboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarCarreracomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Materia:";
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(167, 280);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(98, 26);
            this.btnAgregarProfesor.TabIndex = 16;
            this.btnAgregarProfesor.Text = "Agregar Profesor";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(167, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(175, 20);
            this.txtId.TabIndex = 18;
            this.txtId.Text = "`";
            // 
            // frmAgregarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 355);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seleccionarAsigComboBox);
            this.Controls.Add(this.seleccionarCarreracomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seleccionarAreacomboBox1);
            this.Controls.Add(this.txtNombreProfesor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarProfesor";
            this.Text = "frmAgregarProfesor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProfesor;
        private System.Windows.Forms.ComboBox seleccionarAreacomboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox seleccionarAsigComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox seleccionarCarreracomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
    }
}