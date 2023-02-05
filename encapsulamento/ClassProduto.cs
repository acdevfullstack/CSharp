using System;
using System.Globalization;

namespace encapsulamento
{
    class ClassProduto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public ClassProduto()
        { }

        public ClassProduto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // Construtor Get e Set
        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public void SetPreco(double preco)
        {
            _preco = preco;
        }

        public void SetQuantidade(int quantidade)
        {
            _quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()  // Método
        {
            return _preco * _quantidade;
        }

        //Funcao para Adiocionar Produtos
        public void AdiconarProdutos(int quantidade) // void significa vazio, ou seja, pode receber um valor
        {
            //Quantidade= Quantidade + quantidade;
            // Ou
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            //Quantidade= Quantidade - quantidade;
            // Ou
            _quantidade -= quantidade;
        }

        //Métado
        public override string ToString()
        {
            // Ponto
            return _nome + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantidade + " unidades, " + "Total: $ "
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
