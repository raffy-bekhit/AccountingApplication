using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApplication.Classes
{
    class OwnersEquity
    {
        public static decimal FinalCapital { get; set; }
        public static ArrayList Investments { get; set; }
        public static ArrayList Drawings { get; set; }
        public static Category Capital { get; set; }

        public static void CalculateFinalCapital()
        {
            Capital = Program.categories.ElementAt(5);
            FinalCapital = Capital.calculateSum();
            FinalCapital += IncomeStatement.Income;

        }

        public static List<ArrayList> GetOwnersEquityData()
        {
            CalculateFinalCapital();

            //if +ve add to investents else add to drawings
            foreach (Account a in Capital.Accounts)
            {
                if (a.Sum > 0) Investments.Add(a);
                else Drawings.Add(a);
            }

            //List to fill Owners Equity Data Grid
             List<ArrayList> OEEntries = new List<ArrayList>();

            ArrayList EntryArray = new ArrayList();
            EntryArray.Add("Investments");
            EntryArray.Add(null);
            OEEntries.Add(EntryArray);

            foreach(Account account in Investments)
            {
               
                OEEntries.Add(account.ToArray());
                
            }
            EntryArray = new ArrayList();
            EntryArray.Add("Income");
            EntryArray.Add(IncomeStatement.Income);
            OEEntries.Add(EntryArray);

            EntryArray = new ArrayList();
            EntryArray.Add("Drawings");
            EntryArray.Add(null);
            OEEntries.Add(EntryArray);

            foreach (Account account in Drawings)
            {

                OEEntries.Add(account.ToArray(2));

            }


            EntryArray = new ArrayList();
            EntryArray.Add("Final Capital");
            EntryArray.Add(FinalCapital);
            OEEntries.Add(EntryArray);

            return OEEntries;
        }






    }
}
