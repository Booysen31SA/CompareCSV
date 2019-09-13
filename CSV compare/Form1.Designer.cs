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
            this.Compare = new MetroFramework.Controls.MetroButton();
            this.CompareBox = new System.Windows.Forms.TextBox();
            this.LineBox = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Select First File";
            // 
            // FileOneSelect
            // 
            this.FileOneSelect.Location = new System.Drawing.Point(48, 122);
            this.FileOneSelect.Name = "FileOneSelect";
            this.FileOneSelect.Size = new System.Drawing.Size(95, 23);
            this.FileOneSelect.TabIndex = 0;
            this.FileOneSelect.Text = "Select File One";
            this.FileOneSelect.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // FileLocationOne
            // 
            this.FileLocationOne.AutoSize = true;
            this.FileLocationOne.Location = new System.Drawing.Point(48, 171);
            this.FileLocationOne.Name = "FileLocationOne";
            this.FileLocationOne.Size = new System.Drawing.Size(111, 19);
            this.FileLocationOne.TabIndex = 1;
            this.FileLocationOne.Text = "File One Location";
            // 
            // FileTwoSelect
            // 
            this.FileTwoSelect.Location = new System.Drawing.Point(656, 122);
            this.FileTwoSelect.Name = "FileTwoSelect";
            this.FileTwoSelect.Size = new System.Drawing.Size(92, 23);
            this.FileTwoSelect.TabIndex = 2;
            this.FileTwoSelect.Text = "Select File Two";
            this.FileTwoSelect.Click += new System.EventHandler(this.FileTwoSelect_Click);
            // 
            // FileLocationTwo
            // 
            this.FileLocationTwo.AutoSize = true;
            this.FileLocationTwo.Location = new System.Drawing.Point(656, 171);
            this.FileLocationTwo.Name = "FileLocationTwo";
            this.FileLocationTwo.Size = new System.Drawing.Size(109, 19);
            this.FileLocationTwo.TabIndex = 3;
            this.FileLocationTwo.Text = "File Two Location";
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(48, 233);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(75, 23);
            this.Compare.TabIndex = 4;
            this.Compare.Text = "Compare";
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // CompareBox
            // 
            this.CompareBox.Location = new System.Drawing.Point(228, 316);
            this.CompareBox.Multiline = true;
            this.CompareBox.Name = "CompareBox";
            this.CompareBox.Size = new System.Drawing.Size(445, 372);
            this.CompareBox.TabIndex = 5;
            // 
            // LineBox
            // 
            this.LineBox.Location = new System.Drawing.Point(48, 316);
            this.LineBox.Multiline = true;
            this.LineBox.Name = "LineBox";
            this.LineBox.Size = new System.Drawing.Size(174, 372);
            this.LineBox.TabIndex = 6;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 294);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Line Difference";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(228, 294);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Summary";
            // 
            // CSV_Compare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 711);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LineBox);
            this.Controls.Add(this.CompareBox);
            this.Controls.Add(this.Compare);
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
        private MetroFramework.Controls.MetroLabel FileLocationOne;
        private MetroFramework.Controls.MetroButton FileTwoSelect;
        private MetroFramework.Controls.MetroLabel FileLocationTwo;
        private MetroFramework.Controls.MetroButton Compare;
        private System.Windows.Forms.TextBox CompareBox;
        private System.Windows.Forms.TextBox LineBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

