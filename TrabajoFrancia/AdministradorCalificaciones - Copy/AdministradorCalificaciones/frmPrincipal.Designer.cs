namespace AdministradorCalificaciones
{
    partial class frmPrincipal
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
            this.txtTituloPrincipal = new System.Windows.Forms.Label();
            this.btnCalificarEstudiante = new System.Windows.Forms.Button();
            this.btnRegistrarEstudiante = new System.Windows.Forms.Button();
            this.btnRegistrarMateria = new System.Windows.Forms.Button();
            this.btnListarCalificaciones = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.btnAgregarCarrera = new System.Windows.Forms.Button();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTituloPrincipal
            // 
            this.txtTituloPrincipal.AutoSize = true;
            this.txtTituloPrincipal.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPrincipal.Location = new System.Drawing.Point(133, 9);
            this.txtTituloPrincipal.Name = "txtTituloPrincipal";
            this.txtTituloPrincipal.Size = new System.Drawing.Size(562, 55);
            this.txtTituloPrincipal.TabIndex = 0;
            this.txtTituloPrincipal.Text = "Manejador de Calificaciones";
            // 
            // btnCalificarEstudiante
            // 
            this.btnCalificarEstudiante.Location = new System.Drawing.Point(332, 301);
            this.btnCalificarEstudiante.Name = "btnCalificarEstudiante";
            this.btnCalificarEstudiante.Size = new System.Drawing.Size(141, 45);
            this.btnCalificarEstudiante.TabIndex = 3;
            this.btnCalificarEstudiante.Text = "Calificar Estudiante";
            this.btnCalificarEstudiante.UseVisualStyleBackColor = true;
            this.btnCalificarEstudiante.Click += new System.EventHandler(this.btnCalificarEstudiante_Click);
            // 
            // btnRegistrarEstudiante
            // 
            this.btnRegistrarEstudiante.Location = new System.Drawing.Point(332, 159);
            this.btnRegistrarEstudiante.Name = "btnRegistrarEstudiante";
            this.btnRegistrarEstudiante.Size = new System.Drawing.Size(141, 45);
            this.btnRegistrarEstudiante.TabIndex = 1;
            this.btnRegistrarEstudiante.Text = "Registrar Estudiante";
            this.btnRegistrarEstudiante.UseVisualStyleBackColor = true;
            this.btnRegistrarEstudiante.Click += new System.EventHandler(this.btnRegistrarEstudiante_Click);
            // 
            // btnRegistrarMateria
            // 
            this.btnRegistrarMateria.Location = new System.Drawing.Point(332, 93);
            this.btnRegistrarMateria.Name = "btnRegistrarMateria";
            this.btnRegistrarMateria.Size = new System.Drawing.Size(141, 45);
            this.btnRegistrarMateria.TabIndex = 0;
            this.btnRegistrarMateria.Text = "Registrar Materia";
            this.btnRegistrarMateria.UseVisualStyleBackColor = true;
            this.btnRegistrarMateria.Click += new System.EventHandler(this.btnRegistrarMateria_Click);
            // 
            // btnListarCalificaciones
            // 
            this.btnListarCalificaciones.Location = new System.Drawing.Point(332, 376);
            this.btnListarCalificaciones.Name = "btnListarCalificaciones";
            this.btnListarCalificaciones.Size = new System.Drawing.Size(141, 45);
            this.btnListarCalificaciones.TabIndex = 4;
            this.btnListarCalificaciones.Text = "Listar Calificaciones";
            this.btnListarCalificaciones.UseVisualStyleBackColor = true;
            this.btnListarCalificaciones.Click += new System.EventHandler(this.btnListarCalificaciones_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(332, 229);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(141, 46);
            this.btnAgregarMateria.TabIndex = 2;
            this.btnAgregarMateria.Text = "Agregar Materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.BtnAgregarMateria_Click);
            // 
            // btnAgregarCarrera
            // 
            this.btnAgregarCarrera.Location = new System.Drawing.Point(539, 93);
            this.btnAgregarCarrera.Name = "btnAgregarCarrera";
            this.btnAgregarCarrera.Size = new System.Drawing.Size(141, 45);
            this.btnAgregarCarrera.TabIndex = 5;
            this.btnAgregarCarrera.Text = "Agregar Carrera";
            this.btnAgregarCarrera.UseVisualStyleBackColor = true;
            this.btnAgregarCarrera.Click += new System.EventHandler(this.BtnAgregarCarrera_Click);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(539, 159);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(141, 45);
            this.btnAgregarProfesor.TabIndex = 6;
            this.btnAgregarProfesor.Text = "Agregar Profesor";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.BtnAgregarProfesor_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 471);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.btnAgregarCarrera);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.btnListarCalificaciones);
            this.Controls.Add(this.btnRegistrarMateria);
            this.Controls.Add(this.btnRegistrarEstudiante);
            this.Controls.Add(this.btnCalificarEstudiante);
            this.Controls.Add(this.txtTituloPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Manejador de Calificaciones";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTituloPrincipal;
        private System.Windows.Forms.Button btnCalificarEstudiante;
        private System.Windows.Forms.Button btnRegistrarEstudiante;
        private System.Windows.Forms.Button btnRegistrarMateria;
        private System.Windows.Forms.Button btnListarCalificaciones;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Button btnAgregarCarrera;
        private System.Windows.Forms.Button btnAgregarProfesor;
    }
}

