internal class Program
{
    private static void Main(string[] args)
    {
        //Exemplo Nullable
        //double x = null; Erro
        //Nullable<double> x = null; Modo pouco usado
        //double? x = null; // Modo mais usado

        double? x = null;
        double? y = 10.00;

        // Operador de Coalescência nula
        double? a = x ?? 5.00;
        double? b = y ?? 5.00;
        Console.WriteLine("-------------------Valor Nulo sera substituído-------------------");
        Console.WriteLine(a); // Substitui o valor, quando é nulo
        Console.WriteLine(b);

        /*
        //Pegar o valor se existir, ou exibe o valor 0 que é por Default
        Console.WriteLine("-------------------Tipo GetValueOrDefault-------------------");
        Console.WriteLine(x.GetValueOrDefault());
        Console.WriteLine(y.GetValueOrDefault());

        //E Exibe o valor boleano True ou False
        Console.WriteLine("-------------------Tipo HasValue----------------------------");
        Console.WriteLine(x.HasValue);
        Console.WriteLine(y.HasValue);

        //Exibe o valor armazenado na varável
        Console.WriteLine("-------------------Value------------------------------------");
        
        //Console.WriteLine(x.Value); // Se valor for nulo ocorrera erro, para evitar esse problema deve-0se seguir o exemplo abaixo:
        if (x.HasValue)
            Console.WriteLine(x.Value);
        else
            Console.WriteLine("X is null!");

        if (y.HasValue) Console.WriteLine(y.Value);
        else Console.WriteLine("Y is null!");
        */
    }
}