using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FN21_Aula03_Exemplos.Classes;

namespace FN21_Aula03_Exemplos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiposInteiros tiposInteiros = new TiposInteiros();
            tiposInteiros.ExibirMensagem();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            BaseInteiros baseInteiros = new BaseInteiros();
            baseInteiros.ExibirMensagem();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FloatError floatError = new FloatError();
            floatError.ExibirMensagem();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TiposCharacter tipoCharacter = new TiposCharacter();
            tipoCharacter.ExibirMensagem();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TiposBoolean tiposBoolean = new TiposBoolean();
            tiposBoolean.ExpressaoBooleana();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            ValoresMinimosMaximos valoresMinimosMaximos = new ValoresMinimosMaximos();
            valoresMinimosMaximos.ExibirMensagem();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Identificadores identificadores = new Identificadores();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Variaveis variaveis = new Variaveis();
            variaveis.ExibirMensagem();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Constantes constantes = new Constantes();
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Atribuicao atribuicao = new Atribuicao();
            atribuicao.Executar();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OperadorUnario operadorUnario = new OperadorUnario();
            operadorUnario.Executar();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OperadoresLogicos operadoresLogicos = new OperadoresLogicos();
            operadoresLogicos.Executar();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Casting casting = new Casting();
            casting.Executar();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FormInput messageBox = new FormInput();
            messageBox.ShowDialog();
        }
    }
}
