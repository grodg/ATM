namespace ATM
{
    partial class frmTransactionComplete
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
            this.lblRodgersBank = new System.Windows.Forms.Label();
            this.lblTransactionComplete = new System.Windows.Forms.Label();
            this.lblYourTransComp = new System.Windows.Forms.Label();
            this.lblWouldYouLikeToSee = new System.Windows.Forms.Label();
            this.lblBalances = new System.Windows.Forms.Label();
            this.lblAnotherTransaction = new System.Windows.Forms.Label();
            this.btnYesBalances = new System.Windows.Forms.Button();
            this.btnNoBalances = new System.Windows.Forms.Button();
            this.lblChecking = new System.Windows.Forms.Label();
            this.lblSavings = new System.Windows.Forms.Label();
            this.txtChecking = new System.Windows.Forms.TextBox();
            this.txtSavings = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRodgersBank
            // 
            this.lblRodgersBank.AutoSize = true;
            this.lblRodgersBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodgersBank.ForeColor = System.Drawing.Color.Blue;
            this.lblRodgersBank.Location = new System.Drawing.Point(132, 9);
            this.lblRodgersBank.Name = "lblRodgersBank";
            this.lblRodgersBank.Size = new System.Drawing.Size(216, 22);
            this.lblRodgersBank.TabIndex = 0;
            this.lblRodgersBank.Text = "Rodgers National Bank";
            // 
            // lblTransactionComplete
            // 
            this.lblTransactionComplete.AutoSize = true;
            this.lblTransactionComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionComplete.Location = new System.Drawing.Point(133, 46);
            this.lblTransactionComplete.Name = "lblTransactionComplete";
            this.lblTransactionComplete.Size = new System.Drawing.Size(219, 18);
            this.lblTransactionComplete.TabIndex = 1;
            this.lblTransactionComplete.Text = "Transaction Complete Form";
            // 
            // lblYourTransComp
            // 
            this.lblYourTransComp.AutoSize = true;
            this.lblYourTransComp.Location = new System.Drawing.Point(23, 96);
            this.lblYourTransComp.Name = "lblYourTransComp";
            this.lblYourTransComp.Size = new System.Drawing.Size(148, 13);
            this.lblYourTransComp.TabIndex = 2;
            this.lblYourTransComp.Text = "Your Transaction is Complete!";
            // 
            // lblWouldYouLikeToSee
            // 
            this.lblWouldYouLikeToSee.AutoSize = true;
            this.lblWouldYouLikeToSee.Location = new System.Drawing.Point(23, 150);
            this.lblWouldYouLikeToSee.Name = "lblWouldYouLikeToSee";
            this.lblWouldYouLikeToSee.Size = new System.Drawing.Size(189, 13);
            this.lblWouldYouLikeToSee.TabIndex = 3;
            this.lblWouldYouLikeToSee.Text = "Would you Like to see your Balances?";
            // 
            // lblBalances
            // 
            this.lblBalances.AutoSize = true;
            this.lblBalances.Location = new System.Drawing.Point(23, 209);
            this.lblBalances.Name = "lblBalances";
            this.lblBalances.Size = new System.Drawing.Size(148, 13);
            this.lblBalances.TabIndex = 4;
            this.lblBalances.Text = "Your Bank Balances are now:";
            this.lblBalances.Visible = false;
            // 
            // lblAnotherTransaction
            // 
            this.lblAnotherTransaction.AutoSize = true;
            this.lblAnotherTransaction.Location = new System.Drawing.Point(23, 268);
            this.lblAnotherTransaction.Name = "lblAnotherTransaction";
            this.lblAnotherTransaction.Size = new System.Drawing.Size(177, 13);
            this.lblAnotherTransaction.TabIndex = 5;
            this.lblAnotherTransaction.Text = "Would you like another transaction?";
            this.lblAnotherTransaction.Visible = false;
            // 
            // btnYesBalances
            // 
            this.btnYesBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnYesBalances.Location = new System.Drawing.Point(244, 145);
            this.btnYesBalances.Name = "btnYesBalances";
            this.btnYesBalances.Size = new System.Drawing.Size(75, 23);
            this.btnYesBalances.TabIndex = 6;
            this.btnYesBalances.Text = "Yes";
            this.btnYesBalances.UseVisualStyleBackColor = true;
            this.btnYesBalances.Click += new System.EventHandler(this.btnYesBalances_Click);
            // 
            // btnNoBalances
            // 
            this.btnNoBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNoBalances.Location = new System.Drawing.Point(361, 145);
            this.btnNoBalances.Name = "btnNoBalances";
            this.btnNoBalances.Size = new System.Drawing.Size(75, 23);
            this.btnNoBalances.TabIndex = 7;
            this.btnNoBalances.Text = "No ";
            this.btnNoBalances.UseVisualStyleBackColor = true;
            this.btnNoBalances.Click += new System.EventHandler(this.btnNoBalances_Click);
            // 
            // lblChecking
            // 
            this.lblChecking.AutoSize = true;
            this.lblChecking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChecking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblChecking.Location = new System.Drawing.Point(250, 190);
            this.lblChecking.Name = "lblChecking";
            this.lblChecking.Size = new System.Drawing.Size(60, 13);
            this.lblChecking.TabIndex = 8;
            this.lblChecking.Text = "Checking";
            this.lblChecking.Visible = false;
            // 
            // lblSavings
            // 
            this.lblSavings.AutoSize = true;
            this.lblSavings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSavings.Location = new System.Drawing.Point(372, 189);
            this.lblSavings.Name = "lblSavings";
            this.lblSavings.Size = new System.Drawing.Size(52, 13);
            this.lblSavings.TabIndex = 9;
            this.lblSavings.Text = "Savings";
            this.lblSavings.Visible = false;
            // 
            // txtChecking
            // 
            this.txtChecking.Location = new System.Drawing.Point(231, 206);
            this.txtChecking.Name = "txtChecking";
            this.txtChecking.ReadOnly = true;
            this.txtChecking.Size = new System.Drawing.Size(100, 20);
            this.txtChecking.TabIndex = 10;
            this.txtChecking.Visible = false;
            // 
            // txtSavings
            // 
            this.txtSavings.Location = new System.Drawing.Point(349, 206);
            this.txtSavings.Name = "txtSavings";
            this.txtSavings.ReadOnly = true;
            this.txtSavings.Size = new System.Drawing.Size(100, 20);
            this.txtSavings.TabIndex = 11;
            this.txtSavings.Visible = false;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnYes.Location = new System.Drawing.Point(244, 258);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 12;
            this.btnYes.Text = "Yes ";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Visible = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Red;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Location = new System.Drawing.Point(361, 258);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 13;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmTransactionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(478, 302);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.txtSavings);
            this.Controls.Add(this.txtChecking);
            this.Controls.Add(this.lblSavings);
            this.Controls.Add(this.lblChecking);
            this.Controls.Add(this.btnNoBalances);
            this.Controls.Add(this.btnYesBalances);
            this.Controls.Add(this.lblAnotherTransaction);
            this.Controls.Add(this.lblBalances);
            this.Controls.Add(this.lblWouldYouLikeToSee);
            this.Controls.Add(this.lblYourTransComp);
            this.Controls.Add(this.lblTransactionComplete);
            this.Controls.Add(this.lblRodgersBank);
            this.Name = "frmTransactionComplete";
            this.Text = "frmTransactionComplete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRodgersBank;
        private System.Windows.Forms.Label lblTransactionComplete;
        private System.Windows.Forms.Label lblYourTransComp;
        private System.Windows.Forms.Label lblWouldYouLikeToSee;
        private System.Windows.Forms.Label lblBalances;
        private System.Windows.Forms.Label lblAnotherTransaction;
        private System.Windows.Forms.Button btnYesBalances;
        private System.Windows.Forms.Button btnNoBalances;
        private System.Windows.Forms.Label lblChecking;
        private System.Windows.Forms.Label lblSavings;
        private System.Windows.Forms.TextBox txtChecking;
        private System.Windows.Forms.TextBox txtSavings;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}