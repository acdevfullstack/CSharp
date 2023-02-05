using System;
using System.Globalization;

namespace construtores
{
    internal class ClassProduto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        //Construtor
        public ClassProduto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
            return Nome + ", $ "
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
