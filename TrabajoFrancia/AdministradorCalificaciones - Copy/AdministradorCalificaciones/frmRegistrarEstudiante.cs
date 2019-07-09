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
    public partial class frmRegistrarEstudiante : Form
    {
        public frmRegistrarEstudiante()
        {
            InitializeComponent();


            //string pathMaterias = Environment.CurrentDirectory + "\\Materias";
            //string pathEstudiantes = Environment.CurrentDirectory + "\\Estudiantes";
            //string pathAreas = Environment.CurrentDirectory + "\\Areas";
            //string pathCarreras = Environment.CurrentDirectory + "\\Carreras";
            //Directory.CreateDirectory(pathMaterias);
            //Directory.CreateDirectory(pathEstudiantes);
            //Directory.CreateDirectory(pathAreas);
            //Directory.CreateDirectory(pathCarreras);
            Thread.Sleep(200);
            txtId.Text = DateTime.Now.ToString("yyyydMMmssf");


        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string carrera = seleccionarCarreracomboBox.Text;
            string[] nombrecarrera = carrera.Split('(');

        

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(carrera)  || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(carrera))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
            else
            {
                if (File.Exists(Environment.CurrentDirectory + "\\Estudiantes\\" + id + ".txt"))
                {
                    MessageBox.Show("El estudiante ya está registrado.");
                }
                else
                {


                    //Guardar datos en text files
                    //Guardar txt con id y nombre

                    string IdYNombre = "" + id + ":" + nombre + Environment.NewLine;
                    File.AppendAllText("estudiantes.txt", IdYNombre);

                    //Guardar txt con id, nombre y carrera

                    string IdNombreCarrera = "" + id + ":" + nombre + ":" + nombrecarrera[0] + Environment.NewLine;
                    File.AppendAllText("estudianteslista.txt", IdNombreCarrera);


                    //Guardar ID con sus calificaciones personales
                    
                    string IdMasCalificaciones = "" + id + ":" + nombre + ":" + nombrecarrera[0];
                    string dirUnico = Environment.CurrentDirectory + "\\Estudiantes\\"+ id + ".txt";
                    File.AppendAllText(dirUnico, IdMasCalificaciones);

                    MessageBox.Show("¡Estudiante registrado!");

                    //Limpiar todo despues de hacer todo
                    seleccionarCarreracomboBox.Text = String.Empty;
                    txtId.Text = String.Empty;
                    txtNombre.Text = String.Empty;
                    this.Close();
                    

                }
            }
        }



        private void SeleccionarAreacomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string area = seleccionarAreacomboBox1.Text;
            string[] Areas;
            if (seleccionarAreacomboBox1.Items != null)
            {
                seleccionarCarreracomboBox.Items.Clear();
            }

            switch (area)
            {
                case "Ingenierias":

                    if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + "Ingenierias.txt").Length == 0)
                    {
                        MessageBox.Show("Esta area no tiene carrearas registradas");
                        seleccionarAreacomboBox1.Text = null;

                    }
                    else
                    {
                        Areas = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + "Ingenierias.txt");

                        foreach (var item in Areas)
                        {
                            string[] carrera = item.Split(',');
                            seleccionarCarreracomboBox.Items.Add(carrera[0]);
                        }
                        seleccionarCarreracomboBox.Enabled = true;


                    }
                    break;
                case "Economia y Negocios":

                    if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + "Economia y Negocios.txt").Length == 0)
                    {

                        MessageBox.Show("Esta area no tiene carrearas registradas");
                        seleccionarAreacomboBox1.Text = null;

                    }
                    else
                    {
                        Areas = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + "Economia y Negocios.txt");

                        foreach (var item in Areas)
                        {
                            string[] carrera = item.Split(',');
                            seleccionarCarreracomboBox.Items.Add(carrera[0]);
                        }
                        seleccionarCarreracomboBox.Enabled = true;
                    }
                    break;

                case "Ciencias Sociales y Humanidades":
                    if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Sociales y Humanidades.txt").Length == 0)
                    {

                        MessageBox.Show("Esta area no tiene carrearas registradas");
                        seleccionarAreacomboBox1.Text = null;
                    }
                    else
                    {
                        Areas = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Sociales y Humanidades.txt");

                        foreach (var item in Areas)
                        {
                            string[] carrera = item.Split(',');
                            seleccionarCarreracomboBox.Items.Add(carrera[0]);
                        }
                        seleccionarCarreracomboBox.Enabled = true;
                    }
                    break;

                case "Ciencias Basicas y Ambientales":
                    if (new FileInfo(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Basicas y Ambientales.txt").Length == 0)
                    {

                        MessageBox.Show("Esta area no tiene carrearas registradas");
                        seleccionarAreacomboBox1.Text = null;

                    }
                    else
                    {
                        Areas = File.ReadAllLines(Environment.CurrentDirectory + "\\Areas\\" + "Ciencias Basicas y Ambientales.txt");

                        foreach (var item in Areas)
                        {
                            string[] carrera = item.Split(',');
                            seleccionarCarreracomboBox.Items.Add(carrera[0]);
                        }
                        seleccionarCarreracomboBox.Enabled = true;
                    }
                    break;

                default:
                    break;
            }
        }

        private void SeleccionarCarreracomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
