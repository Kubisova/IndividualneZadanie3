namespace BankSystem
{
    partial class frmAccount
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblClientInfo = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblOverdraftLimit = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblOpNumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtOpNumber = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtStreetNumber = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.numtxtOverdraftLimit = new Controls.NumericTextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblCardsCount = new System.Windows.Forms.Label();
            this.numtxtCardsCount = new Controls.NumericTextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAccount.Location = new System.Drawing.Point(12, 9);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(297, 251);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblClientInfo
            // 
            this.lblClientInfo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblClientInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblClientInfo.Location = new System.Drawing.Point(314, 9);
            this.lblClientInfo.Name = "lblClientInfo";
            this.lblClientInfo.Size = new System.Drawing.Size(398, 251);
            this.lblClientInfo.TabIndex = 4;
            this.lblClientInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblIban.Location = new System.Drawing.Point(28, 103);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(32, 13);
            this.lblIban.TabIndex = 5;
            this.lblIban.Text = "IBAN";
            // 
            // lblOverdraftLimit
            // 
            this.lblOverdraftLimit.AutoSize = true;
            this.lblOverdraftLimit.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblOverdraftLimit.Location = new System.Drawing.Point(25, 158);
            this.lblOverdraftLimit.Name = "lblOverdraftLimit";
            this.lblOverdraftLimit.Size = new System.Drawing.Size(75, 13);
            this.lblOverdraftLimit.TabIndex = 6;
            this.lblOverdraftLimit.Text = "Overdraft Limit";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(28, 119);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(257, 20);
            this.txtIban.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblName.Location = new System.Drawing.Point(327, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblStreet.Location = new System.Drawing.Point(327, 160);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Street";
            // 
            // lblOpNumber
            // 
            this.lblOpNumber.AutoSize = true;
            this.lblOpNumber.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblOpNumber.Location = new System.Drawing.Point(327, 126);
            this.lblOpNumber.Name = "lblOpNumber";
            this.lblOpNumber.Size = new System.Drawing.Size(62, 13);
            this.lblOpNumber.TabIndex = 12;
            this.lblOpNumber.Text = "OP Number";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblSurname.Location = new System.Drawing.Point(327, 91);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Surname";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblContact.Location = new System.Drawing.Point(327, 224);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 14;
            this.lblContact.Text = "Contact";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblCity.Location = new System.Drawing.Point(327, 193);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "City";
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblStreetNumber.Location = new System.Drawing.Point(535, 160);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(75, 13);
            this.lblStreetNumber.TabIndex = 16;
            this.lblStreetNumber.Text = "Street Number";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(405, 84);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(286, 20);
            this.txtSurname.TabIndex = 17;
            // 
            // txtOpNumber
            // 
            this.txtOpNumber.Location = new System.Drawing.Point(405, 119);
            this.txtOpNumber.Name = "txtOpNumber";
            this.txtOpNumber.Size = new System.Drawing.Size(130, 20);
            this.txtOpNumber.TabIndex = 18;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(405, 153);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(123, 20);
            this.txtStreet.TabIndex = 19;
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(616, 153);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(75, 20);
            this.txtStreetNumber.TabIndex = 20;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(405, 190);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(286, 20);
            this.txtCity.TabIndex = 21;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(405, 224);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(286, 20);
            this.txtContact.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(405, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 20);
            this.txtName.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(556, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(637, 281);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSalmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Account";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.Location = new System.Drawing.Point(327, 21);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 27;
            this.lblClient.Text = "Client";
            // 
            // numtxtOverdraftLimit
            // 
            this.numtxtOverdraftLimit.Location = new System.Drawing.Point(28, 174);
            this.numtxtOverdraftLimit.Name = "numtxtOverdraftLimit";
            this.numtxtOverdraftLimit.Size = new System.Drawing.Size(100, 20);
            this.numtxtOverdraftLimit.TabIndex = 28;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblAccountName.Location = new System.Drawing.Point(25, 54);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(78, 13);
            this.lblAccountName.TabIndex = 29;
            this.lblAccountName.Text = "Account Name";
            // 
            // lblCardsCount
            // 
            this.lblCardsCount.AutoSize = true;
            this.lblCardsCount.BackColor = System.Drawing.Color.DarkSalmon;
            this.lblCardsCount.Location = new System.Drawing.Point(25, 208);
            this.lblCardsCount.Name = "lblCardsCount";
            this.lblCardsCount.Size = new System.Drawing.Size(76, 13);
            this.lblCardsCount.TabIndex = 30;
            this.lblCardsCount.Text = "Count of cards";
            // 
            // numtxtCardsCount
            // 
            this.numtxtCardsCount.Location = new System.Drawing.Point(28, 224);
            this.numtxtCardsCount.Name = "numtxtCardsCount";
            this.numtxtCardsCount.Size = new System.Drawing.Size(100, 20);
            this.numtxtCardsCount.TabIndex = 31;
            this.numtxtCardsCount.Text = "1";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(28, 70);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(257, 20);
            this.txtAccountName.TabIndex = 32;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 312);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.numtxtCardsCount);
            this.Controls.Add(this.lblCardsCount);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.numtxtOverdraftLimit);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreetNumber);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtOpNumber);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblStreetNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblOpNumber);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.lblOverdraftLimit);
            this.Controls.Add(this.lblIban);
            this.Controls.Add(this.lblClientInfo);
            this.Controls.Add(this.lblAccount);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblClientInfo;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblOverdraftLimit;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblOpNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtOpNumber;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtStreetNumber;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClient;
        private Controls.NumericTextBox numtxtOverdraftLimit;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblCardsCount;
        private Controls.NumericTextBox numtxtCardsCount;
        private System.Windows.Forms.TextBox txtAccountName;
    }
}