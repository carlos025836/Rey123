namespace AdministradorCalificaciones
{
    partial class frmAgregarMateria
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.seleccionarEstComboBox = new System.Windows.Forms.ComboBox();
            this.btnAgregarAsignatura = new System.Windows.Forms.Button();
            this.AsignaturascheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione un estudiante:";
            // 
            // seleccionarEstComboBox
            // 
            this.seleccionarEstComboBox.FormattingEnabled = true;
            this.seleccionarEstComboBox.Location = new System.Drawing.Point(171, 39);
            this.seleccionarEstComboBox.Name = "seleccionarEstComboBox";
            this.seleccionarEstComboBox.Size = new System.Drawing.Size(190, 21);
            this.seleccionarEstComboBox.TabIndex = 2;
            this.seleccionarEstComboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarEstComboBox1_SelectedIndexChanged);
            // 
            // btnAgregarAsignatura
            // 
            this.btnAgregarAsignatura.Location = new System.Drawing.Point(129, 285);
            this.btnAgregarAsignatura.Name = "btnAgregarAsignatura";
            this.btnAgregarAsignatura.Size = new System.Drawing.Size(132, 30);
            this.btnAgregarAsignatura.TabIndex = 6;
            this.btnAgregarAsignatura.Text = "Agregar Asignatura";
            this.btnAgregarAsignatura.UseVisualStyleBackColor = true;
            this.btnAgregarAsignatura.Click += new System.EventHandler(this.BtnAgregarAsignatura_Click);
            // 
            // AsignaturascheckedListBox1
            // 
            this.AsignaturascheckedListBox1.CheckOnClick = true;
            this.AsignaturascheckedListBox1.Enabled = false;
            this.AsignaturascheckedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturascheckedListBox1.FormattingEnabled = true;
            this.AsignaturascheckedListBox1.Location = new System.Drawing.Point(24, 93);
            this.AsignaturascheckedListBox1.Name = "AsignaturascheckedListBox1";
            this.AsignaturascheckedListBox1.Size = new System.Drawing.Size(408, 148);
            this.AsignaturascheckedListBox1.TabIndex = 8;
            this.AsignaturascheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.AsignaturascheckedListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:Creditos";
            // 
            // frmAgregarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 389);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarAsignatura);
            this.Controls.Add(this.seleccionarEstComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AsignaturascheckedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarMateria";
            this.Text = "frmAgregarMateria";
            this.Load += new System.EventHandler(this.FrmAgregarMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox seleccionarEstComboBox;
        private System.Windows.Forms.Button btnAgregarAsignatura;
        private System.Windows.Forms.CheckedListBox AsignaturascheckedListBox1;
        private System.Windows.Forms.Label label2;
    }
}