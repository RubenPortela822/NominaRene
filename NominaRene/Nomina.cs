using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fase2ReneLozano
{
    public partial class Nomina : Form
    {
        public string documento;
        public string nombre;
        public string cargo;
        public string genero;
        public int dias;
        public int valDia;
        public Boolean guardado;

        public Nomina()
        {
            this.guardado = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.Items.Add("Electricista");
            this.comboBox1.Items.Add("Mecánico");
            this.comboBox1.Items.Add("Soldador");
            this.comboBox1.Items.Add("Servicios generales");
            this.comboBox1.Items.Add("Administrativos");
            this.comboBox1.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = this.comboBox1.SelectedItem.ToString();

            switch (value)
            {
                case "Electricista":
                    this.textBox3.Text = "60000";
                    break;

                case "Mecánico":
                    this.textBox3.Text = "65000";
                    break;

                case "Soldador":
                    this.textBox3.Text = "70000";
                    break;

                case "Servicios generales":
                    this.textBox3.Text = "40000";
                    break;

                case "Administrativos":
                    this.textBox3.Text = "50000";
                    break;

                default:
                    this.textBox3.Text = "0";
                    break;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.textBox4.KeyPress += NumericTextBox_KeyPress;
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es numérica o la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla no es numérica y no es la tecla de retroceso, se cancela la acción
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.KeyPress += NumericTextBox_KeyPress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.validarForm())
            {
                return;
            }
            this.documento = this.textBox1.Text;
            this.nombre = this.textBox2.Text;
            this.cargo = this.comboBox1.SelectedItem.ToString();
            int.TryParse(this.textBox4.Text, out this.dias);
            int.TryParse(this.textBox3.Text, out this.valDia);
            MessageBox.Show("Datos guardados correctamente");
            this.guardado = true;
        }


        private Boolean validarForm()
        {

            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Por favor, digite un documento");
                return false;
            }

            if (this.textBox2.Text == "")
            {
                MessageBox.Show("Por favor, digite un nombre");
                return false;
            }

            if (!(this.comboBox1.SelectedIndex >= 0))
            {
                MessageBox.Show("Por favor, seleccione un cargo");
                return false;
            }

            if (this.radioButton1.Checked)
            {
                this.genero = this.radioButton1.Text;
            }
            else if (this.radioButton2.Checked)
            {
                this.genero = this.radioButton2.Text;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un genero");
                return false;
            }

            if (this.textBox4.Text == "")
            {
                MessageBox.Show("Por favor, digite la cantidad de dias trabajados");
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.guardado)
            {
                Reporte formulario3 = new Reporte(this.documento, this.nombre, this.cargo, this.dias, this.valDia, this.genero);
                this.Hide();
                formulario3.Show();
            }
            else
            {
                MessageBox.Show("Por favor, guarde los datos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
