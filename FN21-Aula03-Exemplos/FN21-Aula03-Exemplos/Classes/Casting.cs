using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de conversao de tipos - casting (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class Casting
    {
        double booking1, booking2, worklog, avg;

        public void Executar()
        {
            booking1 = Double.Parse("10");
            booking2 = Double.Parse("20");
            worklog = Double.Parse("80");
            avg = (booking1 + booking2 + worklog) / 3;
            MessageBox.Show("AVG value: " + avg);
        }
    }
}
