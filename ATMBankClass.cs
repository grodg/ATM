/*Gavin Rodgers
 * 3309 ATM project
 * This ATM class handles the bank class files searching and writing
 * Last Edited: 10/13/18
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ATM
{
    public class ATMBankClass
    {
        // Bank parameters (Named constants defined by the bank)

        // The Files the Bank Owns
        private static string currentFilePath = "C:\\Users\\gavinr\\source\\repos\\ATM\\ATM\\CurrentATMBankFile.txt";
        private static string updatedFilePath = "C:\\Users\\gavinr\\source\\repos\\ATM\\ATM\\UpdatedATMBankFile.txt";

        private currentFileClass currentFile = new currentFileClass(currentFilePath);
        private updatedFileClass updatedFile = new updatedFileClass(updatedFilePath);

        // Exact length of legal accounts for Bailed Out Bank
        private int hiddenAccountLength = 5;

        // Number of attempts Bailed Out Bank allows a user before terminating ATM Session
        private int hiddenTryCountMax = 3;

        // Maximum withdrawal amount bank allows per day
        private decimal hiddenWDAmount = Convert.ToDecimal(500.0);

        // Constructor for the ATM Bank Class ...
        public ATMBankClass()
        {

        }
        //Find customer record given the entered account
        public string findCustomerRecord(string account, ref Boolean found)
        {
            string nextRecord;
            Boolean isEndOfFile = true;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            found = false;
            while (!isEndOfFile)
            {
                if (GlobalDataClass.customer.customerMatch(account, nextRecord))
                {
                    found = true;
                    return (nextRecord);
                }
                else
                {
                    updatedFile.putNextRecord(nextRecord);
                    nextRecord = currentFile.getNextRecord(ref isEndOfFile);
                } // end If
            } //end While

            return (nextRecord);
        } //end find Customer Record


        // Writes a single record (such as a modified record) to the updated file
        public void writeOut(string record)
        {
            updatedFile.putNextRecord(record);
        }  // end writeOut


        // Copies remaining records from currentFile to updatedFile.
        public void CopyRemainingRecords()
        {
            Boolean isEndOfFile = false;
            string nextRecord;

            nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                updatedFile.putNextRecord(nextRecord);
                nextRecord = currentFile.getNextRecord(ref isEndOfFile);
            } // end While

            MessageBox.Show("End of program execution." + "\n"
                + "The number of records read is: " + currentFile.getRecordsReadCount().ToString() + "\n"
                + "The number of records written is: " + updatedFile.getRecordsWrittenCount().ToString());
        } // end CopyRemaingRecords

        public void CountReset()
        {
            hiddenTryCountMax = 3;
        }
        //increments the amount of tries a user uses to enter their bank account credentials
        public void Tries()
        {
            hiddenTryCountMax--;
        }
        //returns whether user has exceeded their amount of tries
        public Boolean accountTry()
        {
            if (hiddenTryCountMax == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //uses this to print remaining user tries
        public int remainingTries()
            {
            return hiddenTryCountMax ;
            }
        //confirms user entered the right length bank account
        public int checkAccountLength()
        {
            return hiddenAccountLength;
        }

        //makes sure user doesn't withdraw more than daily limit
        public decimal DailyWDAmount()
        {
            return hiddenWDAmount;
        }
        //rewinds the files to be searched again
        public void rewindFiles()
        {
            currentFile.rewindFile();
            updatedFile.rewindFile();
        }  // end rewindFiles

        //closes the files at program exit
        public void closeFiles()
        {
            currentFile.closeFile();
            updatedFile.closeFile();
        }  // end close files

    } // end ATMBankClass

} // end ATM_Simulation_Project_CSharp
