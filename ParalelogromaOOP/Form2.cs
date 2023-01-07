using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using ParalelogromaOOP.Classe.Dados;

namespace ParalelogromaOOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void butnClique_Click(object sender, EventArgs e)
        {
            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, double
            //Programa paralelogramo
            //Jonas Valereo - Técnico em Informática 

            //declarando, validação das textbox, usando comando if

            //declarando, validação textboxBase
            if(textBoxBase.Text == "")
            {
                MessageBox.Show("Digite, base do paralelogramo.", "Preenche!",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);

                textBoxBase.BackColor = Color.Aqua;
                textBoxBase.Focus();

                return;
            }

            //declarando, validação textboxAltura
            if(textBoxAltura.Text == "")
            {
                MessageBox.Show("Digite, altura do paralelogramo.", "Preenche",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                textBoxAltura.BackColor = Color.Aqua;
                textBoxAltura.Focus();

                return;
            }

            /*declarando o codigo entrada de dado na textBox,
           declarando variaveis auxiliares*/
            double baser = double.Parse(textBoxBase.Text, 
                CultureInfo.InvariantCulture);
            double altura = double.Parse(textBoxAltura.Text,
                CultureInfo.InvariantCulture);

            //declarando objeto d, da classe dados
            Dados a = new Dados(baser, altura);

            /*declarando, imprimir saida de dados messageBox, chamando o objeto d,
           chamando o método toString da classe dados*/
            MessageBox.Show(" A area do paralelogramo: " + a.ToString()," Messagem ",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //declarando, codigo limpar textbox, simulação de enviou de dados
            textBoxBase.Clear();
            textBoxAltura.Clear();
            textBoxBase.Focus();
            textBoxBase.BackColor = Color.White;
            textBoxAltura.BackColor = Color.White;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //declarando, codigo limpar textbox, buttom cancelar
            textBoxBase.Clear();
            textBoxAltura.Clear();
            textBoxBase.Focus();
            textBoxBase.BackColor = Color.White;
            textBoxAltura.BackColor = Color.White;
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //declarando, codigo fechar programa, button fechar
            Close();

        }

        //fim do programa
    }
}
