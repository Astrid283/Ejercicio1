using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Calcularbutton1_Click(object sender, EventArgs e)
        {
            //variables
            int numero;
            

            numero = int.Parse( IngreseelvalortextBox1.Text);

            if (numero % 2 == 0 )
            {
                ResultadotextBox2.Text = "El numero es par y positivo";
            }
            else
            {
                ResultadotextBox2.Text = "El numero es impar y positivo";
            }
            if (numero >= 0 )
            {
                //ResultadotextBox2.Text = "El numero es positivo";
            }
            else
            {
                ResultadotextBox2.Text = "El numero es negativo";
            }





        }
    }
}
