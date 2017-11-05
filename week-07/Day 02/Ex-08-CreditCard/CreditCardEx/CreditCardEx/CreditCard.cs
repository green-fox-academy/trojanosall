using System;

namespace CreditCardEx
{
    class CreditCard : CreditCardy
    {
        private int codeAccount;
        private int nameCardHolder;
        private int serialNumberOfCarHolder;
        private static Random random = new Random();
        private static readonly string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public CreditCard(int serialNumber)
        {
            serialNumberOfCarHolder = serialNumber;
        }

        public int CumeSumCVV(string codeAccount)
        {
            throw new NotImplementedException();
        }

        public string GetCodeAccount()
        {
            throw new NotImplementedException();
        }

        public string GetNameCardholder()
        {
            string item = "ABC";
            string nameCardHolder = (item + serialNumberOfCarHolder).ToString();
            return nameCardHolder;
        }

        public int GetSumCVV()
        {
            throw new NotImplementedException();
        }

        public string Tostring()
        {
            throw new NotImplementedException();
        }
    }
}
