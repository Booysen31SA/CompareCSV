namespace CSV_compare.GUI.ViewFile
{
    partial class ViewFileForm
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
            this.FileName = new MetroFramework.Controls.MetroLabel();
            this.FilePath = new MetroFramework.Controls.MetroLabel();
            this.FileNameLabel = new MetroFramework.Controls.MetroLabel();
            this.FilePathLabel = new MetroFramework.Controls.MetroLabel();
            this.fileText = new System.Windows.Forms.TextBox();
            this.Back = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.FileSieInfo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.CreatedFile = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lastMod = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.FileExtention = new MetroFramework.Controls.MetroLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.Save = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(63, 105);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(69, 19);
            this.FileName.TabIndex = 0;
            this.FileName.Text = "File Name";
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Location = new System.Drawing.Point(63, 139);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(58, 19);
            this.FilePath.TabIndex = 1;
            this.FilePath.Text = "File Path";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(162, 105);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(64, 19);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "File Label";
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(162, 139);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(93, 19);
            this.FilePathLabel.TabIndex = 3;
            this.FilePathLabel.Text = "File Path Label";
            // 
            // fileText
            // 
            this.fileText.Location = new System.Drawing.Point(63, 209);
            this.fileText.Multiline = true;
            this.fileText.Name = "fileText";
            this.fileText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileText.Size = new System.Drawing.Size(476, 391);
            this.fileText.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(63, 63);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.Style = MetroFramework.MetroColorStyle.Red;
            this.Back.TabIndex = 7;
            this.Back.Text = "Back";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(599, 209);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "File Size";
            // 
            // FileSieInfo
            // 
            this.FileSieInfo.AutoSize = true;
            this.FileSieInfo.Location = new System.Drawing.Point(697, 208);
            this.FileSieInfo.Name = "FileSieInfo";
            this.FileSieInfo.Size = new System.Drawing.Size(128, 19);
            this.FileSieInfo.TabIndex = 9;
            this.FileSieInfo.Text = "File Size Information";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(599, 240);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Created";
            // 
            // CreatedFile
            // 
            this.CreatedFile.AutoSize = true;
            this.CreatedFile.Location = new System.Drawing.Point(697, 240);
            this.CreatedFile.Name = "CreatedFile";
            this.CreatedFile.Size = new System.Drawing.Size(105, 19);
            this.CreatedFile.TabIndex = 11;
            this.CreatedFile.Text = "File was Created";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(599, 270);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(88, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Last Modified";
            // 
            // lastMod
            // 
            this.lastMod.AutoSize = true;
            this.lastMod.Location = new System.Drawing.Point(697, 270);
            this.lastMod.Name = "lastMod";
            this.lastMod.Size = new System.Drawing.Size(88, 19);
            this.lastMod.TabIndex = 13;
            this.lastMod.Text = "Last modified";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(599, 298);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(63, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Extension";
            // 
            // FileExtention
            // 
            this.FileExtention.AutoSize = true;
            this.FileExtention.Location = new System.Drawing.Point(697, 298);
            this.FileExtention.Name = "FileExtention";
            this.FileExtention.Size = new System.Drawing.Size(87, 19);
            this.FileExtention.TabIndex = 15;
            this.FileExtention.Text = "File Extension";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(599, 338);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Edit and Save";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(599, 378);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.Style = MetroFramework.MetroColorStyle.Red;
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ViewFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 623);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.FileExtention);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lastMod);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.CreatedFile);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.FileSieInfo);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.fileText);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FileName);
            this.Name = "ViewFileForm";
            this.Text = "View File ";
            this.Load += new System.EventHandler(this.ViewFileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel FileName;
        private MetroFramework.Controls.MetroLabel FilePath;
        private MetroFramework.Controls.MetroLabel FileNameLabel;
        private MetroFramework.Controls.MetroLabel FilePathLabel;
        private System.Windows.Forms.TextBox fileText;
        private MetroFramework.Controls.MetroButton Back;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel FileSieInfo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel CreatedFile;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lastMod;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel FileExtention;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton Save;
    }
}