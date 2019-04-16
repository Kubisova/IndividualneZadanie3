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
            this.lblTopClients = new System.Windows.Forms.Label();
            this.lblFundsOnAccounts = new System.Windows.Forms.Label();
            this.lblActiveAccounts = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDemography = new System.Windows.Forms.Label();
            this.dgvTopClients = new System.Windows.Forms.DataGridView();
            this.lblNumberActiveAccount = new System.Windows.Forms.Label();
            this.dgvDemography = new System.Windows.Forms.DataGridView();
            this.lblNumberFunds = new System.Windows.Forms.Label();
            this.dgvEstablishedAccounts = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemography)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablishedAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 347);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdFindClient
            // 
            this.cmdFindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmdNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmdAllAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmdAllTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(243, 20);
            this.txtFilter.TabIndex = 10;
            // 
            // lblTopClients
            // 
            this.lblTopClients.AutoSize = true;
            this.lblTopClients.BackColor = System.Drawing.Color.LightGreen;
            this.lblTopClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopClients.Location = new System.Drawing.Point(49, 136);
            this.lblTopClients.Name = "lblTopClients";
            this.lblTopClients.Size = new System.Drawing.Size(70, 13);
            this.lblTopClients.TabIndex = 11;
            this.lblTopClients.Text = "Top clients";
            // 
            // lblFundsOnAccounts
            // 
            this.lblFundsOnAccounts.AutoSize = true;
            this.lblFundsOnAccounts.BackColor = System.Drawing.Color.LightGreen;
            this.lblFundsOnAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundsOnAccounts.Location = new System.Drawing.Point(645, 391);
            this.lblFundsOnAccounts.Name = "lblFundsOnAccounts";
            this.lblFundsOnAccounts.Size = new System.Drawing.Size(156, 13);
            this.lblFundsOnAccounts.TabIndex = 12;
            this.lblFundsOnAccounts.Text = "Funds on clients accounts";
            // 
            // lblActiveAccounts
            // 
            this.lblActiveAccounts.AutoSize = true;
            this.lblActiveAccounts.BackColor = System.Drawing.Color.LightGreen;
            this.lblActiveAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveAccounts.Location = new System.Drawing.Point(459, 391);
            this.lblActiveAccounts.Name = "lblActiveAccounts";
            this.lblActiveAccounts.Size = new System.Drawing.Size(150, 13);
            this.lblActiveAccounts.TabIndex = 13;
            this.lblActiveAccounts.Text = "Count of active accounts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(645, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Count of established accounts (monthly)";
            // 
            // lblDemography
            // 
            this.lblDemography.AutoSize = true;
            this.lblDemography.BackColor = System.Drawing.Color.LightGreen;
            this.lblDemography.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemography.Location = new System.Drawing.Point(391, 136);
            this.lblDemography.Name = "lblDemography";
            this.lblDemography.Size = new System.Drawing.Size(77, 13);
            this.lblDemography.TabIndex = 15;
            this.lblDemography.Text = "Demography";
            // 
            // dgvTopClients
            // 
            this.dgvTopClients.AllowUserToAddRows = false;
            this.dgvTopClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopClients.Location = new System.Drawing.Point(52, 164);
            this.dgvTopClients.Name = "dgvTopClients";
            this.dgvTopClients.ReadOnly = true;
            this.dgvTopClients.RowHeadersVisible = false;
            this.dgvTopClients.Size = new System.Drawing.Size(321, 273);
            this.dgvTopClients.TabIndex = 16;
            // 
            // lblNumberActiveAccount
            // 
            this.lblNumberActiveAccount.AutoSize = true;
            this.lblNumberActiveAccount.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNumberActiveAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberActiveAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumberActiveAccount.Location = new System.Drawing.Point(462, 417);
            this.lblNumberActiveAccount.MaximumSize = new System.Drawing.Size(140, 20);
            this.lblNumberActiveAccount.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblNumberActiveAccount.Name = "lblNumberActiveAccount";
            this.lblNumberActiveAccount.Size = new System.Drawing.Size(140, 20);
            this.lblNumberActiveAccount.TabIndex = 17;
            this.lblNumberActiveAccount.Text = "unknown";
            this.lblNumberActiveAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvDemography
            // 
            this.dgvDemography.AllowUserToAddRows = false;
            this.dgvDemography.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemography.Location = new System.Drawing.Point(394, 164);
            this.dgvDemography.Name = "dgvDemography";
            this.dgvDemography.ReadOnly = true;
            this.dgvDemography.RowHeadersVisible = false;
            this.dgvDemography.Size = new System.Drawing.Size(235, 185);
            this.dgvDemography.TabIndex = 18;
            // 
            // lblNumberFunds
            // 
            this.lblNumberFunds.AutoSize = true;
            this.lblNumberFunds.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNumberFunds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumberFunds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumberFunds.Location = new System.Drawing.Point(648, 417);
            this.lblNumberFunds.MaximumSize = new System.Drawing.Size(140, 20);
            this.lblNumberFunds.MinimumSize = new System.Drawing.Size(140, 20);
            this.lblNumberFunds.Name = "lblNumberFunds";
            this.lblNumberFunds.Size = new System.Drawing.Size(140, 20);
            this.lblNumberFunds.TabIndex = 19;
            this.lblNumberFunds.Text = "unknown";
            this.lblNumberFunds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvEstablishedAccounts
            // 
            this.dgvEstablishedAccounts.AllowUserToAddRows = false;
            this.dgvEstablishedAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstablishedAccounts.Location = new System.Drawing.Point(644, 164);
            this.dgvEstablishedAccounts.Name = "dgvEstablishedAccounts";
            this.dgvEstablishedAccounts.ReadOnly = true;
            this.dgvEstablishedAccounts.RowHeadersVisible = false;
            this.dgvEstablishedAccounts.Size = new System.Drawing.Size(235, 185);
            this.dgvEstablishedAccounts.TabIndex = 21;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(826, 81);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 488);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvEstablishedAccounts);
            this.Controls.Add(this.lblNumberFunds);
            this.Controls.Add(this.dgvDemography);
            this.Controls.Add(this.lblNumberActiveAccount);
            this.Controls.Add(this.dgvTopClients);
            this.Controls.Add(this.lblDemography);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblActiveAccounts);
            this.Controls.Add(this.lblFundsOnAccounts);
            this.Controls.Add(this.lblTopClients);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdAllAccounts);
            this.Controls.Add(this.cmdNewAccount);
            this.Controls.Add(this.cmdFindClient);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(600, 200);
            this.MaximumSize = new System.Drawing.Size(938, 527);
            this.MinimumSize = new System.Drawing.Size(938, 527);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bank System";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemography)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstablishedAccounts)).EndInit();
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
        private System.Windows.Forms.Label lblTopClients;
        private System.Windows.Forms.Label lblFundsOnAccounts;
        private System.Windows.Forms.Label lblActiveAccounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDemography;
        private System.Windows.Forms.DataGridView dgvTopClients;
        private System.Windows.Forms.Label lblNumberActiveAccount;
        private System.Windows.Forms.DataGridView dgvDemography;
        private System.Windows.Forms.Label lblNumberFunds;
        private System.Windows.Forms.DataGridView dgvEstablishedAccounts;
        private System.Windows.Forms.Button btnRefresh;
    }
}

