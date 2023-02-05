internal class Program
{
    private static void Main(string[] args)
    {
        //Obs.: A variável "var", não e uma boa pratica para armazenar valores em memória.
        var x = 10;
        var y = 20.00;
        var z = "Ana";

        //Dificulta a entrada de valores, aceita qualquer valor.
        //var y = z;  

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }
}