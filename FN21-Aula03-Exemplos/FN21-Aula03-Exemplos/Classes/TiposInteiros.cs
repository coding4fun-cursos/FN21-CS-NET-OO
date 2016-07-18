using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de manipulacao de tipos inteiros (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class TiposInteiros
    {
        byte valueByte = 125;
        short valueShort = 32765;
        int valueInt = 2147483645;
        long valueLong = 9223372036854775805L;
        int valueIntError = 0;

        private void IncrementarValores()
        {
            valueByte += 1;
            valueShort += 1;
            valueInt += 1;
            valueLong += 1;
        }

        public void ExibirMensagem()
        {
            this.IncrementarValores();

            MessageBox.Show("Valor de valueByte = " + valueByte);
            MessageBox.Show("Valor de valueShort = " + valueShort);
            MessageBox.Show("valor de valueInt = " + valueInt);
            MessageBox.Show("Valor de valueLong = " + valueLong);

            // error - An unhandled exception of type 'System.DivideByZeroException'
            valueLong /= valueIntError;
        }
    }
}
