namespace BankSystem
{
    partial class frmClientManagement
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
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdNewTransaction = new System.Windows.Forms.Button();
            this.cmdCloseAccount = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.cmdWithdrawal = new System.Windows.Forms.Button();
            this.cmdDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNewCard = new System.Windows.Forms.Button();
            this.btnUnblockBlockedCard = new System.Windows.Forms.Button();
            this.dGVShortAccountInfo = new System.Windows.Forms.DataGridView();
            this.dGVCards = new System.Windows.Forms.DataGridView();
            this.lblAccountInfotext = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCardsInfo = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShortAccountInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCards)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccountInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblAccountInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAccountInfo.Location = new System.Drawing.Point(12, 9);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(732, 185);
            this.lblAccountInfo.TabIndex = 2;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.Location = new System.Drawing.Point(23, 227);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(165, 36);
            this.cmdUpdate.TabIndex = 4;
            this.cmdUpdate.Text = "Update account or client";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdNewTransaction
            // 
            this.cmdNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNewTransaction.Location = new System.Drawing.Point(23, 281);
            this.cmdNewTransaction.Name = "cmdNewTransaction";
            this.cmdNewTransaction.Size = new System.Drawing.Size(165, 36);
            this.cmdNewTransaction.TabIndex = 5;
            this.cmdNewTransaction.Text = "New transaction";
            this.cmdNewTransaction.UseVisualStyleBackColor = true;
            this.cmdNewTransaction.Click += new System.EventHandler(this.cmdNewTransaction_Click);
            // 
            // cmdCloseAccount
            // 
            this.cmdCloseAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCloseAccount.Location = new System.Drawing.Point(578, 227);
            this.cmdCloseAccount.Name = "cmdCloseAccount";
            this.cmdCloseAccount.Size = new System.Drawing.Size(148, 36);
            this.cmdCloseAccount.TabIndex = 6;
            this.cmdCloseAccount.Text = "Close account";
            this.cmdCloseAccount.UseVisualStyleBackColor = true;
            this.cmdCloseAccount.Click += new System.EventHandler(this.cmdCloseAccount_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAllTransactions.Location = new System.Drawing.Point(212, 281);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(146, 36);
            this.cmdAllTransactions.TabIndex = 8;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // cmdWithdrawal
            // 
            this.cmdWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdWithdrawal.Location = new System.Drawing.Point(578, 281);
            this.cmdWithdrawal.Name = "cmdWithdrawal";
            this.cmdWithdrawal.Size = new System.Drawing.Size(148, 36);
            this.cmdWithdrawal.TabIndex = 9;
            this.cmdWithdrawal.Text = "Withdrawal";
            this.cmdWithdrawal.UseVisualStyleBackColor = true;
            this.cmdWithdrawal.Click += new System.EventHandler(this.cmdWithdrawal_Click);
            // 
            // cmdDeposit
            // 
            this.cmdDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeposit.Location = new System.Drawing.Point(387, 281);
            this.cmdDeposit.Name = "cmdDeposit";
            this.cmdDeposit.Size = new System.Drawing.Size(163, 36);
            this.cmdDeposit.TabIndex = 10;
            this.cmdDeposit.Text = "Deposit";
            this.cmdDeposit.UseVisualStyleBackColor = true;
            this.cmdDeposit.Click += new System.EventHandler(this.cmdDeposit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(749, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 281);
            this.label2.TabIndex = 11;
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btnAddNewCard
            // 
            this.btnAddNewCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCard.Location = new System.Drawing.Point(212, 227);
            this.btnAddNewCard.Name = "btnAddNewCard";
            this.btnAddNewCard.Size = new System.Drawing.Size(146, 36);
            this.btnAddNewCard.TabIndex = 18;
            this.btnAddNewCard.Text = "Add new card";
            this.btnAddNewCard.UseVisualStyleBackColor = true;
            this.btnAddNewCard.Click += new System.EventHandler(this.btnAddNewCard_Click);
            // 
            // btnUnblockBlockedCard
            // 
            this.btnUnblockBlockedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnblockBlockedCard.Location = new System.Drawing.Point(387, 227);
            this.btnUnblockBlockedCard.Name = "btnUnblockBlockedCard";
            this.btnUnblockBlockedCard.Size = new System.Drawing.Size(163, 36);
            this.btnUnblockBlockedCard.TabIndex = 19;
            this.btnUnblockBlockedCard.Text = "Unblock blocked card";
            this.btnUnblockBlockedCard.UseVisualStyleBackColor = true;
            // 
            // dGVShortAccountInfo
            // 
            this.dGVShortAccountInfo.AllowUserToAddRows = false;
            this.dGVShortAccountInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVShortAccountInfo.Location = new System.Drawing.Point(23, 53);
            this.dGVShortAccountInfo.Name = "dGVShortAccountInfo";
            this.dGVShortAccountInfo.ReadOnly = true;
            this.dGVShortAccountInfo.RowHeadersVisible = false;
            this.dGVShortAccountInfo.Size = new System.Drawing.Size(703, 90);
            this.dGVShortAccountInfo.TabIndex = 20;
            // 
            // dGVCards
            // 
            this.dGVCards.AllowUserToAddRows = false;
            this.dGVCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCards.Location = new System.Drawing.Point(764, 53);
            this.dGVCards.Name = "dGVCards";
            this.dGVCards.ReadOnly = true;
            this.dGVCards.RowHeadersVisible = false;
            this.dGVCards.Size = new System.Drawing.Size(306, 189);
            this.dGVCards.TabIndex = 21;
            // 
            // lblAccountInfotext
            // 
            this.lblAccountInfotext.AutoSize = true;
            this.lblAccountInfotext.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblAccountInfotext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInfotext.Location = new System.Drawing.Point(23, 34);
            this.lblAccountInfotext.Name = "lblAccountInfotext";
            this.lblAccountInfotext.Size = new System.Drawing.Size(79, 13);
            this.lblAccountInfotext.TabIndex = 22;
            this.lblAccountInfotext.Text = "Account info";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(991, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 27);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCardsInfo
            // 
            this.lblCardsInfo.AutoSize = true;
            this.lblCardsInfo.BackColor = System.Drawing.Color.Lavender;
            this.lblCardsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardsInfo.Location = new System.Drawing.Point(764, 34);
            this.lblCardsInfo.Name = "lblCardsInfo";
            this.lblCardsInfo.Size = new System.Drawing.Size(64, 13);
            this.lblCardsInfo.TabIndex = 24;
            this.lblCardsInfo.Text = "Cards info";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(633, 336);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 27);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmClientManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 375);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblCardsInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAccountInfotext);
            this.Controls.Add(this.dGVCards);
            this.Controls.Add(this.dGVShortAccountInfo);
            this.Controls.Add(this.btnUnblockBlockedCard);
            this.Controls.Add(this.btnAddNewCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdDeposit);
            this.Controls.Add(this.cmdWithdrawal);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdCloseAccount);
            this.Controls.Add(this.cmdNewTransaction);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.lblAccountInfo);
            this.Name = "frmClientManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account management";
            ((System.ComponentModel.ISupportInitialize)(this.dGVShortAccountInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdNewTransaction;
        private System.Windows.Forms.Button cmdCloseAccount;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.Button cmdWithdrawal;
        private System.Windows.Forms.Button cmdDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewCard;
        private System.Windows.Forms.Button btnUnblockBlockedCard;
        private System.Windows.Forms.DataGridView dGVShortAccountInfo;
        private System.Windows.Forms.DataGridView dGVCards;
        private System.Windows.Forms.Label lblAccountInfotext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCardsInfo;
        private System.Windows.Forms.Button btnRefresh;
    }
}