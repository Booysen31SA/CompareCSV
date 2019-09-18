using CSV_compare.Compare;
using CSV_compare.line;
using CSV_compare.OpenDiaglog;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace CSV_compare
{
    public partial class CSV_Compare : MetroFramework.Forms.MetroForm
    {
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
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            openDialog openFirstFile = new openDialog();
            FileLocationOne.Text = openFirstFile.OpenFileDialogForm();
        }

        private void FileTwoSelect_Click(object sender, EventArgs e)
        {
            openDialog openFirstFile = new openDialog();
            FileLocationTwo.Text = openFirstFile.OpenFileDialogForm();
            Compare.Enabled = true;
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            using (new PleaseWait(this.Location))
            {
                Thread.Sleep(1000);
                CompareText compare = new CompareText();
                CompareBox.Text = compare.compareText(FileLocationOne.Text, FileLocationTwo.Text);

                LineShow showLine = new LineShow();
                LineBox.Text = showLine.CompareLine(FileLocationOne.Text, FileLocationTwo.Text);
            }
        }
    }
}
