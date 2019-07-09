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
    public partial class frmAgregarMateria : Form
    {

        public frmAgregarMateria()
        {
            InitializeComponent();
            if (!File.Exists("estudiantes.txt"))
            {
                var myfile = File.Create("estudiantes.txt");
                myfile.Close();
            }
            else 
            {
                string[] lineOfContents = File.ReadAllLines("estudiantes.txt");

                foreach (var item in lineOfContents)
                {
                    string[] elemento = item.Split(':');
                    string id = elemento[0];
                    seleccionarEstComboBox.Items.Add(id);

                }
            }

        }
        private void SeleccionarEstComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsignaturascheckedListBox1.Items.Clear();
            string estudiante = seleccionarEstComboBox.Text;
            int counter = 0;
            string est = File.ReadAllText(Environment.CurrentDirectory + "\\Estudiantes\\" + estudiante + ".txt");
            string[] carrera = est.Split(':');

            string[] materias = File.ReadAllLines(Environment.CurrentDirectory + "\\Carreras\\" + carrera[2] + "Materias.txt");
            foreach (var item in materias)
            {
                string[] elemento = item.Split(':');
                string asignatura = elemento[0] + ":" + elemento[1];
                AsignaturascheckedListBox1.Items.Add(asignatura);

            }
            
              


            if (!File.Exists(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt"))
            {
               var myfile = File.Create(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                myfile.Close();
              
            }
            else
            {
                string[] lines = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");

                foreach (var item in lines)
                {
                    string[] elementos = item.Split(':');
                    string nombre = elementos[0];
                    string cred = elementos[1];
                    string nombre_cred = elementos[0] + ":" + elementos[1];

                    if (AsignaturascheckedListBox1.Items[counter].ToString() == nombre_cred)
                    {
                        AsignaturascheckedListBox1.SetItemChecked(AsignaturascheckedListBox1.Items.IndexOf(nombre_cred), true);
                        AsignaturascheckedListBox1.SetItemCheckState(AsignaturascheckedListBox1.Items.IndexOf(nombre_cred), CheckState.Indeterminate);
                    }

                    counter++;
                }

            }
            if (counter == AsignaturascheckedListBox1.Items.Count)
            {
                MessageBox.Show("Ya se han agregado todas las materias de la carrera correspodniente a este estudiante");
            }
            else
            {

                AsignaturascheckedListBox1.Enabled = true;
            }

        }




        private void BtnAgregarAsignatura_Click(object sender, EventArgs e)
        {
           

            if (string.IsNullOrEmpty(seleccionarEstComboBox.Text))
            {
                MessageBox.Show("Debe de seleccionar a un estudiante");
            }
            else if (AsignaturascheckedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe de seleccionar  almenos una asignatura");
            }
            else
            {

                string estudiante = seleccionarEstComboBox.Text;
                int counter = 0;


                string est = File.ReadAllText(Environment.CurrentDirectory + "\\Estudiantes\\" + estudiante + ".txt");
                string[] carrera = est.Split(':');

                string[] materias = File.ReadAllLines(Environment.CurrentDirectory + "\\Carreras\\" + carrera[2] + "Materias.txt");

                foreach (var item in materias)
                {
                    string[] elemento = item.Split(':');
                    string asignatura = elemento[0] + ":" + elemento[1];

                    if (!File.Exists(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt"))
                    {
                        var myfile = File.Create(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                        myfile.Close();

                    }
                        

                    string[] materiasest = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                    if (new FileInfo(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt").Length != 0)
                    {
                        if (AsignaturascheckedListBox1.CheckedItems.Contains(item))
                        {

                            foreach (var s in materiasest)
                            {
                                string[] elementos = s.Split(':');
                                if (elementos[0] == elemento[0])
                                {
                                    break;
                                }
                                else if (elementos[0] + elementos[1] != elemento[0] + elemento[1])
                                {
                                    StreamWriter archivo = File.AppendText(Environment.CurrentDirectory + "\\Materias\\" + estudiante + "materias.txt");
                                    archivo.Write(AsignaturascheckedListBox1.CheckedItems[AsignaturascheckedListBox1.CheckedItems.IndexOf(item)] + Environment.NewLine);
                                    archivo.Close();

                                    MessageBox.Show("Se ha añadido la materia: " + elemento[0]);
                                }
                            }
                        }
                       
                    }

                    counter++;
                }
                if (counter == AsignaturascheckedListBox1.Items.Count)
                {
                    MessageBox.Show("Todas las asignaturas seleccionadas ya han sido registradas a este estudiante.");
                    this.Close();
                }

            }
            

        }

        private void FrmAgregarMateria_Load(object sender, EventArgs e)
        {

        }

        private void AsignaturascheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
