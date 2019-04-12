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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.lblOverdraftLimit = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.txtOverdraftLimit = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 245);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tu budú informácie o konkrétnom účte.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(314, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 245);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tu budú informácie o konkrétnom klientovi.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIban
            // 
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(34, 287);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(32, 13);
            this.lblIban.TabIndex = 5;
            this.lblIban.Text = "IBAN";
            // 
            // lblOverdraftLimit
            // 
            this.lblOverdraftLimit.AutoSize = true;
            this.lblOverdraftLimit.Location = new System.Drawing.Point(34, 321);
            this.lblOverdraftLimit.Name = "lblOverdraftLimit";
            this.lblOverdraftLimit.Size = new System.Drawing.Size(87, 13);
            this.lblOverdraftLimit.TabIndex = 6;
            this.lblOverdraftLimit.Text = "Limit prečerpania";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(133, 284);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(251, 20);
            this.txtIban.TabIndex = 7;
            // 
            // txtOverdraftLimit
            // 
            this.txtOverdraftLimit.Location = new System.Drawing.Point(133, 318);
            this.txtOverdraftLimit.Name = "txtOverdraftLimit";
            this.txtOverdraftLimit.Size = new System.Drawing.Size(100, 20);
            this.txtOverdraftLimit.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(437, 284);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Meno";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(440, 387);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(31, 13);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Ulica";
            // 
            // lblOpNumber
            // 
            this.lblOpNumber.AutoSize = true;
            this.lblOpNumber.Location = new System.Drawing.Point(437, 359);
            this.lblOpNumber.Name = "lblOpNumber";
            this.lblOpNumber.Size = new System.Drawing.Size(49, 13);
            this.lblOpNumber.TabIndex = 12;
            this.lblOpNumber.Text = "Číslo OP";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(437, 321);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(55, 13);
            this.lblSurname.TabIndex = 13;
            this.lblSurname.Text = "Priezvisko";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(443, 479);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 14;
            this.lblContact.Text = "Kontakt";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(443, 451);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 13);
            this.lblCity.TabIndex = 15;
            this.lblCity.Text = "Mesto";
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Location = new System.Drawing.Point(443, 417);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(71, 13);
            this.lblStreetNumber.TabIndex = 16;
            this.lblStreetNumber.Text = "Popisné číslo";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(514, 321);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(143, 20);
            this.txtSurname.TabIndex = 17;
            // 
            // txtOpNumber
            // 
            this.txtOpNumber.Location = new System.Drawing.Point(514, 352);
            this.txtOpNumber.Name = "txtOpNumber";
            this.txtOpNumber.Size = new System.Drawing.Size(143, 20);
            this.txtOpNumber.TabIndex = 18;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(521, 384);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(136, 20);
            this.txtStreet.TabIndex = 19;
            // 
            // txtStreetNumber
            // 
            this.txtStreetNumber.Location = new System.Drawing.Point(521, 417);
            this.txtStreetNumber.Name = "txtStreetNumber";
            this.txtStreetNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStreetNumber.TabIndex = 20;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(521, 451);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(136, 20);
            this.txtCity.TabIndex = 21;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(521, 479);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(136, 20);
            this.txtContact.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(514, 279);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(704, 504);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Ulož";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 543);
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
            this.Controls.Add(this.txtOverdraftLimit);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.lblOverdraftLimit);
            this.Controls.Add(this.lblIban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Label lblOverdraftLimit;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.TextBox txtOverdraftLimit;
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
    }
}