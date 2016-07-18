using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de operadores lógicos (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class OperadoresLogicos
    {
        int a = 30;
        int b = 20;

        public void Executar()
        {
            MessageBox.Show("Expressão 1: " + (a > 30 && b > 10));
            MessageBox.Show("Expressão 2: " + (a > 30 || b > 10));
            MessageBox.Show("Expressão 3: " + !(b > 10));
            MessageBox.Show("Expressão 4: " + !(a > 30));
        }
    }
}
