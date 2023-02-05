namespace estruturaforeach
{
    class Program
    {
        private static void Main(string[] args)
        {

            string[] vect = new string[] { "Maria", "João", "Pedro" };
            /*
            //Solução antiga, mas funciona
            for (int i=0; i<vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            */

            //Solução Nova
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }

        }
    }
}