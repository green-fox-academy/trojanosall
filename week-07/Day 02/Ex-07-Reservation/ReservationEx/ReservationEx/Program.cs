using System;

namespace ReservationEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var myReservation = new Reservation();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Booking# " + myReservation.GetCodeBooking() + " for " + myReservation.GetDowBooking());
            }

            Console.ReadKey();

        }
    }
}
