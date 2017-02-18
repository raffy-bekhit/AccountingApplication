using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingApplication
{
    class Category
    {
        string Name { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();
        public decimal Sum{ get; set; }

        public Category(string name)
        {
            this.Name = name;
            Sum = 0;

        }

       override public string ToString() {
            return Name;

        }

        public decimal calculateSum()
        {
            if (Sum == 0)
            {
                foreach (Account a in Accounts)
                {
                    Sum += a.calculateSum();

                }
            }
            return Sum;
           
        }
    }
}
