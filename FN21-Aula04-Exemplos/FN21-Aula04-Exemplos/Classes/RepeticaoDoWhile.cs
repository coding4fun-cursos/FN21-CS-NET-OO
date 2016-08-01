using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Classe com exemplo de estrutura repeticao - do..while (slide x). 
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula04_Exemplos.Classes
{
    class RepeticaoDoWhile
    {
        String input = "17"; 

        public void Executar()
        {
            int contador = Int32.Parse(input);
            do
            {
                System.Console.WriteLine("Número: " + contador);
                contador--;
            } while (contador >= 0);
        }
    }
}
