namespace VttSrtConverter
{
    partial class MainForm
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
            this.convertButton = new System.Windows.Forms.Button();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.fileByFileRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.recursiveFolderRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recursiveFolderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.browseRecursiveFolderButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(12, 393);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(343, 30);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(12, 585);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(90, 13);
            this.websiteLabel.TabIndex = 8;
            this.websiteLabel.Text = "AhmedOsama.me";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 442);
            this.logTextBox.MaxLength = 92767;
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(343, 140);
            this.logTextBox.TabIndex = 9;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(12, 426);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(84, 13);
            this.logLabel.TabIndex = 10;
            this.logLabel.Text = "Conversion Log:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(327, 585);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 11;
            this.versionLabel.Text = "v2.1";
            // 
            // fileByFileRadioButton
            // 
            this.fileByFileRadioButton.AutoSize = true;
            this.fileByFileRadioButton.Checked = true;
            this.fileByFileRadioButton.Location = new System.Drawing.Point(12, 12);
            this.fileByFileRadioButton.Name = "fileByFileRadioButton";
            this.fileByFileRadioButton.Size = new System.Drawing.Size(101, 17);
            this.fileByFileRadioButton.TabIndex = 12;
            this.fileByFileRadioButton.TabStop = true;
            this.fileByFileRadioButton.Text = "Select file by file";
            this.fileByFileRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputFolderTextBox);
            this.groupBox1.Controls.Add(this.outputFolderLabel);
            this.groupBox1.Controls.Add(this.browseButton);
            this.groupBox1.Controls.Add(this.deleteAllButton);
            this.groupBox1.Controls.Add(this.deleteSelectedButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.filesListBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 227);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Location = new System.Drawing.Point(96, 194);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(153, 20);
            this.outputFolderTextBox.TabIndex = 14;
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.Location = new System.Drawing.Point(12, 199);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(74, 13);
            this.outputFolderLabel.TabIndex = 13;
            this.outputFolderLabel.Text = "Output Folder:";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(255, 193);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Location = new System.Drawing.Point(255, 92);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAllButton.TabIndex = 11;
            this.deleteAllButton.Text = "Clear";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(255, 45);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(75, 41);
            this.deleteSelectedButton.TabIndex = 10;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(255, 16);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.HorizontalScrollbar = true;
            this.filesListBox.Location = new System.Drawing.Point(12, 16);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesListBox.Size = new System.Drawing.Size(237, 173);
            this.filesListBox.TabIndex = 8;
            // 
            // recursiveFolderRadioButton
            // 
            this.recursiveFolderRadioButton.AutoSize = true;
            this.recursiveFolderRadioButton.Location = new System.Drawing.Point(12, 273);
            this.recursiveFolderRadioButton.Name = "recursiveFolderRadioButton";
            this.recursiveFolderRadioButton.Size = new System.Drawing.Size(116, 17);
            this.recursiveFolderRadioButton.TabIndex = 14;
            this.recursiveFolderRadioButton.Text = "Recursive directory";
            this.recursiveFolderRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.recursiveFolderTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.browseRecursiveFolderButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 86);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search recursively all file with .vtt extension and created a corresponding .srt " +
    "file. If .srt file exists it will be replaced.";
            // 
            // recursiveFolderTextBox
            // 
            this.recursiveFolderTextBox.Location = new System.Drawing.Point(57, 54);
            this.recursiveFolderTextBox.Name = "recursiveFolderTextBox";
            this.recursiveFolderTextBox.Size = new System.Drawing.Size(192, 20);
            this.recursiveFolderTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Folder:";
            // 
            // browseRecursiveFolderButton
            // 
            this.browseRecursiveFolderButton.Location = new System.Drawing.Point(255, 53);
            this.browseRecursiveFolderButton.Name = "browseRecursiveFolderButton";
            this.browseRecursiveFolderButton.Size = new System.Drawing.Size(75, 23);
            this.browseRecursiveFolderButton.TabIndex = 15;
            this.browseRecursiveFolderButton.Text = "Browse...";
            this.browseRecursiveFolderButton.UseVisualStyleBackColor = true;
            this.browseRecursiveFolderButton.Click += new System.EventHandler(this.browseRecursiveFolderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 606);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.recursiveFolderRadioButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileByFileRadioButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.websiteLabel);
            this.Controls.Add(this.convertButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebVTT to SubRip Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.RadioButton fileByFileRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.RadioButton recursiveFolderRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox recursiveFolderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseRecursiveFolderButton;
        private System.Windows.Forms.Label label1;
    }
}

