namespace AdministradorCalificaciones
{
    partial class frmRegMateria
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
            this.txtNombreAsignatura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarAsignatura = new System.Windows.Forms.Button();
            this.seleccionarAreacomboBox1 = new System.Windows.Forms.ComboBox();
            this.seleccionarCarreracomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidadCreditos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la materia";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtNombreAsignatura
            // 
            this.txtNombreAsignatura.Location = new System.Drawing.Point(181, 38);
            this.txtNombreAsignatura.Name = "txtNombreAsignatura";
            this.txtNombreAsignatura.Size = new System.Drawing.Size(165, 20);
            this.txtNombreAsignatura.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad de creditos";
            // 
            // btnRegistrarAsignatura
            // 
            this.btnRegistrarAsignatura.Location = new System.Drawing.Point(119, 240);
            this.btnRegistrarAsignatura.Name = "btnRegistrarAsignatura";
            this.btnRegistrarAsignatura.Size = new System.Drawing.Size(128, 23);
            this.btnRegistrarAsignatura.TabIndex = 4;
            this.btnRegistrarAsignatura.Text = "Registrar asignatura";
            this.btnRegistrarAsignatura.UseVisualStyleBackColor = true;
            this.btnRegistrarAsignatura.Click += new System.EventHandler(this.btnRegistrarAsignatura_Click_1);
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
            this.seleccionarAreacomboBox1.Location = new System.Drawing.Point(170, 122);
            this.seleccionarAreacomboBox1.Name = "seleccionarAreacomboBox1";
            this.seleccionarAreacomboBox1.Size = new System.Drawing.Size(175, 21);
            this.seleccionarAreacomboBox1.TabIndex = 2;
            this.seleccionarAreacomboBox1.SelectedIndexChanged += new System.EventHandler(this.SeleccionarAreacomboBox1_SelectedIndexChanged);
            // 
            // seleccionarCarreracomboBox
            // 
            this.seleccionarCarreracomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarCarreracomboBox.Enabled = false;
            this.seleccionarCarreracomboBox.FormattingEnabled = true;
            this.seleccionarCarreracomboBox.Location = new System.Drawing.Point(170, 159);
            this.seleccionarCarreracomboBox.Name = "seleccionarCarreracomboBox";
            this.seleccionarCarreracomboBox.Size = new System.Drawing.Size(186, 21);
            this.seleccionarCarreracomboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Carrera";
            // 
            // txtCantidadCreditos
            // 
            this.txtCantidadCreditos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCantidadCreditos.FormattingEnabled = true;
            this.txtCantidadCreditos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.txtCantidadCreditos.Location = new System.Drawing.Point(181, 80);
            this.txtCantidadCreditos.Name = "txtCantidadCreditos";
            this.txtCantidadCreditos.Size = new System.Drawing.Size(165, 21);
            this.txtCantidadCreditos.TabIndex = 1;
            // 
            // frmRegMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 301);
            this.Controls.Add(this.txtCantidadCreditos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seleccionarCarreracomboBox);
            this.Controls.Add(this.seleccionarAreacomboBox1);
            this.Controls.Add(this.btnRegistrarAsignatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreAsignatura);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegMateria";
            this.Text = "frmRegMateria";
            this.Load += new System.EventHandler(this.frmRegMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAsignatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrarAsignatura;
        private System.Windows.Forms.ComboBox seleccionarAreacomboBox1;
        private System.Windows.Forms.ComboBox seleccionarCarreracomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtCantidadCreditos;
    }
}