namespace modificadorrefout
{
    class Program
    {
        private static void Main(string[] args)
        {
            /*
             //Aviso o ref e out são considerados designer ruins, mas podem ser utilizados
            int a = 10; // Obs.: A funcao ref exige que a variável seja inicializada
            ClassCalculator.Triple(ref a);
            Console.WriteLine("Resultado: " + a);
            */

            int a = 10; // Obs.: A funcao out não exige que a variável seja inicializada.
            int triple;
            ClassCalculator.Triple(a, out triple);
            Console.WriteLine("Resultado: " + triple);

        }
    }
}