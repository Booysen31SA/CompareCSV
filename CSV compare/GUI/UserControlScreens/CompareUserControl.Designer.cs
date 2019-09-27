namespace CSV_compare.GUI.UserControlScreens
{
    partial class CompareUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompareBox = new System.Windows.Forms.RichTextBox();
            this.ViewFileTwo = new MetroFramework.Controls.MetroButton();
            this.ViewFileOne = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LineBox = new System.Windows.Forms.TextBox();
            this.Compare = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CompareBox
            // 
            this.CompareBox.Location = new System.Drawing.Point(183, 101);
            this.CompareBox.Name = "CompareBox";
            this.CompareBox.Size = new System.Drawing.Size(658, 372);
            this.CompareBox.TabIndex = 20;
            this.CompareBox.Text = "";
            // 
            // ViewFileTwo
            // 
            this.ViewFileTwo.Location = new System.Drawing.Point(272, 20);
            this.ViewFileTwo.Name = "ViewFileTwo";
            this.ViewFileTwo.Size = new System.Drawing.Size(83, 23);
            this.ViewFileTwo.TabIndex = 19;
            this.ViewFileTwo.Text = "View File two";
            this.ViewFileTwo.Click += new System.EventHandler(this.ViewFileTwo_Click);
            // 
            // ViewFileOne
            // 
            this.ViewFileOne.Location = new System.Drawing.Point(183, 20);
            this.ViewFileOne.Name = "ViewFileOne";
            this.ViewFileOne.Size = new System.Drawing.Size(83, 23);
            this.ViewFileOne.TabIndex = 18;
            this.ViewFileOne.Text = "View File one";
            this.ViewFileOne.Click += new System.EventHandler(this.ViewFileOne_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(183, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Summary";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Line Difference";
            // 
            // LineBox
            // 
            this.LineBox.Location = new System.Drawing.Point(3, 101);
            this.LineBox.Multiline = true;
            this.LineBox.Name = "LineBox";
            this.LineBox.Size = new System.Drawing.Size(174, 372);
            this.LineBox.TabIndex = 14;
            // 
            // Compare
            // 
            this.Compare.Location = new System.Drawing.Point(3, 20);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(75, 23);
            this.Compare.TabIndex = 13;
            this.Compare.Text = "Compare";
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // CompareUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CompareBox);
            this.Controls.Add(this.ViewFileTwo);
            this.Controls.Add(this.ViewFileOne);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.LineBox);
            this.Controls.Add(this.Compare);
            this.Name = "CompareUserControl";
            this.Size = new System.Drawing.Size(926, 500);
            this.Load += new System.EventHandler(this.CompareUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CompareBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox LineBox;
        public MetroFramework.Controls.MetroButton ViewFileTwo;
        public MetroFramework.Controls.MetroButton ViewFileOne;
        public MetroFramework.Controls.MetroButton Compare;
    }
}
