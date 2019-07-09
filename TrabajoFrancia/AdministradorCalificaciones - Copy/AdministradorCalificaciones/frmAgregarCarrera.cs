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
    public partial class frmAgregarCarrera : Form
    {
        public frmAgregarCarrera()
        {
            InitializeComponent();
        }

        private void BtnAgregarCarrera_Click(object sender, EventArgs e)
        {
            string nombreCarrera = txtNombreCarrera.Text;
            string siglas = txtSiglasCarrera.Text;
            string area = seleccionarAreacomboBox1.Text;

            if (txtNombreCarrera.Text.Trim() == "" || txtSiglasCarrera.Text.Trim() == "" || seleccionarAreacomboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
            else
            {
                StreamWriter archivo = File.AppendText(Environment.CurrentDirectory + "\\Areas\\" + area + ".txt");
                archivo.WriteLine("{0}({1}),",siglas,nombreCarrera);
                archivo.Close();
                txtNombreCarrera.Text = String.Empty;
                txtSiglasCarrera.Text = String.Empty;
                MessageBox.Show("Carrera Registrada!");
                this.Close();

            }

        }
    }
}
