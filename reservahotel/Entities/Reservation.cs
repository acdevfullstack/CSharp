using System;
using reservahotel.Entities.Exceptions;

namespace reservahotel.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn <= checkOut)
            {
                throw new DomianException("Check-out must be affter check-in date");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomianException("Reservation dates for update must be futire dates");
            }

            if (checkIn <= checkOut)
            {
                throw new DomianException("Check-out must be affter check-in date");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        /* Solução ruim
        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {            
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return ("Reservation dates for update must be futire dates");
            }
            
            if (checkIn <= checkOut)
            {
                return ("Check-out must be affter check-in date");
            }
            
            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }
        */
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "nigths";
        }
    }
}
