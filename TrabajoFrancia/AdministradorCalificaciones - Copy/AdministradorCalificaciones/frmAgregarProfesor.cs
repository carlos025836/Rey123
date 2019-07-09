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
    public partial class frmAgregarProfesor : Form
    {
        public frmAgregarProfesor()
        {
            InitializeComponent();
            Thread.Sleep(200);
            txtId.Text = DateTime.Now.ToString("yyyydMMmssf");

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
            string[] carrera = seleccionarCarreracomboBox.Text.Split('(');
            string[] materias = File.ReadAllLines(Environment.CurrentDirectory + "\\Carreras\\" + carrera[0] + "Materias.txt");
            if (seleccionarAsigComboBox.Items.Count > 0)
            {
                seleccionarAsigComboBox.Items.Clear();
            }

                foreach (var item in materias)
                {
                    string[] elementos = item.Split(':');
                    seleccionarAsigComboBox.Items.Add(elementos[0]);

                }
                seleccionarAsigComboBox.Enabled = true;
            


            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombreProfesor.Text;
            string area = seleccionarAreacomboBox1.Text;
            string carreraMateria = seleccionarCarreracomboBox.Text;
            string[] carrerasiglas = carreraMateria.Split('(');
            string materia = seleccionarAsigComboBox.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(area) || string.IsNullOrWhiteSpace(carreraMateria) || string.IsNullOrWhiteSpace(materia))
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
            else
            {
                if (!File.Exists(Environment.CurrentDirectory + "\\Profesores\\" + id + ".txt"))
                {
                    string nombre_carreraM_materia = nombre + ":" + carrerasiglas[0] + ":" + materia + Environment.NewLine;
                    File.AppendAllText(Environment.CurrentDirectory + "\\Profesores\\" + id + ".txt", nombre_carreraM_materia);
                    MessageBox.Show("Profesor agregado con exito!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Este profesor ya esta registrado");
                }

            }


        }
    }
}
