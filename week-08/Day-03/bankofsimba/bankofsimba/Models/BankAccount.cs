namespace bankofsimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public AnimalType AnimalType { get; set; }
        public bool KingIsTheOwner { get; set; }
        public bool GoodOrNot { get; set; }

        public BankAccount()
        {
        }

        public BankAccount(string name, int balance, AnimalType animalType, bool kingIsTheOwner, bool goodOrNot)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            KingIsTheOwner = kingIsTheOwner;
            GoodOrNot = goodOrNot;
        }

    }
}
