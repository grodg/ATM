/*Gavin Rodgers
 * 3309 ATM Project
 * This the Pin and ID entry code that handles the second form of ATM for pin and name entry
 * Last edited: 10/13/18
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
    public partial class frmPinIDEntry : Form
    {
        //Initializes the pin ID entry form
        public frmPinIDEntry()
        {
            InitializeComponent();    
        }
        //handles the OK click buttons to confirm the user credentials, loads frmTransactionEntry 
        //if match is found
        private void btnOK_Click(object sender, EventArgs e)
        {
            GlobalDataClass.ATMBank.Tries();
            if (txtPIN.Text.Length == 4 && GlobalDataClass.ATMBank.accountTry() == false)
            {
                int access = GlobalDataClass.customer.VerifyNumberAndPin(txtName.Text, txtPIN.Text);
                if (access == 3)
                {
                    GlobalDataClass.FormsCode = "frmTransactionEntry";
                    this.Hide();
                    Form frmPinIDEntry = new frmTransactionEntry();
                    frmPinIDEntry.ShowDialog();
                    this.Visible = false;
                    this.Close();
                }
                else if (access == 1)
                {
                  
                    txtName.Text = "";
                    txtName.Focus();
                }
                else if(access == 2)
                {
                   
                    txtPIN.Text = "";
                    txtPIN.Focus();
                }               
            }
            else if(GlobalDataClass.ATMBank.accountTry() == true)
            {
                MessageBox.Show("Please go see bank Manager", "Account Locked");
                this.Close();
                
            }
            else if(txtPIN.Text.Length != 4)
            {
                MessageBox.Show("Please Enter a valid name and 4 digit Pin number \n"+ "Remaining Tries: " 
                    + GlobalDataClass.ATMBank.remainingTries().ToString(), "Entry Error");
            }
            
        }
    }
}
