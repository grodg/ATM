/* Gavin Rodgers
 * 3309 ATM Project
 * This class handles the code form the account entry form
 * Last edited: 10/13/18
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ATM;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM
{
   
    public partial class frmForm1 : Form
    {
        //initializes the account entry form
        public frmForm1()
        {
            InitializeComponent();
        }
       //handles the find me button and searches for an account match, loads form 2 if match found
        private void btnFindMe_Click(object sender, EventArgs e)
        {
            GlobalDataClass.ATMBank.Tries();
            if (txtAccountNumber.Text.Length == GlobalDataClass.ATMBank.checkAccountLength())
            {
                string account = txtAccountNumber.Text;
                btnFindMe.Enabled = false;
                Boolean found = false;
                GlobalDataClass.ATMBank.findCustomerRecord(account, ref found);

                if (found)
                {
                   
                    GlobalDataClass.ATMBank.CountReset();
                    this.Hide();
                    Form Form1 = new frmPinIDEntry();                    
                    Form1.ShowDialog();                  
                    this.Visible = false;
                    this.Close();
                    
                }
               else if (!found)
                {                   
                    btnFindMe.Enabled = true;
                    txtAccountNumber.Text = "";
                    MessageBox.Show("Please reenter Account Number\n" + "Remaining Tries: "
                    + GlobalDataClass.ATMBank.remainingTries().ToString(), "Account Not Found");
                }
              
            }
           else if(txtAccountNumber.Text.Length != GlobalDataClass.ATMBank.checkAccountLength())
           {
                    MessageBox.Show("Please Enter a valid 5 digit account number\n" + "Remaining Tries: "
                    + GlobalDataClass.ATMBank.remainingTries().ToString(), "Entry Invalid");
                    txtAccountNumber.Text = "";
                    txtAccountNumber.Focus();
           }
           if (GlobalDataClass.ATMBank.accountTry() == true)
           {
                MessageBox.Show("Please See Manager", "Account Locked");
                this.Close();
           }
            GlobalDataClass.ATMBank.rewindFiles();
        }
        //empty event handler
        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
