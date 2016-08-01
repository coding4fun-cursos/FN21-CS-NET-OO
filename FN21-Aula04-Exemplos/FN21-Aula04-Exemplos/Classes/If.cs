using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de estrutura if-else - if sem else (slide x).
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula04_Exemplos.Classes
{
    class If
    {
        String input = "S"; 
        
        public void Executar()
        {
            String mensagem = "Caracter informado "+ input;

            if (!input.Equals("S") && !input.Equals("N")){
                mensagem += " é inválido.";
            }

            MessageBox.Show(mensagem);
        }
    }
}
