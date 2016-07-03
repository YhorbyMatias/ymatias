using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntNormal_Click(object sender, EventArgs e)
        {
            //muestra un mensaje normal
            MessageBox.Show("Hola Programador");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Muestra un mensaje con título
            MessageBox.Show("Hola Programador", "Aqui titulo del mensaje");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Muestra un mensaje con mas botones ademas que el OK (aceptar)
            MessageBox.Show("Hola Programador", "Aqui titulo del mensaje",MessageBoxButtons.YesNoCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Mostrar un mensaje con ícono
            MessageBox.Show("Hola Programador", "Aqui titulo del mensaje", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //aqui mostramos variables en el MessageBox
            //declaramos una variable entera para el valor 2
            //y asignamos su valor convirtiendo a entero
           
            int numero2 = Convert.ToInt32(txt_num2.Text);
            //se declara una variable entera para la suma y se realiza la misma
            int suma = Convert.ToInt32(txt_num1.Text) + numero2;
            //Mostrar el resultado de la suma
            MessageBox.Show("La suma de "+ Convert.ToInt32(txt_num1.Text) + " + " + numero2 + " es: " + suma + "", "Resultado de la suma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
