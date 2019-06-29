namespace vtt_to_srt
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
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.deleteAllButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputFolderLabel = new System.Windows.Forms.Label();
            this.outputFolderTextBox = new System.Windows.Forms.TextBox();
            this.websiteLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filesListBox
            // 
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.HorizontalScrollbar = true;
            this.filesListBox.Location = new System.Drawing.Point(12, 12);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.filesListBox.Size = new System.Drawing.Size(237, 212);
            this.filesListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(255, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add...";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(255, 41);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(75, 41);
            this.deleteSelectedButton.TabIndex = 2;
            this.deleteSelectedButton.Text = "Delete Selected";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.Location = new System.Drawing.Point(255, 88);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(75, 23);
            this.deleteAllButton.TabIndex = 3;
            this.deleteAllButton.Text = "Clear";
            this.deleteAllButton.UseVisualStyleBackColor = true;
            this.deleteAllButton.Click += new System.EventHandler(this.DeleteAllButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(255, 229);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(255, 258);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // outputFolderLabel
            // 
            this.outputFolderLabel.AutoSize = true;
            this.outputFolderLabel.Location = new System.Drawing.Point(12, 235);
            this.outputFolderLabel.Name = "outputFolderLabel";
            this.outputFolderLabel.Size = new System.Drawing.Size(71, 13);
            this.outputFolderLabel.TabIndex = 6;
            this.outputFolderLabel.Text = "Output folder:";
            // 
            // outputFolderTextBox
            // 
            this.outputFolderTextBox.Location = new System.Drawing.Point(94, 230);
            this.outputFolderTextBox.Name = "outputFolderTextBox";
            this.outputFolderTextBox.Size = new System.Drawing.Size(155, 20);
            this.outputFolderTextBox.TabIndex = 7;
            // 
            // websiteLabel
            // 
            this.websiteLabel.AutoSize = true;
            this.websiteLabel.Location = new System.Drawing.Point(2, 285);
            this.websiteLabel.Name = "websiteLabel";
            this.websiteLabel.Size = new System.Drawing.Size(90, 13);
            this.websiteLabel.TabIndex = 8;
            this.websiteLabel.Text = "AhmedOsama.me";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(255, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Convert Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.websiteLabel);
            this.Controls.Add(this.outputFolderTextBox);
            this.Controls.Add(this.outputFolderLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.filesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebVTT to SubRip Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button deleteAllButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputFolderLabel;
        private System.Windows.Forms.TextBox outputFolderTextBox;
        private System.Windows.Forms.Label websiteLabel;
        private System.Windows.Forms.Button button1;
    }
}

