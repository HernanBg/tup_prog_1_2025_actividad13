using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Actividad_13.Models;

namespace Actividad_13
{
    public partial class Form1 : Form
    {
        Lote lote=new Lote();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {

                double medida = Convert.ToDouble(form.tbValor.Text);
                lote.RegistrarMedida(medida);
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
           



        }
    }
}    

    