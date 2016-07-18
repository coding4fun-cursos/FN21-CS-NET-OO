using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de operadores aritméticos unários (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class OperadorUnario
    {
        public void Executar()
        {
            int a = 30;
            int b = 10;
            a++;
            ++b;
            MessageBox.Show("Sem expressão. a: " + a + ", b: " + b);

            a = 30;
            b = 10;
            int c = a - ++b;
            MessageBox.Show("Expressão pré-incremento. c: " + c + ", b: " + b);

            a = 30;
            b = 10;
            int d = a - b++;
            MessageBox.Show("Expressão pós-incremento. d: " + d + ", b: " + b);

            a = 10;
            a = a++ + a + a-- - a-- + ++a;
            // a = 10 + 11 + 11 - 10 + 10
            MessageBox.Show("a: " + a);
        }
    }
}
