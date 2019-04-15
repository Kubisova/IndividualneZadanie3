namespace BankSystem
{
    partial class frmTransaction
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
            this.lblSender = new System.Windows.Forms.Label();
            this.lblAccountOfRecipient = new System.Windows.Forms.Label();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.numtxtAmmount = new Controls.NumericTextBox();
            this.txtSenderAccout = new System.Windows.Forms.TextBox();
            this.txtRecipientAccount = new System.Windows.Forms.TextBox();
            this.lblSS = new System.Windows.Forms.Label();
            this.lblKS = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblMessageForRecipient = new System.Windows.Forms.Label();
            this.txtMessageForRecipient = new System.Windows.Forms.TextBox();
            this.numtxtKS = new Controls.NumericTextBox();
            this.numtxtVS = new Controls.NumericTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.Location = new System.Drawing.Point(26, 69);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(111, 13);
            this.lblSender.TabIndex = 0;
            this.lblSender.Text = "Account of sender";
            // 
            // lblAccountOfRecipient
            // 
            this.lblAccountOfRecipient.AutoSize = true;
            this.lblAccountOfRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountOfRecipient.Location = new System.Drawing.Point(26, 104);
            this.lblAccountOfRecipient.Name = "lblAccountOfRecipient";
            this.lblAccountOfRecipient.Size = new System.Drawing.Size(122, 13);
            this.lblAccountOfRecipient.TabIndex = 1;
            this.lblAccountOfRecipient.Text = "Account of recipient";
            // 
            // lblAmmount
            // 
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmount.Location = new System.Drawing.Point(26, 35);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmmount.TabIndex = 2;
            this.lblAmmount.Text = "Amount";
            // 
            // numtxtAmmount
            // 
            this.numtxtAmmount.Location = new System.Drawing.Point(164, 28);
            this.numtxtAmmount.Name = "numtxtAmmount";
            this.numtxtAmmount.Size = new System.Drawing.Size(174, 20);
            this.numtxtAmmount.TabIndex = 3;
            // 
            // txtSenderAccout
            // 
            this.txtSenderAccout.Location = new System.Drawing.Point(164, 66);
            this.txtSenderAccout.Name = "txtSenderAccout";
            this.txtSenderAccout.ReadOnly = true;
            this.txtSenderAccout.Size = new System.Drawing.Size(293, 20);
            this.txtSenderAccout.TabIndex = 4;
            // 
            // txtRecipientAccount
            // 
            this.txtRecipientAccount.Location = new System.Drawing.Point(164, 101);
            this.txtRecipientAccount.Name = "txtRecipientAccount";
            this.txtRecipientAccount.Size = new System.Drawing.Size(293, 20);
            this.txtRecipientAccount.TabIndex = 5;
            // 
            // lblSS
            // 
            this.lblSS.AutoSize = true;
            this.lblSS.Location = new System.Drawing.Point(22, 142);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(80, 13);
            this.lblSS.TabIndex = 6;
            this.lblSS.Text = "Specific symbol";
            // 
            // lblKS
            // 
            this.lblKS.AutoSize = true;
            this.lblKS.Location = new System.Drawing.Point(22, 175);
            this.lblKS.Name = "lblKS";
            this.lblKS.Size = new System.Drawing.Size(84, 13);
            this.lblKS.TabIndex = 7;
            this.lblKS.Text = "Konstant symbol";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.Location = new System.Drawing.Point(22, 206);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(76, 13);
            this.lblVS.TabIndex = 8;
            this.lblVS.Text = "Variabil symbol";
            // 
            // lblMessageForRecipient
            // 
            this.lblMessageForRecipient.AutoSize = true;
            this.lblMessageForRecipient.Location = new System.Drawing.Point(22, 241);
            this.lblMessageForRecipient.Name = "lblMessageForRecipient";
            this.lblMessageForRecipient.Size = new System.Drawing.Size(108, 13);
            this.lblMessageForRecipient.TabIndex = 9;
            this.lblMessageForRecipient.Text = "Message for recipient";
            // 
            // txtMessageForRecipient
            // 
            this.txtMessageForRecipient.Location = new System.Drawing.Point(164, 238);
            this.txtMessageForRecipient.Name = "txtMessageForRecipient";
            this.txtMessageForRecipient.Size = new System.Drawing.Size(293, 20);
            this.txtMessageForRecipient.TabIndex = 10;
            // 
            // numtxtKS
            // 
            this.numtxtKS.Location = new System.Drawing.Point(164, 168);
            this.numtxtKS.Name = "numtxtKS";
            this.numtxtKS.Size = new System.Drawing.Size(100, 20);
            this.numtxtKS.TabIndex = 12;
            // 
            // numtxtVS
            // 
            this.numtxtVS.Location = new System.Drawing.Point(164, 203);
            this.numtxtVS.Name = "numtxtVS";
            this.numtxtVS.Size = new System.Drawing.Size(100, 20);
            this.numtxtVS.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(280, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(382, 279);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(164, 134);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 20);
            this.txtSS.TabIndex = 16;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 318);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numtxtVS);
            this.Controls.Add(this.numtxtKS);
            this.Controls.Add(this.txtMessageForRecipient);
            this.Controls.Add(this.lblMessageForRecipient);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.lblKS);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.txtRecipientAccount);
            this.Controls.Add(this.txtSenderAccout);
            this.Controls.Add(this.numtxtAmmount);
            this.Controls.Add(this.lblAmmount);
            this.Controls.Add(this.lblAccountOfRecipient);
            this.Controls.Add(this.lblSender);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblAccountOfRecipient;
        private System.Windows.Forms.Label lblAmmount;
        private Controls.NumericTextBox numtxtAmmount;
        private System.Windows.Forms.TextBox txtSenderAccout;
        private System.Windows.Forms.TextBox txtRecipientAccount;
        private System.Windows.Forms.Label lblSS;
        private System.Windows.Forms.Label lblKS;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Label lblMessageForRecipient;
        private System.Windows.Forms.TextBox txtMessageForRecipient;
        private Controls.NumericTextBox numtxtKS;
        private Controls.NumericTextBox numtxtVS;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtSS;
    }
}