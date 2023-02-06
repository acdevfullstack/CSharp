using System;
using stringbuilder.Entities;

namespace stringbuilder
{
    class Program
    {
        private static void Main(string[] args)
        {
            Comment c1 = new Comment("Fazer boa viagem!");
            Comment c2 = new Comment("Uau, isso é incrível!");
            Post p1 = new Post(
                    DateTime.Parse("21/06/2018 13:05:44"),
                    "Viajar para a Nova Zelândia",
                    "Vou visitar este país maravilhoso!",
                    12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Boa noite");
            Comment c4 = new Comment("Que a força esteja com você");
            Post p2 = new Post(
                    DateTime.Parse("28/07/2018 23:14:19"),
                    "Boa noite, galera",
                    "Vejo você amanhã",
                    5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}