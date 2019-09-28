using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using VttSrtConverter.Core;

namespace VttSrtConverter
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "WebVTT files (*.vtt)|*.vtt|All files (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(string str in openFileDialog.FileNames)
                    if(!filesListBox.Items.Contains(str))
                        filesListBox.Items.Add(str);
            }
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            foreach (int index in filesListBox.SelectedIndices)
                list.Add(index);
            list.Reverse();
            foreach (int index in list)
                filesListBox.Items.RemoveAt(index);
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            filesListBox.Items.Clear();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    outputFolderTextBox.Text = fbd.SelectedPath;
                }
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(outputFolderTextBox.Text))
            {
                logTextBox.Clear();
                SwitchUIControlsEnabled();
                WebvttSubripConverter converter = new WebvttSubripConverter();
                foreach (string inputFilePath in filesListBox.Items)
                {
                    logTextBox.Text += inputFilePath + Environment.NewLine;
                    try
                    {
                        converter.ConvertToSubrip(inputFilePath, outputFolderTextBox.Text);
                        logTextBox.Text += Strings.convertedSuccessfully;
                    }
                    catch (Exception exception)
                    {
                        logTextBox.Text += "Error:: " + exception.Message;
                    }
                    logTextBox.Text += Environment.NewLine + Environment.NewLine;
                }
                MessageBox.Show(Strings.convertingFinished, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SwitchUIControlsEnabled();
            }
            else
                MessageBox.Show(Strings.noOutputFolder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        void SwitchUIControlsEnabled()
        {
            outputFolderTextBox.Enabled = !outputFolderTextBox.Enabled;
            filesListBox.Enabled = !filesListBox.Enabled;
            addButton.Enabled = !addButton.Enabled;
            deleteSelectedButton.Enabled = !deleteSelectedButton.Enabled;
            deleteAllButton.Enabled = !deleteAllButton.Enabled;
            browseButton.Enabled = !browseButton.Enabled;
            convertButton.Enabled = !convertButton.Enabled;
        }

    }

}
