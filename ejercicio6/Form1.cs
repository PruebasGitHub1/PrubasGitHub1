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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {






        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] notas = new int[5];

            notas[0] = 15;
            notas[1] = 10;
            notas[2] = 20;
            notas[3] = 05;
            notas[4] = 55;
            for (int i = 0; i <= 4; i++)
            {
                lsbver.Items.Add(notas[i]);

            }
            //BUENO

        }
        int[] Vector = new int[10];
        int Ver;

        private void btnagregar_Click(object sender, EventArgs e)
        {
            var promedio = 0;

            for (int i = 1; i <= 9; i++)
            {
                Ver = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("ingrese el numero" + i, "del vector"));
                Vector[i - 1] = Ver;
                lbver2.Items.Add(Vector[i - 1]);
               
                promedio = promedio+ Vector[i];
               
            }
           txtVer9.Text = Convert.ToString(promedio/9);
            //BUENO

        }

        private void btnAgregarlist_Click(object sender, EventArgs e)
        {
            int desde = Convert.ToInt32(txtdesde.Text);
            int hasta = Convert.ToInt32(txthasta.Text);
            int multiplo = Convert.ToInt32(txtmultiplo.Text);
            lista.Items.Clear();
            for (int i = desde; i <= hasta; i++)
            {
                if(i % multiplo ==0 )
                {
                    lista.Items.Add(i);
                }

            }
        }
        string Vista;
        string[] array2;
       
        private void btnEnviar_Click(object sender, EventArgs e)

        {
            
            int Tama = Convert.ToInt32(txtTamano.Text);
            string[] array1 = new string[Tama];
         
            for (int i = 0; i <= Tama - 1; i++)
            {
                Vista = Microsoft.VisualBasic.Interaction.InputBox("ingrese el Nombre" + i, "A ingresar");
                array1[i] =  Vista;
                lblista.Items.Add(array1[i]);
                int tamcadena = Vista.Length;

                lblista.Items.Add(tamcadena);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            lblista.Items.Clear();
            txtTamano.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            txtmultiplo.Clear();
            txtdesde.Clear();
            txthasta.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbver2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lsbver.Items.Clear();
        }
    }
}
