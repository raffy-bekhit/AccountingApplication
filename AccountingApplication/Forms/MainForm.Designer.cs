namespace AccountingApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCat1 = new System.Windows.Forms.ComboBox();
            this.cmbCat2 = new System.Windows.Forms.ComboBox();
            this.lstAcc1 = new System.Windows.Forms.ListBox();
            this.lstAcc2 = new System.Windows.Forms.ListBox();
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.txtNewAccName = new System.Windows.Forms.TextBox();
            this.btnAddEntry = new System.Windows.Forms.Button();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.btnEnterNewAcc = new System.Windows.Forms.Button();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.lstAcc3 = new System.Windows.Forms.ListBox();
            this.cmbCat3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCatNewAcc = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ownersEquityBtn = new System.Windows.Forms.Button();
            this.balanceSheetBtn = new System.Windows.Forms.Button();
            this.incomeStatementBtn = new System.Windows.Forms.Button();
            this.TrialBalanceGrid = new System.Windows.Forms.DataGridView();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrialBalanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCat1
            // 
            this.cmbCat1.FormattingEnabled = true;
            this.cmbCat1.Location = new System.Drawing.Point(47, 34);
            this.cmbCat1.Name = "cmbCat1";
            this.cmbCat1.Size = new System.Drawing.Size(121, 24);
            this.cmbCat1.TabIndex = 0;
            this.cmbCat1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbCat2
            // 
            this.cmbCat2.FormattingEnabled = true;
            this.cmbCat2.Location = new System.Drawing.Point(308, 34);
            this.cmbCat2.Name = "cmbCat2";
            this.cmbCat2.Size = new System.Drawing.Size(121, 24);
            this.cmbCat2.TabIndex = 1;
            this.cmbCat2.SelectedIndexChanged += new System.EventHandler(this.cmbCat2_SelectedIndexChanged);
            // 
            // lstAcc1
            // 
            this.lstAcc1.FormattingEnabled = true;
            this.lstAcc1.ItemHeight = 16;
            this.lstAcc1.Location = new System.Drawing.Point(48, 82);
            this.lstAcc1.Name = "lstAcc1";
            this.lstAcc1.Size = new System.Drawing.Size(120, 84);
            this.lstAcc1.TabIndex = 2;
            // 
            // lstAcc2
            // 
            this.lstAcc2.FormattingEnabled = true;
            this.lstAcc2.ItemHeight = 16;
            this.lstAcc2.Location = new System.Drawing.Point(309, 82);
            this.lstAcc2.Name = "lstAcc2";
            this.lstAcc2.Size = new System.Drawing.Size(120, 84);
            this.lstAcc2.TabIndex = 3;
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.Location = new System.Drawing.Point(58, 266);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(122, 31);
            this.btnNewAcc.TabIndex = 4;
            this.btnNewAcc.Text = "new account";
            this.btnNewAcc.UseVisualStyleBackColor = true;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // txtNewAccName
            // 
            this.txtNewAccName.Location = new System.Drawing.Point(321, 398);
            this.txtNewAccName.Name = "txtNewAccName";
            this.txtNewAccName.Size = new System.Drawing.Size(120, 22);
            this.txtNewAccName.TabIndex = 5;
            this.txtNewAccName.Visible = false;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Location = new System.Drawing.Point(573, 266);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(119, 31);
            this.btnAddEntry.TabIndex = 6;
            this.btnAddEntry.Text = "Add Entry";
            this.btnAddEntry.UseVisualStyleBackColor = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(48, 195);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(120, 22);
            this.txtValue1.TabIndex = 7;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(309, 195);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(120, 22);
            this.txtValue2.TabIndex = 8;
            // 
            // btnEnterNewAcc
            // 
            this.btnEnterNewAcc.Location = new System.Drawing.Point(573, 387);
            this.btnEnterNewAcc.Name = "btnEnterNewAcc";
            this.btnEnterNewAcc.Size = new System.Drawing.Size(120, 31);
            this.btnEnterNewAcc.TabIndex = 9;
            this.btnEnterNewAcc.Text = "Enter";
            this.btnEnterNewAcc.UseVisualStyleBackColor = true;
            this.btnEnterNewAcc.Visible = false;
            this.btnEnterNewAcc.Click += new System.EventHandler(this.btnEnterAcc_Click);
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(561, 195);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(120, 22);
            this.txtValue3.TabIndex = 12;
            // 
            // lstAcc3
            // 
            this.lstAcc3.FormattingEnabled = true;
            this.lstAcc3.ItemHeight = 16;
            this.lstAcc3.Location = new System.Drawing.Point(560, 82);
            this.lstAcc3.Name = "lstAcc3";
            this.lstAcc3.Size = new System.Drawing.Size(120, 84);
            this.lstAcc3.TabIndex = 11;
            // 
            // cmbCat3
            // 
            this.cmbCat3.FormattingEnabled = true;
            this.cmbCat3.Location = new System.Drawing.Point(560, 34);
            this.cmbCat3.Name = "cmbCat3";
            this.cmbCat3.Size = new System.Drawing.Size(121, 24);
            this.cmbCat3.TabIndex = 10;
            this.cmbCat3.SelectedIndexChanged += new System.EventHandler(this.cmbCat3_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCat3);
            this.groupBox1.Controls.Add(this.lstAcc3);
            this.groupBox1.Controls.Add(this.txtValue3);
            this.groupBox1.Controls.Add(this.txtValue1);
            this.groupBox1.Controls.Add(this.txtValue2);
            this.groupBox1.Controls.Add(this.lstAcc2);
            this.groupBox1.Controls.Add(this.cmbCat2);
            this.groupBox1.Controls.Add(this.lstAcc1);
            this.groupBox1.Controls.Add(this.cmbCat1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 233);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // cmbCatNewAcc
            // 
            this.cmbCatNewAcc.FormattingEnabled = true;
            this.cmbCatNewAcc.Location = new System.Drawing.Point(58, 398);
            this.cmbCatNewAcc.Name = "cmbCatNewAcc";
            this.cmbCatNewAcc.Size = new System.Drawing.Size(122, 24);
            this.cmbCatNewAcc.TabIndex = 14;
            this.cmbCatNewAcc.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(717, 178);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ownersEquityBtn);
            this.groupBox3.Controls.Add(this.balanceSheetBtn);
            this.groupBox3.Controls.Add(this.incomeStatementBtn);
            this.groupBox3.Controls.Add(this.TrialBalanceGrid);
            this.groupBox3.Location = new System.Drawing.Point(745, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 417);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // ownersEquityBtn
            // 
            this.ownersEquityBtn.Location = new System.Drawing.Point(6, 316);
            this.ownersEquityBtn.Name = "ownersEquityBtn";
            this.ownersEquityBtn.Size = new System.Drawing.Size(345, 31);
            this.ownersEquityBtn.TabIndex = 5;
            this.ownersEquityBtn.Text = "Create Owner\'s Equity";
            this.ownersEquityBtn.UseVisualStyleBackColor = true;
            this.ownersEquityBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // balanceSheetBtn
            // 
            this.balanceSheetBtn.Location = new System.Drawing.Point(6, 375);
            this.balanceSheetBtn.Name = "balanceSheetBtn";
            this.balanceSheetBtn.Size = new System.Drawing.Size(343, 31);
            this.balanceSheetBtn.TabIndex = 4;
            this.balanceSheetBtn.Text = "Create Balance Sheet";
            this.balanceSheetBtn.UseVisualStyleBackColor = true;
            // 
            // incomeStatementBtn
            // 
            this.incomeStatementBtn.Location = new System.Drawing.Point(6, 254);
            this.incomeStatementBtn.Name = "incomeStatementBtn";
            this.incomeStatementBtn.Size = new System.Drawing.Size(345, 31);
            this.incomeStatementBtn.TabIndex = 2;
            this.incomeStatementBtn.Text = "Create Income Statement";
            this.incomeStatementBtn.UseVisualStyleBackColor = true;
            this.incomeStatementBtn.Click += new System.EventHandler(this.incomeStatementBtn_Click);
            // 
            // TrialBalanceGrid
            // 
            this.TrialBalanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrialBalanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account,
            this.Credit,
            this.Debit});
            this.TrialBalanceGrid.Location = new System.Drawing.Point(6, 27);
            this.TrialBalanceGrid.Name = "TrialBalanceGrid";
            this.TrialBalanceGrid.RowTemplate.Height = 24;
            this.TrialBalanceGrid.Size = new System.Drawing.Size(345, 206);
            this.TrialBalanceGrid.TabIndex = 1;
            // 
            // Account
            // 
            this.Account.HeaderText = "Account Name";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmbCatNewAcc);
            this.Controls.Add(this.btnEnterNewAcc);
            this.Controls.Add(this.btnAddEntry);
            this.Controls.Add(this.txtNewAccName);
            this.Controls.Add(this.btnNewAcc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrialBalanceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCat1;
        private System.Windows.Forms.ComboBox cmbCat2;
        private System.Windows.Forms.ListBox lstAcc1;
        private System.Windows.Forms.ListBox lstAcc2;
        private System.Windows.Forms.Button btnNewAcc;
        private System.Windows.Forms.TextBox txtNewAccName;
        private System.Windows.Forms.Button btnAddEntry;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Button btnEnterNewAcc;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.ListBox lstAcc3;
        private System.Windows.Forms.ComboBox cmbCat3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCatNewAcc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView TrialBalanceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.Button incomeStatementBtn;
        private System.Windows.Forms.Button ownersEquityBtn;
        private System.Windows.Forms.Button balanceSheetBtn;
    }
}

