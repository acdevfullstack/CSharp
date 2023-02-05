
namespace modificadorrefout
{
    internal class ClassCalculator
    {
        // Solução que não funciona
        /*
           public static void Triple(int x) {
               x = x * 3;
           }

        // Solução funciona, mas exige que a variavél seja inicalizada
           public static void Triple(ref int x)
           {
               x = x * 3;
           }
                */

        // Solução funciona, não exige que a variavél seja inicalizada
        public static void Triple(int origem, out int resultado)
        {
            resultado = origem * 3;
        }
    }
}
