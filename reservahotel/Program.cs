using System;
using reservahotel.Entities;
using reservahotel.Entities.Exceptions;

namespace reservahotel
{
    class Program
    {
        private static void Main(string[] args)
        {

            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine()); // variasvel ja foi criada
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomianException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

            /*
        if (checkOut <= checkIn)
        {
            Console.WriteLine("Error in reservation: Check-out must be affter check-in date ");
        }
        else
        {
            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter data to update the reservation: ");

            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine()); // variasvel ja foi criada

            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());


              Primeira solução é muito ruim, a lógica da validação no programa principal (Lógida de validação não delega a reserva)

            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                Console.WriteLine("Error in reservation: Check-out must be affter check-in date ");
            }
            else if (checkIn <= checkOut)
            {
                Console.WriteLine("Error in reservation: Check-out must be affter check-in date ");
            }
            else
            {
                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }

            // A segunda solução também é ruim, porque o métado retornando string (semâtica da operação é prejudicada)
            string error = reservation.UpdateDates(checkIn, checkOut);
            if (error != null)
            {
                Console.WriteLine("Error in reservation: " + error);
            }
            else
            {
                Console.WriteLine("Reservation: " + reservation);
            }
            */
        }
    }
}
