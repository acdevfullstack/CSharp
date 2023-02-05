namespace switchcase
{
    class Program
    {
        private static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            //Solução com If else
            /*
            if (x == 1)
            {
                day = "Saunday";
            }
            else if (x == 2)
            { day = "Monday"; }
            else if (x == 3)
            { day = "third"; }
            else if (x == 4)
            { day = "fourth"; }
            else if (x == 5)
            { day = "Thursday"; }
            else if (x == 6)
            { day = "friday"; }
            else if (x == 7)
            { day = "Saturday"; }
            else
            {
                day = "Invalid value!";
            }

            */
            //Solução com Switch Case
            switch (x)
            {
                case 1:
                    day = "Saunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "third";
                    break;
                case 4:
                    day = "fourth";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Invalid value!";
                    break;
            }

            Console.WriteLine("Day: " + day);
        }
    }
}