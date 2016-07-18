using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de entrada de dados com MessageBox (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class MessageBoxInput
    {
        public double nota1, nota2, trabalho, media;
       
        public string Executar()
        {
            media = (nota1 + nota2 + trabalho) / 3;
            return media.ToString();
        }
    }
}
