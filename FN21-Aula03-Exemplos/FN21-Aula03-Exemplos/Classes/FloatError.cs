using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de manipulacao de tipos ponto flutuante (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class FloatError
    {
        float valueFloat1 = 24.2345565F; // correto
        // float valueFloat2 = 24.2345565; // error, falta sufixo

        double valueDouble1 = 24.2345565; // correto
        double valueDouble2 = 24.2345565D; // correto, nao necessario (default)

        public void ExibirMensagem()
        {
            MessageBox.Show("valueFloat1: "+ valueFloat1);
            MessageBox.Show("valueDouble1: "+ valueDouble1);
            MessageBox.Show("valueDouble2: "+ valueDouble2);
        }
    }
}
