using CSV_compare.GUI.UserControlScreens;
using CSV_compare.OpenDiaglog;
using System;
using System.Windows.Forms;

namespace CSV_compare
{
    public partial class CSV_Compare : MetroFramework.Forms.MetroForm
    {
        public static String SetFilePathOne = "File One Name";
        public static String SetFilePathTwo = "File One Name";

        public static String SetFilePath = "File One Name";
        //private CompareUserControl User = new CompareUserControl();

        public CSV_Compare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Compare();
            startUp();
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            openDialog openFirstFile = new openDialog();
            FileLocationOne.Text = openFirstFile.OpenFileDialogForm();
            CompareUserControl.IsReady = true;
            CompareUserControl.Instance.ViewFileOne.Enabled = true;
            CompareUserControl.Instance.ViewFileOne.Visible = true;
            SetFilePathOne = FileLocationOne.Text;
            Compare();
        }

        private void FileTwoSelect_Click(object sender, EventArgs e)
        {
            openDialog openFirstFile = new openDialog();
            FileLocationTwo.Text = openFirstFile.OpenFileDialogForm();
            CompareUserControl.Instance.Compare.Enabled = true;
            CompareUserControl.IsReady = true;
            CompareUserControl.Instance.ViewFileTwo.Enabled = true;
            CompareUserControl.Instance.ViewFileTwo.Visible = true;
            SetFilePathTwo = FileLocationTwo.Text;
        }

        private void startUp()
        {
            if (!ContentPanel.Controls.Contains(StartUpUserControl.Instance))
            {
                ContentPanel.Controls.Add(StartUpUserControl.Instance);
                StartUpUserControl.Instance.Dock = DockStyle.Fill;
                StartUpUserControl.Instance.BringToFront();
            }
            else
            {

                StartUpUserControl.Instance.BringToFront();
            }
        }
        private void Compare()
        {
            if (!ContentPanel.Controls.Contains(CompareUserControl.Instance))
            {
                ContentPanel.Controls.Add(CompareUserControl.Instance);
                CompareUserControl.Instance.Dock = DockStyle.Fill;
                CompareUserControl.Instance.BringToFront();
            }
            else
            {

                CompareUserControl.Instance.BringToFront();
            }
        }

    }
}
