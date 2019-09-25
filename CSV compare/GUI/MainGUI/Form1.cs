using CSV_compare.Compare;
using CSV_compare.GUI.ViewFile;
using CSV_compare.line;
using CSV_compare.OpenDiaglog;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CSV_compare
{
    public partial class CSV_Compare : MetroFramework.Forms.MetroForm
    {

        public static String SetFilePath = "File One Name";

        private bool IsReady = false;
        public CSV_Compare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Compare.Enabled = false;
            CompareBox.ScrollBars = ScrollBars.Both;
            CompareBox.WordWrap = false;

            LineBox.ScrollBars = ScrollBars.Both;
            LineBox.WordWrap = false;

            //view files
            ViewFileOne.Enabled = false;
            ViewFileOne.Visible = false;
            ViewFileTwo.Enabled = false;
            ViewFileTwo.Visible = false;
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            openDialog openFirstFile = new openDialog();
            FileLocationOne.Text = openFirstFile.OpenFileDialogForm();
            IsReady = true;
            IsReadyText.Text = "";
            ViewFileOne.Enabled = true;
            ViewFileOne.Visible = true;
        }

        private void FileTwoSelect_Click(object sender, EventArgs e)
        {
            openDialog openFirstFile = new openDialog();
            FileLocationTwo.Text = openFirstFile.OpenFileDialogForm();
            Compare.Enabled = true;
            IsReady = true;
            IsReadyText.Text = "";
            ViewFileTwo.Enabled = true;
            ViewFileTwo.Visible = true;
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            if(IsReady == true)
            {
                using (new PleaseWait(this.Location))
                {
                    Thread.Sleep(1000);
                    CompareText compare = new CompareText();
                    CompareBox.Text = compare.compareText(FileLocationOne.Text, FileLocationTwo.Text);

                    LineShow showLine = new LineShow();
                    LineBox.Text = showLine.CompareLine(FileLocationOne.Text, FileLocationTwo.Text);
                    IsReady = false;
                }
            }
            else { IsReadyText.Text = "Please Change file, Its already been compared"; }
            
        }

        private void ViewFileOne_Click(object sender, EventArgs e)
        {

            SetFilePath = FileLocationOne.Text;
            ViewFileForm form = new ViewFileForm();
            form.Show();
        }

        private void ViewFileTwo_Click(object sender, EventArgs e)
        {
            SetFilePath = FileLocationTwo.Text;
            ViewFileForm form = new ViewFileForm();
            form.Show();
        }
    }
}
