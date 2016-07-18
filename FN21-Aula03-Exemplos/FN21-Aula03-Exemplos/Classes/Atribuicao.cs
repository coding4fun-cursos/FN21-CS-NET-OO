using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de operadores de atribuicao (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class Atribuicao
    {
        public void Executar()
        {
            int a = 20;
            int b = a;

            double doubleValue = 30.4;
            float floatValue1 = 20.5F;
            float floatValue2 = floatValue1;

            MessageBox.Show("Soma: " + (b += a));

            a = b = 20;
            MessageBox.Show("Subtração: " + (b -= a));

            a = b = 20;
            MessageBox.Show("Multiplicação: " + (b *= a));

            a = b = 20;
            MessageBox.Show("Divisão: " + (b /= a));

            int value1 = 20, value2 = 83, value3 = 34;
            value1 = value2 = value3;
            MessageBox.Show("value1: " + value1);
        }
    }
}
