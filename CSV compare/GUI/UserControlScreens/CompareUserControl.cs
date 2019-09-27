using CSV_compare.Compare;
using CSV_compare.GUI.ViewFile;
using CSV_compare.line;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CSV_compare.GUI.UserControlScreens
{
    public partial class CompareUserControl : UserControl
    {
        private CSV_Compare CSV_Compare = new CSV_Compare();
        private static CompareUserControl _instance;
        public static bool IsReady = false;
        public static String FilePathName = "";

        public CompareUserControl()
        {
            InitializeComponent();
        }

        public static CompareUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CompareUserControl();
                }
                return _instance;
            }
        }

        private void CompareUserControl_Load(object sender, EventArgs e)
        {
            Compare.Enabled = false;
            CompareBox.WordWrap = false;

            LineBox.ScrollBars = ScrollBars.Both;
            LineBox.WordWrap = false;

            //view files
            ViewFileOne.Enabled = false;
            ViewFileOne.Visible = false;
            ViewFileTwo.Enabled = false;
            ViewFileTwo.Visible = false;
        }

        private void Compare_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsReady == true)
                {
                    using (new PleaseWait(this.Location))
                    {
                        Thread.Sleep(1000);
                        CompareText compare = new CompareText();
                        CompareBox.Text = compare.compareText(CSV_Compare.SetFilePathOne, CSV_Compare.SetFilePathTwo);

                        LineShow showLine = new LineShow();
                        LineBox.Text = showLine.CompareLine(CSV_Compare.SetFilePathOne, CSV_Compare.SetFilePathTwo);
                        IsReady = false;
                    }
                }
                else { MessageBox.Show("Please Change file, Its already been compared"); }
            }
            catch (Exception)
            {
                MessageBox.Show("Error\r\nPlease Retry", "Error");
            }
        }

        private void ViewFileOne_Click(object sender, EventArgs e)
        {
            FilePathName = CSV_Compare.SetFilePathOne;
            ViewFileForm form = new ViewFileForm();
            form.Show();
        }

        private void ViewFileTwo_Click(object sender, EventArgs e)
        {
            FilePathName = CSV_Compare.SetFilePathTwo;
            ViewFileForm form = new ViewFileForm();
            form.Show();
        }
    }
}