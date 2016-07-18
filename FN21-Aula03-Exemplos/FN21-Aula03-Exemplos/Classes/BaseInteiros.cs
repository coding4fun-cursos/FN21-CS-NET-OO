using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de manipulacao de bases inteiros (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class BaseInteiros
    {
        // representacao do numero 357 em bases diferentes
        int baseDecimal = 357;
        string baseOctal = "0545";
        int baseHexadecimal = 0x165;

        public void ExibirMensagem()
        {
            MessageBox.Show("Base decimal: "+ baseDecimal);
            MessageBox.Show("Base octal [0545]: " + Convert.ToInt32(baseOctal, 8));
            MessageBox.Show("Base hexadecimal [0x165]: " + baseHexadecimal);
        }
    }
}
