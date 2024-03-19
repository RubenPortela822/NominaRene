using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2ReneLozano
{
    public partial class Reporte : Form
    {

        public string documento;
        public string nombre;
        public string cargo;
        public string genero;
        public int cantDias;
        public int valDia;
        public Reporte(string documento, string nombre, string cargo, int cantDias, int valDia, string genero)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.cargo = cargo;
            this.genero = genero;
            this.cantDias = cantDias;
            this.valDia = valDia;
            InitializeComponent();
            double sueldo = this.calcularSueldo();
            DateTime fechaActual = DateTime.Now;
            this.textBox1.Text = fechaActual.ToString("dd-MM-yyyy");
            this.label2.Text = "El señor " + this.nombre + " identificado con la cedula de ciudadania numero " + this.documento + " \n de genero " + this.genero + " esta contratado ejerciendo el cargo de " + this.cargo + "\n Tiene una asignacion diaria de su salario " + this.valDia + " en el transcurso del mes laboró 25 días \n para un total devengado de $" + sueldo;

        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private double calcularSueldo()
        {

            return this.cantDias * this.valDia;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nomina formulario2 = new Nomina();
            this.Hide();
            formulario2.Show();
        }
    }
}
