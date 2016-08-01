using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de estrutura repeticao - foreach (slide x).
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula04_Exemplos.Classes
{
    class RepeticaoForeach
    {
        List<String> frutas = new List<String> { "Banana", "Melancia", "Laranja", "Kiwi", "Amora" };
        public void Executar()
        {
            foreach (String fruta in frutas)
            {
                System.Console.WriteLine(fruta);
            }
        }
    }
}
