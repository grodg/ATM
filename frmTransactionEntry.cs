/* Gavin Rodgers
 * 3309 ATM project 
 * this form handles all of the transaction entries that the user performs
 * last edited: 10/15/18
 */ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmTransactionEntry : Form
    {
        //initializes the transaction entry form
        public frmTransactionEntry()
        {
            InitializeComponent();
        }
        //event handler for savings deposit transaction
        private void btnSavingsDeposit_Click(object sender, EventArgs e)
        {
            TransactionButtons();
            disableButtons();
            btnSavingsDeposit.BackColor = Color.Orange;

        }
        //event handler for savings withdraw transaction
        private void btnSavingsWithdraw_Click(object sender, EventArgs e)
        {
            TransactionButtons();
            disableButtons();
            btnSavingsWithdraw.BackColor = Color.Orange;

        }
        //event handler for savings balance transaction
        private void btnSavingsBalance_Click(object sender, EventArgs e)
        {
            BalanceButtons();
            disableButtons();
            btnSavingsBalance.BackColor = Color.Orange;
        }
        //event handler for transfer savings to checking transaction
        private void btnTransferSavChk_Click(object sender, EventArgs e)
        {
            TransactionButtons();
            disableButtons();
            btnTransferSavChk.BackColor = Color.Orange;
        }
        //event handler for checking deposit transaction
        private void btnCheckingDeposit_Click(object sender, EventArgs e)
        {
            TransactionButtons();
            disableButtons();
            btnCheckingDeposit.BackColor = Color.Orange;
        }
        //event handler for checking withdraw transaction 
        private void btnCheckingWithdraw_Click(object sender, EventArgs e)
        {
            TransactionButtons();
            disableButtons();
            btnCheckingWithdraw.BackColor = Color.Orange;
        }
        //event handler for checking balance transaction
        private void btnCheckingBalance_Click(object sender, EventArgs e)
        {
            BalanceButtons();
            disableButtons();
            btnCheckingBalance.BackColor = Color.Orange;

        }
        //event handler for transfer checking to savings transaction
        private void button8_Click(object sender, EventArgs e)
        {
            TransactionButtons();
            disableButtons();   
            btnTransferChkSav.BackColor = Color.Orange;
        }
        //handles the transaction process based on users select and amount entry
        private void btnYes_Click(object sender, EventArgs e)
        {
            decimal input;
            if (btnSavingsDeposit.BackColor == System.Drawing.Color.Orange)
            {
                input = Convert.ToDecimal(txtAmount.Text);
                GlobalDataClass.ATMBank.writeOut(GlobalDataClass.customer.modifyCustomerRecord(1, input));
            }
            if (btnCheckingDeposit.BackColor == System.Drawing.Color.Orange)
            {
                input = Convert.ToDecimal(txtAmount.Text);
                GlobalDataClass.ATMBank.writeOut(GlobalDataClass.customer.modifyCustomerRecord(2, input));
            }
            if (btnSavingsWithdraw.BackColor == System.Drawing.Color.Orange)
            {
                input = Convert.ToDecimal(txtAmount.Text);
                GlobalDataClass.ATMBank.writeOut(GlobalDataClass.customer.modifyCustomerRecord(3, input));
               
            }
            if (btnCheckingWithdraw.BackColor == System.Drawing.Color.Orange)
            {
                input = Convert.ToDecimal(txtAmount.Text);
                GlobalDataClass.ATMBank.writeOut(GlobalDataClass.customer.modifyCustomerRecord(4, input));
              
            }
            if (btnSavingsBalance.BackColor == System.Drawing.Color.Orange)
            {
                GlobalDataClass.ATMBank.writeOut(GlobalDataClass.customer.modifyCustomerRecord(7, 0.0m));

            }
            if (btnCheckingBalance.BackColor == System.Drawing.Color.Orange)
            {
               
                GlobalDataClass.ATMBank.writeOut(GlobalDataClass.customer.modifyCustomerRecord(7, 0.0m));

            }
            if (btnTransferSavChk.BackColor == System.Drawing.Color.Orange)
            {
                input = Convert.ToDecimal(txtAmount.Text);
                GlobalDataClass.ATMBank.writeOut(GlobalDataClass.customer.modifyCustomerRecord(7, input));
               
            }
            if (btnTransferChkSav.BackColor == System.Drawing.Color.Orange)
            {
                input = Convert.ToDecimal(txtAmount.Text);
                GlobalDataClass.ATMBank.writeOut(GlobalDataClass.customer.modifyCustomerRecord(8, input));
               
            }
            GlobalDataClass.FormsCode = "frmTransactionComplete";
            this.Hide();
            Form frmTransactionEntry = new frmTransactionComplete();
            frmTransactionEntry.ShowDialog();
            this.Visible = false;
            this.Close();
        }
        //if user denies the transaction, this resets the board and transaction buttons
        private void btnNo_Click(object sender, EventArgs e)
        {
            lblSelectAmount.Visible = false;
            btnOK.Visible = false;
            txtAmount.Visible = false;
            btnSavingsBalance.Enabled = true;
            btnCheckingBalance.Enabled = true;
            btnSavingsDeposit.Enabled = true;
            btnCheckingDeposit.Enabled = true;
            btnSavingsWithdraw.Enabled = true;
            btnCheckingWithdraw.Enabled = true;
            btnTransferSavChk.Enabled = true;
            btnTransferChkSav.Enabled = true;
            lblYouSelected.Visible = false;
            lblMarkedTransaction.Visible = false;
            txtYouSelected.Visible = false;
            btnYes.Visible = false;
            btnNo.Visible = false;
            btnSavingsBalance.BackColor = default(Color);
            btnCheckingBalance.BackColor = default(Color);
            btnSavingsDeposit.BackColor = default(Color);
            btnCheckingDeposit.BackColor = default(Color);
            btnSavingsWithdraw.BackColor = default(Color);
            btnCheckingWithdraw.BackColor = default(Color);
            btnTransferSavChk.BackColor = default(Color);
            btnTransferChkSav.BackColor = default(Color);
            lblBalanceCorrect.Visible = false;
            txtAmount.Text = "";
            txtYouSelected.Text = "";
                
        }
        //ok button event handler
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                decimal input = Convert.ToDecimal(txtAmount.Text);
                if (txtAmount.Text != "" && input > 0 )
                {
                    lblYouSelected.Visible = true;
                    lblMarkedTransaction.Visible = true;
                    txtYouSelected.Visible = true;
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnOK.Enabled = false;
                    txtYouSelected.Text = txtAmount.Text;                   
                }
                else
                {
                    MessageBox.Show("Please enter a value", "Input Error");
                    txtAmount.Text = "";
                    txtAmount.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid input amount without punctuation", "Input Error");
                txtAmount.Text = "";
                txtAmount.Focus();
            }

        }
        //disables buttons when transaction button is clicked
        public void disableButtons()
        {     
            btnSavingsBalance.Enabled = false;
            btnCheckingBalance.Enabled = false;
            btnSavingsDeposit.Enabled = false;
            btnCheckingDeposit.Enabled = false;
            btnSavingsWithdraw.Enabled = false;
            btnCheckingWithdraw.Enabled = false;
            btnTransferSavChk.Enabled = false;
            btnTransferChkSav.Enabled = false;
        }
        //enables the form components for the balance buttons
        public void BalanceButtons()
        {
            lblBalanceCorrect.Visible = true;
            btnNo.Visible = true;
            btnYes.Visible = true;
        }
        //enables the form components for the transaction buttons
        public void TransactionButtons()
        {
            lblSelectAmount.Visible = true;
            btnOK.Visible = true;
            txtAmount.Visible = true;
        }
    }
}
