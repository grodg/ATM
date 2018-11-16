namespace ATM
{
    partial class frmTransactionEntry
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
            this.btnNo = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.txtYouSelected = new System.Windows.Forms.TextBox();
            this.lblMarkedTransaction = new System.Windows.Forms.Label();
            this.lblYouSelected = new System.Windows.Forms.Label();
            this.lblBalanceCorrect = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblSelectAmount = new System.Windows.Forms.Label();
            this.btnTransferChkSav = new System.Windows.Forms.Button();
            this.btnCheckingBalance = new System.Windows.Forms.Button();
            this.btnCheckingWithdraw = new System.Windows.Forms.Button();
            this.btnCheckingDeposit = new System.Windows.Forms.Button();
            this.btnTransferSavChk = new System.Windows.Forms.Button();
            this.btnSavingsBalance = new System.Windows.Forms.Button();
            this.btnSavingsWithdraw = new System.Windows.Forms.Button();
            this.btnSavingsDeposit = new System.Windows.Forms.Button();
            this.lblSelectTransaction = new System.Windows.Forms.Label();
            this.lblTransactionPage = new System.Windows.Forms.Label();
            this.lblRodgersBank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(306, 364);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(148, 23);
            this.btnNo.TabIndex = 39;
            this.btnNo.Text = "NO - Select Again";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(69, 364);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(148, 23);
            this.btnYes.TabIndex = 38;
            this.btnYes.Text = "YES - Process Request";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // txtYouSelected
            // 
            this.txtYouSelected.Location = new System.Drawing.Point(131, 326);
            this.txtYouSelected.Name = "txtYouSelected";
            this.txtYouSelected.ReadOnly = true;
            this.txtYouSelected.Size = new System.Drawing.Size(100, 20);
            this.txtYouSelected.TabIndex = 37;
            this.txtYouSelected.Visible = false;
            // 
            // lblMarkedTransaction
            // 
            this.lblMarkedTransaction.AutoSize = true;
            this.lblMarkedTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkedTransaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMarkedTransaction.Location = new System.Drawing.Point(237, 329);
            this.lblMarkedTransaction.Name = "lblMarkedTransaction";
            this.lblMarkedTransaction.Size = new System.Drawing.Size(262, 13);
            this.lblMarkedTransaction.TabIndex = 36;
            this.lblMarkedTransaction.Text = "And the Marked Transaction. Is this Correct?";
            this.lblMarkedTransaction.Visible = false;
            // 
            // lblYouSelected
            // 
            this.lblYouSelected.AutoSize = true;
            this.lblYouSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblYouSelected.Location = new System.Drawing.Point(42, 329);
            this.lblYouSelected.Name = "lblYouSelected";
            this.lblYouSelected.Size = new System.Drawing.Size(83, 13);
            this.lblYouSelected.TabIndex = 35;
            this.lblYouSelected.Text = "You Selected";
            this.lblYouSelected.Visible = false;
            // 
            // lblBalanceCorrect
            // 
            this.lblBalanceCorrect.AutoSize = true;
            this.lblBalanceCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceCorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBalanceCorrect.Location = new System.Drawing.Point(42, 310);
            this.lblBalanceCorrect.Name = "lblBalanceCorrect";
            this.lblBalanceCorrect.Size = new System.Drawing.Size(268, 13);
            this.lblBalanceCorrect.TabIndex = 34;
            this.lblBalanceCorrect.Text = "You Selected A Balance Only. Is this Correct?";
            this.lblBalanceCorrect.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(416, 290);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(44, 23);
            this.btnOK.TabIndex = 33;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(310, 290);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 32;
            this.txtAmount.Visible = false;
            // 
            // lblSelectAmount
            // 
            this.lblSelectAmount.AutoSize = true;
            this.lblSelectAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSelectAmount.Location = new System.Drawing.Point(42, 293);
            this.lblSelectAmount.Name = "lblSelectAmount";
            this.lblSelectAmount.Size = new System.Drawing.Size(262, 13);
            this.lblSelectAmount.TabIndex = 31;
            this.lblSelectAmount.Text = "Select an Amount in dollars (No Punctuation)";
            this.lblSelectAmount.Visible = false;
            // 
            // btnTransferChkSav
            // 
            this.btnTransferChkSav.Location = new System.Drawing.Point(310, 243);
            this.btnTransferChkSav.Name = "btnTransferChkSav";
            this.btnTransferChkSav.Size = new System.Drawing.Size(144, 23);
            this.btnTransferChkSav.TabIndex = 30;
            this.btnTransferChkSav.Text = "Transfer CHK -> SAV";
            this.btnTransferChkSav.UseVisualStyleBackColor = true;
            this.btnTransferChkSav.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCheckingBalance
            // 
            this.btnCheckingBalance.Location = new System.Drawing.Point(310, 212);
            this.btnCheckingBalance.Name = "btnCheckingBalance";
            this.btnCheckingBalance.Size = new System.Drawing.Size(144, 23);
            this.btnCheckingBalance.TabIndex = 29;
            this.btnCheckingBalance.Text = "Checking Balance";
            this.btnCheckingBalance.UseVisualStyleBackColor = true;
            this.btnCheckingBalance.Click += new System.EventHandler(this.btnCheckingBalance_Click);
            // 
            // btnCheckingWithdraw
            // 
            this.btnCheckingWithdraw.Location = new System.Drawing.Point(310, 183);
            this.btnCheckingWithdraw.Name = "btnCheckingWithdraw";
            this.btnCheckingWithdraw.Size = new System.Drawing.Size(144, 23);
            this.btnCheckingWithdraw.TabIndex = 28;
            this.btnCheckingWithdraw.Text = "Checking Withdraw";
            this.btnCheckingWithdraw.UseVisualStyleBackColor = true;
            this.btnCheckingWithdraw.Click += new System.EventHandler(this.btnCheckingWithdraw_Click);
            // 
            // btnCheckingDeposit
            // 
            this.btnCheckingDeposit.Location = new System.Drawing.Point(310, 153);
            this.btnCheckingDeposit.Name = "btnCheckingDeposit";
            this.btnCheckingDeposit.Size = new System.Drawing.Size(144, 23);
            this.btnCheckingDeposit.TabIndex = 27;
            this.btnCheckingDeposit.Text = "Checking Deposit";
            this.btnCheckingDeposit.UseVisualStyleBackColor = true;
            this.btnCheckingDeposit.Click += new System.EventHandler(this.btnCheckingDeposit_Click);
            // 
            // btnTransferSavChk
            // 
            this.btnTransferSavChk.Location = new System.Drawing.Point(69, 243);
            this.btnTransferSavChk.Name = "btnTransferSavChk";
            this.btnTransferSavChk.Size = new System.Drawing.Size(144, 23);
            this.btnTransferSavChk.TabIndex = 26;
            this.btnTransferSavChk.Text = "Transfer SAV -> CHK";
            this.btnTransferSavChk.UseVisualStyleBackColor = true;
            this.btnTransferSavChk.Click += new System.EventHandler(this.btnTransferSavChk_Click);
            // 
            // btnSavingsBalance
            // 
            this.btnSavingsBalance.Location = new System.Drawing.Point(69, 213);
            this.btnSavingsBalance.Name = "btnSavingsBalance";
            this.btnSavingsBalance.Size = new System.Drawing.Size(144, 23);
            this.btnSavingsBalance.TabIndex = 25;
            this.btnSavingsBalance.Text = "Savings Balance";
            this.btnSavingsBalance.UseVisualStyleBackColor = true;
            this.btnSavingsBalance.Click += new System.EventHandler(this.btnSavingsBalance_Click);
            // 
            // btnSavingsWithdraw
            // 
            this.btnSavingsWithdraw.Location = new System.Drawing.Point(69, 183);
            this.btnSavingsWithdraw.Name = "btnSavingsWithdraw";
            this.btnSavingsWithdraw.Size = new System.Drawing.Size(144, 23);
            this.btnSavingsWithdraw.TabIndex = 24;
            this.btnSavingsWithdraw.Text = "Savings Withdraw";
            this.btnSavingsWithdraw.UseVisualStyleBackColor = true;
            this.btnSavingsWithdraw.Click += new System.EventHandler(this.btnSavingsWithdraw_Click);
            // 
            // btnSavingsDeposit
            // 
            this.btnSavingsDeposit.Location = new System.Drawing.Point(69, 153);
            this.btnSavingsDeposit.Name = "btnSavingsDeposit";
            this.btnSavingsDeposit.Size = new System.Drawing.Size(144, 23);
            this.btnSavingsDeposit.TabIndex = 23;
            this.btnSavingsDeposit.Text = "Savings Deposit";
            this.btnSavingsDeposit.UseVisualStyleBackColor = true;
            this.btnSavingsDeposit.Click += new System.EventHandler(this.btnSavingsDeposit_Click);
            // 
            // lblSelectTransaction
            // 
            this.lblSelectTransaction.AutoSize = true;
            this.lblSelectTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTransaction.Location = new System.Drawing.Point(42, 110);
            this.lblSelectTransaction.Name = "lblSelectTransaction";
            this.lblSelectTransaction.Size = new System.Drawing.Size(179, 18);
            this.lblSelectTransaction.TabIndex = 22;
            this.lblSelectTransaction.Text = "Select A Transaction...";
            // 
            // lblTransactionPage
            // 
            this.lblTransactionPage.AutoSize = true;
            this.lblTransactionPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionPage.Location = new System.Drawing.Point(202, 77);
            this.lblTransactionPage.Name = "lblTransactionPage";
            this.lblTransactionPage.Size = new System.Drawing.Size(149, 20);
            this.lblTransactionPage.TabIndex = 21;
            this.lblTransactionPage.Text = "Transaction Page";
            // 
            // lblRodgersBank
            // 
            this.lblRodgersBank.AutoSize = true;
            this.lblRodgersBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodgersBank.ForeColor = System.Drawing.Color.Blue;
            this.lblRodgersBank.Location = new System.Drawing.Point(160, 46);
            this.lblRodgersBank.Name = "lblRodgersBank";
            this.lblRodgersBank.Size = new System.Drawing.Size(216, 22);
            this.lblRodgersBank.TabIndex = 20;
            this.lblRodgersBank.Text = "Rodgers National Bank";
            // 
            // frmTransactionEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 429);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtYouSelected);
            this.Controls.Add(this.lblMarkedTransaction);
            this.Controls.Add(this.lblYouSelected);
            this.Controls.Add(this.lblBalanceCorrect);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblSelectAmount);
            this.Controls.Add(this.btnTransferChkSav);
            this.Controls.Add(this.btnCheckingBalance);
            this.Controls.Add(this.btnCheckingWithdraw);
            this.Controls.Add(this.btnCheckingDeposit);
            this.Controls.Add(this.btnTransferSavChk);
            this.Controls.Add(this.btnSavingsBalance);
            this.Controls.Add(this.btnSavingsWithdraw);
            this.Controls.Add(this.btnSavingsDeposit);
            this.Controls.Add(this.lblSelectTransaction);
            this.Controls.Add(this.lblTransactionPage);
            this.Controls.Add(this.lblRodgersBank);
            this.Name = "frmTransactionEntry";
            this.Text = "frmTransactionEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.TextBox txtYouSelected;
        private System.Windows.Forms.Label lblMarkedTransaction;
        private System.Windows.Forms.Label lblYouSelected;
        private System.Windows.Forms.Label lblBalanceCorrect;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblSelectAmount;
        private System.Windows.Forms.Button btnTransferChkSav;
        private System.Windows.Forms.Button btnCheckingBalance;
        private System.Windows.Forms.Button btnCheckingWithdraw;
        private System.Windows.Forms.Button btnCheckingDeposit;
        private System.Windows.Forms.Button btnTransferSavChk;
        private System.Windows.Forms.Button btnSavingsBalance;
        private System.Windows.Forms.Button btnSavingsWithdraw;
        private System.Windows.Forms.Button btnSavingsDeposit;
        private System.Windows.Forms.Label lblSelectTransaction;
        private System.Windows.Forms.Label lblTransactionPage;
        private System.Windows.Forms.Label lblRodgersBank;
    }
}