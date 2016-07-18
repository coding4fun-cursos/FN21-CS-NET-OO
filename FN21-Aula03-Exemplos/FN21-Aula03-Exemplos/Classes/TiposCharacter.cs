using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de manipulacao de tipo char (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class TiposCharacter
    {
        char c1 = 'X';
        char c2 = '\x0058'; // hexadecimal
        char c3 = '\u0058'; // unicode

        // valores nao equivalentes
        char c4 = '9';
        char c5 = '\u0099';

        // erro, compilacao em numero negativo
        //char c6 = -88; // cannot implicitly convert type 'int' to 'char' 
        char c7 = (char)88;

        public void ExibirMensagem()
        {
            MessageBox.Show("c1: " + c1);
            MessageBox.Show("c2: " + c2);
            MessageBox.Show("c3: " + c3);

            MessageBox.Show("c4: " + c4);
            MessageBox.Show("c5: " + c5);
            MessageBox.Show("c7: " + c7);
        }
    }
}
