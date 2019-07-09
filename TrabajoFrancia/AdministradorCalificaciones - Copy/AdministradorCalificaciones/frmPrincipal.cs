using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AdministradorCalificaciones
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            string pathMaterias = Environment.CurrentDirectory + "\\Materias";
            string pathEstudiantes = Environment.CurrentDirectory + "\\Estudiantes";
            string pathAreas = Environment.CurrentDirectory + "\\Areas";
            string pathCarreras = Environment.CurrentDirectory + "\\Carreras";
            string pathProfesores = Environment.CurrentDirectory + "\\Profesores";
            Directory.CreateDirectory(pathMaterias);
            Directory.CreateDirectory(pathEstudiantes);
            Directory.CreateDirectory(pathAreas);
            Directory.CreateDirectory(pathCarreras);
            Directory.CreateDirectory(pathProfesores);

            if (!File.Exists(Environment.CurrentDirectory + "\\Areas\\" + "Ingenierias.txt"))
            {
                var myfile = File.Create(Environment.CurrentDirectory + "\\Areas\\" + "Ingenierias.txt");
                myfile.Close();
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Areas\\" + "Economia y Negocios.txt"))
            {
                var myfile = File.Create(Environment.CurrentDirectory + "\\Areas\\" + "Economia y Negocios.txt");
                myfile.Close();
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Sociales y Humanidades.txt"))
            {
                var myfile = File.Create(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Sociales y Humanidades.txt");
                myfile.Close();
            }
            if (!File.Exists(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Basicas y Ambientales.txt"))
            {
                var myfile = File.Create(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Basicas y Ambientales.txt");
                myfile.Close();

            }

        }

        private void btnCalificarEstudiante_Click(object sender, EventArgs e)
        {

            if (!File.Exists("estudiantes.txt"))
            {
                var miarchivo = File.Create("estudiantes.txt");
                miarchivo.Close();
            }



                string lineOfContents = File.ReadAllText("estudiantes.txt");

                if (string.IsNullOrWhiteSpace(lineOfContents))
                {

                    MessageBox.Show("No hay estudiantes registrados, antes de calificar registre a algun estudiante");
                }
                else
                {
                    Form calificarEstudiante = new frmCalificarEstudiante();
                    calificarEstudiante.Show();
                }
            

         
        }

        private void btnRegistrarMateria_Click(object sender, EventArgs e)
        {
            Form registrarMateria = new frmRegMateria();
            registrarMateria.Show();
        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            Form registrarEstudiante = new frmRegistrarEstudiante();
            registrarEstudiante.Show();
        }

        private void btnListarCalificaciones_Click(object sender, EventArgs e)
        {

            if (!File.Exists("estudiantes.txt"))
            {
                var miarchivo = File.Create("estudiantes.txt");
                miarchivo.Close();
            }

                string lineOfContents = File.ReadAllText("estudiantes.txt");
                if (string.IsNullOrWhiteSpace(lineOfContents))
                {

                    MessageBox.Show("No hay estudiantes registrados, antes de listar registre a algun estudiante");
                }
                if (!Directory.EnumerateFileSystemEntries(Environment.CurrentDirectory + "\\Materias").Any())
                {
                    MessageBox.Show("No hay materias registradas, antes de listar regitre alguna materia");
                }
                else
                {
                    Form listarCalificaciones = new frmListarCalificaciones();
                    listarCalificaciones.Show();
                }
            
        }

        private void BtnAgregarMateria_Click(object sender, EventArgs e)
        {
            if (!File.Exists("estudiantes.txt"))
            {
                var myfile = File.Create("estudiantes.txt");
                myfile.Close();
            }

                string lineOfContents = File.ReadAllText("estudiantes.txt");
                if (string.IsNullOrWhiteSpace(lineOfContents))
                {

                    MessageBox.Show("No hay estudiantes registrados, antes de calificar registre a algun estudiante");
                }
                else
                {
                    Form agregarmateria = new frmAgregarMateria();
                    agregarmateria.Show();
                }


            

            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregarCarrera_Click(object sender, EventArgs e)
        {
            Form agregarcarrera = new frmAgregarCarrera();
            agregarcarrera.Show();
        }

        private void BtnAgregarProfesor_Click(object sender, EventArgs e)
        {
            Form agregarprofesor = new frmAgregarProfesor();
            agregarprofesor.Show();
        }
    }
}
