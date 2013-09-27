namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FileDirectory = new System.Windows.Forms.TextBox();
            this.browsebutton = new System.Windows.Forms.Button();
            this.MD5check = new System.Windows.Forms.CheckBox();
            this.SHA1check = new System.Windows.Forms.CheckBox();
            this.SHA256check = new System.Windows.Forms.CheckBox();
            this.SHA384check = new System.Windows.Forms.CheckBox();
            this.SHA512check = new System.Windows.Forms.CheckBox();
            this.MD5label = new System.Windows.Forms.Label();
            this.SHA1label = new System.Windows.Forms.Label();
            this.SHA256label = new System.Windows.Forms.Label();
            this.SHA384label = new System.Windows.Forms.Label();
            this.SHA512label = new System.Windows.Forms.Label();
            this.gethash = new System.Windows.Forms.Button();
            this.MD5HashBox = new System.Windows.Forms.TextBox();
            this.SHA1HashBox = new System.Windows.Forms.TextBox();
            this.SHA256HashBox = new System.Windows.Forms.TextBox();
            this.SHA384HashBox = new System.Windows.Forms.TextBox();
            this.SHA512HashBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FileDirectory
            // 
            this.FileDirectory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FileDirectory.Location = new System.Drawing.Point(12, 12);
            this.FileDirectory.Name = "FileDirectory";
            this.FileDirectory.ReadOnly = true;
            this.FileDirectory.Size = new System.Drawing.Size(285, 20);
            this.FileDirectory.TabIndex = 1;
            // 
            // browsebutton
            // 
            this.browsebutton.Location = new System.Drawing.Point(303, 10);
            this.browsebutton.Name = "browsebutton";
            this.browsebutton.Size = new System.Drawing.Size(75, 23);
            this.browsebutton.TabIndex = 2;
            this.browsebutton.Text = "Select File";
            this.browsebutton.UseVisualStyleBackColor = true;
            this.browsebutton.Click += new System.EventHandler(this.browsebutton_Click);
            // 
            // MD5check
            // 
            this.MD5check.AutoSize = true;
            this.MD5check.Location = new System.Drawing.Point(35, 40);
            this.MD5check.Name = "MD5check";
            this.MD5check.Size = new System.Drawing.Size(49, 17);
            this.MD5check.TabIndex = 3;
            this.MD5check.Text = "MD5";
            this.MD5check.UseVisualStyleBackColor = true;
            // 
            // SHA1check
            // 
            this.SHA1check.AutoSize = true;
            this.SHA1check.Location = new System.Drawing.Point(90, 40);
            this.SHA1check.Name = "SHA1check";
            this.SHA1check.Size = new System.Drawing.Size(54, 17);
            this.SHA1check.TabIndex = 4;
            this.SHA1check.Text = "SHA1";
            this.SHA1check.UseVisualStyleBackColor = true;
            // 
            // SHA256check
            // 
            this.SHA256check.AutoSize = true;
            this.SHA256check.Location = new System.Drawing.Point(150, 40);
            this.SHA256check.Name = "SHA256check";
            this.SHA256check.Size = new System.Drawing.Size(66, 17);
            this.SHA256check.TabIndex = 5;
            this.SHA256check.Text = "SHA256";
            this.SHA256check.UseVisualStyleBackColor = true;
            // 
            // SHA384check
            // 
            this.SHA384check.AutoSize = true;
            this.SHA384check.Location = new System.Drawing.Point(222, 40);
            this.SHA384check.Name = "SHA384check";
            this.SHA384check.Size = new System.Drawing.Size(66, 17);
            this.SHA384check.TabIndex = 6;
            this.SHA384check.Text = "SHA384";
            this.SHA384check.UseVisualStyleBackColor = true;
            // 
            // SHA512check
            // 
            this.SHA512check.AutoSize = true;
            this.SHA512check.Location = new System.Drawing.Point(294, 40);
            this.SHA512check.Name = "SHA512check";
            this.SHA512check.Size = new System.Drawing.Size(66, 17);
            this.SHA512check.TabIndex = 7;
            this.SHA512check.Text = "SHA512";
            this.SHA512check.UseVisualStyleBackColor = true;
            // 
            // MD5label
            // 
            this.MD5label.AutoSize = true;
            this.MD5label.Location = new System.Drawing.Point(12, 62);
            this.MD5label.Name = "MD5label";
            this.MD5label.Size = new System.Drawing.Size(58, 13);
            this.MD5label.TabIndex = 0;
            this.MD5label.Text = "MD5 Hash";
            // 
            // SHA1label
            // 
            this.SHA1label.AutoSize = true;
            this.SHA1label.Location = new System.Drawing.Point(12, 88);
            this.SHA1label.Name = "SHA1label";
            this.SHA1label.Size = new System.Drawing.Size(63, 13);
            this.SHA1label.TabIndex = 0;
            this.SHA1label.Text = "SHA1 Hash";
            // 
            // SHA256label
            // 
            this.SHA256label.AutoSize = true;
            this.SHA256label.Location = new System.Drawing.Point(12, 119);
            this.SHA256label.Name = "SHA256label";
            this.SHA256label.Size = new System.Drawing.Size(75, 13);
            this.SHA256label.TabIndex = 0;
            this.SHA256label.Text = "SHA256 Hash";
            // 
            // SHA384label
            // 
            this.SHA384label.AutoSize = true;
            this.SHA384label.Location = new System.Drawing.Point(12, 165);
            this.SHA384label.Name = "SHA384label";
            this.SHA384label.Size = new System.Drawing.Size(75, 13);
            this.SHA384label.TabIndex = 0;
            this.SHA384label.Text = "SHA384 Hash";
            // 
            // SHA512label
            // 
            this.SHA512label.AutoSize = true;
            this.SHA512label.Location = new System.Drawing.Point(12, 220);
            this.SHA512label.Name = "SHA512label";
            this.SHA512label.Size = new System.Drawing.Size(75, 13);
            this.SHA512label.TabIndex = 0;
            this.SHA512label.Text = "SHA512 Hash";
            // 
            // gethash
            // 
            this.gethash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gethash.Location = new System.Drawing.Point(12, 256);
            this.gethash.Name = "gethash";
            this.gethash.Size = new System.Drawing.Size(366, 63);
            this.gethash.TabIndex = 13;
            this.gethash.Text = "Get Hashes!";
            this.gethash.UseVisualStyleBackColor = true;
            this.gethash.Click += new System.EventHandler(this.gethash_Click);
            // 
            // MD5HashBox
            // 
            this.MD5HashBox.BackColor = System.Drawing.SystemColors.Info;
            this.MD5HashBox.Location = new System.Drawing.Point(93, 63);
            this.MD5HashBox.Name = "MD5HashBox";
            this.MD5HashBox.ReadOnly = true;
            this.MD5HashBox.Size = new System.Drawing.Size(285, 20);
            this.MD5HashBox.TabIndex = 8;
            // 
            // SHA1HashBox
            // 
            this.SHA1HashBox.BackColor = System.Drawing.SystemColors.Info;
            this.SHA1HashBox.Location = new System.Drawing.Point(93, 89);
            this.SHA1HashBox.Name = "SHA1HashBox";
            this.SHA1HashBox.ReadOnly = true;
            this.SHA1HashBox.Size = new System.Drawing.Size(285, 20);
            this.SHA1HashBox.TabIndex = 9;
            // 
            // SHA256HashBox
            // 
            this.SHA256HashBox.BackColor = System.Drawing.SystemColors.Info;
            this.SHA256HashBox.Location = new System.Drawing.Point(93, 114);
            this.SHA256HashBox.Multiline = true;
            this.SHA256HashBox.Name = "SHA256HashBox";
            this.SHA256HashBox.ReadOnly = true;
            this.SHA256HashBox.Size = new System.Drawing.Size(285, 32);
            this.SHA256HashBox.TabIndex = 10;
            // 
            // SHA384HashBox
            // 
            this.SHA384HashBox.BackColor = System.Drawing.SystemColors.Info;
            this.SHA384HashBox.Location = new System.Drawing.Point(93, 153);
            this.SHA384HashBox.Multiline = true;
            this.SHA384HashBox.Name = "SHA384HashBox";
            this.SHA384HashBox.ReadOnly = true;
            this.SHA384HashBox.Size = new System.Drawing.Size(285, 45);
            this.SHA384HashBox.TabIndex = 11;
            // 
            // SHA512HashBox
            // 
            this.SHA512HashBox.BackColor = System.Drawing.SystemColors.Info;
            this.SHA512HashBox.Location = new System.Drawing.Point(93, 205);
            this.SHA512HashBox.Multiline = true;
            this.SHA512HashBox.Name = "SHA512HashBox";
            this.SHA512HashBox.ReadOnly = true;
            this.SHA512HashBox.Size = new System.Drawing.Size(285, 45);
            this.SHA512HashBox.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 328);
            this.Controls.Add(this.SHA512HashBox);
            this.Controls.Add(this.SHA384HashBox);
            this.Controls.Add(this.SHA256HashBox);
            this.Controls.Add(this.SHA1HashBox);
            this.Controls.Add(this.MD5HashBox);
            this.Controls.Add(this.gethash);
            this.Controls.Add(this.SHA512label);
            this.Controls.Add(this.SHA384label);
            this.Controls.Add(this.SHA256label);
            this.Controls.Add(this.SHA1label);
            this.Controls.Add(this.MD5label);
            this.Controls.Add(this.SHA512check);
            this.Controls.Add(this.SHA384check);
            this.Controls.Add(this.SHA256check);
            this.Controls.Add(this.SHA1check);
            this.Controls.Add(this.MD5check);
            this.Controls.Add(this.browsebutton);
            this.Controls.Add(this.FileDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Simple Hash Checker";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainForm_DragOver);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileDirectory;
        private System.Windows.Forms.Button browsebutton;
        private System.Windows.Forms.CheckBox MD5check;
        private System.Windows.Forms.CheckBox SHA1check;
        private System.Windows.Forms.CheckBox SHA256check;
        private System.Windows.Forms.CheckBox SHA384check;
        private System.Windows.Forms.CheckBox SHA512check;
        private System.Windows.Forms.Label MD5label;
        private System.Windows.Forms.Label SHA1label;
        private System.Windows.Forms.Label SHA256label;
        private System.Windows.Forms.Label SHA384label;
        private System.Windows.Forms.Label SHA512label;
        private System.Windows.Forms.Button gethash;
        private System.Windows.Forms.TextBox MD5HashBox;
        private System.Windows.Forms.TextBox SHA1HashBox;
        private System.Windows.Forms.TextBox SHA256HashBox;
        private System.Windows.Forms.TextBox SHA384HashBox;
        private System.Windows.Forms.TextBox SHA512HashBox;
    }
}

