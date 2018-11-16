/* Gavin Rodgers
 * 3309 ATM Project
 * This class handles and stores all the information about the user operating the ATM
 * Last edited: 10/13/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM
{
    public class CustomerClass
    {
        string [] customer;
        string recordAccountNumber;
        string recordName;
        string recordPin;
        decimal recordChkBalance;
        decimal recordSavBalance;
        int recordTransactionNumber;
       
        public CustomerClass()
        {

        }
       
        //Match customer account against bank file
        public Boolean customerMatch(string account, string record)
        {
            customer = record.Split('*');
            int customerSize = customer.GetLength(0);
            for(int i = 0; i <= customerSize - 1; i++)
            {
                customer[i] = customer[i].Trim();
            }
            recordAccountNumber = customer[0];
            if (account == recordAccountNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //This method is used to verify users number and pin ID for validation
        public int VerifyNumberAndPin(string Name, string Pin)
        {
            int NameandPinOK;
            recordName = customer[1];
            recordPin = customer[2];
            NameandPinOK = 0;
            if (Pin == recordPin && Name == recordName)
            {
                return NameandPinOK = 3;
            }
            if (Name != recordName)
            {
                MessageBox.Show("(" + Name + ") entered does not match name on account."
                    + " Please reenter,\n" + "Remaining Tries: "
                    + GlobalDataClass.ATMBank.remainingTries().ToString(), "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                NameandPinOK = 1;
            }
            if(Pin != recordPin)
            {
                MessageBox.Show("(" + Pin + ") entered does not match Pin on account."
                    + " Please reenter,\n" + "Remaining Tries: "
                    + GlobalDataClass.ATMBank.remainingTries().ToString(), "Pin Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                NameandPinOK = 2;
            }
            return NameandPinOK = 0;
        }
        //this method is used to carry out the transactions based off what the user enters
        public string modifyCustomerRecord(int transactionCode, decimal amount)
        {
            string newRecord = "";
            if (GlobalDataClass.FormsCode == "frmTransactionEntry")
            {
                recordChkBalance = Convert.ToDecimal(customer[3].Replace(",","").Replace("$",""));
                recordSavBalance = Convert.ToDecimal(customer[4].Replace(",", "").Replace("$", ""));
            }
            switch (transactionCode)
            {
                case 1:
                    recordSavBalance += amount;
                    break;
                case 2:
                    recordChkBalance += amount;
                    break;
                case 3:
                    if (amount < GlobalDataClass.ATMBank.DailyWDAmount())
                    {
                        if (amount <= recordSavBalance)
                        {
                            recordSavBalance -= amount;
                        }
                    }
                    else
                    {
                        MessageBox.Show("(" + amount + ") Savings withdraw exceeds your balance. Try amount, " + "Please Re-Enter",
                           "Withdraw OverDraft", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return newRecord;
                    }
                    break;
                case 4:
                    if (amount < GlobalDataClass.ATMBank.DailyWDAmount())
                    {
                        if (amount <= recordChkBalance)
                        {
                            recordChkBalance -= amount;
                        }
                    }
                    else
                    {
                        MessageBox.Show("(" + amount + ") Checking withdraw exceeds your balance. Try amount, " + "Please Re-Enter",
                           "Withdraw OverDraft", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return newRecord;
                    }
                    break;
                case 5:
                 
                    break;
                case 6:

                    break;
                case 7:
                    if (amount <= recordSavBalance)
                    {
                        recordSavBalance -= amount;
                        recordChkBalance += amount;

                    }
                    else
                    {
                        MessageBox.Show("(" + amount + ") Savings transfer exceeds your balance. Try amount, " + "Please Re-Enter",
                            "Transfer OverDraft", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return newRecord;
                    }
                    break;
                case 8:
                    if (amount <= recordChkBalance)
                    {
                        recordChkBalance -= amount;
                        recordSavBalance += amount;
                    }
                    else
                    {
                        MessageBox.Show("(" + amount + ") Checking transfer exceeds your balance. Try amount, " + "Please Re-Enter",
                            "Transfer OverDraft", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return newRecord;
                    }
                    break;                
            }
            newRecord = recordAccountNumber + "*" + recordName + "*" + recordPin +
                "*" + recordChkBalance.ToString("c") + "*" + recordSavBalance.ToString("c");
            return newRecord;
        }
       //gets the checking balance of the user
        public string checkingBalanceString()
        {
            string checking = Convert.ToString(recordChkBalance);
            return checking;
        }
        //gets the savings balance of the user
        public string savingBalanceString()
        {
            string saving = Convert.ToString(recordSavBalance);
            return saving;
        }
    }

}
