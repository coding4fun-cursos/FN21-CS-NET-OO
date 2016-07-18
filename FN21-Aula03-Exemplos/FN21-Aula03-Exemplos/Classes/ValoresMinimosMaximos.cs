using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Classe com exemplo de valores minimos e maximos tipos primitivos (slide x)
/// Author: Ryan Padilha - ryan@coding4fun.com.br
/// </summary>
namespace FN21_Aula03_Exemplos.Classes
{
    class ValoresMinimosMaximos
    {
        public void ExibirMensagem()
        {
            MessageBox.Show("Tipos primitivos - valores minimos e máximos.");
            MessageBox.Show("Byte valor minimo: "+ System.Byte.MinValue); 
            MessageBox.Show("Byte valor maximo: "+ System.Byte.MaxValue);

            MessageBox.Show("Short valor minimo: "+ System.Int16.MinValue);
            MessageBox.Show("Short valor maximo: "+ System.Int16.MaxValue);

            MessageBox.Show("Integer valor minimo: "+ System.Int32.MinValue);
            MessageBox.Show("Integer valor maximo: "+ System.Int32.MaxValue);

            MessageBox.Show("Long valor minimo: "+ System.Int64.MinValue);
            MessageBox.Show("Long valor maximo: "+ System.Int64.MaxValue);

            MessageBox.Show("Char valor minimo: " + System.Char.MinValue);
            MessageBox.Show("Char valor maximo: " + System.Char.MaxValue);
            
            MessageBox.Show("Float valor minimo: "+ System.Single.MinValue);
            MessageBox.Show("Float valor maximo: "+ System.Single.MaxValue);

            MessageBox.Show("Double valor minimo: "+ System.Double.MinValue);
            MessageBox.Show("Double valor maximo: "+ System.Double.MaxValue);

            MessageBox.Show("Decimal valor minimo: "+ System.Decimal.MinValue);
            MessageBox.Show("Decimal valor maximo: " + System.Decimal.MaxValue);
        }
    }
}
