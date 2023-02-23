using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Matriz
            int[,] matriz1 = new int[2, 3] { 
                                             { 5, 6, 4 }, 
                                             { 9, 7, 3 } 
                                           };

            //Llenar la matriz
            Random aleatorio = new Random();
            int[,] matriz2 = new int[4, 6];
            //matriz2.getlength(0);
            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = aleatorio.Next(0,100);
                }
            }

            //mostrar la matriz en el listbox   

            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox1.Items.Add("La posición: [" + fila + "," + columna + "] = " + matriz2[fila,columna]);
                }
            }

            

        }
    }
}
