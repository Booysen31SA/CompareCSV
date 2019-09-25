using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSV_compare;
using CSV_compare.MD5;
using CSV_compare.SaveDiaglog;
using CSV_compare.infoOnFile;
using System.Text.RegularExpressions;

namespace CSV_compare.GUI.ViewFile
{
    public partial class ViewFileForm : MetroFramework.Forms.MetroForm
    {
        private string[] words;
        private String OldText = "";
        private md5Hash getMd5hash = new md5Hash();

        public ViewFileForm()
        {
            InitializeComponent();
        }

        private void ViewFileForm_Load(object sender, EventArgs e)
        {
            FilePathLabel.Text = CSV_Compare.SetFilePath;
            FileNameLabel.Text = Path.GetFileName(CSV_Compare.SetFilePath);
            setFileText();
            this.OldText = getMd5hash.CreateMD5(fileText.Text);
        }

        private void setFileText()
        {
            String file = "";
            using (StreamReader f1 = new StreamReader(CSV_Compare.SetFilePath))
            {
                int lineNumber = 0;
                using (new PleaseWait(this.Location))
                {
                    while (!f1.EndOfStream)
                    {
                        lineNumber++;
                        var line1 = f1.ReadLine().Replace(";", "; ");

                        if (line1 != null)
                        {
                            file += string.Format("{0}\r\n", line1);
                            fileText.Text = file;
                        }
                    }//End of While
                }
                FileInfo();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FileInfo()
        {
            forFileData i = new forFileData();
            using (new PleaseWait(this.Location))
            {
                FileInfo file = new FileInfo(CSV_Compare.SetFilePath);
                long size = file.Length;
                FileSieInfo.Text = i.FileSize(size);
                CreatedFile.Text = i.FileLastCreated(file.CreationTime);
                lastMod.Text =i. LastModified(file.LastWriteTime);
                FileExtention.Text = i.Extension(file.Extension);
            }
        }


        private void EditAndSave()
        {
            SaveFile saveFile = new SaveFile();
            
                String md5 = getMd5hash.CreateMD5(fileText.Text);
                if(OldText == md5)
                {
                    MessageBox.Show("Nothing has Changed", "Nothing has Changed");
                }
                else
                {
                    String fileLocation = saveFile.saveFileDialog(FileNameLabel.Text);
                    File.WriteAllText(fileLocation, fileText.Text);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            EditAndSave();
            Save.BackColor = Color.LawnGreen;
        }

        private void Find_Click(object sender, EventArgs e)
        {
            fileText.SelectionStart = 0;
            fileText.SelectAll();
            fileText.SelectionBackColor = Color.White;
            findAWord();
        }

        private void findAWord()
        {
            words = FindAWordTextBox.Text.Split(';');
            using (new PleaseWait(this.Location))
            {
                foreach (string word in words)
                {
                    int startindex = 0;
                    while (startindex < fileText.TextLength)
                    {
                        int wordstartIndex = fileText.Find(word, startindex, RichTextBoxFinds.None);
                        if (wordstartIndex != -1)
                        {
                            fileText.SelectionStart = wordstartIndex;
                            fileText.SelectionLength = word.Length;
                            fileText.SelectionBackColor = Color.Yellow;
                        }
                        else
                            break;
                        startindex += wordstartIndex + word.Length;
                    }
                }
            }
        }

        private void Replace_Click(object sender, EventArgs e)
        {
            using (new PleaseWait(this.Location))
            {
                if (FindAWordTextBox.Text.Length <= 0)
                {
                    MessageBox.Show("Please Enter a value in the find TextBox");
                }
                else if (ReplaceText.Text.Length <= 0)
                {
                    MessageBox.Show("Please Enter a value in the replace TextBox");

                }
                else
                {
                    String OldString = fileText.Text;
                    String NewString = Regex.Replace(fileText.Text, FindAWordTextBox.Text, ReplaceText.Text, RegexOptions.IgnoreCase);
                    fileText.Text = NewString;
                }
            }
        }
    }
}