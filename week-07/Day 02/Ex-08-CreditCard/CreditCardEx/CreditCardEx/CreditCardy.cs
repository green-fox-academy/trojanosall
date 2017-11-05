namespace CreditCardEx
{
    interface CreditCardy
    {
        int GetSumCVV();

        string GetNameCardholder();

        string GetCodeAccount();

        int CumeSumCVV(string codeAccount);

        string Tostring();
    }
}
