using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace ejercicio6.Trabajos
{
    class BuscarValores
    {
        public void IngresarInfoArray(string[] Lista)
        {
            for (int i = 0; i <= Lista.Length - 1; i++)
            {
                Lista[i] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre para la posición número " + (i + 1).ToString());
            }
        }
        public void BuscarValoresArray(string[] Lista,string Palabra)
        {
            string Pos = string.Empty;
            for (int i = 0; i <= Lista.Length - 1; i++)
            {
                if (Lista[i] == Palabra)
                {
                    Pos += "Esta en la posición: " + (i+1).ToString() + "\n";
                }
            }
            if (!string.IsNullOrEmpty(Pos))
                MessageBox.Show(Pos);
        }
    }
}
