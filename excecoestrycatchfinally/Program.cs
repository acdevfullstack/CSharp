namespace excecoestrycatchfinally
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine($"Resultado da divisão de {n1} por {n2} = " + result);
            }
            //catch (Exception e) // Função mais genérica, entra na lista de erro, mas não especifica diretamente
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error! " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error! " + e.Message);
            }
            finally
            {
                Console.WriteLine("Processo finalizado com sucesso!");
            }
        }
    }
}