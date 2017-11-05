using System;

namespace ReservationEx
{
    class Reservation : IReservationy
    {
        private string reservationCode;
        private string dow;
        private static Random random = new Random();
        private static readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static readonly string[] DaysName = new string[7] { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };

        public Reservation()
        {
        }

        public string GetCodeBooking()
        {
            var stringChars = new char[8];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var reservationCode = new String(stringChars);

            return reservationCode;
        }

        public string GetDowBooking()
        {

            int RandomNumber = random.Next(DaysName.Length);

            string dow = DaysName[RandomNumber].ToString();

            return dow;
        }
    }
}
