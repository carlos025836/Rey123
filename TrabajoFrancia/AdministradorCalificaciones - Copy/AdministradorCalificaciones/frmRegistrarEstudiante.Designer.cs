namespace AdministradorCalificaciones
{
    partial class frmRegistrarEstudiante
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.seleccionarCarreracomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seleccionarAreacomboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carrera";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(58, 47);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(175, 20);
            this.txtId.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(58, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(175, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(96, 300);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // seleccionarCarreracomboBox
            // 
            this.seleccionarCarreracomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarCarreracomboBox.Enabled = false;
            this.seleccionarCarreracomboBox.FormattingEnabled = true;
            this.seleccionarCarreracomboBox.Location = new System.Drawing.Point(58, 232);
            this.seleccionarCarreracomboBox.Name = "seleccionarCarreracomboBox";
            this.seleccionarCarreracomboBox.Size = new System.Drawing.Size(186, 21);
            this.seleccionarCarreracomboBox.TabIndex = 3;
            this.seleccionarCarreracomboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarCarreracomboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
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
            this.seleccionarAreacomboBox1.Location = new System.Drawing.Point(58, 169);
            this.seleccionarAreacomboBox1.Name = "seleccionarAreacomboBox1";
            this.seleccionarAreacomboBox1.Size = new System.Drawing.Size(175, 21);
            this.seleccionarAreacomboBox1.TabIndex = 2;
            this.seleccionarAreacomboBox1.SelectedIndexChanged += new System.EventHandler(this.SeleccionarAreacomboBox1_SelectedIndexChanged);
            // 
            // frmRegistrarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 352);
            this.Controls.Add(this.seleccionarAreacomboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seleccionarCarreracomboBox);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarEstudiante";
            this.Text = "frmRegistrarEstudiante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox seleccionarCarreracomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox seleccionarAreacomboBox1;
    }
}