using System;

namespace CreditCardEx
{
    class CreditCard : CreditCardy
    {
        private string codeAccount { get; set; }
        private int nameCardHolder;
        private int serialNumberOfCarHolder;
        private static Random random = new Random();
        private static readonly string chars = "0123456789";

        public CreditCard(int serialNumber)
        {
            serialNumberOfCarHolder = serialNumber;
        }

        public int CumeSumCVV(string codeAccount)
        {
            int sumCVV = 0;
            codeAccount = GetCodeAccount();
            var x = codeAccount.ToCharArray();

            for (int i = 0; i <= x.Length - 1; i++)
            {
                if (x[i] > '0' && x[i] <= '9')
                {
                    sumCVV += x[i] - '0';
                }
            }
            return sumCVV;
        }

        public string GetCodeAccount()
        {
            var stringChars = new char[10];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var codeAccount = new String(stringChars);

            return codeAccount;
        }

        public string GetNameCardholder()
        {
            string item = "ABC";
            string nameCardHolder = (item + serialNumberOfCarHolder).ToString();
            return nameCardHolder;
        }

        public int GetSumCVV()
        {
            return CumeSumCVV(codeAccount);
        }

        public string Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
