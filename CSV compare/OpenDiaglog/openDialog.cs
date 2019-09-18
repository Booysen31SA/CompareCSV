using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_compare.OpenDiaglog
{
    class openDialog
    {
        public String OpenFileDialogForm()
        {
            String name = "Please Select File";

            OpenFileDialog firstFile = new OpenFileDialog
            {
                RestoreDirectory = true,
                Filter = "csv Files (*.csv)|*.csv",
                CheckFileExists = true,
            };
            
            if(firstFile.ShowDialog() == DialogResult.OK)
            {
                name = firstFile.FileName;
            }
            else { return name;}

            //multiple Files Select
            //this.openFileDialog1.Multiselect = true;
           // foreach (String file in openFileDialog1.FileNames)
           // {
           //     MessageBox.Show(file);
           // }
            return name;
        }
    }
}
