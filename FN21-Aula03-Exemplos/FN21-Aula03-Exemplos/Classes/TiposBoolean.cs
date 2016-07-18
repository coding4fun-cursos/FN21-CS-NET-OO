using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de manipulacao de tipos boolean (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class TiposBoolean
    {
        bool valueBoolean = true;
        //bool valueBooleanError = 0; // error

        public void ExpressaoBooleana()
        {
            MessageBox.Show("valueBoolean: " + valueBoolean);

            int quantidadeMinima = 60;
            bool freteGratuito = (quantidadeMinima > 50);
            MessageBox.Show("Frete é gratuito? " + freteGratuito);
        }

    }
}
