internal class Program
{
    private static void Main(string[] args)
    {
        string original = "abcde ABCDE fghi abc JO MN   ";

        string s1 = original.ToLower();
        string s2 = original.ToUpper();
        string s3 = original.Trim();
        int s4 = original.IndexOf("bc");
        int s5 = original.LastIndexOf("bc");
        string s6 = original.Substring(3);
        string s7 = original.Substring(3,5);
        string s8 = original.Replace('a','x');
        string s9 = original.Replace("abc", "xy");

        bool b1 = string.IsNullOrEmpty(original); // Testar se a varivel esta vazia
        bool b2 = string.IsNullOrWhiteSpace(original); // Testar se a varivel esta vazia ou com espaços em branco

        Console.WriteLine("Letras minusculas: -" + s1 + "-");
        Console.WriteLine("Letras mainsculas: -"+ s2 + "-");
        Console.WriteLine("Letras sem espaços em branco: -" + s3 + "-");
        Console.WriteLine("IndexOF('bc'): " + s4);
        Console.WriteLine("LastIndexOf('bc'): " + s5);

        Console.WriteLine("Substring: " + s6);
        Console.WriteLine("Substring: " + s7);

        Console.WriteLine("Replace: " + s8);
        Console.WriteLine("Replace: " + s9);
        Console.WriteLine("IsNullOrEmpty: " + b1);
        Console.WriteLine("IsNullOrWhiteSpace: " + b2);

    }
}