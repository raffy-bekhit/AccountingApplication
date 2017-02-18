﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApplication.Classes
{
   static class IncomeStatement
    {
        public static decimal Income { get; set; }

        public static decimal calculateIncome( )
        {
            decimal revenues,expenses;
            revenues = Program.categories.ElementAt(4).calculateSum();
            expenses = Program.categories.ElementAt(1).calculateSum();
            Income = revenues - expenses;
            return Income;
        }

       public static List<ArrayList> GetIncomeStatementData()
        {
            calculateIncome();
            List<ArrayList> IncomeStatementEntries = new List<ArrayList>();

            ArrayList EntryArray = new ArrayList();
            EntryArray.Add("Revenues");
            EntryArray.Add(null);
            EntryArray.Add(null);
            IncomeStatementEntries.Add(EntryArray);

            foreach(Account account in Program.categories.ElementAt(4).Accounts)
            {
                account.ToArray();
                IncomeStatementEntries.Add(account.ToArray());
                
            }
            EntryArray = new ArrayList();
            EntryArray.Add("Total Revenues");
            EntryArray.Add(null);
            EntryArray.Add(Program.categories.ElementAt(4).Sum);
            IncomeStatementEntries.Add(EntryArray);

            EntryArray = new ArrayList();
            EntryArray.Add("Expenses");
            EntryArray.Add(null);
            EntryArray.Add(null);
            IncomeStatementEntries.Add(EntryArray);

            foreach (Account account in Program.categories.ElementAt(1).Accounts)
            {
                
                IncomeStatementEntries.Add(account.ToArray());

            }

            EntryArray = new ArrayList();
            EntryArray.Add("Total Expenses");
            EntryArray.Add(null);
            EntryArray.Add((Program.categories.ElementAt(4).Sum)*-1);
            IncomeStatementEntries.Add(EntryArray);

            EntryArray = new ArrayList();
            EntryArray.Add("Income");
            EntryArray.Add(null);
            EntryArray.Add(Income);
            IncomeStatementEntries.Add(EntryArray);

            return IncomeStatementEntries;

        }

    }
}
