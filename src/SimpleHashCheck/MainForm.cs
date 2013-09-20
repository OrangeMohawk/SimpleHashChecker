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

        private void browsebutton_Click(object sender, EventArgs e)
        {
            //set up a string to display the file location, set it to null
            string directory = "";
            //set up a stream to load files
            Stream ms = null;

            //create the open file dialog when the button is clicked
            OpenFileDialog fs = new OpenFileDialog();
            //set the file type to reach all files
            fs.Filter = "All Files (*.*)|*.*";

            //sets the file to be opened to that which is chosen in the file dialog
            DialogResult dr = fs.ShowDialog();
            //if a file is selected in the file dialog
            if (dr == DialogResult.OK)
            {
                //change the file location string to the name of the file we opened
                directory = fs.FileName;
                //clear the textbox which shows this path
                FileDirectory.Clear();
                //paste the file name into the path textbox
                FileDirectory.Paste(directory);
                try
                {
                    //if a file is opened
                    if ((ms = fs.OpenFile()) != null)
                    {
                        //clear all the hash textboxes
                        MD5HashBox.Clear();
                        SHA1HashBox.Clear();
                        SHA256HashBox.Clear();
                        SHA384HashBox.Clear();
                        SHA512HashBox.Clear();
                        
                        //if the MD5 checkbox is checked
                        if (MD5check.Checked)
                        {
                            //compute the hash of the file, paste to the MD5 hash textbox, and remove all instances of "-"
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
                //catch errors
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void gethash_Click(object sender, EventArgs e)
        {
            //what happens when the get hashes button is clicked;
            //this is the same code as used above, but not everything was neede
            //we needed no stream since this will only be used if a file is already open through the dialog
            string directory = FileDirectory.Text;
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
    }
}
