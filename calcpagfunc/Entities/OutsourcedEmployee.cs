using System;
using System.Collections.Generic;

namespace calcpagfunc.Etities
{
     class OutsourcedEmployee : Employee
    {
    public double AdditionalCharge { get; set; }

        //Construtor
        public OutsourcedEmployee() { 
        
        }
        
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        //Obs.: Aproveita o campo Payment
        public override double Paymemt()
        {
            return base.Paymemt() + 1.1 * AdditionalCharge;
        }

    }
}
