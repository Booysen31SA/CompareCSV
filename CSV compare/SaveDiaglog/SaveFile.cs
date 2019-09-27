using System;
using System.Windows.Forms;

namespace CSV_compare.SaveDiaglog
{
    internal class SaveFile
    {
        public String SaveFileDialog(String fileName)
        {
            String location = "";
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog
            {
                RestoreDirectory = true,
                Filter = "csv Files (*.csv)|*.csv|txt Files(*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Browse Text Files",
                DefaultExt = "txt",
                CheckPathExists = true,
                FileName = fileName
            };

            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                location = SaveFileDialog1.FileName;
            }
            return location;
        }
    }
}