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
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (Directory.Exists(outputFolderTextBox.Text))
            {
                fbd.SelectedPath = outputFolderTextBox.Text;
            }

            if (fbd.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                outputFolderTextBox.Text = fbd.SelectedPath;
            }
        }

        private void browseRecursiveFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (Directory.Exists(recursiveFolderTextBox.Text))
            {
                fbd.SelectedPath = recursiveFolderTextBox.Text;
            }

            if (fbd.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                recursiveFolderTextBox.Text = fbd.SelectedPath;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (fileByFileRadioButton.Checked)
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
            else if (recursiveFolderRadioButton.Checked)
            {
                if (Directory.Exists(recursiveFolderTextBox.Text))
                {
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(recursiveFolderTextBox.Text);

                    logTextBox.Clear();
                    SwitchUIControlsEnabled();

                    WebvttSubripConverter converter = new WebvttSubripConverter();
                    WalkDirectoryTree(di, converter);

                    MessageBox.Show(Strings.convertingFinished, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SwitchUIControlsEnabled();
                }
                else
                    MessageBox.Show(Strings.noOutputFolder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WalkDirectoryTree(System.IO.DirectoryInfo root, WebvttSubripConverter converter)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            try
            {
                files = root.GetFiles("*.vtt");
            }
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show(Strings.unauthorizedAccess, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (System.IO.DirectoryNotFoundException e)
            {
                MessageBox.Show(Strings.noOutputFolder, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    logTextBox.Text += fi.FullName + Environment.NewLine;
                    try
                    {
                        converter.ConvertToSubrip(fi.FullName, root.FullName);
                        logTextBox.Text += Strings.convertedSuccessfully;
                    }
                    catch (Exception exception)
                    {
                        logTextBox.Text += "Error:: " + exception.Message;
                    }
                    logTextBox.Text += Environment.NewLine + Environment.NewLine;
                }

                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    WalkDirectoryTree(dirInfo, converter);
                }
            }
        }

        void SwitchUIControlsEnabled()
        {
            outputFolderTextBox.Enabled = !outputFolderTextBox.Enabled;
            filesListBox.Enabled = !filesListBox.Enabled;
            addButton.Enabled = !addButton.Enabled;
            deleteSelectedButton.Enabled = !deleteSelectedButton.Enabled;
            deleteAllButton.Enabled = !deleteAllButton.Enabled;
            browseButton.Enabled = !browseButton.Enabled;

            recursiveFolderTextBox.Enabled = !recursiveFolderTextBox.Enabled;
            browseRecursiveFolderButton.Enabled = !browseRecursiveFolderButton.Enabled;

            convertButton.Enabled = !convertButton.Enabled;
        }
    }

}
