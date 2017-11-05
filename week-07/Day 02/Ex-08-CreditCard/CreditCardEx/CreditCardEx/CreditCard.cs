using System;

namespace CreditCardEx
{
    class CreditCard : CreditCardy
    {
        private string codeAccount;
        private string nameCardHolder;
        private int sumCVV;
        private int serialNumberOfCarHolder;
        private static Random random = new Random();
        private static readonly string chars = "0123456789";

        public CreditCard(int serialNumber)
        {
            serialNumberOfCarHolder = serialNumber;
            codeAccount = GetCodeAccount();
            nameCardHolder = GetNameCardholder();
            sumCVV = GetSumCVV();
        }

        public int CumeSumCVV(string CodeAccount)
        {
            int sumCVV = 0;
            var x = CodeAccount.ToCharArray();

            for (int i = 0; i <= x.Length - 1; i++)
            {
                sumCVV += x[i] - '0';

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

            var CodeAccount = new String(stringChars);

            return CodeAccount;
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
            string cardFormat = string.Format("Name ={0} CC#={1} CVV={2}", nameCardHolder, codeAccount, sumCVV);
            return cardFormat;
        }
    }
}
