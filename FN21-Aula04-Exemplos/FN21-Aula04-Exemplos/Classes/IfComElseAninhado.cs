using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de estrutura if-else - if com else aninhado (slide x).
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula04_Exemplos.Classes
{
    class IfComElseAninhado
    {
        // informar um valor entre 1 a 7
        String input = "7"; 

        public void Executar()
        {
            String diaSemana;
            int dia = Int32.Parse(input);

            if (dia == 1)
                diaSemana = "Domingo";
            else if (dia == 2)
                diaSemana = "Segunda";
            else if (dia == 3)
                diaSemana = "Terça";
            else if (dia == 4)
                diaSemana = "Quarta";
            else if (dia == 5)
                diaSemana = "Quinta";
            else if (dia == 6)
                diaSemana = "Sexta";
            else if (dia == 7)
                diaSemana = "Sábado";
            else
                diaSemana = "Dia da semana informado desconhecido.";

            MessageBox.Show("Dia da semana: " + diaSemana);      
        }
    }
}
