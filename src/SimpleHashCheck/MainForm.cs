using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //select file button
        private void browsebutton_Click(object sender, EventArgs e)
        {
            string directory = "";
            Stream ms = null;
            
            OpenFileDialog fs = new OpenFileDialog();
            fs.Filter = "All Files (*.*)|*.*";

            DialogResult dr = fs.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //change the text box's text to the path of the file we opened
                directory = fs.FileName;
                FileDirectory.Clear();
                FileDirectory.Paste(directory);
                try
                {
                    if ((ms = fs.OpenFile()) != null)
                    {
                        MD5HashBox.Clear();
                        SHA1HashBox.Clear();
                        SHA256HashBox.Clear();
                        SHA384HashBox.Clear();
                        SHA512HashBox.Clear();
                        
                        if (MD5check.Checked)
                        {
                            using (var md5 = MD5.Create())
                                MD5HashBox.Paste(BitConverter.ToString(md5.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                        }
                        if (SHA1check.Checked)
                        {
                            using (var sha1 = SHA1.Create())
                                SHA1HashBox.Paste(BitConverter.ToString(sha1.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                        }
                        if (SHA256check.Checked)
                        {
                            using (var sha256 = SHA256.Create())
                                SHA256HashBox.Paste(BitConverter.ToString(sha256.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                        }
                        if (SHA384check.Checked)
                        {
                            using (var sha384 = SHA384.Create())
                                SHA384HashBox.Paste(BitConverter.ToString(sha384.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                        }
                        if (SHA512check.Checked)
                        {
                            using (var sha512 = SHA512.Create())
                                SHA512HashBox.Paste(BitConverter.ToString(sha512.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        //get hash button click
        private void gethash_Click(object sender, EventArgs e)
        {
            string directory = FileDirectory.Text;
            try
            {
                MD5HashBox.Clear();
                SHA1HashBox.Clear();
                SHA256HashBox.Clear();
                SHA384HashBox.Clear();
                SHA512HashBox.Clear();

                if (MD5check.Checked)
                {
                    using (var md5 = MD5.Create())
                        MD5HashBox.Paste(BitConverter.ToString(md5.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                    }
                if (SHA1check.Checked)
                {
                    using (var sha1 = SHA1.Create())
                        SHA1HashBox.Paste(BitConverter.ToString(sha1.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                }
                if (SHA256check.Checked)
                {
                    using (var sha256 = SHA256.Create())
                        SHA256HashBox.Paste(BitConverter.ToString(sha256.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                }
                if (SHA384check.Checked)
                {
                    using (var sha384 = SHA384.Create())
                        SHA384HashBox.Paste(BitConverter.ToString(sha384.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                }
                if (SHA512check.Checked)
                {
                    using (var sha512 = SHA512.Create())
                        SHA512HashBox.Paste(BitConverter.ToString(sha512.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                }
            }
            catch
            {
                MessageBox.Show("Drop a File, not a Folder.", "Error");
            }
        }

        //drag & drop functionality
        private void MainForm_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            //allow only one item to open when multiple are dropped on the form
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            string lastFile = files[files.Length - 1];
            {
                FileDirectory.Clear();
                FileDirectory.Paste(lastFile);
                string directory = FileDirectory.Text;
                try
                {
                    MD5HashBox.Clear();
                    SHA1HashBox.Clear();
                    SHA256HashBox.Clear();
                    SHA384HashBox.Clear();
                    SHA512HashBox.Clear();

                    if (MD5check.Checked)
                    {
                        using (var md5 = MD5.Create())
                            MD5HashBox.Paste(BitConverter.ToString(md5.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                    }
                    if (SHA1check.Checked)
                    {
                        using (var sha1 = SHA1.Create())
                            SHA1HashBox.Paste(BitConverter.ToString(sha1.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                    }
                    if (SHA256check.Checked)
                    {
                        using (var sha256 = SHA256.Create())
                            SHA256HashBox.Paste(BitConverter.ToString(sha256.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                    }
                    if (SHA384check.Checked)
                    {
                        using (var sha384 = SHA384.Create())
                            SHA384HashBox.Paste(BitConverter.ToString(sha384.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                    }
                    if (SHA512check.Checked)
                    {
                        using (var sha512 = SHA512.Create())
                            SHA512HashBox.Paste(BitConverter.ToString(sha512.ComputeHash(File.ReadAllBytes(directory))).Replace("-", ""));
                    }
                }
                catch
                {
                    MessageBox.Show("Please Select a File.","Error");
                }
            }
        }
    }
}
