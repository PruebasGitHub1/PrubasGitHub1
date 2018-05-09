using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio6
{
    public partial class Matriz : Form
    {
        public Matriz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] numero;
            int cano = 0;
            int filas = 0;
            int columnas = 0;
            filas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cuantas Filas Necesita"));
            columnas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cuantas Columnas Necesita"));
            numero = new int[filas, columnas];
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1); j++)
                {
                    cano = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nota"));
                    numero[i,j] = cano;
                }
            }
            string resultado=string.Empty;
            for (int i = 0; i <= numero.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= numero.GetLength(1) - 1; j++)
                {
                    resultado += (numero[i, j] + " ").ToString();  
                }
                resultado += System.Environment.NewLine;    
            }
            MessageBox.Show(resultado);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int[,] mat1;
            int[,] mat2;
            int[,] resultado;
            int filas = 0;
            int columnas = 0;
            filas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cuantas Filas desea que tenga la Matriz"));
            columnas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cuantas Columnas desea que tenga la Matriz"));
            mat1 = new int[filas, columnas];
            mat2 = new int[filas, columnas];
           
            Random ram = new Random();

           
            for (int i = 0; i <= mat1.GetLength(0)-1; i++)
            {
                for (int j = 0; j<= mat1.GetLength(1)-1;j++)
                {
                    mat1[i, j] = ram.Next(1, 100);
                    mat2[i, j] = ram.Next(1,100);
                    
                }
           
            }
            string res = string.Empty;
            string res1 = string.Empty;
            for (int i = 0; i <= mat1.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= mat1.GetLength(1) - 1; j++)
                {
                    res += (mat1[i, j] + " ").ToString();
                    res1 += (mat2[i, j] + " ").ToString();
                }
                res += System.Environment.NewLine;
                res1 += System.Environment.NewLine;
                
            }
            MessageBox.Show(res);
            MessageBox.Show(res1);
            resultado = new int[filas, columnas];
            for (int i = 0; i <= resultado.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= resultado.GetLength(1) - 1; j++)
                {
                    resultado[i, j] = mat1[i, j] + mat2[i, j];
                
                }
                res += System.Environment.NewLine;
                res1 += System.Environment.NewLine;
            }
            string resultado1 = string.Empty;
            for (int i = 0; i <= resultado.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= resultado.GetLength(1) - 1; j++)
                {
                    resultado1 += (resultado[i, j] + " ").ToString();
                }
                resultado1 += System.Environment.NewLine;
            }
            MessageBox.Show(resultado1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] mat1;
            int[,] mat2;
            int[,] resultado;
            int filas = 0;
            int columnas = 0;
            filas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cuantas Filas desea que tenga la Matriz"));
            columnas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cuantas Columnas desea que tenga la Matriz"));
            mat1 = new int[filas, columnas];
            mat2 = new int[filas, columnas];

            Random ram = new Random();


            for (int i = 0; i <= mat1.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= mat1.GetLength(1) - 1; j++)
                {
                    mat1[i, j] = ram.Next(1, 10);
                    mat2[i, j] = ram.Next(1, 10);

                }

            }
            string res = string.Empty;
            string res1 = string.Empty;
            for (int i = 0; i <= mat1.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= mat1.GetLength(1) - 1; j++)
                {
                    res += (mat1[i, j] + " ").ToString();
                    res1 += (mat2[i, j] + " ").ToString();
                }
                res += System.Environment.NewLine;
                res1 += System.Environment.NewLine;

            }
            MessageBox.Show(res);
            MessageBox.Show(res1);
            resultado = new int[filas, columnas];
            for (int i = 0; i <= resultado.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= resultado.GetLength(1) - 1; j++)
                {
                    resultado[i, j] = mat1[i, j] * mat2[j,i];

                }
                res += System.Environment.NewLine;
                res1 += System.Environment.NewLine;
            }
            string resultado1 = string.Empty;
            for (int i = 0; i <= resultado.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= resultado.GetLength(1) - 1; j++)
                {
                    resultado1 += (resultado[i, j] + " ").ToString();
                }
                resultado1 += System.Environment.NewLine;
            }
            MessageBox.Show(resultado1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[,] numero;
            int cano = 0;
            int filas = 0;
            int columnas = 0;
            filas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cuantas Filas Necesita"));
            columnas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Cuantas Columnas Necesita"));
            numero = new int[filas, columnas+1];
            Random ram = new Random();
            for (int i = 0; i < numero.GetLength(0); i++)
            {
                for (int j = 0; j < numero.GetLength(1)-1; j++)
                {
                    numero[i, j] = ram.Next(1, 10);
                }
            }    
            
            string resultado1 = string.Empty;
            for (int i = 0; i <= numero.GetLength(0)-1; i++)
            {
                int acumuladorf = 0;
                for (int j = 0; j <= numero.GetLength(1) - 1; j++)
                {
                    acumuladorf = acumuladorf + numero[i, j] ;
                    if (j == numero.GetLength(1)-1)
                        numero[i, j] = acumuladorf/j;
                }
                        resultado1 += System.Environment.NewLine;
            }
            for (int i = 0; i <= numero.GetLength(0)-1; i++)
            {
                for (int j = 0; j <= numero.GetLength(1) - 1; j++)
                {
                    if (j == numero.GetLength(1) - 2)
                        resultado1 += (numero[i, j] + ": ").ToString();
                    else
                        resultado1 += (numero[i, j]+ " ").ToString();
                }
                resultado1 += System.Environment.NewLine;
            }
            MessageBox.Show(resultado1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[,] array4 = { { 1, 2,3,6 }, { 3, 4,4,5 }, { 5, 6,4,7 }, { 7, 8,5,7 } };

            int mayor = 0;
            for (int i = 0; i <= array4.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= array4.GetLength(1) - 1; j++)
                {
                    if (array4[i, j] > mayor)
                     mayor =+ array4[i, j];
                }
         
            }
            string resultado = string.Empty;
            for (int i = 0; i <= array4.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= array4.GetLength(1) - 1; j++)
                {
                    resultado += (array4[i, j] + " ").ToString();
                }
                resultado += System.Environment.NewLine;
            }
            MessageBox.Show(resultado);
            MessageBox.Show(Convert.ToString( mayor));

        }
    }
}
