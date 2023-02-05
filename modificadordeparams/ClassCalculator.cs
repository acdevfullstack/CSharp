
namespace modificadordeparams
{
    class ClassCalculator
    {
        //Solução perfeita
        //public static int Soma(int[] numeros) // Essa solução precisa instanciar os parâmetros
        public static int Soma(params int[] numeros) // Essa solução não precisa instanciar os parâmetros
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }

        /*
        // Solução ruin usando SobreCarga
        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int Soma(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public static int Soma(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }

        */

    }
}
