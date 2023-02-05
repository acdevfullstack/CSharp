using System;
using enumeracoes.Entities;
using enumeracoes.Entities.Enums;


namespace enumeracoes
{
    class Program
    {
        private static void Main(string[] args)
        {
            ClassOrder order = new ClassOrder
            {
                Id = 10500,
                Moment = DateTime.Now,
                Status = ClassOrderStatus.PendingPayment

            };

            Console.WriteLine(order);

            //Conversao de strings
            string txt = ClassOrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            ClassOrderStatus os = Enum.Parse<ClassOrderStatus>("Delivered");
            Console.WriteLine(os);


            /* OBS
             Mas se não funcionar na sua versão do C#, tente deste jeito:
             OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            
             Se mesmo assim ainda tiver dando erro, há ainda uma terceira forma:
             OrderStatus os;
             Enum.TryParse("Delivered", out os);
           */


        }
    }
}