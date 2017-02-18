namespace AccountingApplication
{
    partial class IncomeStatementForm
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
            this.IncomeStatementGrid = new System.Windows.Forms.DataGridView();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeStatementGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IncomeStatementGrid
            // 
            this.IncomeStatementGrid.AllowUserToAddRows = false;
            this.IncomeStatementGrid.AllowUserToDeleteRows = false;
            this.IncomeStatementGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IncomeStatementGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Account,
            this.SingleValue,
            this.Total});
            this.IncomeStatementGrid.Location = new System.Drawing.Point(12, 12);
            this.IncomeStatementGrid.Name = "IncomeStatementGrid";
            this.IncomeStatementGrid.RowTemplate.Height = 24;
            this.IncomeStatementGrid.Size = new System.Drawing.Size(345, 150);
            this.IncomeStatementGrid.TabIndex = 0;
            // 
            // Account
            // 
            this.Account.HeaderText = "";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            // 
            // SingleValue
            // 
            this.SingleValue.HeaderText = "";
            this.SingleValue.Name = "SingleValue";
            this.SingleValue.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // IncomeStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 452);
            this.Controls.Add(this.IncomeStatementGrid);
            this.Name = "IncomeStatementForm";
            this.Text = "IncomeStatementForm";
            this.Load += new System.EventHandler(this.IncomeStatementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IncomeStatementGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IncomeStatementGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingleValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}