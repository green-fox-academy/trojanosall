using System;

namespace ReservationEx
{
    class Reservation : IReservationy
    {
        private string reservationCode;
        private string dow;
        private static Random random = new Random();

        public Reservation()
        {
        }

        public string GetCodeBooking()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var reservationCode = new String(stringChars);

            return reservationCode;
        }

        public string GetDowBooking()
        {
            var random = new Random();
            string[] DaysName = new string[7] { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };

            int RandomNumber = random.Next(DaysName.Length);

            string dow = DaysName[RandomNumber].ToString();

            return dow;
        }
    }
}
