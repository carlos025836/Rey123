namespace AdministradorCalificaciones
{
    partial class frmCalificarEstudiante
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.seleccionarEstComboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.seleccionarAsigComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un estudiante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Materia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calificación:";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Enabled = false;
            this.txtCalificacion.Location = new System.Drawing.Point(93, 179);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(218, 20);
            this.txtCalificacion.TabIndex = 2;
            this.txtCalificacion.TextChanged += new System.EventHandler(this.TxtCalificacion_TextChanged);
            // 
            // seleccionarEstComboBox1
            // 
            this.seleccionarEstComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarEstComboBox1.FormattingEnabled = true;
            this.seleccionarEstComboBox1.Location = new System.Drawing.Point(30, 57);
            this.seleccionarEstComboBox1.Name = "seleccionarEstComboBox1";
            this.seleccionarEstComboBox1.Size = new System.Drawing.Size(190, 21);
            this.seleccionarEstComboBox1.TabIndex = 0;
            this.seleccionarEstComboBox1.SelectedIndexChanged += new System.EventHandler(this.seleccionarEstComboBox1_SelectedIndexChanged);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(135, 285);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 3;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // seleccionarAsigComboBox
            // 
            this.seleccionarAsigComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seleccionarAsigComboBox.Enabled = false;
            this.seleccionarAsigComboBox.FormattingEnabled = true;
            this.seleccionarAsigComboBox.Location = new System.Drawing.Point(78, 115);
            this.seleccionarAsigComboBox.Name = "seleccionarAsigComboBox";
            this.seleccionarAsigComboBox.Size = new System.Drawing.Size(196, 21);
            this.seleccionarAsigComboBox.TabIndex = 4;
            this.seleccionarAsigComboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarAsigComboBox_SelectedIndexChanged);
            // 
            // frmCalificarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 351);
            this.Controls.Add(this.seleccionarAsigComboBox);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.seleccionarEstComboBox1);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCalificarEstudiante";
            this.Text = "frmCalificarEstudiante";
            this.Load += new System.EventHandler(this.FrmCalificarEstudiante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.ComboBox seleccionarEstComboBox1;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.ComboBox seleccionarAsigComboBox;
    }
}