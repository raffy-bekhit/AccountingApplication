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
    public partial class Form1 : Form
    {
        List<Category> categories = Program.categories;
       
        int entries_count;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //initialize 
            entries_count = 0;
        
            

            ////initializing comboBoxes
           
            cmbCat1.DataSource = categories.ToList();
            cmbCat2.DataSource = categories.ToList();
            cmbCat3.DataSource = categories.ToList();
            cmbCatNewAcc.DataSource = categories.ToList();

           
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fills first listbox with accounts
            lstAcc1.DataSource = categories.ElementAt(cmbCat1.SelectedIndex).Accounts;
        }

        private void btnNewAcc_Click(object sender, EventArgs e)
        {
            //adds account to list
            txtNewAccName.Visible = true;
            btnEnterNewAcc.Visible = true;
            cmbCatNewAcc.Visible = true;
        }

        private void btnEnterAcc_Click(object sender, EventArgs e)
        {
            Account newAccount = new Account(txtNewAccName.Text,cmbCatNewAcc.SelectedItem.ToString());
            categories.ElementAt(cmbCatNewAcc.SelectedIndex).Accounts.Add(newAccount);

            cmbCatNewAcc.Visible = false; 
            txtNewAccName.Visible = false;
            btnEnterNewAcc.Visible=false;

            txtNewAccName.Text = null;
            addAccountToTrialBalance(newAccount);
 
        }

        private void cmbCat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fills second listbox with accounts
            lstAcc2.DataSource = categories.ElementAt(cmbCat2.SelectedIndex).Accounts;
        }

        private void cmbCat3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fills third listbox with accounts
            lstAcc3.DataSource = categories.ElementAt(cmbCat3.SelectedIndex).Accounts;
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            if(checkEntryConditions())
            {
                for(int i=0;i<3;i++)
                {
                    decimal tempValue;
                    if(getTextBox(i)!= null &&Decimal.TryParse(getTextBox(i).Text,out tempValue))
                    {
                        getAccountFromList(i).Entries.Add(entries_count, tempValue);
                        getTextBox(i).Text = null;
                        updateAccountinTrialBalance(getAccountFromList(i));
                    }
                }
                entries_count++;
                MessageBox.Show("Entry is added successfully! :)");
                
                }
            }
        



        Account getAccountFromList(int listNum)
        {
            //getting selected Account
            int accIndex = getListBox(listNum).SelectedIndex;
            int catIndex = getComboBox(listNum).SelectedIndex;
            
            return categories.ElementAt(catIndex).Accounts.ElementAt(accIndex);
        }

        

        void addAccountToTrialBalance(Account account)
        {
            //updates TrialBalanceTable
            
            
            
            
            TrialBalanceGrid.Rows.Add(account);
            
        }

        void updateAccountinTrialBalance(Account account)
        {

            for (int i = 0; i < TrialBalanceGrid.Rows.Count; i++)
            {
                DataGridViewRow row = TrialBalanceGrid.Rows[i];
                try
                {
                    if (row.Cells[0].Value.Equals(account))
                    {

                        decimal sum = account.calculateSum();
                        if (account.Credit)
                        {
                            row.Cells[1].Value = sum;
                            row.Cells[2].Value = null;
                        }
                        else
                        {
                            row.Cells[1].Value = null;
                            row.Cells[2].Value = sum;
                        }

                        TrialBalanceGrid.UpdateCellValue(1, i);
                        TrialBalanceGrid.UpdateCellValue(2,i);
                    }
                }
                catch (NullReferenceException) { return; }

            }
        }

        bool checkNumberOfEntries() {
            //checks number of entries are 2 or 3 

            int textCounter = 0;
            decimal temp;
            if (Decimal.TryParse(txtValue1.Text,out temp )) textCounter++;
            if (Decimal.TryParse(txtValue2.Text, out temp)) textCounter++;
            if (Decimal.TryParse(txtValue3.Text, out temp)) textCounter++;

            if (textCounter > 1) return true;
            else { MessageBox.Show("Enter at least two decimal values!"); return false; }

        }

        bool isAccSelected()
        {
            //checks if accounts are selected for given values of entry
            int selectedAccCounter = 0;
            if (!string.IsNullOrEmpty(txtValue1.Text) && lstAcc1.SelectedIndex>-1) selectedAccCounter++;
            if (!string.IsNullOrEmpty(txtValue2.Text) && lstAcc2.SelectedIndex > -1) selectedAccCounter++;
            if (!string.IsNullOrEmpty(txtValue3.Text) && lstAcc3.SelectedIndex > -1) selectedAccCounter++;

            if (selectedAccCounter > 1) return true;
            else {
                MessageBox.Show("Select the wanted accounts!");
                    return false; }

        }
        ComboBox getComboBox(int cmbNum)
        {
            //gets combobox by its number
            if (cmbNum == 0) return cmbCat1;
            if (cmbNum == 1) return cmbCat2;
            if (cmbNum == 2) return cmbCat3;
            return null;
        }

        TextBox getTextBox(int txtNum)
        {
            //gets text box by its number
            if (txtNum == 0) return txtValue1;
            if (txtNum == 1) return txtValue2;
            if (txtNum == 2) return txtValue3;
            return null;
        }

        ListBox getListBox(int lstNum)
        {
            //gets listbox by its number
            if (lstNum == 0) return lstAcc1;
            if (lstNum == 1) return lstAcc2;
            if (lstNum == 2) return lstAcc3;
            return null;
        }

        bool isCategoryCredit(int cmbNum)
        {
           //checks whether category chosen is credit or debit 
            if (getComboBox(cmbNum)!=null&&getComboBox(cmbNum).SelectedIndex < 3) return true;
            return false;
        }

        bool checkEntryConditions()
        {
            //check if entry obeys conditions

            decimal totalEntry = -9999;
            
            if (checkNumberOfEntries() && isAccSelected()) {
                totalEntry = 0;
                for (int i=0; i<3; i++)
                {
                    
                    decimal tempValue = 0;
                    if (Decimal.TryParse(getTextBox(i).Text, out tempValue) && isCategoryCredit(i) )
                        totalEntry += tempValue;
                    else totalEntry = totalEntry+(-1 * tempValue);
                }
            }
            if (totalEntry == 0) return true;
            MessageBox.Show("Entry does not obey accounting rules!");
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void incomeStatementBtn_Click(object sender, EventArgs e)
        {

            IncomeStatementForm incomeStatementForm = new IncomeStatementForm();
            incomeStatementForm.Show();
        }
    }

}
