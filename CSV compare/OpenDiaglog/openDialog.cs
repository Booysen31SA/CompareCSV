using System;
using System.Windows.Forms;

namespace CSV_compare.OpenDiaglog
{
    internal class openDialog
    {
        public String OpenFileDialogForm()
        {
            String name = "Please Select File";

            OpenFileDialog firstFile = new OpenFileDialog
            {
                RestoreDirectory = true,
                Filter = "csv Files (*.csv)|*.csv|txt Files(*.txt)|*.txt",
                CheckFileExists = true,
            };

            if (firstFile.ShowDialog() == DialogResult.OK)
            {
                name = firstFile.FileName;
            }
            else { return name; }

            //multiple Files Select
            //this.openFileDialog1.Multiselect = true;
            // foreach (String file in openFileDialog1.FileNames)
            // {
            //     MessageBox.Show(file);
            // }
            return name;
        }//end of method
    }
}