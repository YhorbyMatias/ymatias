using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // aqui llenamos las variables de la linea vertical
            int x1v = 250;
            int x2v = 250;
            int y1v = 0;
            int y2v = 500;
            //fin

            // aqui llenamos las variable de la linea horizontal
            int x1h = 0;
            int x2h = 500;
            int y1h = 250;
            int y2h = 250;
            // fin

            Graphics grafico; // llamamos a Graphics que es la que nos permitira dibujar
            grafico = this.CreateGraphics();
            Pen lapiz;       // llamamos a Pen que es un objeto que nos permite dibujar lineas y curvas
            lapiz = new Pen(Color.Chocolate, 5);
            grafico.DrawLine(lapiz, x1v, y1v, x2v, y2v); // Utilizamos el metodo DrawLine para dibujar las lineas verticales

            grafico.DrawLine(lapiz, x1h, y1h, x2h, y2h);  // Utilizamos el metodo DrawLine para dibujar las lineas horizontales
        }

        private void btn_vector_Click(object sender, EventArgs e)
        {
            // aqui llenamos las variable de la linea del vector
            int x1v = Width/ 2; // le decimos posicionate a la mitad de la anchura, para que quede dentro del plano
            int x2v = 0;
            int y1v = Height / 2; // le decimos posicionate a la mitad de la altura, para que quede dentro del plano
            int y2v = 0;
            Graphics grafico;
            grafico = this.CreateGraphics();
            Pen lapiz;
            lapiz = new Pen(Color.Black, 5); // aqui definimos de que color queremos la linea y el grosor de la misma
            grafico.DrawLine(lapiz, x1v, y1v, x2v, y2v);
        }

        // se repite igual a partir de aqui ---->
        private void btn_vectorabjo_Click(object sender, EventArgs e)
        {
            int x1v = Width / 2;
            int x2v = 20;
            int y1v = Height / 2;
            int y2v = 10;
            Graphics grafico;
            grafico = this.CreateGraphics();
            Pen lapiz;
            lapiz = new Pen(Color.BlueViolet, 5);
            grafico.DrawLine(lapiz, x1v, y1v, x2v, y2v);


        }
    }
}
