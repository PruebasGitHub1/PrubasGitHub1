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
    public partial class vectoresTaller : Form
    {
        public vectoresTaller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Lista;
                int Tam = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tamaño de la lista"));
                Lista = new string[Tam];
                Trabajos.BuscarValores bl = new Trabajos.BuscarValores();
                bl.IngresarInfoArray(Lista);
                //string MostarInfo = string.Empty;
                //for (int i = 0; i <= Lista.Length - 1; i++)
                //{
                //    MostarInfo += (i + 1).ToString() + ". " + Lista[i] + "\n";    
                //}
                //if (!String.IsNullOrEmpty(MostarInfo))
                //{
                //    MessageBox.Show(MostarInfo);
                //}
                bl.BuscarValoresArray(Lista, Microsoft.VisualBasic.Interaction.InputBox("Ingrese el dato a buscar"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int[] NumerosLista = new int[Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tañano de la lista"))];
            for (int i = 0; i <= NumerosLista.Length - 1; i++)
            {
                int NumRep = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un número")); bool rep=false;
                for (int j = 0; j <= NumerosLista.Length - 1; j++)
                {
                    if (Convert.ToInt32(NumerosLista[j]) == NumRep) rep = true;
                    break;
                }
                if (!rep)
                    NumerosLista[i] = NumRep;
                else
                {
                    MessageBox.Show("El numero ya existe");i--;
                }
            }
            MostarInformacion(NumerosLista);
        }
        internal void MostarInformacion(int [] Lista)
        {
            string MostarInfo = string.Empty;
            for (int i = 0; i <= Lista.Length - 1; i++)
            {
                MostarInfo += (i + 1).ToString() + ". " + Lista[i] + "\n";
            }
            if (!String.IsNullOrEmpty(MostarInfo))
            {
                MessageBox.Show(MostarInfo);
            }
        }
        internal void MostarInformacionstring(string[] Lista)
        {
            string MostarInfo = string.Empty;
            for (int i = 0; i <= Lista.Length - 1; i++)
            {
                MostarInfo += (i + 1).ToString() + ". " + Lista[i] + "\n";
            }
            if (!String.IsNullOrEmpty(MostarInfo))
            {
                MessageBox.Show(MostarInfo);
            }
        }
        internal void MostarInformacionstringMul(string[,] Lista)
        {
            string MostarInfo = string.Empty;
            for (int i = 0; i <= (Lista.Length/2) - 1; i++)
            {
                if (string.IsNullOrEmpty(Lista[i, 0]))
                {
                    Lista[i, 0] = string.Empty;
                }
                else
                {
                    MostarInfo += (i + 1).ToString() + ". " + Lista[i, 0] + " Esta: " + Lista[i, 1] + "\n";
                }
            }
            if (!String.IsNullOrEmpty(MostarInfo))
            {
                MessageBox.Show(MostarInfo);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ///Pediremos los IDs (números) de alumnos de dos clases, álgebra y análisis. Queremos mostrar todos los alumnos comunes en las dos asignaturas.
            ///Estos alumnos se guarden en un tercer arreglo y que sea el que se muestre.También indica el numero de alumnos que se repiten.
            string[] Algebra, Analisis;
            string [,]Resultado;
            int CantidadAlumnos = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tañano de la lista"));
            Algebra = new string[CantidadAlumnos];Analisis = new string[CantidadAlumnos];Resultado = new string[CantidadAlumnos,2];
            Trabajos.BuscarValores bl = new Trabajos.BuscarValores();
            bl.IngresarInfoArray(Algebra);
            bl.IngresarInfoArray(Analisis);
            // ARREGLOS DE ALGEBRA Y ANALISIS LLENOS.
            int Cont1=0,Conta2=0,k=-1;bool ext=false;
            for (int i = 0; i <= Algebra.Length - 1; i++)
            {
                ext = false;
                string Nombre = Algebra[i];
                Cont1 = 0;
                for (int h = 0; h <= (Resultado.Length)/2 - 1; h++)
                {
                    if (Nombre == Resultado[h, 0])
                    {
                        ext = true;
                        break;
                    }
                }
                if (!ext)
                {
                    for (int j = 0; j <= Algebra.Length - 1; j++)
                    {
                        if (Algebra[j] == Nombre)
                        {
                            Cont1++;
                        }
                    }
                    k++;
                    Resultado[k, 0] = Nombre;
                    Resultado[k, 1] = Cont1.ToString();
                    
                }
            }
            string NombreAc=string.Empty;
            for (int i = 0; i <= Analisis.Length - 1; i++)
            {
                ext = false;
                string Nombre = Analisis[i];
                Cont1 = 0;
                for (int h = 0; h <= (Resultado.Length) / 2 - 1; h++)
                {
                    if (Nombre == Resultado[h, 0])
                    {
                        ext = true;
                        break;
                    }
                }
                if (!ext)
                {
                    for (int j = 0; j <= Analisis.Length - 1; j++)
                    {
                        if (Analisis[j] == Nombre)
                        {
                            Cont1++;
                        }
                    }
                    k++;
                    Resultado[k, 0] = Nombre;
                    Resultado[k, 1] = Cont1.ToString();

                }
                else
                {
                    if (Nombre != NombreAc)
                    {
                        for (int j = 0; j <= Analisis.Length - 1; j++)
                        {
                            if (Analisis[j] == Nombre)
                            {
                                Cont1++;
                            }
                        }
                        for (int h = 0; h <= (Resultado.Length) / 2 - 1; h++)
                        {
                            if (Nombre == Resultado[h, 0])
                            {
                                NombreAc = Resultado[h, 0];
                                int dRes = Convert.ToInt32(Resultado[h, 1]);
                                Resultado[h, 1] = (Cont1 + dRes).ToString();
                                break;
                            }
                        }
                    }
                }
            }
            MostarInformacionstring(Algebra);
            MostarInformacionstring(Analisis);
            MostarInformacionstringMul(Resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cano = 0;

            int[] nota = new int[Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tañano de la lista"))];

            int acumulador = 0;
            int promedio = 0;
            for (int i = 0; i < nota.Length ; i++)
            {
                cano = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nota"));
                listBox1.Items.Add(cano);
                acumulador = acumulador + cano;
                promedio = acumulador / (nota.Length); 
            }
            listBox1.Items.Add(acumulador);
            listBox1.Items.Add(promedio);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cano = 0;

            int[] nota = new int[Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el tañano de la lista"))];

            int acumulador = 0;
            double promedio = 0;

            int acumulador1 = 0;
            decimal promedio1 = 0;


            for (int i = 0; i < nota.Length; i++)
            {
                cano = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nota"));
                listBox2.Items.Add(cano);
            
                if (cano >= 6)
                {  
                   acumulador = acumulador + cano;
                   promedio = acumulador / (nota.Length);
                }
                else if (cano <=5) {
                    acumulador1 = acumulador1 + cano;
                    promedio1 = acumulador1 / (nota.Length);
                }   
            }
            // listBox2.Items.Add(acumulador);
            listBox2.Items.Add("[]");
            listBox2.Items.Add(promedio);
            listBox2.Items.Add("[]");
            listBox2.Items.Add(promedio1);
         
        }
    }
}
