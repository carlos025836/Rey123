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
using System.Threading;


namespace AdministradorCalificaciones
{
    public partial class frmCalificarEstudiante : Form
    {
        public frmCalificarEstudiante()
        {
            InitializeComponent();

            //Buscar los estudiantes de la lista


            string[] lineOfContents = File.ReadAllLines("estudiantes.txt");

            foreach (var item in lineOfContents)
            {
                string[] elemento = item.Split(':');
                string id = elemento[0];

                seleccionarEstComboBox1.Items.Add(id);

            }
        }


        private void seleccionarEstComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estudiante = seleccionarEstComboBox1.Text;
            if (!File.Exists(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt"))
            {
                MessageBox.Show("Debe de agregar una materia antes de poder calificar a un estudiante");
                this.Close();
            }
            else
            {
                string[] Asignaturas = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");

                foreach (var item in Asignaturas)
                {
                    string[] elemento = item.Split(':');
                    string asignatura = elemento[0];
                    if (!seleccionarAsigComboBox.Items.Contains(asignatura))
                    {
                        seleccionarAsigComboBox.Items.Add(asignatura);
                    }
                }

                if (!string.IsNullOrEmpty(seleccionarEstComboBox1.Text))
                {
                    seleccionarAsigComboBox.Enabled = true;
                }
                else
                {
                    seleccionarAsigComboBox.Enabled = false;
                }
            }

        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            double indice = 0;
            double puntos_honor = 0;
            //string honor = null;
            string calificacion = txtCalificacion.Text;//Los datos del la calificacion

            if (!calificacion.All(char.IsDigit) || Convert.ToDouble(calificacion) > 100 || Convert.ToDouble(calificacion) < 0 )
            {
                MessageBox.Show("Debe de ingresar una calificacion del 0-100");
            }
            else
            {
                //Leer de la lista de estudiantes con 
                string[] allLines = File.ReadAllLines("estudianteslista.txt");
                string line = string.Empty;
                if (allLines.Length >= seleccionarEstComboBox1.SelectedIndex + 1)
                {
                    line = allLines[seleccionarEstComboBox1.SelectedIndex];
                }

                //Calcular las notas
                string estudiante = seleccionarEstComboBox1.Text;
                string[] Asignaturas = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                double vNota = Convert.ToDouble(calificacion);
                int counter = 0;

                foreach (var item in Asignaturas)
                {

                    string[] elemento = item.Split(':');
                    double cred = Convert.ToDouble(elemento[1]);

                    if (vNota < 101 && vNota > 89)
                    {
                        puntos_honor = 4.00 * cred;
                        indice = 4.00;
                    }
                    else if (vNota < 90 && vNota > 84)
                    {
                        puntos_honor = 3.50 * cred;
                        indice = 3.50;
                    }
                    else if (vNota < 85 && vNota > 79)
                    {
                        puntos_honor = 3.00 * cred;
                        indice = 3.00;
                    }
                    else if (vNota < 80 && vNota > 74)
                    {
                        puntos_honor = 2.50 * cred;
                        indice = 2.50;
                    }
                    else if (vNota < 75 && vNota > 69)
                    {
                        puntos_honor = 2.00 * cred;
                        indice = 2.00;
                    }
                    else if (vNota < 70)
                    {
                        puntos_honor = 0;
                        indice = 0;
                    }

                    string text = ":" + vNota + ":" + indice + ":" + puntos_honor;



                    if (elemento[0] == seleccionarAsigComboBox.Text)
                    {
                        Asignaturas[counter] = string.Format(item + text);
                    }

                    counter++;


                }


                FileInfo myarchivo = new FileInfo(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                myarchivo.Delete();

                File.WriteAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt", Asignaturas);

                seleccionarEstComboBox1.Text = string.Empty;
                seleccionarAsigComboBox.Text = string.Empty;
                txtCalificacion.Text = string.Empty;


                MessageBox.Show("¡Estudiante calificado!");
                this.Close();
            }
        }

        private void txtMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarAsigComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estudiante = seleccionarEstComboBox1.Text;
            if (!string.IsNullOrEmpty(seleccionarAsigComboBox.Text))
            {
                txtCalificacion.Enabled = true;
            }

                string[] Asignaturas = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");

                for (int i = 0; i < Asignaturas.Length; i++)
                {
                    string[] elementos = Asignaturas[i].Split(':');

                    if (elementos.Length == 5 && elementos[0] == seleccionarAsigComboBox.Text)
                    {
                        MessageBox.Show("Esta materia ya tiene una calificacion");
                        seleccionarAsigComboBox.Text = null;
                       txtCalificacion.Enabled = false;
                        break;
                    }

                }
            



        }

        private void FrmCalificarEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void TxtCalificacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
