using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace ParalelogromaOOP.Classe.Dados
{
    class Dados
    {
        //Treinamento, Programação Orientação ao Objeto
        //Inserindo dados, double
        //Programa paralelogramo
        //Jonas Valereo - Técnico em Informática 


        //declarando os attributos , campos e variaveis da classe dados
        //declarando tipo private, tipo double

        private double _baser;
        private double _altura;

        //declarando o construtor da classe dados
        public Dados(double baser, double altura)
        {
            _baser = baser;
            _altura = altura;
        }

        //declarando o metodo media, da classe dados

        public double Area()
        {
            return _baser * _altura;
            
        }

        //declarando o modificador toString da classe dados
        public override string ToString()
        {
            return Area().ToString("F2", CultureInfo.InvariantCulture);
        }

        //fim da classe dados
    }
}
