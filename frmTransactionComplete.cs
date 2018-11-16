/* Gavin Rodgers
 * 3309 ATM Project
 * this is the code behind the form that handles form 4 and displays user balances and closes atm
 * Last edited: 10/15/18
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
    public partial class frmTransactionComplete : Form
    {
        //initializes the form
        public frmTransactionComplete()
        {
            InitializeComponent();
        }
        //copies record, closes files, and closes ATM program for no button
        private void button4_Click(object sender, EventArgs e)
        {
            GlobalDataClass.ATMBank.CopyRemainingRecords();
            GlobalDataClass.ATMBank.closeFiles();

            this.Close();
        }

       //displays the user balances, and offers another transaction
        private void btnYesBalances_Click(object sender, EventArgs e)
        {
            btnYesBalances.Enabled = false;
            lblBalances.Visible = true;
            lblChecking.Visible = true;
            lblSavings.Visible = true;
            txtChecking.Visible = true;
            txtSavings.Visible = true;
            btnNoBalances.Enabled = false;
            btnNo.Visible = true;
            btnYes.Visible = true;
            txtChecking.Text = GlobalDataClass.customer.checkingBalanceString();
            txtSavings.Text = GlobalDataClass.customer.savingBalanceString();
            lblAnotherTransaction.Visible = true;
        }
        //doesnt display user balances, and offers another transaction
        private void btnNoBalances_Click(object sender, EventArgs e)
        {
            btnNoBalances.Enabled = false;
            btnYesBalances.Enabled = false;
            btnYes.Visible = true;
            btnNo.Visible = true;
            lblAnotherTransaction.Visible = true;
            
        }
        //loads another transaction. closes form complete, opens transaction entry form
        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frmTransactionEntry = new frmTransactionEntry();
            frmTransactionEntry.ShowDialog();
            this.Visible = false;
            this.Close();
        }

      
    }
}
