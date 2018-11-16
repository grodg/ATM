/* Gavin Rodgers
 * 3309 ATM Project
 * This class handles and stores all the information for the updated file class
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
    public class updatedFileClass
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW;   // Reference variable of type SR
        private int recordWrittenCount;
     //creates the constructor to bring in the path to the updated file 
        public updatedFileClass(string filePath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate Program.",
                            "Output File Connection Error.",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end Try
        }
        //gets amount of records written out to updated file 
        public int getRecordsWrittenCount()
        {
            return recordWrittenCount;
        }
        //writes out the next record to the updated file
        public void putNextRecord(string nextRecord)
        {
            try
            {
                updatedFileSW.WriteLine(nextRecord);
            }
            catch { MessageBox.Show("Record didnt write to file", "File Error"); }
            recordWrittenCount++;
        }
        //closes the updated file
        public void closeFile()
        {
            updatedFileSW.Close();
        }
        //rewinds the updated file
        public void rewindFile()
        {
            recordWrittenCount = 0;
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

        }
    }
}
