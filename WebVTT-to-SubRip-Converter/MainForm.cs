using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace vtt_to_srt
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
                Filter = "WebVTT files (*.vtt)|*.vtt",
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
                SwitchUIControlsEnabled();
                foreach (string str in filesListBox.Items)
                    ConvertToSrt(str);
                MessageBox.Show("All files converted successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SwitchUIControlsEnabled();
            }
            else
                MessageBox.Show("Output folder doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        void ConvertToSrt(string filePath)
        {
            try
            {
                ConvertToSrt(filePath, outputFolderTextBox.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ConvertToSrt(string filePath, string outputPath)
        {            
            using (StreamReader stream = new StreamReader(filePath))
            {
                StringBuilder output = new StringBuilder();
                int lineNumber = 1;
                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();
                    if (IsTimecode(line))
                    {
                        output.AppendLine(lineNumber.ToString());
                        lineNumber++;
                        line = line.Replace('.', ',');
                        line = DeleteCueSettings(line);
                        line = AddHour(line);
                        output.AppendLine(line);
                        bool foundCaption = false;
                        while(true)
                        {
                            if (stream.EndOfStream)
                            {
                                if (foundCaption)
                                    break;
                                else
                                    throw new Exception("Corrupted file: Found timecode without caption");
                            }
                            line = stream.ReadLine();
                            if (String.IsNullOrEmpty(line) || String.IsNullOrWhiteSpace(line))
                            {
                                output.AppendLine();
                                break;
                            }
                            foundCaption = true;
                            output.AppendLine(line);
                        }
                    }
                }
                string fileName = Path.GetFileNameWithoutExtension(filePath) + ".srt";
                using (StreamWriter outputFile = new StreamWriter(outputPath + '\\' + fileName))
                    outputFile.Write(output);
            }            
        }

        bool IsTimecode(string line)
        {
            return line.Contains("-->");
        }

        string DeleteCueSettings(string line)
        {
            StringBuilder output = new StringBuilder();
            foreach (char ch in line)
            {
                char chLower = Char.ToLower(ch);
                if (chLower >= 'a' && chLower <= 'z')
                {
                    break;
                }
                output.Append(ch);
            }
            return output.ToString();
        }

        string AddHour(string line)
        {
            line = $"00:{line}";
            line = line.Replace(" --> ", " --> 00:");
            return line;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    if (fbd.ShowDialog() == DialogResult.OK && !String.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        string[] fileArray = Directory.GetFiles(@fbd.SelectedPath, "*.vtt", SearchOption.AllDirectories);
                        foreach(string vttFile in fileArray)
                        {
                            ConvertToSrt(vttFile, Path.GetDirectoryName(vttFile));
                        }
                    }
                }
                MessageBox.Show(this, "Convert Success, Enjoy your sub", "Convert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
