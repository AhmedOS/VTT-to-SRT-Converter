using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vtt_to_srt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "WebVTT files (*.vtt)|*.vtt";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach(string str in openFileDialog1.FileNames)
                    if(!listBox1.Items.Contains(str))
                        listBox1.Items.Add(str);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> lst = new List<int>();
            foreach (int idx in listBox1.SelectedIndices)
                lst.Add(idx);
            lst.Reverse();
            foreach (int idx in lst)
                listBox1.Items.RemoveAt(idx);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        void switchBtns()
        {
            textBox1.Enabled = !textBox1.Enabled;
            listBox1.Enabled = !listBox1.Enabled;
            button1.Enabled = !button1.Enabled;
            button2.Enabled = !button2.Enabled;
            button3.Enabled = !button3.Enabled;
            button4.Enabled = !button4.Enabled;
            button5.Enabled = !button5.Enabled;
        }
        
        void convertToSrt(string str)
        {
            try
            {
                using (StreamReader sr = new StreamReader(str))
                {
                    string txt = sr.ReadToEnd();
                    StringBuilder txt2 = new StringBuilder();
                    txt2.Append(txt);
                    txt2.Remove(0, 6);
                    txt2.Replace('.', ',');
                    StringBuilder fn = new StringBuilder();
                    foreach (char ch in str)
                        if (ch == '\\')
                            fn.Clear();
                        else
                            fn.Append(ch);
                    fn[fn.Length - 1] = 't';
                    fn[fn.Length - 2] = 'r';
                    fn[fn.Length - 3] = 's';
                    using (StreamWriter outputFile = new StreamWriter(textBox1.Text + '\\' + fn.ToString()))
                        foreach (char ch in txt2.ToString())
                            outputFile.Write(ch);
                }
            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                switchBtns();
                foreach (string str in listBox1.Items)
                    convertToSrt(str);
                MessageBox.Show("All files converted successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                switchBtns();
            }
            else
                MessageBox.Show("Output folder doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
