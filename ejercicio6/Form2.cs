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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string Vista;
        string Vista1;

        private void txtarreglo2_Click(object sender, EventArgs e)
        {

            int Tama = Convert.ToInt32(txttamaño.Text);
            int[] array2 = new int[Tama];
            int[] array1 = new int[Tama];
            int[] array3 = new int[Tama];
            for (int i = 0; i <= Tama - 1; i++)
            {
                Vista = Microsoft.VisualBasic.Interaction.InputBox("ingrese el Numero" + i, "Izquierda");
                Vista1 = Microsoft.VisualBasic.Interaction.InputBox("ingrese el Numero" + i, "Derecha ");
                array2[i] = Convert.ToInt32( Vista);
                array1[i] = Convert.ToInt32( Vista1);
                lblistar2.Items.Add(array2[i]);
                lblistar1.Items.Add(array1[i]);
             
                array3[i] = array1[i] + array2[i];
                lbResultado.Items.Add(array3[i]);
                
            }

        }
        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lblistar2.Items.Clear();
            lblistar1.Items.Clear();
            lbResultado.Items.Clear();
            txttamaño.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
        int Tama = 5;
        string[] array66 = new string[5];
        public void btnListar_Click(object sender, EventArgs e)
        {
            array66[0] = "Medellin";
            array66[1] = "Cali";
            array66[2] = "Bogota";
            array66[3] = "Pereira";
            array66[4] = "Cali";
            for (int i = 0; i <= Tama - 1; i++)
            {
                lbSelect.Items.Add(array66[i]);
            }
        }

        public void btnbusqueda_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= Tama - 1; i++) {     
             if (array66[i] == txtpala.Text) 
                    lbCon.Items.Add(array66[i]);
            }
            MessageBox.Show("No encontrado");
        }
    }
}
