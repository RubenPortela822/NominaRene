using Fase2ReneLozano;
using System;
using System.Windows.Forms;

namespace NominaRene
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1300, 500); // Ancho: 500, Alto: 300
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;

            if (password == "123")
            {
                Nomina formulario2 = new Nomina();
                this.Hide();                
                formulario2.Show();                
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Por favor, inténtelo de nuevo.");
            }
        }
    }
}
