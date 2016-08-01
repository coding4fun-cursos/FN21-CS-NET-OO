using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FN21_Aula04_Exemplos.Classes;

namespace FN21_Aula04_Exemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            If condicaoIf = new If();
            condicaoIf.Executar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IfComElse condicaoIfElse = new IfComElse();
            condicaoIfElse.Executar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IfComElseAninhado condicaoIfElseAninhado = new IfComElseAninhado();
            condicaoIfElseAninhado.Executar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SwitchCase switchCase = new SwitchCase();
            switchCase.Executar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RepeticaoFor repeticaoFor = new RepeticaoFor();
            repeticaoFor.Executar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RepeticaoForeach repeticaoForeach = new RepeticaoForeach();
            repeticaoForeach.Executar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RepeticaoWhile repeticaoWhile = new RepeticaoWhile();
            repeticaoWhile.Executar();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RepeticaoDoWhile repeticaoDoWhile = new RepeticaoDoWhile();
            repeticaoDoWhile.Executar();
        }
    }
}
