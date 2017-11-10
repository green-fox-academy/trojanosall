using System;

namespace MyBudgetApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public ExpenseCategoryEnum Category { get; set; }


        //public string GetExpenseCategory(ExpenseCategoryEnum Category)
        //{
        //    switch (Category)
        //    {
        //        case ExpenseCategoryEnum.InternetAndTV:
        //            return "Internet and TV";

        //        case ExpenseCategoryEnum.GasUtilityService:
        //            return "Gas utility service";

        //        case ExpenseCategoryEnum.WaterUtilityService:
        //            return "Water utility service";

        //        case ExpenseCategoryEnum.WasteUtilityService:
        //            return "Waste utility service";

        //        case ExpenseCategoryEnum.ElectricityUtilityService:
        //            return "Electricity utility service";

        //        case ExpenseCategoryEnum.LunchTinus:
        //            return "Lunch for Tinus";

        //        case ExpenseCategoryEnum.LunchLoci:
        //            return "Lunch for Loci";

        //        case ExpenseCategoryEnum.MobileServiceFee:
        //            return "Mobile service fee";

        //        case ExpenseCategoryEnum.Cigarette:
        //            return "Cigarette";

        //        case ExpenseCategoryEnum.Shopping:
        //            return "Shopping";

        //        case ExpenseCategoryEnum.Fuel:
        //            return "Fuel";

        //        case ExpenseCategoryEnum.PublicTransportFee:
        //            return "Public transport fee";

        //        case ExpenseCategoryEnum.Clothes:
        //            return "Clothes";

        //        case ExpenseCategoryEnum.Recreation:
        //            return "Recreation";

        //        case ExpenseCategoryEnum.Car:
        //            return "Car";

        //        case ExpenseCategoryEnum.BankLoan:
        //            return "Bank loan";

        //        case ExpenseCategoryEnum.Savings:
        //            return "Savings";

        //        case ExpenseCategoryEnum.BankCharges:
        //            return "Bank charges";

        //        case ExpenseCategoryEnum.HealthCare:
        //            return "Health care";

        //        case ExpenseCategoryEnum.Gifts:
        //            return "Gifts";

        //        case ExpenseCategoryEnum.Childs:
        //            return "Childs";

        //        case ExpenseCategoryEnum.Learning:
        //            return "Learning";

        //        case ExpenseCategoryEnum.Other:
        //            return "Other";

        //        case ExpenseCategoryEnum.Travel:
        //            return "Travel";
        //    }
        //}
    }
}
