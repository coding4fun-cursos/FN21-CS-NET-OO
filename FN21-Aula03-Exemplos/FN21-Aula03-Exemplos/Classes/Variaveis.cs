using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de declaracao de variaveis (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class Variaveis
    {
        char sexo = 'F';
        byte idade = 32;
        short codigoAluno = 256;
        float nota = 9.9f;
        int alunosGraduacao = 1000, classes = 200;
        long habitantes = 90319000;
        double valorEuro = 4.5;
        bool isActive = false;

        public void ExibirMensagem()
        {
            MessageBox.Show("sexo: " + sexo + ", idade: " + idade);
            MessageBox.Show("nota: " + nota + ", codigo: " + codigoAluno);
            MessageBox.Show("alunos graduacao: " + alunosGraduacao + ", quantidade classes: " + classes);
            MessageBox.Show("habitantes: " + habitantes + ", valor Euro: " + valorEuro);
            MessageBox.Show("aluno ativo: " + isActive);
        }
    }
}
