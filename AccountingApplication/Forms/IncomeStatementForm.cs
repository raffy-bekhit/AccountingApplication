using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace AccountingApplication
{
    public partial class IncomeStatementForm : Form
    {
        public IncomeStatementForm()
        {
            InitializeComponent();
        }

        private void IncomeStatementForm_Load(object sender, EventArgs e)
        {
            

            foreach (ArrayList array in Classes.IncomeStatement.GetIncomeStatementData())
            {
                IncomeStatementGrid.Rows.Add(array.ToArray());
            }
        }
    }
}
