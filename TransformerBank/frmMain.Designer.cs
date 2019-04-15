namespace TransformerBank
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
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.numtxtCardNumber = new Controls.NumericTextBox();
            this.numtxtPin = new Controls.NumericTextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCardNumber.Location = new System.Drawing.Point(45, 254);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(78, 13);
            this.lblCardNumber.TabIndex = 0;
            this.lblCardNumber.Text = "Card number";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPin.Location = new System.Drawing.Point(45, 283);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(28, 13);
            this.lblPin.TabIndex = 1;
            this.lblPin.Text = "PIN";
            // 
            // numtxtCardNumber
            // 
            this.numtxtCardNumber.Location = new System.Drawing.Point(129, 247);
            this.numtxtCardNumber.Name = "numtxtCardNumber";
            this.numtxtCardNumber.Size = new System.Drawing.Size(164, 20);
            this.numtxtCardNumber.TabIndex = 2;
            // 
            // numtxtPin
            // 
            this.numtxtPin.Location = new System.Drawing.Point(129, 276);
            this.numtxtPin.Name = "numtxtPin";
            this.numtxtPin.Size = new System.Drawing.Size(164, 20);
            this.numtxtPin.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOK.Location = new System.Drawing.Point(297, 326);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransformerBank.Properties.Resources.bank_islam;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.numtxtPin);
            this.Controls.Add(this.numtxtCardNumber);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblCardNumber);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblPin;
        private Controls.NumericTextBox numtxtCardNumber;
        private Controls.NumericTextBox numtxtPin;
        private System.Windows.Forms.Button btnOK;
    }
}

