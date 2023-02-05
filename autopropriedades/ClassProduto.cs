using System;
using System.Collections.Generic;
using System.Globalization;

namespace autopropriedades
{
    class ClassProduto
    {
        //Auto Propriedades
        private string _nome; // Obs.: esse campo foi definido uma regra, por isso não pode ser utilizado
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public ClassProduto()
        { }

        public ClassProduto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length < 1)
                {
                    _nome = value;
                }
            }
        }
        public double ValorTotalEmEstoque()  // Método
        {
            return Preco * Quantidade;
        }

        //Funcao para Adiocionar Produtos
        public void AdiconarProdutos(int quantidade) // void significa vazio, ou seja, pode receber um valor
        {
            //Quantidade= Quantidade + quantidade;
            // Ou
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            //Quantidade= Quantidade - quantidade;
            // Ou
            Quantidade -= quantidade;
        }

        //Métado
        public override string ToString()
        {
            // Ponto
            return _nome + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, " + "Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

            // Ponto e virgula
            //return Nome + ", $ "
            //+ Preco.ToString("F2")
            //+ ", " + Quantidade + " unidades, "
            //+ "Total: $ "
            //+ ValorTotalEmEstoque().ToString("F2");
        }
    }
}
