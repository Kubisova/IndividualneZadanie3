namespace TransformerBank
{
    partial class frmMenu
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.numtxtAmount = new Controls.NumericTextBox();
            this.btnOkWithdrawal = new System.Windows.Forms.Button();
            this.btnCancelWithdrawal = new System.Windows.Forms.Button();
            this.btnBalanceOK = new System.Windows.Forms.Button();
            this.btnCancelBalance = new System.Windows.Forms.Button();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnAccountBalance = new System.Windows.Forms.Button();
            this.txtAccountBalance = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(90, 86);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // numtxtAmount
            // 
            this.numtxtAmount.Location = new System.Drawing.Point(148, 83);
            this.numtxtAmount.Name = "numtxtAmount";
            this.numtxtAmount.Size = new System.Drawing.Size(179, 20);
            this.numtxtAmount.TabIndex = 2;
            // 
            // btnOkWithdrawal
            // 
            this.btnOkWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOkWithdrawal.Location = new System.Drawing.Point(162, 109);
            this.btnOkWithdrawal.Name = "btnOkWithdrawal";
            this.btnOkWithdrawal.Size = new System.Drawing.Size(75, 23);
            this.btnOkWithdrawal.TabIndex = 3;
            this.btnOkWithdrawal.Text = "OK";
            this.btnOkWithdrawal.UseVisualStyleBackColor = true;
            this.btnOkWithdrawal.Click += new System.EventHandler(this.btnOkWithdrawal_Click);
            // 
            // btnCancelWithdrawal
            // 
            this.btnCancelWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancelWithdrawal.Location = new System.Drawing.Point(252, 109);
            this.btnCancelWithdrawal.Name = "btnCancelWithdrawal";
            this.btnCancelWithdrawal.Size = new System.Drawing.Size(75, 23);
            this.btnCancelWithdrawal.TabIndex = 4;
            this.btnCancelWithdrawal.Text = "Cancel";
            this.btnCancelWithdrawal.UseVisualStyleBackColor = true;
            this.btnCancelWithdrawal.Click += new System.EventHandler(this.btnCancelWithdrawal_Click);
            // 
            // btnBalanceOK
            // 
            this.btnBalanceOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBalanceOK.Location = new System.Drawing.Point(162, 212);
            this.btnBalanceOK.Name = "btnBalanceOK";
            this.btnBalanceOK.Size = new System.Drawing.Size(75, 23);
            this.btnBalanceOK.TabIndex = 5;
            this.btnBalanceOK.Text = "OK";
            this.btnBalanceOK.UseVisualStyleBackColor = true;
            this.btnBalanceOK.Click += new System.EventHandler(this.btnBalanceOK_Click);
            // 
            // btnCancelBalance
            // 
            this.btnCancelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancelBalance.Location = new System.Drawing.Point(252, 212);
            this.btnCancelBalance.Name = "btnCancelBalance";
            this.btnCancelBalance.Size = new System.Drawing.Size(75, 23);
            this.btnCancelBalance.TabIndex = 6;
            this.btnCancelBalance.Text = "Cancel";
            this.btnCancelBalance.UseVisualStyleBackColor = true;
            this.btnCancelBalance.Click += new System.EventHandler(this.btnCancelBalance_Click);
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnWithdrawal.Location = new System.Drawing.Point(12, 41);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(135, 23);
            this.btnWithdrawal.TabIndex = 7;
            this.btnWithdrawal.Text = "Withdrawal";
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
            // 
            // btnAccountBalance
            // 
            this.btnAccountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAccountBalance.Location = new System.Drawing.Point(12, 147);
            this.btnAccountBalance.Name = "btnAccountBalance";
            this.btnAccountBalance.Size = new System.Drawing.Size(135, 23);
            this.btnAccountBalance.TabIndex = 8;
            this.btnAccountBalance.Text = "Account balance";
            this.btnAccountBalance.UseVisualStyleBackColor = true;
            this.btnAccountBalance.Click += new System.EventHandler(this.btnAccountBalance_Click);
            // 
            // txtAccountBalance
            // 
            this.txtAccountBalance.Location = new System.Drawing.Point(148, 186);
            this.txtAccountBalance.Name = "txtAccountBalance";
            this.txtAccountBalance.Size = new System.Drawing.Size(179, 20);
            this.txtAccountBalance.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Location = new System.Drawing.Point(12, 259);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 303);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtAccountBalance);
            this.Controls.Add(this.btnAccountBalance);
            this.Controls.Add(this.btnWithdrawal);
            this.Controls.Add(this.btnCancelBalance);
            this.Controls.Add(this.btnBalanceOK);
            this.Controls.Add(this.btnCancelWithdrawal);
            this.Controls.Add(this.btnOkWithdrawal);
            this.Controls.Add(this.numtxtAmount);
            this.Controls.Add(this.lblAmount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximumSize = new System.Drawing.Size(377, 342);
            this.MinimumSize = new System.Drawing.Size(377, 342);
            this.Name = "frmMenu";
            this.Text = "ATM Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private Controls.NumericTextBox numtxtAmount;
        private System.Windows.Forms.Button btnOkWithdrawal;
        private System.Windows.Forms.Button btnCancelWithdrawal;
        private System.Windows.Forms.Button btnBalanceOK;
        private System.Windows.Forms.Button btnCancelBalance;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnAccountBalance;
        private System.Windows.Forms.TextBox txtAccountBalance;
        private System.Windows.Forms.Button btnExit;
    }
}