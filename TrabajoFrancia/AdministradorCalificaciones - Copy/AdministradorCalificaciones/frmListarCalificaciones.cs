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
    public partial class frmListarCalificaciones : Form
    {
        public class _ID
        {
            public static int id = 0;
        }

        public frmListarCalificaciones()
        {
            InitializeComponent();
        }

        private void btnListarCalificaciones_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            double puntos_honor = 0;
            double creditos = 0;
            int counter = 0;
            //string[] array = new string[7];
            //try
            //{
            string[] lineas1 = File.ReadAllLines("estudiantes.txt");
            StreamReader streamReader = new StreamReader("estudiantes.txt");
            string text = "";
            string[] ID = new string[lineas1.Length];
            string[] Nombre = new string[lineas1.Length];
            string[] Carrera = new string[lineas1.Length];
            double[] indice = new double[lineas1.Length];
            string[] honor = new string[lineas1.Length];
            string[] print = new string[lineas1.Length];

            for (text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
            {
                string[] array = text.Split(new char[] { ':' });
                ID[counter] = array[0];
                Nombre[counter] = array[1];
                counter++;
            }
            streamReader.Close();


            for (int i = 0; i < lineas1.Length; i++)
            {
                puntos_honor = 0;
                creditos = 0;
                string[] lineas2 = File.ReadAllLines(Environment.CurrentDirectory + "\\Estudiantes\\" + ID[i] + ".txt");
                string[] lineas3 = File.ReadAllLines(Environment.CurrentDirectory + "\\Materias\\" + ID[i] + "materias.txt");



                string[] elementos = lineas2[0].Split(':');
                Carrera[i] = elementos[2];


                foreach (var item in lineas3)
                {
                    string[] elementos2 = item.Split(':');
                    puntos_honor += Convert.ToDouble(elementos2[4]);
                    creditos += Convert.ToDouble(elementos2[1]);
                }

                indice[i] = puntos_honor / creditos;

                if (indice[i] >= 3.80 && indice[i] <= 4.00)
                {
                    honor[i] = "Summa Cum Laude";
                }
                else if (indice[i] >= 3.50 && indice[i] < 3.80)
                {
                    honor[i] = "Magna Cum Laude";
                }
                else if (indice[i] >= 3.20 && indice[i] < 3.50)
                {
                    honor[i] = "Cum Laude";
                }
                else if (indice[i] < 3.20)
                {
                    honor[i] = "No Honor";
                }

                print[i] = ID[i] + ":" + Nombre[i] + ":" + Carrera[i] + ":" + indice[i] + ":" + honor[i];

                dataGridView1.Rows.Add(print[i].Split(':'));


            }
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Height = (dataGridView1.ClientRectangle.Height - dataGridView1.ColumnHeadersHeight) / dataGridView1.Rows.Count;
            }
        }
        

        private void frmListarCalificaciones_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
