/* Gavin Rodgers
 * 3309 ATM Project
 * This GlobalDataClass handles and stores all the instantiation for the forms and classes
 * Last edited: 10/13/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ATM;
using System.Windows.Forms;

namespace ATM
{
    public static class GlobalDataClass
    {
        // NOTE:
        //       Static methods of a class may be called without instantiating the class
        //              They called from the class itself
        //       Static objects or variables may be accessed without creating an instance of the class
        //              that contains them
        //       When you declare a class as static, all its members are automatically static

        private static string currentFilePath = "C:\\Users\\gavinr\\source\\repos\\ATM\\ATM\\CurrentATMBankFile.txt";
      //  private static string updatedFilePath = "C:\\Users\\gavinr\\source\\repos\\ATM\\ATMUpdatedATMBankFile.txt";

        // Application classes
        public static ATMBankClass ATMBank = new ATMBankClass();
        public static CustomerClass customer = new CustomerClass();
        public static currentFileClass currentFile = new currentFileClass(currentFilePath);
    //    public static updatedFileClass updatedFile = new updatedFileClass(updatedFilePath);

        // Creating instances of all the forms ...
        public static Form TransactionCompleteForm = new frmTransactionComplete();
        public static Form TransactionEntryForm = new frmTransactionEntry();
        // Only need these two (below) forms once so there is no need to instantiate them global and public.  We Instatiate them as we need them
        public static Form PinIDEntryForm = new frmPinIDEntry();
        public static Form SplashStartForm = new frmForm1();

        // For communication between forms ...
        public static string FormsCode = "";

    } // end Global Data Class

} // end namespace
