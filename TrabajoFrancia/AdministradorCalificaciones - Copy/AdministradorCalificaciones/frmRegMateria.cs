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
    public partial class frmRegMateria : Form
    {
        public frmRegMateria()
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


        }



        private void frmRegMateria_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarAsignatura_Click_1(object sender, EventArgs e)
        {
            string materia = txtNombreAsignatura.Text;
            string creditos = txtCantidadCreditos.Text;
            string area = seleccionarAreacomboBox1.Text;
            string[] nombrecarrera = seleccionarCarreracomboBox.Text.Split('(');
            

            if (txtNombreAsignatura.Text.Trim() == "" || txtCantidadCreditos.Text.Trim() == "" || seleccionarAreacomboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
            else
            {
                txtNombreAsignatura.Text = String.Empty;
                txtCantidadCreditos.Text = String.Empty;
                seleccionarAreacomboBox1.Text = String.Empty;
                seleccionarCarreracomboBox.Text = String.Empty;
                StreamWriter archivo = File.AppendText(Environment.CurrentDirectory + "\\Carreras\\" + nombrecarrera[0] +"Materias.txt");
                archivo.WriteLine(materia + ":" + creditos);
                MessageBox.Show("¡Materia registrada!");
                archivo.Close();
                this.Close();
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

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

    }
}
