using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de estrutura switch-case (slide x).
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula04_Exemplos.Classes
{
    class SwitchCase
    {
        // informar um valor entre 1 a 7
        String input = "7";

        public void Executar()
        {
            String diaSemana;
            int dia = Int32.Parse(input);

            switch (dia)
            {
                case 1: diaSemana = "Domingo"; break;
                case 2: diaSemana = "Segunda"; break;
                case 3: diaSemana = "Terça"; break;
                case 4: diaSemana = "Quarta"; break;
                case 5: diaSemana = "Quinta"; break;
                case 6: diaSemana = "Sexta"; break;
                case 7: diaSemana = "Sábado"; break;
                default: diaSemana = "Dia da semana informado desconhecido."; break;
            }

            MessageBox.Show("Dia da semana: " + diaSemana);
        }
    }
}
