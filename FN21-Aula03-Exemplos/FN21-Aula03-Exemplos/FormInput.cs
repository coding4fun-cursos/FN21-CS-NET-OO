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
    public partial class FormInput : Form
    {
        public FormInput()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBoxInput messageBox = new MessageBoxInput();
            messageBox.nota1 = Convert.ToDouble(txtNota1.Text);
            messageBox.nota2 = Convert.ToDouble(txtNota2.Text);
            messageBox.trabalho = Convert.ToDouble(txtTrabalho.Text);
            txtMedia.Text = messageBox.Executar();
        }
    }
}
