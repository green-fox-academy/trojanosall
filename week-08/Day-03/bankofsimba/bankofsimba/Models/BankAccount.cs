using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bankofsimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Balance { get; set; }
        public string AnimalType { get; set; }
        public bool KingIsTheOwner { get; set; } = true;

        public BankAccount()
        {
        }

        public BankAccount(string name, int balance, string animalType, bool kingIsTheOwner)
        {
            Name = name;
            Balance = balance;
            AnimalType = animalType;
            KingIsTheOwner = true;
        }
    }
}
