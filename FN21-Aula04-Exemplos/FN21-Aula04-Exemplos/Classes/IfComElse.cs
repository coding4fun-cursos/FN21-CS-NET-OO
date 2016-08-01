using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de estrutura if-else - if com else (slide x).
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula04_Exemplos.Classes
{
    class IfComElse
    {
        Double value = 7;
        
        public void Executar()
        {
            if (value >= 0 && value <= 10)
            {
                MessageBox.Show(String.Format("Valor {0} válido.", value.ToString()));
            } else
            {
                MessageBox.Show(String.Format("Valor {0} inválido.", value.ToString()));
            }
        } 
    }
}
