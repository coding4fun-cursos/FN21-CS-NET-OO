using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de estrutura repeticao - for (slide x).
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula04_Exemplos.Classes
{
    class RepeticaoFor
    {
        public void Executar()
        {
            for (int horas = 0; horas < 24; horas++)
            {
                for (int minutos = 0; minutos < 60; minutos++)
                {
                    for (int segundos = 0; segundos < 60; segundos++)
                    {
                        System.Console.WriteLine(horas + " horas, " + minutos + " minutos, " + segundos + " segundos");
                        
                        System.Threading.Thread.Sleep(1000);
                        Application.DoEvents();

                        if (segundos == 10)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
