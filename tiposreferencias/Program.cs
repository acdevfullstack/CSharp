using tiposreferencias;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassTiposReferencias p;

        //Variável foi reinicializada
        p.x = 10; 
        p.y = 20;
        Console.WriteLine(p);

        p = new ClassTiposReferencias();
        Console.WriteLine("----------------------------------------");
        Console.WriteLine(p);
    }
}