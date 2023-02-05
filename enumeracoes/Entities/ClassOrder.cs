using System;
using enumeracoes.Entities.Enums;

namespace enumeracoes.Entities
{
    internal class ClassOrder
    {
        public int Id { get; set; }
        public DateTime Moment{ get; set; }
        public ClassOrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                   + ", "
                   + Moment
                   + ", "
                   + Status; 
        }
    }
}
