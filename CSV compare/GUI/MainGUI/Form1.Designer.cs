namespace CSV_compare
{
    partial class CSV_Compare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileOneSelect = new MetroFramework.Controls.MetroButton();
            this.FileLocationOne = new MetroFramework.Controls.MetroLabel();
            this.FileTwoSelect = new MetroFramework.Controls.MetroButton();
            this.FileLocationTwo = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select First File";
            // 
            // FileOneSelect
            // 
            this.FileOneSelect.Location = new System.Drawing.Point(51, 84);
            this.FileOneSelect.Name = "FileOneSelect";
            this.FileOneSelect.Size = new System.Drawing.Size(95, 23);
            this.FileOneSelect.TabIndex = 0;
            this.FileOneSelect.Text = "Select File One";
            this.FileOneSelect.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // FileLocationOne
            // 
            this.FileLocationOne.AutoSize = true;
            this.FileLocationOne.Location = new System.Drawing.Point(168, 88);
            this.FileLocationOne.Name = "FileLocationOne";
            this.FileLocationOne.Size = new System.Drawing.Size(111, 19);
            this.FileLocationOne.TabIndex = 1;
            this.FileLocationOne.Text = "File One Location";
            // 
            // FileTwoSelect
            // 
            this.FileTwoSelect.Location = new System.Drawing.Point(51, 128);
            this.FileTwoSelect.Name = "FileTwoSelect";
            this.FileTwoSelect.Size = new System.Drawing.Size(95, 23);
            this.FileTwoSelect.TabIndex = 2;
            this.FileTwoSelect.Text = "Select File Two";
            this.FileTwoSelect.Click += new System.EventHandler(this.FileTwoSelect_Click);
            // 
            // FileLocationTwo
            // 
            this.FileLocationTwo.AutoSize = true;
            this.FileLocationTwo.Location = new System.Drawing.Point(168, 132);
            this.FileLocationTwo.Name = "FileLocationTwo";
            this.FileLocationTwo.Size = new System.Drawing.Size(109, 19);
            this.FileLocationTwo.TabIndex = 3;
            this.FileLocationTwo.Text = "File Two Location";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Location = new System.Drawing.Point(228, 256);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 23);
            this.metroLabel3.TabIndex = 0;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(51, 189);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(926, 500);
            this.ContentPanel.TabIndex = 4;
            // 
            // CSV_Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 716);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.FileLocationTwo);
            this.Controls.Add(this.FileTwoSelect);
            this.Controls.Add(this.FileLocationOne);
            this.Controls.Add(this.FileOneSelect);
            this.Name = "CSV_Compare";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "CSV Compare";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroButton FileOneSelect;
        private MetroFramework.Controls.MetroButton FileTwoSelect;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroLabel FileLocationOne;
        public MetroFramework.Controls.MetroLabel FileLocationTwo;
        private System.Windows.Forms.Panel ContentPanel;
    }
}

