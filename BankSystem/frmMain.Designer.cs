namespace BankSystem
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmdFindClient = new System.Windows.Forms.Button();
            this.cmdNewAccount = new System.Windows.Forms.Button();
            this.cmdAllAccounts = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(796, 299);
            this.label1.TabIndex = 1;
            this.label1.Text = "Na tomto okne budú manažérske prehľady.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdFindClient
            // 
            this.cmdFindClient.Location = new System.Drawing.Point(283, 15);
            this.cmdFindClient.Name = "cmdFindClient";
            this.cmdFindClient.Size = new System.Drawing.Size(112, 23);
            this.cmdFindClient.TabIndex = 2;
            this.cmdFindClient.Text = "Find client";
            this.cmdFindClient.UseVisualStyleBackColor = true;
            this.cmdFindClient.Click += new System.EventHandler(this.cmdFindClient_Click);
            // 
            // cmdNewAccount
            // 
            this.cmdNewAccount.Location = new System.Drawing.Point(23, 61);
            this.cmdNewAccount.Name = "cmdNewAccount";
            this.cmdNewAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdNewAccount.TabIndex = 3;
            this.cmdNewAccount.Text = "New account";
            this.cmdNewAccount.UseVisualStyleBackColor = true;
            this.cmdNewAccount.Click += new System.EventHandler(this.cmdNewAccount_Click);
            // 
            // cmdAllAccounts
            // 
            this.cmdAllAccounts.Location = new System.Drawing.Point(146, 61);
            this.cmdAllAccounts.Name = "cmdAllAccounts";
            this.cmdAllAccounts.Size = new System.Drawing.Size(120, 23);
            this.cmdAllAccounts.TabIndex = 4;
            this.cmdAllAccounts.Text = "All accounts";
            this.cmdAllAccounts.UseVisualStyleBackColor = true;
            this.cmdAllAccounts.Click += new System.EventHandler(this.cmdAllAccounts_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(283, 61);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 5;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(23, 15);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(243, 20);
            this.txtFilter.TabIndex = 10;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 444);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdAllAccounts);
            this.Controls.Add(this.cmdNewAccount);
            this.Controls.Add(this.cmdFindClient);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bank System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdFindClient;
        private System.Windows.Forms.Button cmdNewAccount;
        private System.Windows.Forms.Button cmdAllAccounts;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.TextBox txtFilter;
    }
}

