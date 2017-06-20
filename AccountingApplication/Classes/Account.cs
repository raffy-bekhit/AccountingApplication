using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApplication
{
    
    class Account
    {
        public int  ID { get; set; }
        public Dictionary<int, Decimal> Entries { get; set; } = new Dictionary<int, decimal>();
        public string Name { get; set; }
        public int Counter { get; set; }
        public decimal Sum { get; set; }
        public bool NormalType { get; set; } //true if normal balance type is Cedit & false for debit
        public string Category { get; set; }
        public bool Credit { get; set; } 

        public Account(string name,string category )
        {
            Name = name;
            Category = category;
            if (category.Equals("assets") || category.Equals("expenses") || category.Equals("drawings"))
                NormalType = true; 
            else NormalType = false;
     
        }

        public override string ToString()
        {
            return Name;
        }

        public decimal calculateSum()
        {
            //calculates sum of account entries and specifies if account is credit or debit
            Sum = Entries.Values.Sum();
            if (NormalType==true ) {
                if (Sum > 0) Credit = true;
                else Credit = false;
            }
            else
            {
                if (Sum > 0) Credit = false;
                else Credit = true;
            }
            return Math.Abs(Sum);

        }

        public ArrayList ToArray(int i)
        {
            //i=3 for IS , 2 for OE
            ArrayList array = new ArrayList();
            
            array.Add(Name);
            array.Add(Sum);
            if(i==3)
            array.Add(null);
            return array;
        }
        
    }
}
