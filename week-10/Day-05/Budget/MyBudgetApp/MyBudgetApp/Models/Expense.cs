using System;
using System.Collections.Generic;

namespace MyBudgetApp.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }


        //public string GetExpenseCategory()
        //{
        //    ExpenseCategoryEnum MyExpenseCategoryEnum = new ExpenseCategoryEnum();
        //    Dictionary<ExpenseCategoryEnum, string> ExpenseCategoryMapping = new Dictionary<ExpenseCategoryEnum, string>()
        //{
        //    {ExpenseCategoryEnum.BankCharges, "Bank charges"},
        //    {ExpenseCategoryEnum.BankLoan, "Bank loan"},
        //    {ExpenseCategoryEnum.Car, "Car"},
        //    {ExpenseCategoryEnum.Childs, "Childs"},
        //    {ExpenseCategoryEnum.Cigarette, "Cigarette"},
        //    {ExpenseCategoryEnum.Clothes, "Clothes"},
        //    {ExpenseCategoryEnum.ElectricityUtilityService, "Electricity utility service"},
        //    {ExpenseCategoryEnum.Fuel, "Fuel"},
        //    {ExpenseCategoryEnum.GasUtilityService, "Gas utility service"},
        //    {ExpenseCategoryEnum.Gifts, "Gifts"},
        //    {ExpenseCategoryEnum.HealthCare, "Health care"},
        //    {ExpenseCategoryEnum.InternetAndTV, "Internet and TV"},
        //    {ExpenseCategoryEnum.Learning, "Learning"},
        //    {ExpenseCategoryEnum.LunchLoci, "Lunch for Loci"},
        //    {ExpenseCategoryEnum.LunchTinus, "Lunch for Tinus"},
        //    {ExpenseCategoryEnum.MobileServiceFee, "Mobile service fee"},
        //    {ExpenseCategoryEnum.Other, "Other"},
        //    {ExpenseCategoryEnum.PublicTransportFee, "Public transport fee"},
        //    {ExpenseCategoryEnum.Recreation, "Recreation"},
        //    {ExpenseCategoryEnum.Savings, "Savings"},
        //    {ExpenseCategoryEnum.Shopping, "Shopping"},
        //    {ExpenseCategoryEnum.Travel, "Travel"},
        //    {ExpenseCategoryEnum.WasteUtilityService, "Waste utility service"},
        //    {ExpenseCategoryEnum.WaterUtilityService, "Water utility service"},
        //};

        //    Category = ExpenseCategoryMapping[MyExpenseCategoryEnum];
        //    return Category;
        //}
    }
}