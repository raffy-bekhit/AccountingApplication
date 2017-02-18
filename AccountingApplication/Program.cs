using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingApplication
{
    static class Program
    {
        //declares List of Categories
        public static List<Category> categories=createCategoriesList();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
           
        }

        public static List<Category> createCategoriesList()
        {
            //creating list of basic accounting elements
            List<Category> categories = new List<Category>();
            categories.Add(new Category("assets"));
            categories.Add(new Category("expenses"));
            categories.Add(new Category("drawings"));
            categories.Add(new Category("liabilities"));
            categories.Add(new Category("revenues"));
            categories.Add(new Category("capital"));

            return categories;
        }
    }
}
