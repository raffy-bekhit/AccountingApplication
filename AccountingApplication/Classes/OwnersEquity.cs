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
        
        public OwnersEquity()
        {
           

        }
        public decimal EndingCapital { get; set; }
        public decimal BeginningCapital { get; set; }
        public ArrayList Investments { get; set; }
        public ArrayList Drawings { get; set; }

    }
}
