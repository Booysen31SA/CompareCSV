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
        private Button selectButton;
        private OpenFileDialog openFileDialog1;

        public String OpenFileDialogForm()
        {
            OpenFileDialog firstFile = new OpenFileDialog();
            firstFile.RestoreDirectory = true;
            firstFile.Filter = "csv Files (*.csv)|*.csv";
            firstFile.CheckFileExists = true;
            firstFile.ShowDialog();
            String name = firstFile.FileName;

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
