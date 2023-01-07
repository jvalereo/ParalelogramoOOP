using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParalelogromaOOP.Classe.Dados;

namespace ParalelogromaOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Treinamento, Programação Orientação ao Objeto
            //Inserindo dados, double
            //programa paralelogroma
            //Jonas Valereo - Técnico em Informática 

            //declarando chamando o form2, fechando o form1 

            this.Visible = false;
            Form2 a = new Form2();
            a.ShowDialog();
            this.Visible = false;
        }

        //fim do programas
    }
}
